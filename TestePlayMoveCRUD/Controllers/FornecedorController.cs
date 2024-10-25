using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestePlayMoveCRUD.Data;
using TestePlayMoveCRUD.Model;
using TestePlayMoveCRUD.Model.Entities;

namespace TestePlayMoveCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper _mapper;

        public FornecedorController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            _mapper = mapper;
        }

        // Retorna uma lista com todos os Fornecedores
        [HttpGet]
        public IActionResult GetAllFornecedores()
        {
            try
            {
                var fornecedores = dbContext.Fornecedores.ToList();

                // Verifica se possui registros
                if (!fornecedores.Any())
                {
                    return NoContent(); // Retorna 204 No Content se não houver fornecedores
                }

                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao recuperar fornecedores: {ex.Message}"); // Retorna 500 Internal Server Error
            }
        }

        // Retorna o fornecedor por id
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetFornecedorById(Guid id)
        {
            try
            {
                var fornecedor = dbContext.Fornecedores.Find(id);

                // Verifica se o fornecedor foi encontrado
                if (fornecedor == null)
                {
                    return NotFound(); // Retorna 404 Not Found se não encontrar o fornecedor
                }

                return Ok(fornecedor); // Retorna 200 OK com o fornecedor encontrado
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao recuperar o fornecedor: {ex.Message}"); // Retorna 500 Internal Server Error
            }
        }

        // Adiciona um Fornecedor
        [HttpPost]
        public IActionResult AddFornecedor(AddFornecedorDto addFornecedorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Mapeia as propriedades do DTO para a entidade
                var fornecedor = _mapper.Map<Fornecedor>(addFornecedorDto);
                dbContext.Fornecedores.Add(fornecedor);
                dbContext.SaveChanges();
                return Ok(fornecedor);
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Erro ao adicionar o fornecedor: {dbEx.Message}"); // Retorna 500 Internal Server Error
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}"); // Retorna 500 Internal Server Error
            }
        }

        // Atualiza o fornecedor pelo Id
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateFornecedor(Guid id, UpdateFornecedorDto updateFornecedorDto)
        {
            try
            {
                var fornecedor = dbContext.Fornecedores.Find(id);

                // Verifica a validade dos campos
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Mapeia as propriedades do DTO para a entidade
                _mapper.Map(updateFornecedorDto, fornecedor);

                dbContext.SaveChanges();

                return Ok(fornecedor);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                return StatusCode(409, $"Conflito de atualização: {ex.Message}"); // Retorna 409 Conflict para erros de concorrência
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar o fornecedor: {ex.Message}"); // Retorna 500 Internal Server Error
            }
        }

        //Remove um fornecedor pelo Id
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteFornecedor(Guid id)
        {
            try
            {
                var fornecedor = dbContext.Fornecedores.Find(id);

                // Verifica se o fornecedor foi encontrado
                if (fornecedor == null)
                {
                    return NotFound(); // Retorna 404 Not Found se não encontrar o fornecedor
                }

                dbContext.Fornecedores.Remove(fornecedor);
                dbContext.SaveChanges();

                return Ok();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"Erro ao excluir o fornecedor: {ex.Message}"); // Retorna 500 Internal Server Error para erros de atualização
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro inesperado: {ex.Message}"); // Retorna 500 Internal Server Error para erros inesperados
            }
        }
    }
}
