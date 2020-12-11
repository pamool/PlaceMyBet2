using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class Mercado
    {
        public int MercadoId { get; set; }
        public double OverUnder { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double DineroOver { get; set; }
        public double DineroUnder { get; set; }

        //relacion mercado evento
        public int EventoId { get; set; }

        public Evento evento { get; set; }
        //un mercado guarda muchas apuestas
        List<Apuesta> apuestas { get; set; }

        public Mercado(int mercadoId, double overUnder, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, int eventoId)
        {
            MercadoId = mercadoId;
            OverUnder = overUnder;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
            EventoId = eventoId;
        }
        public Mercado()
        {

        }
    }
}