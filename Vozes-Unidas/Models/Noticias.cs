namespace Vozes_Unidas.Models
{
    public class Noticias
    {
        public int Id { get; set; }
        public string imagemCapa { get; set; }
        public string titulo {  get; set; }
        public string conteudo { get; set; }
        public DateOnly dataPublicacao { get; set; }
        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
