using System;

namespace Repositorio.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public int IdInteressado { get; set; }
        public int IdAnuncio { get; set; }
        public string Descricao { get; set; }
        public virtual Resposta Resposta { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
