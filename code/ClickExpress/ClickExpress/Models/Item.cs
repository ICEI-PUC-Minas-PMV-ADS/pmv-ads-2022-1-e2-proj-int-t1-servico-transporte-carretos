using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models
{
    [Table("Itens")]
    public class Item
    {

        [Key]
        [Display(Name = "Número do item: ")]
        public int Id_item { get; set; }

        [Display(Name = "Quantidade do item: ")]
        [Required(ErrorMessage = "Obrigatório informar a qunatidade!")]
        public int Quantidade { get; set; }

        [Display(Name = "Descrição do item")]
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }

        [Display(Name = "Pedido")]
        public Pedido Pedido { get; set; }


    }
}
