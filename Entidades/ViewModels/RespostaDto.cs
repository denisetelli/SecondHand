using System;
using System.Collections.Generic;

namespace Entidades.ViewModels
{
    public class RespostaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<ImagemDto> IImagens { get; set; }
        public DateTime DataInclusao { get; set; }
    }

}
