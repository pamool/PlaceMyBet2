using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }

        public List<Mercado> mercados { get; set; }

        public Evento(int eventoId, string equipoLocal, string equipoVisitante, DateTime fecha)
        {
            EventoId = eventoId;
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            Fecha = fecha;
        }
        public Evento()
        {

        }
    }
    /**Ejercicio 1**/
    public class EventoApuesta
    {
        public string EquipoLocal { get; set; }
        public Apuesta apuestaId { get; set; }
        public Apuesta OverUnder { get; set; }
        public Apuesta Cuota { get; set; }
        public Apuesta TipoApuesta { get; set; }
        public Apuesta DineroApuesta { get; set; }
        public Apuesta Fecha { get; set; }
        public Apuesta EventoId { get; set; }
        public Apuesta MercadoId { get; set; }
        public Apuesta UsuarioId { get; set; }

        public EventoApuesta(string equipoLocal,Apuesta ApuestaId, Apuesta overUnder, Apuesta cuota, Apuesta tipoApuesta, Apuesta dineroApuesta, Apuesta fecha, Apuesta eventoId, Apuesta mercadoId, Apuesta usuarioId)
        {
            EquipoLocal = equipoLocal;
            apuestaId = ApuestaId;
            OverUnder = overUnder;
            Cuota= cuota;
            TipoApuesta = tipoApuesta;
            DineroApuesta = dineroApuesta;
            Fecha = fecha;
            EventoId = eventoId;
            MercadoId = mercadoId;
            UsuarioId = usuarioId;

        }
        public EventoApuesta()
        {

        }

    }
    /**Fin Ejercicio1**/
}