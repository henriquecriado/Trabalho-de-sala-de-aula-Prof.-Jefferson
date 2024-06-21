using TrabalhoJeff.Model.Enum;

namespace TrabalhoJeff.Model
{
    public class TaskModel

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StateTask State { get; set; }

    }

}
