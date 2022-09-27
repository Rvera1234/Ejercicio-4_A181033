using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreaGeometricas.Properties
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public int Cuadrado(int a = 0, int b = 0)
        {

            int L1 = a;
            int L2 = b;

            int res = L1 * L2;


            return res;
        }


        [WebMethod]
        public double Circculo(double r)
        {

            double Radio = r;
            double area;
            area = (Radio * Radio) * (3.1416);

            return area;
        }


        [WebMethod]
        public int Triangulo(int b, int a)
        {
            int base1 = b;
            int altura1 = a;
            int res = (b * a) / 2;


            return res;
        }







    }
}
