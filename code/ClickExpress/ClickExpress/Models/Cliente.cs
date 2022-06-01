using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models
{
    [Table("Clientes")]
    public class Cliente : Usuario
    {
        
        [Display(Name = "Identificação do cliente: ")]
        public int Id_cliente { get; set; }
    }       
}
