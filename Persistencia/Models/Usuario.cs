using System;
using System.Collections.Generic;

namespace Persistencia.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<Anuncio> Snuncios { get; set; }
        public List<Pergunta> Perguntas { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
        public double Nota { get; set; }
    }

}
