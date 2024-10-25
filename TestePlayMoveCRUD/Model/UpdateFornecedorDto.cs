namespace TestePlayMoveCRUD.Model
{
    public class UpdateFornecedorDto
    {
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public string? Descricao { get; set; }
    }
}
