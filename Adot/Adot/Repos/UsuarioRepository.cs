using Adot.Context;
using Adot.Shared.Interfaces;
using Adot.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Adot.Repos
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AnuncioContext _context;

        public UsuarioRepository(AnuncioContext context)
        {
            _context = context;
        }

        //Adicionar
        public async Task<Usuario> AddUsuarioAsync(Usuario model)
        {
            _context.Usuarios.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        //Deletar
        public async Task<Usuario> DeleteUsuarioAsync(int UsuarioId)
        {
            var model = await _context.Usuarios.FindAsync(UsuarioId);
            _context.Usuarios.Remove(model);
            await _context.SaveChangesAsync();
            return model;
        }

        //Atualizar
        public async Task<Usuario> UpdateUsuarioAsync(Usuario model)
        {
            var usuario = await _context.Usuarios.FindAsync(model.Id);
            if (usuario is null) return null!;
            usuario.Nome = model.Nome;
            usuario.Email = model.Email;
            usuario.Imagem = model.Imagem;
            await _context.SaveChangesAsync();
            return usuario;
        }

        //Listar
        public async Task<List<Usuario>> GetAllUsuariosAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        //Encontrar por ID
        public async Task<Usuario> GetUsuarioAsync(int UsuarioId)
        {
            return await _context.Usuarios.FindAsync(UsuarioId);
        }

        //Encontrar por nome
        public async Task<List<Usuario>> GetUsuariosssAsync(string nome)
        {
            return await _context.Usuarios.Where(x => x.Nome == nome).ToListAsync();
        }
    }
}
