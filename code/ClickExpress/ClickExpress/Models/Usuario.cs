using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClickExpress.Models // classe criada
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id_usuario { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "*Campo Obrigatório") ]
        public string Nome { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Contato:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Tel { get; set; }

        [Display(Name = "Cadastre uma senha:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        [DataType(DataType.Password)] //inserir criptografia na caixa de senha (****)
        public string Senha { get; set; }

        [Display(Name = "CEP:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Cep { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Cidade { get; set; }

        [Display(Name = "Logradouro:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Logradouro { get; set; }

        [Display(Name = "UF:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string UF{ get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Bairro { get; set; }

        [Display(Name = "Número:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Num_endereco { get; set; }

        [Display(Name = "CPF/CNPJ:")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public string Cpf_Cnpj { get; set; }

        public string Perfil { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }

}
