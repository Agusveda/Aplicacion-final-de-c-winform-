﻿using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Presentacion
{
    public partial class Frm_AltaArticulo : Form
    {
        private Clase_Articulo Articulo = null;
        bool parametro = true; // true modificar / false ver detalle
        private OpenFileDialog archivo = null;
        public Frm_AltaArticulo()
        {
            InitializeComponent();
        } // Cuando se haga un ingreso 
        public Frm_AltaArticulo(Clase_Articulo Articulo, bool parametro)
        {
            InitializeComponent();
            this.Articulo = Articulo;
            this.parametro = parametro;
            if(parametro == true)
            {
            Text = " Modificar articulo";
            }
            else
            {
                Text = " Ver detalle ";
            }
        } // Cuando se haga una modificacion se cambia el nombre de la ventana y se setea al articulo para no crear uno nuevo
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
                    cargarImagen(Articulo.ImagenUrl);// carga la imagen
                    txtImagenUrl.Text = Articulo.ImagenUrl; // aseguro de que quede guardada
                    txtPrecio.Text = Articulo.Precio.ToString();
                    cbMarca.SelectedValue = Articulo.Marca.Id;
                    cbCategoria.SelectedValue = Articulo.Categoria.Id;


                }
                if (parametro == false)
                {


                    txtCodigo.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                    txtImagenUrl.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtPrecio.ReadOnly = true;
                    cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbCategoria.Enabled = false;
                    cbMarca.Enabled = false;



                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btbAceptar_Click(object sender, EventArgs e)
        {
            

            int contNull = 0 ;
            Clase_Articulo arti = new Clase_Articulo();
            RepositorioArticulo repositorioArticulo = new RepositorioArticulo();
            if (txtCodigo.Text == "") // pinto de rojo los campos que no esten completos
            {
                txtCodigo.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtCodigo.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }
            if (txtPrecio.Text == "")
            {
                txtPrecio.BackColor = Color.Salmon;
                contNull = 0;

            }
            else
            {
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
                contNull++;
            }

            if (contNull == 3)
            {

                try
                {
                    if (Articulo == null) // si el articulo es null se crea una nueva instancia
                        Articulo = new Clase_Articulo();




                    Articulo.Codigo = txtCodigo.Text;
                    Articulo.Nombre = txtNombre.Text;
                    Articulo.Descripcion = txtDescripcion.Text;
                    Articulo.ImagenUrl = txtImagenUrl.Text;
                    Articulo.Categoria = (IdCategoria)cbCategoria.SelectedItem;
                    Articulo.Marca = (IdMarca)cbMarca.SelectedItem;
                    Articulo.Precio=decimal.Parse(txtPrecio.Text);
                    

                if (Articulo.Id != 0) // si id es distinto de 0 es porque ya existe y es modificacion..
                {
                    repositorioArticulo.Modificar(Articulo);
                    MessageBox.Show("modificado exitosamente");

                }

                else // sino se agrega el nuevo articulo
                {

                    repositorioArticulo.Agregar(Articulo);
                    MessageBox.Show("agregado exitosamente");
                }
                // guardo imagen si la levanto localmente
                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                }
                    Close(); // cierro ventana
            }
            catch (Exception ex)
            {

                throw ex;
            }
            }

            else
            {
                MessageBox.Show("Campos vacios, porfavor ingresar los campos obligatorios (marcados en rojo) para poder guardar..");
            }
            

        }
        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
                OpenFileDialog archivo = new OpenFileDialog(); // puede abrir archivos en la pc local

                archivo.Filter = "png|*.png;|jpg|*.jpg"; //dpende los archivos que se quieran admitir se escriben en esta linea
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtImagenUrl.Text = archivo.FileName;
                    cargarImagen(archivo.FileName); // funcion para poder cargar la imagen


                    

                }
            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenart.Load(imagen); //seleccionado es el articulo que vaya en el datagrid

            }
            catch (Exception ex)
            {

                pbImagenart.Load("https://previews.123rf.com/images/yoginta/yoginta2301/yoginta230100567/196853824-imagen-no-encontrada-ilustraci%C3%B3n-vectorial.jpg");
            }

        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) //seteo para que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
