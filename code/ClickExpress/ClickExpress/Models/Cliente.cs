using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClickExpress.Models
{
    [Table("Clientes")]
    public class Cliente : Usuario
    {
        [Display(Name = "Cliente: ")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id_cliente { get; set; }

      
    }
}