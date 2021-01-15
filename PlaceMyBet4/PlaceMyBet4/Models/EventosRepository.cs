using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class EventosRepository
    {
        internal List<Evento> Retrieve()
        {
            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Evento.ToList();
            }
            return eventos;
        }
        internal void Save(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Evento.Add(e);
            context.SaveChanges();
        }
        /**Ejercicio 1**/
        internal EventoApuesta eventoApuesta(string EquipoLocal)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                var apuesta = context.Evento.FirstOrDefault(e => e.EquipoLocal == EquipoLocal);
                return apuesta;
            }

        }
        /**Fin Ejercicio 1**/
    }
}