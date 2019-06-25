using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace twright_FinancialAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DefaultController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        // GET: api/Default
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 
        /// </summary>
        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 
        /// </summary>
        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
