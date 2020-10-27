namespace Entidades.ViewModels
{
	public class AvaliacaoDto
	{
		public int Id { get; set; }
		public int Nota { get; set; }
		public string Comentario { get; set; }
		public  UsuarioDto Avaliador { get; set; }
		public  AnuncioDto AnuncioOrigem { get; set; }

	}
}
