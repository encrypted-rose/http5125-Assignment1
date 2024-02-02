using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class numberMachineController : ApiController
    {
        /// <summary>
        /// This is a method that will get the total of 4 mathemathical operations through a GET request.
        /// <example> GET localhost/NumberMachine/10 </example>
        /// <example> GET localhost/NumberMachine/-5 </example>
        /// <example> GET localhost/NumberMachine/30 </example>
        /// </summary>
        /// <param name="id"> Input number.</param>
        /// <returns>The input number plus 10, then multiplied by 10, then divided by 100 and then plus 100. </returns>
        /// 

        public int Get(int id)
        {
            return ((id + 10) *10) / 100 + 100;
        }
    }
}
