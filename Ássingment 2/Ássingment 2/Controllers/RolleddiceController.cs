using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ássingment_2.Controllers
{
    public class RolleddiceController : ApiController
    {
        // GET: api/<RollTheDice_J2>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int count = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }
            string totalstring = $"There are {count} total ways to get the sum 10";
            return totalstring;
        }

    }
}

