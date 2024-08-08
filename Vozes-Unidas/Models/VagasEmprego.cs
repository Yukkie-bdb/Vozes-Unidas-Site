namespace Vozes_Unidas.Models
{
    public class VagasEmprego
    {
        public int Id { get; set; }
        public string local {  get; set; }
        public string cargo { get; set; }
        public TimeOnly horarioInicial { get; set; }
        public TimeOnly horarioFinal { get; set; }
        public int salario { get; set; }
        public string descricao { get; set; }
        public int EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
