using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class addTenController : ApiController
    {
        /// <summary>
        /// This is a method that will get a numeral value and add 10 through a GET request.
        /// <example> GET localhost/AddTen/21 </example>
        /// <example> GET localhost/AddTen/0 </example>
        /// <example> GET localhost/AddTen/-9 </example>
        /// </summary>
        /// <param name="id"> Input number.</param>
        /// <returns>The input number plus 10 added. </returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
