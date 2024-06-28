using Adot.Shared.Interfaces;
using Adot.Shared.Entidades;
using System.Net.Http.Json;
using System.Text.Json;

namespace Adot.Client.Services
{
    public class UsuarioService : IUsuarioRepository
    {
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions _options;

        public UsuarioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
        public async Task<Usuario> AddUsuarioAsync(Usuario model)
        {
            var usuario = await httpClient.PostAsJsonAsync("api/Usuario/Add-Usuario", model);
            var response = await usuario.Content.ReadFromJsonAsync<Usuario>();
            return response!;
        }

        public async Task<Usuario> DeleteUsuarioAsync(int usuarioId)
        {
            var usuario = await httpClient.DeleteAsync($"api/Usuario/Delete-Usuario/{usuarioId}");
            var response = await usuario.Content.ReadFromJsonAsync<Usuario>();
            return response!;
        }

        public async Task<List<Usuario>> GetAllUsuariosAsync()
        {
            var usuarios = await httpClient.GetAsync("api/Usuario/Usuarios");
            var response = await usuarios.Content.ReadFromJsonAsync<List<Usuario>>();
            return response!;
        }

        public async Task<Usuario> GetUsuarioAsync(int usuarioId)
        {
            var usuario = await httpClient.GetAsync($"api/Usuario/Usuario/{usuarioId}");
            var response = await usuario.Content.ReadFromJsonAsync<Usuario>();
            return response!;
        }

        public async Task<List<Usuario>> GetUsuariosssAsync(string titulo)
        {
            var usuario = await httpClient.GetAsync($"api/Usuario/Usuario/{titulo}");
            var response = await usuario.Content.ReadFromJsonAsync<List<Usuario>>();
            return response!;
        }

        public async Task<Usuario> UpdateUsuarioAsync(Usuario model)
        {
            var usuario = await httpClient.PutAsJsonAsync("api/Usuario/Update-Usuario", model);
            var response = await usuario.Content.ReadFromJsonAsync<Usuario>();
            return response!;
        }
    }
}
