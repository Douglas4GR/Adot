using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adot.Shared.Entidades;

namespace Adot.Shared.Interfaces
{
    public interface IAnuncioRepository
    {
        Task<Anuncio> AddAnuncioAsync (Anuncio model);
        Task<Anuncio> UpdateAnuncioAsync(Anuncio model);
        Task<Anuncio> DeleteAnuncioAsync(int anuncioId);
        Task<List<Anuncio>> GetAllAnunciosAsync();
        Task<Anuncio> GetAnuncioAsync(int anuncioId);
        Task<List<Anuncio>> GetAnunciosssAsync (string titulo);
    }
}
