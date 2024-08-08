namespace Vozes_Unidas.Models
{
    public class Comentarios
    {
        public int Id { get; set; }
        public string conteudo { get; set; }
        public DateOnly dataPublicacao { get; set; }
        public int ForumId { get; set; }
        public Forum? Forum { get; set; }
    }
}
