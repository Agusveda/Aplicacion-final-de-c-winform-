using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Repositorio;

namespace Presentacion
{
    public partial class Frm_Catalogo : Form
    {
        private List<Clase_Articulo> ListaArticulos;
        public Frm_Catalogo()
        {
            InitializeComponent();
        }
        public Frm_Catalogo(Clase_Articulo articulo)
        {
            InitializeComponent();
        }
        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
            CargarListado();
            cbcampo.Items.Add("Precio.");
            cbcampo.Items.Add("Nombre.");


        }
        private void CargarListado()
        {
            RepositorioArticulo repoArticulo = new RepositorioArticulo();

            try
            {

                ListaArticulos = repoArticulo.listar(); // seteo lista
                dgvArticulos.DataSource = ListaArticulos; //agrego al dgv la lista para que se pueda visualizar

                pbArticulos.Load(ListaArticulos[0].ImagenUrl);


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            ocultarColumnas();

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e) // recorrer el dgv
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Clase_Articulo seleccionado = (Clase_Articulo)dgvArticulos.CurrentRow.DataBoundItem; /// dame el objeto enlazado en la grilla 
                // obligo a convertirse en tipo ARTICULO al objeto
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen); 

            }
            catch (Exception)
            {

                pbArticulos.Load("https://previews.123rf.com/images/yoginta/yoginta2301/yoginta230100567/196853824-imagen-no-encontrada-ilustraci%C3%B3n-vectorial.jpg");
            }

        }
        private void txtFiltro_TextChanged(object sender, EventArgs e) // funcion del filtro basico
        {
            List<Clase_Articulo> listaFiltada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {

                listaFiltada = ListaArticulos.FindAll(x => x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltada = ListaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltada;
            ocultarColumnas();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaArticulo alta = new Frm_AltaArticulo();
            alta.ShowDialog();
            CargarListado();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clase_Articulo ArtSeleccionado;
            ArtSeleccionado = (Clase_Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            Frm_AltaArticulo Modificar = new Frm_AltaArticulo(ArtSeleccionado,true); // le envio el articulo seleccionado para que tome sus 

            Modificar.ShowDialog(); // muestro form
            CargarListado(); // cargo el listado de nuevo una vez modificado.


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioArticulo repoarti = new RepositorioArticulo();
            Clase_Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro en eliminar el registro?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Clase_Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    repoarti.Eliminar(seleccionado.Id);
                CargarListado();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnfiltro_Click(object sender, EventArgs e)
        {
            RepositorioArticulo repoarti = new RepositorioArticulo();
            try
            {

                if (validacionFiltros())
                    return;
                string campo = cbcampo.SelectedItem.ToString();
                string criterio = cbcriterio.SelectedItem.ToString();
                string filtro = txtfiltroavanz.Text;
                dgvArticulos.DataSource = repoarti.FiltrarArticulos(campo, criterio, filtro);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validacionFiltros()
        {
            if (cbcampo.SelectedIndex == -1)
            {

                MessageBox.Show("Por favor, seleccione el campo para fitlrar... ");
                return true;
            }
            if (cbcriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el criterio para fitlrar... ");
                return true;
            }
            if (cbcampo.SelectedItem.ToString() == "Precio.")
            {
                if (!(soloNumeros(txtfiltroavanz.Text)))
                {

                    MessageBox.Show("Solo numeros para filtrar en un campo numerico");
                    return true;
                }

            }

            return false;

        }
        private bool soloNumeros(string cadena)
        {
            foreach (char character in cadena)
            {
                if (!(char.IsNumber(character)))
                {
                    return false;
                }
            }
            return true;
        }
        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Clase_Articulo> listaFiltada;
            string filtro = txtfiltroavanz.Text;

            if (filtro != "")
            {

                listaFiltada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro));

            }
            else
            {
                listaFiltada = ListaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltada;
            ocultarColumnas();

        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["id"].Visible = false;
        } // oculto columnas del dgv
        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbcampo.SelectedItem.ToString();

            if (opcion == "Precio.")
            {
                cbcriterio.Items.Clear(); // aparecia un error que sumaba los items, con el clear limpio cada vez que se selecciona el campo
                cbcriterio.Items.Add("Mayor a..");
                cbcriterio.Items.Add("Menor a..");
                cbcriterio.Items.Add("Igual a..");


            }
            else if (opcion == "Nombre.")
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("comienza con..");
                cbcriterio.Items.Add("Termina con..");
                cbcriterio.Items.Add("Contiene..");

            }

        }
        private void BtnLimpiarfiltro_Click(object sender, EventArgs e) // limpio filtro 
        {
            txtfiltroavanz.Text = string.Empty; // lo vacio 
            CargarListado();

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Clase_Articulo ArtSeleccionado;
            ArtSeleccionado = (Clase_Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Frm_AltaArticulo verDetalle  = new Frm_AltaArticulo(ArtSeleccionado,false);

            verDetalle.ShowDialog();

        }
    }
    
}