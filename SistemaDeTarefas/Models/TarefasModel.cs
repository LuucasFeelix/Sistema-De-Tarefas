namespace SistemaDeTarefas.Models
{
    public class TarefasModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? descricao { get; set; }
        public int Status { get; set; }
    }
}
