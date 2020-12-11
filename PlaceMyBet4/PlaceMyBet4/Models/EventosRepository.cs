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
        internal void Update(int id,string equipoLocal, string equipoVisitante)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Evento.FirstOrDefault(a => a.EventoId == id);
            evento.EquipoLocal = equipoLocal;
            evento.EquipoVisitante = equipoVisitante;
            context.SaveChanges();
        }
        internal void Eliminar(int id)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Evento.FirstOrDefault(a => a.EventoId == id);
            context.Remove(evento);
            context.SaveChanges();
        }
    }
}