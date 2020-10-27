using System;

namespace Persistencia.Models
{
	public class Avaliacao
	{
		public int Id { get; set; }
		public int Nota { get; set; }
		public string Comentario { get; set; }
		public virtual Usuario Avaliador { get; set; }
		public virtual Anuncio AnuncioOrigem { get; set; }

	}
}
