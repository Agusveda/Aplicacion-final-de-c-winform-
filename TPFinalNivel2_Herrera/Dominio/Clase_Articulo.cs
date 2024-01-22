using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Clase_Articulo
    {
        public int Id {  get; set; }
        public string Codigo { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public IdMarca Marca { get; set; }
        public IdCategoria Categoria { get; set; }
        public  string ImagenUrl { get; set; }
        public decimal Precio { get; set; }

    }
}
