using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                datos.setearConsulta("select ar.Id as id ,Codigo,Nombre, ar.Descripcion as Descripcion, ca.id as idcategoria, ca.Descripcion as categoria , ma.id as idmarca, ma.Descripcion as Marca,ImagenUrl,Precio from ARTICULOS ar inner join CATEGORIAS ca on ca.Id = ar.IdCategoria inner join MARCAS ma on ma.Id = ar.IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clase_Articulo aux = new Clase_Articulo();
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (aux.Precio > 0) // si el precio es menor a 0 no lo muestra (baja logica)
                    {

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


                        ListaArticulos.Add(aux);
                    
                    }


                }

                datos.cerrarConexion();                
                return ListaArticulos;

            }

            catch (Exception ex)
            {

                throw ex;
            }
        
            





        }

        public void Agregar(Clase_Articulo nuevoart)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                datos.setearParametros("@Codigo", nuevoart.Codigo);
                datos.setearParametros("@Nombre", nuevoart.Nombre);
                datos.setearParametros("@Descripcion", nuevoart.Descripcion);
                datos.setearParametros("@IdMarca", nuevoart.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevoart.Categoria.Id);
                datos.setearParametros("@ImagenUrl", nuevoart.ImagenUrl);
                datos.setearParametros("@Precio", nuevoart.Precio );
                datos.ejecutarAccion();
            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }



        }

        public void Modificar(Clase_Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion , IdMarca=@IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where id = @id");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.setearParametros("@id", articulo.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                datos.cerrarConexion();
            }

        }

        public void Eliminar(int id )
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Precio = -1 where Id = @id ");
                datos.setearParametros("@id", id);
                datos.ejecutarLectura();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}


        }

        public List<Clase_Articulo> FiltrarArticulos(string campo, string criterio, string filtro)
          {
            List<Clase_Articulo> lista = new List<Clase_Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select a.Id, Codigo, Nombre , a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, ImagenUrl, Precio from articulos a inner join CATEGORIAS c on a.IdCategoria = c.Id inner join MARCAS m on a.IdMarca = m.Id where Precio > 0 and ";
                if (campo == "Precio.")
                {
                    switch (criterio)
                    {
                        case "Mayor a..":
                            consulta += "Precio > @Precio";
                            break;
                        case "Menor a..":
                            consulta += "Precio < @Precio";
                            break;
                        default:
                            consulta += "Precio = @Precio";
                            break;
                    }
                    datos.setearParametros("@Precio", Convert.ToDecimal(filtro));
                }
                else if (campo == "Nombre.")
                {
                    switch (criterio)
                    {
                        case "comienza con..":
                            consulta += "Nombre like @Filtro + '%'";
                            break;
                        case "Termina con..":
                            consulta += "Nombre like '%' + @Filtro";
                            break;
                        default:
                            consulta += "Nombre like '%' + @Filtro + '%'";
                            break;
                    }
                    datos.setearParametros("@Filtro", filtro);
                }

                datos.setearConsulta(consulta);
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
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    // para poder cargar IdCategoria
                    aux.Categoria = new IdCategoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];

                    // me aseguro que no sea nulo
                    if (!(datos.Lector["ImagenURL"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
