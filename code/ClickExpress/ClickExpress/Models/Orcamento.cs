using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models
{
    [Table("Orcamentos")]
    public class Orcamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Número do orçamento: ")]
        public int Id_orcamento { get; set; }

        [Display(Name = "Número da solicitação")]
        public int Id_contrato { get; set; }
        [ForeignKey("Id_contrato")]
        public Pedido Pedido { get; set; }

        [Display(Name = "Prestador responsável: ")]
        public int Id_prestador { get; set; }

        [Display(Name = "Valor do pedido")]
        public double Preco { get; set; }

        [Display(Name = "Status orçamento")]
        public string Status_orcamento { get; set; }



    }
}
