namespace TestePlayMoveCRUD.Model.Entities
{
    public class Fornecedor
    {
        public Guid Id { get; init; } // Guid é uma opção mais robusta e evita problemas em migrações, init nao permite alteração do valor.
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public string? Descricao { get; set; } // É preciso usar "?" para mostrar que essa propriedade é nullable, ou seja, opcional
    }
}
