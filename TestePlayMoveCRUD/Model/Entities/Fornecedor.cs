using System.ComponentModel.DataAnnotations;

namespace TestePlayMoveCRUD.Model.Entities
{
    public class Fornecedor
    {
        public required Guid Id { get; init; } // Guid é uma opção mais robusta e evita problemas em migrações, init nao permite alteração do valor.

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(1, ErrorMessage = "O nome não pode ser vazio.")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [MinLength(1, ErrorMessage = "O telefone não pode ser vazio.")]
        public required string Telefone { get; set; }

        public string? Descricao { get; set; } // É preciso usar "?" para mostrar que essa propriedade é nullable, ou seja, opcional
    }
}
