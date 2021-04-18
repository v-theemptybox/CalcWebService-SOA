using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWS
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public double add(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double subtract(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double multiply(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double divide(double a, double b)
        {
            if (b == 0) throw new Exception("divide by zero");
            return a / b;
        }

    }
}
