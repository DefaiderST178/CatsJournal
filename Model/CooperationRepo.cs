using System;

namespace CatsJournal.Model
{
    public class CooperationRepo
    {
        public static List<Cooperation> AllCooperation => new List<Cooperation>
        {

            new Cooperation
            {
                Name = "Ветеринарная клиника «Хомячок»",
                Description = "Ветеринарная клиника Хомячок расположена в г.Новочеркасске, на улице им. Мацоты С.В., 32 Она оказывает широкий спектр услуг по лечению и профилактике заболеваний мелких домашних животных. У нас опытные и квалифицированные специалисты, низкие цены, доброжелательная и уютная атмосфера. Имеется ветеринарная аптека, в которой вы можете приобрести корма для животных, препараты для лечения, средства от паразитов, аксессуары и многое другое.",
                Address = "ул. С. В. Мацоты, 32, Новочеркасск, Ростовская обл.",
                Phone = "+7 938 103 86 85",
                Website = "http://homyachok-iko.ru/index/veterinarnaja_klinika/0-35"
            },

            new Cooperation
            {
                Name = "Вет клиника -Рык-",
                Description = "Лечение и осмотр домашних животных. Проведение операций. Специальный корм для ваших любимцев.",
                Address = "Айболитова 9",
                Phone = "+7 967 732 23 67",
                Website = "Отсутствует"
            },

            new Cooperation
            {
                Name = "ZooHoma",
                Description = "В наличии корма для питомцев, игрушки, домики, лотки и многое другое.",
                Address = "Улиточки 75",
                Phone = "+7 925 714 85 25",
                Website = "Отсутствует"
            },
        };

        public List<Cooperation> GetAllBreeds()
        {
            return AllCooperation;
        }
    }
}
