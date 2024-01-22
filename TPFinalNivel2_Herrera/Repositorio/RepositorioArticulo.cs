using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Repositorio
{
     public class RepositorioArticulo
    {
        public List<Clase_Articulo> listar()
        {
            List<Clase_Articulo> ListaArticulos = new List<Clase_Articulo>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                // consulta para seleccionar todos los articulos con sus marcas/categorias
                datos.setearConsulta("select ar.Id,Codigo,Nombre, ar.Descripcion as Descripcion, ca.id as idcategoria, ca.Descripcion as categoria , ma.id as idmarca, ma.Descripcion as Marca,ImagenUrl,Precio from ARTICULOS ar inner join CATEGORIAS ca on ca.Id = ar.IdCategoria inner join MARCAS ma on ma.Id = ar.IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clase_Articulo aux = new Clase_Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    // para poder cargar IdMarca
                    aux.Marca = new IdMarca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    // para poder cargar IdCategoria
                    aux.Categoria = new IdCategoria();
                    aux.Categoria.Id = (int)datos.Lector["idcategoria"];
                    aux.Categoria.Descripcion= (string)datos.Lector["categoria"];

                    // me aseguro que no sea nulo
                    if (!(datos.Lector["ImagenURL"] is DBNull)) 
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];



                     aux.Precio = (decimal)datos.Lector["Precio"];




                        ListaArticulos.Add(aux);
                    


                }

                datos.cerrarConexion();                
                return ListaArticulos;

            }

            catch (Exception ex)
            {

                throw ex;
            }
        
            





        }

        public void Agregar(Clase_Articulo articulo)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) set (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }



        }


    }
}
