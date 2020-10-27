using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
        public virtual List<Pergunta> Perguntas { get; set; }
        public virtual List<Avaliacao> Avaliacoes { get; set; }
        public double Nota { get; set; }
    }
}
