﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prjWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Admin/5
        public string strMyName(string strName)
        {
            return strName;
        }

        // POST: api/Admin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Admin/5
        public void Delete(int id)
        {
        }
    }
}
