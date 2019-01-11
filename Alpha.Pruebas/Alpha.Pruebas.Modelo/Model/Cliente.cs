using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Pruebas.Modelo.Model
{
    public class Cliente
    {

        public int ID { get; set; }
       
        public string Nombre { get; set; }                
        //[MaxLength(100)] impacta sobre el atributo que esta debajo
        [DisplayName("Apellido de la persona")]//descriccion de atributo que se ubica debajo, que terminara como nombre de columna en tabla clientes
        public string Apellido { get; set; }

        //usa virtual como "marcador de que es una tabla"
        public virtual ICollection<Factura> Facturas { get; set; }

    }
}
