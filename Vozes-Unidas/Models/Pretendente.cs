namespace Vozes_Unidas.Models
{
    public class Pretendente
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
