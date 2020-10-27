using System;

namespace Persistencia.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public virtual Usuario Interessado { get; set; }
        public string Descricao { get; set; }
        public virtual Resposta Resposta { get; set; }
        public DateTime DataInclusao { get; set; }
    }

}
