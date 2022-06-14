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
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Prestador responsável: ")]
        public int Id_prestador { get; set; }

        [Display(Name = "Veículo:")]
        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        public string Veiculo { get; set; }



    }
}
