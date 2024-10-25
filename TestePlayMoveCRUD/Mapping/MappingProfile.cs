using AutoMapper;
using TestePlayMoveCRUD.Model;
using TestePlayMoveCRUD.Model.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AddFornecedorDto, Fornecedor>();
        CreateMap<UpdateFornecedorDto, Fornecedor>();
    }
}