using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class EventosRepository
    {
        internal List<EventosExamen> Retrieve()
        {
            List<EventosExamen> eventos = new List<EventosExamen>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.EventosExamen.ToList();
            }
            return eventos;
        }
        internal void Save(EventosExamen F)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.EventosExamen.Add(F);
            context.SaveChanges();
        }
        /*
         *         internal void Save(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Evento.Add(e);
            context.SaveChanges();
        }
          */
        internal void Update(int id, string equipoLocal, string equipoVisitante)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            EventosExamen evento = context.Evento.FirstOrDefault(a => a.EventoId == id);
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



        /*intento de ejercicio de examen mi propuesta con este ejercicio era intentar filtrar por id el Evento
        que a partir de ahi mostrar los valores que se piden en el ejercicio y despues intentar modificar para que buscara
        por el nombre del equipo.
        internal List<EventoDTO> RetrievebyId(int id)
        {
            List<Evento> lista;
            List<EventoDTO> final = new List<EventoDTO>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                lista = context.Evento.Where(e => e.EventoId == id).ToList();
            }
            for (int i = 0; i < lista.Count; i++)
            {
                final.Add(toDTO(lista[i]));
            }
            return final;
        }
        static public EventoDTO toDTO(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Mercado m;
            using (context)
            {
                m = context.Mercado.Single(c => c.MercadoId == e.MercadoId);

            }
            return new EventoDTO(e.EquipoVisitante,m.MercadoId,m.CuotaOver,m.CuotaUnder);
        }
    }*/
    }
}
