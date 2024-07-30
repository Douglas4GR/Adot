using Microsoft.EntityFrameworkCore;
using Adot.Shared.Entidades;

namespace Adot.Context
{
    public class AnuncioContext : DbContext
    {
        public AnuncioContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
