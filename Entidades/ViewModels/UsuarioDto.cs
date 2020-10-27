using System.Collections.Generic;

namespace Entidades.ViewModels
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<AnuncioDto> Snuncios { get; set; }
        public List<PerguntaDto> Perguntas { get; set; }
        public List<AvaliacaoDto> Avaliacoes { get; set; }
        public double Nota { get; set; }
    }

}
