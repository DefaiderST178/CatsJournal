using System;

namespace CatsJournal.Model
{
    public class CooperationRepo
    {
        public static List<Cooperation> AllCooperation => new List<Cooperation>
        {

            new Cooperation
            {
                Name = "Пушистые друзья",
                Description = "Фелинариум для свободного посещения. Более 30 пород кошек, возможность хорошо провести время и отдохнуть среди котиков. Возможность покормить особо голодных питомцев. Стоимость в час 500 рублей.",
                Address = "Манулов 23",
                Phone = "+7 904 158 78 98",
                Website = "Отсутствует"
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
