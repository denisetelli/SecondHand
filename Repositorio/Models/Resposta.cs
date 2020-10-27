using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public int IdPergunta { get; set; }
        public string Descricao { get; set; }
        public virtual List<Imagem> Imagens { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
