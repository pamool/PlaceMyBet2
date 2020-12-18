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
    public class EventoDTO{
        public string EquipoVisitante { get; set; }
        public int MercadoId { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }


        public EventoDTO(string equipoVisitante, int mercadoId, double cuotaOver, double cuotaUnder)
        {
            EquipoVisitante = equipoVisitante;
            MercadoId = mercadoId;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
        }
        public EventoDTO()
        {
        }
    }
    public class EventosExamen
    {
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int MercadoId { get; set; }
        public double OverUnder { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double DineroOver { get; set; }
        public double DineroUnder { get; set; }
        public Mercado mercado { get; set; }

        public EventosExamen(string equipoLocal, string equipoVisitante, int mercadoId, double overUnder, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder)
        {
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            MercadoId = mercadoId;
            OverUnder = overUnder;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
        }
        public EventosExamen()
        {
        }
    }

}
