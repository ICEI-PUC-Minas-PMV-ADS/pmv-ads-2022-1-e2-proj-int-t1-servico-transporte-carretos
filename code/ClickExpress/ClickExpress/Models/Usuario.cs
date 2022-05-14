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
        [Required(ErrorMessage = "Obrigatório informar o nome!") ]
        public string Nome { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Display(Name = "Contato:")]
        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Tel { get; set; }

        [Display(Name = "Cadastre uma senha:")]
        [Required(ErrorMessage = "Obrigatório informar senha!")]
        [DataType(DataType.Password)] //inserir criptografia na caixa de senha (****)
        public string Senha { get; set; }

        [Display(Name = "CEP:")]
        [Required(ErrorMessage = "Obrigatório informar o cep!")]
        public string Cep { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "Obrigatório informar a cidade!")]
        public string Cidade { get; set; }

        [Display(Name = "Logradouro:")]
        [Required(ErrorMessage = "Obrigatório informar o logradouro!")]
        public string Logradouro { get; set; }

        [Display(Name = "UF:")]
        [Required(ErrorMessage = "Obrigatório informar o estado!")]
        public string UF{ get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Obrigatório informar o bairro!")]
        public string Bairro { get; set; }

        [Display(Name = "Complemento:")]
        [Required(ErrorMessage = "Obrigatório informar o número de endereço!")]
        public string Num_endereco { get; set; }

        [Display(Name = "CPF/CNPJ:")]
        [Required(ErrorMessage = "Obrigatório informar o cpf ou cnpj!")]
        public string Cpf_Cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar perfil!")]
        public Perfil Perfil { get; set; }

        [Display(Name = "Veículo:")]
        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        public string Veiculo { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }

    public enum Perfil
    {
        Cliente,
        Prestador
    }

}
