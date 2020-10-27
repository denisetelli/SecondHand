using System;
using System.Collections.Generic;

namespace Persistencia.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<Imagem> IImagens { get; set; }
        public DateTime DataInclusao { get; set; }
    }

}
