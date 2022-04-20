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
        [Required(ErrorMessage = "Obrigatório informar a descrição do pedido!")]
        public string Desc_pedido { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Dt_pedido { get; set; }

        public int Id_pedido { get; set; }

        public int Qtde_pedidos { get; set; }

    }
}
