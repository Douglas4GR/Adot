using Microsoft.AspNetCore.Mvc;
using Adot.Shared.Entidades;
using Adot.Shared.Interfaces;

namespace Adot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        //retorna todos os Usuarios
        [HttpGet("Usuarios")]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuarioAsync()
        {
            var usuarios = await _usuarioRepository.GetAllUsuariosAsync();
            return Ok(usuarios);
        }

        //retorna um Usuario pelo id
        [HttpGet("Usuario/{id}")]
        public async Task<ActionResult<List<Usuario>>> GetSingleUsuarioAsync(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioAsync(id);
            return Ok(usuario);
        }

        //retorna um Usuario pelo titulo
        [HttpGet("Usuario-Titulo/{titulo}")]
        public async Task<ActionResult<List<Usuario>>> GetUsuarioByTituloAsync(string titulo)
        {
            var usuario = await _usuarioRepository.GetUsuariosssAsync(titulo);
            return Ok(usuario);
        }

        //adiciona um Usuario
        [HttpPost("Add-Usuario")]
        public async Task<ActionResult<List<Usuario>>> AddUsuarioAsync(Usuario model)
        {
            var usuario = await _usuarioRepository.AddUsuarioAsync(model);
            return Ok(usuario);
        }

        //atualiza um usuario
        [HttpPut("Update-Usuario")]
        public async Task<ActionResult<List<Usuario>>> UpdateUsuarioAsync(Usuario model)
        {
            var usuario = await _usuarioRepository.UpdateUsuarioAsync(model);
            return Ok(usuario);
        }

        //deleta um usuario
        [HttpDelete("Delete-Usuario/{id}")]
        public async Task<ActionResult<List<Usuario>>> DeleteUsuarioAsync(int id)
        {
            var usuario = await _usuarioRepository.DeleteUsuarioAsync(id);
            return Ok(usuario);
        }
    }
}
