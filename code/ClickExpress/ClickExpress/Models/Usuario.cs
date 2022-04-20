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
        
        [Required(ErrorMessage = "Obrigatório informar o nome!") ]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Obrigatório informar senha!")]
        [DataType(DataType.Password)] //inserir criptografia na caixa de senha (****)
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a rua!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o estado!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número de endereço!")]
        public string Num_endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o cpf ou cnpj!")]
        public string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar perfil!")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil

    {
        Cliente,
        Prestador
    }

}
