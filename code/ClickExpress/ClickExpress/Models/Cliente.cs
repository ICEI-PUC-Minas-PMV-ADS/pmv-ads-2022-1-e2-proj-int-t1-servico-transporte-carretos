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
        [Display(Name = "Descrição do pedido: ")]
        [Required(ErrorMessage = "Obrigatório informar a descrição do pedido!")]
        public string Desc_pedido { get; set; }

        [Display(Name = "Data: ")]
        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Dt_pedido { get; set; }

        public int Id_pedido { get; set; }

        [Display(Name = "Quantidade: ")]
        public int Qtde_pedidos { get; set; }

    }
}
