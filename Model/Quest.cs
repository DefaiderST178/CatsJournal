namespace CatsJournal.Model
{
    public class Quest
    {
        public int Id { get; set; } // id
        public string QuestName { get; set; } // Название теста
        public List<string> Breeds { get; set; } // породы
        public List<string> Images { get; set; } // фото пород
        public string Answer { get; set; } // Ответ
    }
}
