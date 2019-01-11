using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Pruebas.Modelo.Model
{
    public class Factura
    {

        public int ID { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }        
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public void Prueba()
        {
            //Control + k + s ...try
            try
            {
                //Control + k + s ...if
                if (true)
                {
                    //Comentar Control + k + c
                    //Descomentar Control + k + u
                    int a = 1; 
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
