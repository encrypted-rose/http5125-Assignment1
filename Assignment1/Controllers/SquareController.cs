using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This is a method that will get square root of a number by multiplying it against itself through a GET request.
        /// <example> GET localhost/Square/2 </example>
        /// <example> GET localhost/Square/-2 </example>
        /// <example> GET localhost/Square/10 </example>
        /// </summary>
        /// <param name="id"> Input number.</param>
        /// <returns>The input number multiplied by itself. </returns>
        public int Get(int id)
        {
            return id *id;
        }
    }
}
