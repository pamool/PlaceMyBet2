using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public string Nombre { get; set; }
        public double Saldo { set; get; }



        //una cuenta tiene un usuario
        public int UsuarioID { get; set; }
        public Usuario usuario { get; set; }

        public Cuenta(int cuentaId, string nombre, double saldo, int usuarioID)
        {
            CuentaId = cuentaId;
            Nombre = nombre;
            Saldo = saldo;
            UsuarioID = usuarioID;
        }
        public Cuenta() { 


        }
    }
}