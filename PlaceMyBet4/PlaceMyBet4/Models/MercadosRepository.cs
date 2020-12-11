using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class MercadosRepository
    {
        internal List<Mercado> Retrieve()
        {
            List<Mercado> mercados = new List<Mercado>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.Mercado.ToList();
            }
            return mercados;
        }
        internal Mercado RetrieveId(int id)
        {
            using(PlaceMyBetContext context = new PlaceMyBetContext())
            {
                var mercado = context.Mercado.FirstOrDefault(m => m.MercadoId == id);
                return mercado;
            }

        }
        internal void Save(Mercado m)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Mercado.Add(m);
            context.SaveChanges();
        }
        public static MercadoDTO ToDTO(Mercado m)
        {
            return new MercadoDTO(m.OverUnder,m.CuotaOver,m.CuotaUnder);
        }
        public List<MercadoDTO> RetrieveDTO()
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            List<MercadoDTO> mercadoDTOs = context.Mercado.Select(m =>ToDTO(m)).ToList();
            return mercadoDTOs;
        }
    }
    
}