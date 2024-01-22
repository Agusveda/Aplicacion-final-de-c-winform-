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

        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
            CargarListado();

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


        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
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
                pbArticulos.Load(imagen); //seleccionado es el pokemon que vaya en el datagrid

            }
            catch (Exception)
            {

                pbArticulos.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?size=626&ext=jpg&ga=GA1.1.1687694167.1703289600&semt=ais");
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Clase_Articulo> listaFiltada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {

                listaFiltada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||  x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltada = ListaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltada;

        }
    }
    
}