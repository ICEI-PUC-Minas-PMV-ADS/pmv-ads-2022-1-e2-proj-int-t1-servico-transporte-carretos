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
        [Display(Name = "Data:")]
        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Dt_entrega { get; set; }

        public int Id_entrega { get; set; }

        [Display(Name = "Quantidade: ")]
        public int Qtde_entregas { get; set; }

    }
}
