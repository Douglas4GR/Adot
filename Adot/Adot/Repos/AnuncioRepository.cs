using Adot.Context;
using Adot.Shared.Interfaces;
using Adot.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Adot.Repos
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private readonly AnuncioContext _context;
        public AnuncioRepository(AnuncioContext context)
        {
            _context = context;
        }

        //Adicionar
        public async Task<Anuncio> AddAnuncioAsync(Anuncio model)
        {
            if (model is null) return null!;

            var chk = await _context.Anuncios.FindAsync(model.Id);
            if (chk is not null) return null!;

            var novoAnuncio = _context.Anuncios.Add(model).Entity;
            await _context.SaveChangesAsync();
            return novoAnuncio;
        }

        //Deletar
        public async Task<Anuncio> DeleteAnuncioAsync(int anuncioId)
        {
            var anuncio = await _context.Anuncios.FindAsync(anuncioId);
            if (anuncio is null) return null!;
            _context.Anuncios.Remove(anuncio);
            await _context.SaveChangesAsync();
            return anuncio;
        }

        //Listar
        public async Task<List<Anuncio>> GetAllAnunciosAsync()
        {
            return await _context.Anuncios.ToListAsync();
        }

        //Encontrar por ID
        public async Task<Anuncio> GetAnuncioAsync(int anuncioId)
        {
            var anuncio = await _context.Anuncios.FindAsync(anuncioId);
            if (anuncio is null) return null!;
            return anuncio!;
        }

        //Encontrar por titulo
        public async Task<List<Anuncio>> GetAnunciosssAsync(string titulo)
        {
            return await _context.Anuncios.Where(x => x.Titulo.Contains(titulo)).ToListAsync();
        }

        //Atualizar
        public async Task<Anuncio> UpdateAnuncioAsync(Anuncio model)
        {
            var anuncio = await _context.Anuncios.FindAsync(model.Id);

            if (anuncio is null) return null!;

            anuncio.Titulo = model.Titulo;
            anuncio.Descricao = model.Descricao;
            anuncio.Imagem = model.Imagem;

            await _context.SaveChangesAsync();

            return await _context.Anuncios.FindAsync(model.Id);
        }
    }
}
