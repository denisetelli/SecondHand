using System;

namespace Entidades.ViewModels
{
    public class PerguntaDto
    {
        public int Id { get; set; }
        public UsuarioDto Interessado { get; set; }
        public string Descricao { get; set; }
        public RespostaDto Resposta { get; set; }
        public DateTime DataInclusao { get; set; }
    }

}
