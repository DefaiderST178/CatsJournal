namespace CatsJournal.Model
{
    public class Breed
    {
        public int Id { get; set; } // id
        public string BreedsName { get; set; } // название
        public string BreedsDescr { get; set; } // описание
        public List<string> BreedsImages { get; set; } // фотки
        public string BreedsWeight { get; set; } // вес
        public string BreedsCost { get; set; } // цена
        public string BreedsPersonality { get; set; } // характер
        public string BreedsHistory { get; set; } // история
        public string BreedsCatCare { get; set; } // уход
        public string BreedsTraining { get; set; } // обучение
    }
}
