using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class ApuestasRepository
    {
        internal List<Apuesta> Retrieve()
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuesta.Include(a => a.mercado).ToList();
            }
            return apuestas;
        }
        internal Apuesta RetrieveId(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                var apuesta = context.Apuesta.FirstOrDefault(a => a.ApuestaId == id);
                return apuesta;
            }

        }
        internal void Save(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Mercado mercado;
            mercado = context.Mercado.FirstOrDefault(m => m.MercadoId == a.MercadoId);
            if(a.tipoApuesta == "over")
            {
                mercado.DineroOver += a.DineroApuesta;

                a.Cuota = mercado.CuotaOver;
            }
            else if(a.tipoApuesta == "under")
            {
                mercado.DineroUnder += a.DineroApuesta;

                a.Cuota = mercado.CuotaUnder;
            }
            //actualizar y añadir informacion el la apuesta
            double probabilidadOver = mercado.DineroOver / (mercado.DineroOver + mercado.DineroUnder);
            double probabilidadUnder = mercado.DineroUnder / (mercado.DineroOver + mercado.DineroUnder);
            mercado.CuotaOver = (1 / probabilidadOver) * 0.95;
            mercado.CuotaUnder = (1 / probabilidadUnder) * 0.95;
            a.Fecha = DateTime.Now;
            a.OverUnder = mercado.OverUnder;
            a.EventoId = mercado.EventoId;
            context.Mercado.Update(mercado);
            context.Apuesta.Add(a);
            context.SaveChanges();
        }

    }
}