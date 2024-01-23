using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMarca
    {
        public List<IdMarca> listar()
        {

            List<IdMarca> lista = new List<IdMarca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select id, descripcion from Marcas");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    IdMarca aux = new IdMarca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
