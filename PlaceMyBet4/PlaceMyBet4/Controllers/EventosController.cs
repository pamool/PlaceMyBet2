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
        /*
        [Route("api/Eventos/{id}")]
        public List<EventoDTO> Get(int id)
        {
            EventosRepository rep = new EventosRepository();
            return rep.RetrievebyId(id);
        }*/


        // POST: api/Eventos
       /* public void Post([FromBody]Evento e)
        {
            var repo = new EventosRepository();
            repo.Save(e);
        }*/
       
        public void Post([FromBody] EventosExamen F)
        {
            var repo = new EventosRepository();
            repo.Save(F);
        }


        // PUT: api/Eventos/5
        public void Put(int id,string equipoLocal,string equipoVisitante)
        {
            var repo = new EventosRepository();
            repo.Update(id, equipoLocal, equipoVisitante);
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
            var repo = new EventosRepository();
            repo.Eliminar(id);
        }
    }
}
