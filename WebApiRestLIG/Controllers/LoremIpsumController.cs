using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApiRestLIG.Models;

namespace WebApiRestLIG.Controllers
{
    public class LoremIpsumController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "LoremIpsum", "LoremIpsum2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}


        public string Get(int id)
        {
            string item = "LoremIpsum";
            short i = 0;
            StringBuilder sbReturn = new StringBuilder();
            sbReturn.Append(string.Empty);
            if (id < 1)
            {
                return sbReturn.ToString();
            }
            while (i < id)
            {
                if (id > 1 && i > 0)
                    sbReturn.Append("  ");
                sbReturn.Append(item);
               
                i++;
            }

            return sbReturn.ToString();
        }
    }
}
