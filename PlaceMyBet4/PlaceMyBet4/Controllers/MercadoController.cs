﻿using PlaceMyBet4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet4.Controllers
{
    public class MercadoController : ApiController
    {
        // GET: api/Mercado
        public IEnumerable<Mercado> Get()
        {
            var repo = new MercadosRepository();
            List<Mercado> mercados = repo.Retrieve();
            return mercados;
        }


        // GET: api/Mercado/5
        public Mercado Get(int id)
        {
            var repo = new MercadosRepository();
            Mercado mercado = repo.RetrieveId(id);
            return mercado;
        }

        // POST: api/Mercado
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercado/5
        public void Delete(int id)
        {
        }
    }
}
