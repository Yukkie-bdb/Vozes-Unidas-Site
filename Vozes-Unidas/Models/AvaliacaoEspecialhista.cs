namespace Vozes_Unidas.Models
{
    public class AvaliacaoEspecialhista
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public int estrelas { get; set; }
        public string descricao { get; set; }
    }
}
