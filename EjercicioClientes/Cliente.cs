using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EjercicioClientes
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string rfc,
            string direccion, string estado,
            string municipio, string telefono,
            string nombreEncargado, Image fotoEncargado)
        {
            Id = id;
            Nombre = nombre;
            RFC = rfc;
            Direccion = direccion;
            Estado = estado;
            Municipio = municipio;
            Telefono = telefono;
            NombreEncargado = nombreEncargado;
            FotoEncargado = fotoEncargado;
        }

        public string[] ConvertToArrayString()
        {
            string[] array = {  Id.ToString(), Nombre, RFC, Direccion, Estado, Municipio, Telefono,
                                NombreEncargado };
            return array;
        }

        public int Id { set; get; }
        public string Nombre { set; get; }
        public string RFC { set; get; }
        public string Direccion { set; get; }
        public string Estado { set; get; }
        public string Municipio { set; get; }
        public string Telefono { set; get; }
        public string NombreEncargado { set; get; }
        public Image FotoEncargado { set; get; }
    }
}
