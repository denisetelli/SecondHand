namespace Repositorio.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public virtual Usuario Avaliador { get; set; }
    }
}
