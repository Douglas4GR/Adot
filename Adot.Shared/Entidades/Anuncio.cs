using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adot.Shared.Entidades
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string? UsuarioNome { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        public bool EhMeuAnuncio { get; set; }
    }
}
