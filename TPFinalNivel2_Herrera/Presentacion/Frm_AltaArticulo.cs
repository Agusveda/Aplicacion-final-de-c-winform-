using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_AltaArticulo : Form
    {
        private Clase_Articulo Articulo = null;
        public Frm_AltaArticulo()
        {
            InitializeComponent();
        }

        public Frm_AltaArticulo(Clase_Articulo Articulo)
        {
            InitializeComponent();
            this.Articulo = Articulo;
            Text = " Modificar articulo";
        }

        private void Frm_AltaArticulo_Load(object sender, EventArgs e)
        {
            
            RepositorioCategoria repoCategoria = new RepositorioCategoria();
            RepositorioMarca repoMarca = new RepositorioMarca();
            try
            {
                cbCategoria.DataSource = repoCategoria.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = repoMarca.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                
                if(Articulo !=null)
                {
                    txtCodigo.Text = Articulo.Codigo.ToString();
                    txtNombre.Text = Articulo.Nombre;
                    txtDescripcion.Text = Articulo.Descripcion;
                    cargarImagen(Articulo.ImagenUrl);
                    txtPrecio.Text = Articulo.Precio.ToString();
                    cbMarca.SelectedValue = Articulo.Marca.Id;
                    cbCategoria.SelectedValue = Articulo.Categoria.Id;


                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }



        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenart.Load(imagen); //seleccionado es el pokemon que vaya en el datagrid

            }
            catch (Exception ex)
            {

                pbImagenart.Load("https://previews.123rf.com/images/yoginta/yoginta2301/yoginta230100567/196853824-imagen-no-encontrada-ilustraci%C3%B3n-vectorial.jpg");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            Clase_Articulo articulo = new Clase_Articulo();
            RepositorioArticulo repositorioArticulo = new RepositorioArticulo();

            try
            {
                if(articulo == null)
                {

                    articulo = new Clase_Articulo();


                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.ImagenUrl = txtImagenUrl.Text;
                    articulo.Categoria = (IdCategoria)cbCategoria.SelectedItem;
                    articulo.Marca= (IdMarca)cbMarca.SelectedItem;





                }



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
