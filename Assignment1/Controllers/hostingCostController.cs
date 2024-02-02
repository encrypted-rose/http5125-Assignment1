using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class hostingCostController : ApiController
    {
        /// <summary>
        /// This method will get you the total of the hosting cost of web server through a GET method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The total cost after the right calculations.</returns>
        /// 
        public IEnumerable<string> Get(int id)
        {
            /*Not sure how to make the decimal calculation using int.
            * I understand how to make the return/output work, however converting "id" into a value that equals the days and then working with decimals*/

            return new string[] { id +" fortnights at $5.50/FN = " + "$" + id + " CAD", "HST 13% = " + "$" + id + " CAD", "Total = " + "$" + id + " CAD" };
        }
    }
}
