using PlaceMyBet4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet4.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<Evento> Get()
        {
            var repo = new EventosRepository();
            List<Evento> eventos = repo.Retrieve();
            return eventos;
        }

        // GET: api/Eventos/5
        public string Get(int id)
        {
            return "value";
        }
        /**Ejercicio1**/
        public IEnumerable<Evento> Get(string EquipoLocal)
        {
            var repo = new EventosRepository();
            List<EventoApuesta> eventos = repo.eventoApuesta(EquipoLocal);
            return eventos;
        }
        /**Fin Ejercicio1**/
        // POST: api/Eventos
        public void Post([FromBody]Evento e)
        {
            var repo = new EventosRepository();
            repo.Save(e);
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
