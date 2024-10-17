﻿using System;

namespace CatsJournal.Model
{
    public class NoteRepo
    {
        public static List<Note> AllNotes = new List<Note>
        {
            new Note
            {
                Name = "Как приучить кошку к новому дому",
                Descriptions = new List<string>
                {
                    "Если вы не представляете жизнь без домашнего животного и решили завести себе питомца, то ветеринары советуют брать животное в возрасте 10-12 недель от роду. В этом возрасте питомец начинает привыкать к человеку.",
                    "Когда вы принесете пушистого любимца в дом, сумку или корзину, в которой принесли животное не нужно сразу убирать. Поставьте ее в уголок, пока кошка не пройдет адаптацию к новому месту, это будет для нее убежищем, кошка не раз воспользуется им. На видном для питомца месте поставьте необходимые сосуды — миску для еды и воды, лоток, куда кошка будет ходить в туалет.",
                    "С появлением нового дома, кошка может вести себя очень насторожено, забиться в угол или наоборот все обнюхивать. В такой момент животное испытывает большой стресс, человек должен помочь пережить питомцу этот этап. Человек в такой момент должен сам быть спокоен, не кричать, не вести себя агрессивно пока питомец привыкает к новому месту.",
                    "Постарайтесь несколько дней как можно больше проводить время с новым членом семьи, уделяйте ему больше внимания и тогда период адаптации закончится намного быстрее."
                },
                Images = new List<string> // 
                {
                    "newdom1.jpg",
                    "newdom2.jpg",
                    "newdom3.jpg",
                    "newdom4.jpg"
                },
            },
            new Note
            {
                Name = "Чем нельзя кормить кошку",
                Descriptions = new List<string>
                {
                    "Рыба несет вред для кошек, она содержит очень много белка, который увеличивает нагрузку на почки животного, тем самым разрушает минеральный баланс, после чего начинается мочекаменная болезнь.",
                    "Нельзя давать кошкам мучные изделия и бобовые культуры, они вызывают метеоризм у животного и расстройство кишечника.",
                    "Нельзя кормить кошек свининой, она очень жирная для них. Жирная еда вызывает ожирение внутренних органов у кошки, а так же в свином мясе могут быть паразиты.",
                    "Так же нельзя, чтобы еда, которую вы даете кошке была с приправами. Следите, чтобы кошки не добрались до комнатных растений, так как они, могут быть ядовиты."
                },
                Images = new List<string>
                {
                    "korm1.jpg",
                    "korm2.jpg",
                    "korm3.jpg",
                    "korm4.jpg"
                },
            },
            new Note
            {
                Name = "Как приучить к лотку",
                Descriptions = new List<string>
                {
                    "Для первого знакомства котенка с туалетным местом следует посадить его в лоток и дать время все там изучить. Главное для котенка – понять, что это место «то самое». Не стоит удерживать его насильно, но если он захотел сходить в туалет то стоит подождать. Сразу же чистить лоток не нужно. По запаху малыш в следующий раз сможет быстро найти свой горшок.",
                    "Как понять, что котенок хочет в туалет? В раннем возрасте  перед походом в туалет они начинают поиски – принюхиваются, осматривают углы, ищут место. Почти все малыши крутятся вокруг себя. Котята бегут в лоток после еды и после сна. Зная эту «хитрость», можно сразу посадить малыша в туалет, не дожидаясь сигналов.",
                    "Котенок может с первого раза не запомнить нужное место. Поэтому заметив что он начинает готовится «сделать свои дела», следует отнести его в лоток и проследить за ним до «завершения мисси». Закрепить результат можно похвалой любимца, погладить и поощрить ласковым голосом.",
                    "Если котенок сходил в неположенном месте, в недовольном тоне скажите что так делать нельзя и отнесите его к лотку – покажите, куда ему нужно ходить.  Отсутствие положительного результата  к месяцу может говорить, что любимцу что-то не нравиться (место, наполнитель, резкие запахи рядом или от лотка). Если проблема так и не решилась, отвезите котенка к ветеринару."
                },
                Images = new List<string>
                {
                    "lotok1.jpg",
                    "lotok2.jpg",
                    "lotok3.jpg",
                    "lotok4.jpg"
                },
            },
            new Note
            {
                Name = "Как приучить кошку к когтеточке",
                Descriptions = new List<string>
                {
                    "Если кошка начала портить мебель, а стричь когти уже поздно, то нужно в срочном порядкеприобрести вашему питомцу когтеточку. Для начала нужно понаблюдать какое место стал портить питомец.",
                    "Если это косяк или стена с обоями, то когтеточку лучше купить с уголком из ковролина. Установите ее на то место, которое стала драть кошка. По началу такой инвентарь кошка может принять агрессивно, но есть несколько хитростей, которые помогут вам приучить питомца к когтеточке.",
                    "Во-первых, нужно взять питомца на руки, поднести к когтеточке и поставить лапку на нее, затем слегка нажать на лапку, чтобы кошка выпустила когти, и провести так лапкой сверху в низ. Такой трюк нужно проделать несколько раз, можно не подряд, а в течение дня или нескольких дней.",
                    "Во-вторых, сейчас продают специальные спреи для такого метода, в основном они на основе мяты. Нужно только побрызгать когтеточку. Ветеринары советуют не использовать валерьянку, он является наркотиком для котов и кошек."
                },
                Images = new List<string>
                {
                    "kogte1.jpg",
                    "kogte2.jpg",
                    "kogte3.jpg",
                    "kogte4.jpg"
                },
            },
            new Note
            {
                Name = "Поиграй со мной",
                Descriptions = new List<string>
                {
                    "Чтобы оставаться сильными, ловкими стройными, коты обязательно должны двигаться. Кроме того, игры помогают животным усваивать навыки выживания, учат защищаться и развивают охотничье мастерство.",
                    "Обычно коты развлекают себя сами, что выглядит весьна забавна. Но в то же время хозяева должны обеспечить их игрушками и ежедневно хотя бы понемногу играть со своими любимцами.",
                    "Иначе деятельный котенок, скорее всего, станет бегать по штором, о взрослый кот обленится и растолстеет. Особенно важно найти способ активного времяпрепровождения для питомцев, которые не выходят на улицу.",
                    "Кстати, играя со своим котом, вы сможата установить с ним поистине фантастические отношения и стать лучшими друзьями на всю жизнь!"
                },
                Images = new List<string>
                {
                    "playgame1.jpg",
                    "playgame2.jpg",
                    "playgame3.jpg",
                    "playgame4.jpg"
                },
            },
            new Note
            {
                Name = "Уход за шерстью",
                Descriptions = new List<string>
                {
                    "Очень большую роль для здоровья кошек и котов играет уход за их шерстью. Эти животные очень чистоплотны, они вылизывают свою шерсть очень тщательно. Бывает таких усилий мало и поэтому ветеринары настоятельно рекомендуют помогать кошкам в этом деле.",
                    "Ухаживать за шерстью животного вам помогут гребни и щетки, которые можно приобрести в зоомагазине. Старайтесь как можно чаще осматривать кошек, чтобы сразу выявить у них какое-либо заболевание или обнаружить паразитов. Вычесывание кошек облегчит жизнь не только им, но и вам.",
                    "Шерсть, которую вы вычешите, могла бы оказаться на диване или на полу по всей квартире. Когда кошка сама себя вылизывает, она съедает свою шерсть, чтобы избавиться от этого комка, кошка начинает кашлять, вызывая этим рвоту. Это нормальное явление.",
                    "Если у кошки шерсть короткая, то нужно вычесывать ее два раза в неделю, а если шерсть длинная, то один раз в день, чтобы шерсть не закаталась, иначе придется удалять этот комок только ножницами. Старайтесь вычесывать кошек аккуратно, чтобы не повредить кожу."
                },
                Images = new List<string>
                {
                    "sherst1.jpg",
                    "uhod2.jpg",
                    "uhod3.jpg",
                    "uhod4.jpg"
                },
            },
            new Note
            {
                Name = "Купание кошек",
                Descriptions = new List<string>
                {
                    "Кошки – невероятно чистоплотны, они могут по несколько часов в день тратить на вылизывание своей шубки. Однако бывают ситуации, когда одного вылизывания недостаточно и мытье кошки – неизбежная процедура. Например животное сильно испачкалась, появились блохи или подготовка к выставке. ",
                    "Перед тем, как вымыть кошку, ее необходимо тщательно вычесать и подстричь когти специальными ножницами. Мыть животное рекомендуется в небольшой и неглубокой емкости, на дно которой положить полотенце, чтобы питомец не скользил и не волновался. Вода должна быть теплой.",
                    "Кошку нужно погружать медленно, придерживая голову, чтобы вода не попала в нос и уши. Специальный шампунь следует наносить аккуратно на всю шерсть, не задевая мордочку. Затем осторожно смыть его до характерного «скрипа шерсти». После купания вода должна слегка стечь. Выньте кошку из ванны, заверните в полотенце и некоторое время держите на руках.",
                    "Что делать, если любимица категорически не приемлет воды и каждое купание заканчивается бешенством и истерикой? Современные производители предлагают две альтернативы: Шампунь в виде спрея и сухой шампунь. Они могут сильно помочь с поддержанием гигиены кошки."
                },
                Images = new List<string>
                {
                    "water1.jpg",
                    "water2.jpg",
                    "water3.jpg",
                    "water4.jpg"
                },
            },
            new Note
            {
                Name = "Первые вакцины",
                Descriptions = new List<string>
                {
                    "Прививки помогают кошкам выработать иммунитет к опасным инфекционным заболеваниям. Инфицирование отмечается лишь у 10 % привитых, но даже в этом случае болезнь протекает без осложнений. У непривитых животных ситуация обратна. ",
                    "График прививок котятам составляет ветеринар. В зависимости от риска заражения в месте проживания, он может добавить другие вакцины из дополнительного списка. ",
                    "Впервые котята подвергаются вакцинации в первые 8-12 недель своей жизни, раньше делать это не имеет смысла, так как в организме у котят уже есть антитела, полученные вместе с молоком матери. С течением времени иммунитет начинает слабеть, вот тогда и рекомендуется начинать делать кошке прививку впервые.",
                    "После того, как котятам будет введена первая вакцина от панлейкопении, калицивироза и ринотрахеита, через месяц рекомендуется сделать ревакцинацию, совмещая с вакциной от бешенства. В дальнейшей жизни котенка делать ревакцинацию рекомендуется раз в год."
                },
                Images = new List<string>
                {
                    "privivka1.jpg",
                    "privivka2.jpg",
                    "privivka3.jpg",
                    "privivka4.jpg"
                },
            },
        };
    }
}
