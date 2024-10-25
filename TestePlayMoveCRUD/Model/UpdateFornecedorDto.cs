using System.ComponentModel.DataAnnotations;

namespace TestePlayMoveCRUD.Model
{
    public class UpdateFornecedorDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(1, ErrorMessage = "O nome não pode ser vazio.")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [MinLength(1, ErrorMessage = "O telefone não pode ser vazio.")]
        public required string Telefone { get; set; }

        public string? Descricao { get; set; }
    }
}
