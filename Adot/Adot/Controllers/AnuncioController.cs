using Microsoft.AspNetCore.Mvc;
using Adot.Shared.Entidades;
using Adot.Shared.Interfaces;

namespace Adot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioController(IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        //retorna todos os anuncios
        [HttpGet("Anuncios")]
        public async Task<ActionResult<List<Anuncio>>> GetAllAnuncioAsync()
        {
            var anuncios = await _anuncioRepository.GetAllAnunciosAsync();
            return Ok(anuncios);
        }

        //retorna um anuncio pelo id
        [HttpGet("Anuncio/{id}")]
        public async Task<ActionResult<List<Anuncio>>> GetSingleAnuncioAsync(int id)
        {
            var anuncio = await _anuncioRepository.GetAnuncioAsync(id);
            return Ok(anuncio);
        }

        //retorna um anuncio pelo titulo
        [HttpGet("Anuncio-Titulo/{titulo}")]
        public async Task<ActionResult<List<Anuncio>>> GetAnuncioByTituloAsync(string titulo)
        {
            var anuncio = await _anuncioRepository.GetAnunciosssAsync(titulo);
            return Ok(anuncio);
        }

        //adiciona um anuncio
        [HttpPost("Add-Anuncio")]
        public async Task<ActionResult<List<Anuncio>>> AddAnuncioAsync(Anuncio model)
        {
            var anuncio = await _anuncioRepository.AddAnuncioAsync(model);
            return Ok(anuncio);
        }

        //atualiza um anuncio
        [HttpPut("Update-Anuncio")]
        public async Task<ActionResult<List<Anuncio>>> UpdateAnuncioAsync(Anuncio model)
        {
            var anuncio = await _anuncioRepository.UpdateAnuncioAsync(model);
            return Ok(anuncio);
        }

        //deleta um anuncio
        [HttpDelete("Delete-Anuncio/{id}")]
        public async Task<ActionResult<List<Anuncio>>> DeleteAnuncioAsync(int id)
        {
            var anuncio = await _anuncioRepository.DeleteAnuncioAsync(id);
            return Ok(anuncio);
        }
    }
}
