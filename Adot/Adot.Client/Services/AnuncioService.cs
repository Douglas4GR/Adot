using Adot.Shared.Interfaces;
using Adot.Shared.Entidades;
using System.Net.Http.Json;
using System.Text.Json;

namespace Adot.Client.Services
{
    public class AnuncioService : IAnuncioRepository
    {
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions _options;

        public AnuncioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }
        public async Task<Anuncio> AddAnuncioAsync(Anuncio model)
        {
            var anuncio = await httpClient.PostAsJsonAsync("api/Anuncio/Add-Anuncio", model);
            var response = await anuncio.Content.ReadFromJsonAsync<Anuncio>();
            return response!;
        }

        public async Task<Anuncio> DeleteAnuncioAsync(int anuncioId)
        {
            var anuncio = await httpClient.DeleteAsync($"api/Anuncio/Delete-Anuncio/{anuncioId}");
            var response = await anuncio.Content.ReadFromJsonAsync<Anuncio>();
            return response!;
        }

        public async Task<List<Anuncio>> GetAllAnunciosAsync()
        {
            var anuncios = await httpClient.GetAsync("api/Anuncio/Anuncios");
            var response = await anuncios.Content.ReadFromJsonAsync<List<Anuncio>>();
            return response!;
        }

        public async Task<Anuncio> GetAnuncioAsync(int anuncioId)
        {
            var anuncio = await httpClient.GetAsync($"api/Anuncio/Anuncio/{anuncioId}");
            var response = await anuncio.Content.ReadFromJsonAsync<Anuncio>();
            return response!;
        }

        public async Task<List<Anuncio>> GetAnunciosssAsync(string titulo)
        {
            var anuncio = await httpClient.GetAsync($"api/Anuncio/Anuncio/{titulo}");
            var response = await anuncio.Content.ReadFromJsonAsync<List<Anuncio>>();
            return response!;
        }

        public async Task<Anuncio> UpdateAnuncioAsync(Anuncio model)
        {
            var anuncio = await httpClient.PutAsJsonAsync("api/Anuncio/Update-Anuncio", model);
            var response = await anuncio.Content.ReadFromJsonAsync<Anuncio>();
            return response!;
        }
    }
}
