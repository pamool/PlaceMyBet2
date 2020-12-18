using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public Cuenta Cuenta { get; set; }
        public List<Apuesta> Apuestas { get; set; }

        public Usuario(int usuarioId, string nombre, string apellido, int edad)
        {
            UsuarioId = usuarioId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public Usuario()
        {

        }
    }
}
