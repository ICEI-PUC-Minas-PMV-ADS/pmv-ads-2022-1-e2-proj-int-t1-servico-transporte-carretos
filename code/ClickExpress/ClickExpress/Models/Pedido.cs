using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Número do pedido")]
        public int Id_contrato { get; set; }

        [Display(Name = "Data do pedido")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Dt_contrato { get; set; }

        [Display(Name = "Tipo do Serviço")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public TipoServico Tipo { get; set; }

        [Display(Name = "Endereço de Origem")]
        [Required(ErrorMessage = "Obrigatório informar o endereço de partida!")]
        public string End_Destino { get; set; }

        [Display(Name = "Endereço de Destino")]
        [Required(ErrorMessage = "Obrigatório informar o endereço de destino!")]
        public string End_Partida { get; set; }

        [Display(Name = "Disponibilidade de horário")]
        [Required(ErrorMessage = "Obrigatório informar o horario!")]
        public Horario Horario { get; set; }

        [Display(Name = "Valor do pedido")]
        public double Preco { get; set; }


        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Obrigatório informar o usuario!")] 
        public int Usuario_Id { get; set; }
        [ForeignKey("Usuario_Id")]
        public Usuario Usuario { get; set; }
    }
    public enum TipoServico
    {
        Mudança,
        Carreto
    }
    public enum Horario
    {
        Definir_Horario,
        Dia_Inteiro,
        Matutino,
        Vespertino,
        Noturno,

    }
}