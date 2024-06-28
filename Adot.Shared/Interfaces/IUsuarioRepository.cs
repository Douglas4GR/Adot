using Adot.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adot.Shared.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> AddUsuarioAsync(Usuario model);
        Task<Usuario> UpdateUsuarioAsync(Usuario model);
        Task<Usuario> DeleteUsuarioAsync(int UsuarioId);
        Task<List<Usuario>> GetAllUsuariosAsync();
        Task<Usuario> GetUsuarioAsync(int UsuarioId);
        Task<List<Usuario>> GetUsuariosssAsync(string nome);
    }
}
