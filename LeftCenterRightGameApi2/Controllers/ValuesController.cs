using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LeftCenterRightGameApi2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET: Values
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1","value2" };

        }
    }
}