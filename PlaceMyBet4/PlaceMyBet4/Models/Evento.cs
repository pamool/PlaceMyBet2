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
}
/*
 * Apuesta.cs
Ejercicio 1
   public class ApuestaDTO3
    {
        public double dinero { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }

        public ApuestaDTO3(double dinero, string tipo, string nombre)
        {
            this.dinero = dinero;
            this.tipo = tipo;
            this.nombre = nombre;
        }
    }

 Ejercicio 2

    public class ApuestaDTO4
    {
        public string tipo { get; set; }
        public string local { get; set; }
        public string visitante { get; set; }

        public ApuestaDTO4(string tipo, string local, string visitante)
        {
            this.tipo = tipo;
            this.local = local;
            this.visitante = visitante;
        }
    }
}
ApuestasRepository.cs
Ejercicio 2
       internal List<ApuestaDTO4> RetrievebyId(int id)
        {
            List<Apuesta> lista;
            List<ApuestaDTO4> final = new List<ApuestaDTO4>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                lista = context.Apuestas.Where(a => a.dinero > id).ToList();
            }
            for(int i = 0; i < lista.Count; i++)
            {
                final.Add(toDTO4(lista[i]));
            }
            return final;
        }
       static public ApuestaDTO4 toDTO4(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento e;
            Mercado m;
            using (context)
            {
                m = context.Mercados.Single(p => p.MercadoId == a.MercadoId);
                e = context.Eventos.Single(p => p.EventoId == m.EventoId);
            }
            return new ApuestaDTO4(a.tipoCuota, e.Local, e.Visitante);
        }
    }

Apuestas Controller,cs
Ejercicio 2
       [Route("api/Apuestas")]
        public List<ApuestaDTO4> Get(int dinero)
        {
            ApuestasRepository rep = new ApuestasRepository();
            return rep.RetrievebyId(dinero);
        }


MercadosRepository.cs

Ejercicio 1

       internal List<ApuestaDTO3> RetrievebyId(int id)
        {
            List<Apuesta> lista;
            List<ApuestaDTO3> final = new List<ApuestaDTO3>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                lista = context.Apuestas.Where(a => a.MercadoId == id).ToList();
            }
            for(int i = 0; i < lista.Count; i++)
            {
                final.Add(toDTO3(lista[i]));
            }
            return final;
        }

       static public ApuestaDTO3 toDTO3(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Usuario u;
            using (context)
            {
                u = context.Usuarios.Single(b => b.UsuarioId == a.UsuarioId);

            }
            return new ApuestaDTO3(a.dinero, a.tipoCuota, u.Nombre);
        }
    }

Mercados Controller.cs
Ejercicio1

       [Route("api/Mercados/{id}")]
        public List<ApuestaDTO3> Get(int id)
        {
            MercadosRepository rep = new MercadosRepository();
            return rep.RetrievebyId(id);
        }

 */