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
        public DateTime Dt_contrato { get; set; }

        [Display(Name = "Tipo do Serviço")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public TipoServico Tipo { get; set; }

        [Display(Name = "CEP:")]
        [Required(ErrorMessage = "Obrigatório informar o cep!")]
        public string Cep_origem { get; set; }

        [Display(Name = "Logradouro:")]
        [Required(ErrorMessage = "Obrigatório informar o logradouro!")]
        public string Logradouro_origem { get; set; }

        [Display(Name = "Número:")]
        [Required(ErrorMessage = "Obrigatório informar o complemento!")]
        public string Complemento_origem { get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Obrigatório informar o bairro!")]
        public string Bairro_origem { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "Obrigatório informar a cidade!")]
        public string Cidade_origem { get; set; }        

        [Display(Name = "UF:")]
        [Required(ErrorMessage = "Obrigatório informar o estado!")]
        public string UF_origem { get; set; }

        [Display(Name = "Cep:")]
        [Required(ErrorMessage = "Obrigatório informar o cep!")]
        public string Cep_destino { get; set; }

        [Display(Name = "Logradouro:")]
        [Required(ErrorMessage = "Obrigatório informar o logradouro!")]
        public string Logradouro_destino { get; set; }

        [Display(Name = "Número:")]
        [Required(ErrorMessage = "Obrigatório informar o complemento!")]
        public string Complemento_destino { get; set; }


        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Obrigatório informar o bairro!")]
        public string Bairro_destino { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "Obrigatório informar a cidade!")]
        public string Cidade_destino { get; set; }

        [Display(Name = "UF:")]
        [Required(ErrorMessage = "Obrigatório informar o estado!")]
        public string UF_destino { get; set; }
       
        [Display(Name = "Data/Horário do agendamento: ")]
        public DateTime Dt_agendamento { get; set; }

        [Display(Name = "Valor do pedido")]
        public double Preco { get; set; }

        [Display(Name = "Serviço de descarregamento")]
        public bool Serv_descarrega { get; set; }

        [Display(Name = "Serviço de montagem")]
        public bool Serv_montagem { get; set; }

        [Display(Name = "Usuario")]
        public int Id_usuario { get; set; }
        [ForeignKey("Id_usuario")]
        public Usuario Usuario { get; set; }

        public ICollection<Item> Itens { get; set; }  

    }
    public enum TipoServico
    {
        Mudança,
        Carreto
    }

}