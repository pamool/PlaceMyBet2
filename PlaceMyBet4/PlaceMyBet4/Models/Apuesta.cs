using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class Apuesta
    {
        public int ApuestaId { get; set; }
        public double OverUnder { get; set; }
        public double Cuota { get; set; }
        public string tipoApuesta { get; set; }
        public double DineroApuesta { get; set; }
        public DateTime Fecha { get; set; }

        public int EventoId { get; set; }

        //una apuesta guarda un mercado
        public int MercadoId { get; set; }
        public Mercado mercado { get; set; }

        //una apuesta un usuario
        public int UsuarioId { get; set; }
        public Usuario usuario { get; set; }

        public Apuesta(int apuestaId, double overUnder, double cuota, string tipoApuesta, double dineroApuesta, DateTime fecha, int eventoId, int mercadoId, int usuarioId)
        {
            ApuestaId = apuestaId;
            OverUnder = overUnder;
            Cuota = cuota;
            this.tipoApuesta = tipoApuesta;
            DineroApuesta = dineroApuesta;
            Fecha = fecha;
            EventoId = eventoId;
            MercadoId = mercadoId;
            UsuarioId = usuarioId;
        }
        public Apuesta()
        {

        }

    }



    public class ApuestaDTO
    {
        public int UsuarioId { get; set; }
        public int EventoId { get; set; }
        public double Cuota { get; set; }
        public string tipoApuesta { get; set; }
        public double DineroApuesta { get; set; }

        public ApuestaDTO(int usuarioId, int eventoId, double cuota, string tipoApuesta, double dineroApuesta)
        {
            UsuarioId = usuarioId;
            EventoId = eventoId;
            Cuota = cuota;
            this.tipoApuesta = tipoApuesta;
            DineroApuesta = dineroApuesta;
        }
        public ApuestaDTO()
        {

        }
    }
}
