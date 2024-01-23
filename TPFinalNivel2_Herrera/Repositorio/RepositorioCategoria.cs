using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioCategoria
    {

        public List<IdCategoria> listar()
        {

			List<IdCategoria> lista = new List<IdCategoria>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("select id, descripcion from categorias");
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					IdCategoria aux = new IdCategoria();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					lista.Add(aux);
				}

				return lista;

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


    }
}
