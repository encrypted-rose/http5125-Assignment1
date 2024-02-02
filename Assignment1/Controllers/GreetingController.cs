using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This is a method that will return a sentence with the input number added through a GET method.
        /// <example> GET localhost/Greeting/3 </example>
        /// <example> GET localhost/Greeting/6 </example>
        /// <example> GET localhost/Greeting/0 </example>
        /// </summary>
        /// <param name="id"> Input number.</param>
        /// <returns>The input within a string sentence. </returns>
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }
    }
}
