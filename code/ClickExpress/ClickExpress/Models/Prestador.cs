using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models
{
    [Table("Prestadores")]
    public class Prestador : Usuario
    {
        
        [Display(Name = "Identificação do prestador: ")]
        public int Id_prestador { get; set; }

        [Display(Name = "Veículo: ")]
        public string Veiculo { get; set; }

    }
}
