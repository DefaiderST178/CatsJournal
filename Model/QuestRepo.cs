namespace CatsJournal.Model
{
    public class QuestRepo
    {
        public static List<Quest> AllQuest => new List<Quest>
        {
            new Quest // 1
            {
                QuestName = "Угадайте где Мейн-кун?",
                Breeds = new List<string>
                {
                    "Мейн-кун",
                    "Бирманская",
                    "Сибирская",
                    "Норвежская"
                },
                Images = new List<string>
                {
                    "maine_coon4.jpg",
                    "birma3.jpg",
                    "siberian4.jpg",
                    "norwegian5.jpg"
                },
                Answer = "Мейн-кун",
            },
            new Quest // 2
            {
                QuestName = "Угадайте где Американский бобтейл?",
                Breeds = new List<string>
                {
                    "Пиксибоб",
                    "Японский бобтейл",
                    "Американский бобтейл",
                    "Курильский бобтейл"
                },
                Images = new List<string>
                {
                    "pixcibob5.jpg",
                    "japanese_bobtail2.jpg",
                    "amerbob3.jpg",
                    "kuribob4.jpg"
                },
                Answer = "Американский бобтейл",
            },
            new Quest // 3
            {
                QuestName = "Угадайте где Тайская?",
                Breeds = new List<string>
                {
                    "Тонкинская",
                    "Тайская",
                    "Сиамская",
                    "Сноу-шу"
                },
                Images = new List<string>
                {
                    "tonk1.jpg",
                    "taiski1.jpg",
                    "siamese_cat1.jpg",
                    "snow5.jpg"
                },
                Answer = "Тайская",
            },
            new Quest // 4
            {
                QuestName = "Угадайте где Бомбейская?",
                Breeds = new List<string>
                {
                    "Шантильи-Тиффани",
                    "Йоркская шоколадная",
                    "Экзотическая",
                    "Бомбейская"
                },
                Images = new List<string>
                {
                    "tiffani1.jpg",
                    "york_chocolate_cat5.jpg",
                    "eczot5.jpg",
                    "bombei5.jpg"
                },
                Answer = "Бомбейская",
            },
            new Quest // 5
            {
                QuestName = "Угадайте где Корат?",
                Breeds = new List<string>
                {
                    "Русская голубая",
                    "Корат",
                    "Британская",
                    "Нибелунг"
                },
                Images = new List<string>
                {
                    "rusbly5.jpg",
                    "korat1.jpg",
                    "bct5.jpg",
                    "nibel4.jpg"
                },
                Answer = "Корат",
            },
            //new Quest // 6
            //{
            //    QuestName = "Угадайте где 6 ?",
            //    Breeds = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Images = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Answer = "",
            //},
            //new Quest // 7
            //{
            //    QuestName = "Угадайте где 7 ?",
            //    Breeds = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Images = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Answer = "",
            //},
            //new Quest // 8
            //{
            //    QuestName = "Угадайте где 8 ?",
            //    Breeds = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Images = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Answer = "",
            //},
            //new Quest // 9
            //{
            //    QuestName = "Угадайте где 9 ?",
            //    Breeds = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Images = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Answer = "",
            //},
            //new Quest // 10
            //{
            //    QuestName = "Угадайте где 10 ?",
            //    Breeds = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Images = new List<string>
            //    {
            //        "",
            //        "",
            //        "",
            //        ""
            //    },
            //    Answer = "",
            //}
        };
    }
}
