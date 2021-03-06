# Решение для задачи на SQL

*"В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться."*

###  Создадим структуру:
    CREATE TABLE Products(id int NOT NULL PRIMARY KEY, Name varchar(255));
    CREATE TABLE Categories(id int NOT NULL PRIMARY KEY, Name varchar(255));
    CREATE TABLE Prod_Cat(id int NOT NULL PRIMARY KEY, idProd int, idCat int, FOREIGN KEY (idProd) REFERENCES Categories(id), FOREIGN KEY (idCat) REFERENCES Products(id));

В результате, будет создана такая структура:

![Полученная структура данных](https://raw.githubusercontent.com/RedSerge/mindbox_hh/master/dbscheme.png)

### Искомый запрос:

    SELECT Products.Name, Categories.Name FROM Products, Categories, Prod_Cat WHERE Prod_Cat.idCat=Categories.id AND Prod_Cat.idProd=Products.id
    UNION ALL
    SELECT Products.Name, NULL FROM Products WHERE Products.id NOT IN (SELECT idProd FROM Prod_Cat);

# Задача на C#

*"Пришлите ссылку на пример вашего кода на C#, за который вам не стыдно. Если кода нет, выполните задание ниже. Оно также поможет, если код есть.*

*Задание:*

---

*Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *1. Юнит-тесты*
 
 *2. Легкость добавления других фигур*
 
 *3. Вычисление площади фигуры без знания типа фигуры*
 
 *4. Проверку на то, является ли треугольник прямоугольным"*

---
*Немного стыдно:* https://github.com/RedSerge/fun/tree/master/Experiments/DAISYGen7/DAISYGen/Code

*По задаче:*
- Shape/ShapesApp - главное приложение с демонстрацией использования библиотеки-решения задачи (*доп. пп. 2, 3*)
- Shape/ShapeArea - собственно, сама библиотека и единое решение ShapeArea.sln (*основное задание + доп. п. 4*)
- Shape/ShapeUnitTest - юнит-тесты (*доп. п. 1*) (bin.zip распаковывается в папку bin того же уровня)

# Все вопросы с портала

*Вопрос 1
Читали ли вы чужой код? Если да, то что это был за код? Опишите свои впечатления от него.*

Читал код из проектов Open Source и книг. Как правило, восхищался и учился. Еще читал код своих студентов. Как правило, находил ошибки и тоже учился.

*Вопрос 2
Опишите известные вам языки программирования и их предназначение.*

Опишу только языки, с которыми, так или иначе, сталкивался на практике:

1) Assembler — низкоуровневый язык программирования, пригоден для построения компиляторов или для обеспечения максимальной производительности (но только в умелых руках).
2) Basic — язык для обучения программированию. Как правило, плохому. В настоящее время существует в основном как способ создания макросов для офисных приложений (например, Microsoft Office VBA, LibreOffice Basic), а также скриптов (например, средство лицензирования Windows slmgr.vbs).
3) Python — Бейсик здорового человека, хороший выбор в качестве первого языка. Backend, десктопные приложения, анализ данных… Интерпертируемый, но в связке с C/C++ или Cython области применения практически универсальны за счет удобства прототипирования, принудительно-удобочитаемого кода и адекватных принципов («Zen of Python»).
4) Cython — Cython для Python — как TypeScript для JavaScript. Ускоряет работу за счет введения статической типизации, позволяет компилировать код на Python и собирать его в динамические библиотеки. Максимально гладко и бесшовно реализует систему типов C в Python.
5) Ruby — язык довольно странный, с особенностями, но с приятным синтаксисом. Используется в веб-разработке (backend).
6) Crystal — многообещающая переработка Ruby со статической типизацией и высокой производительностью. Пока — только под Linux.
7) Kotlin — функциональный язык программирования, совместимый с Java. Есть версия, независимая от JVM (Kotlin Native) — но медленная. Обеспечивает быстрое, приятное прототипирование. Используется в мобильной разработке.
8) C — по современным меркам, весьма низкоуровневый, но быстрый язык. Используется в качестве диалекта при межъязыковом взаимодействии и для экспорта функций из динамических библиотек. Особенно полезен там, где важна высокая производительность при ограниченных ресурсах (например, для встраиваемых решений).
9) C++ - объектно-ориентированный C. Чем современнее, тем гибче. Позволяет писать очень быстрые решения, поддерживает множество платформ. Универсальный язык.
10) Golang – попытка Google заменить C++. Язык, преимущественно используемый при разработке микросервисов. На мой взгляд, обладает потенциалом более универсального языка. Прост в изучении основ, обладает богатой функциональной плитрой стандартной библиотеки, особенно для сетевого и системного программирования. Rust, со своей догматичной и последовательной концепцией владения и заимствования, обгоняет в производительности полагающийся на сборщик мусора Golang. Однако отличный механизм многопоточности и собственный менеджер для более эффективного распределения ресурсов между потоками позволяют этому языку не терять популярность.
11) Object/Free Pascal (Delphi/Lazarus) – хороший, но устаревший язык для методологии RAD, взаимодействия с базами данных и написания кросс-компилируемых приложений с единообразными интерфейсами.
12) JavaScript — прототипный язык программирования, объединивший миры веб-разработки, backend (через NodeJS) и frontend. До появления WebAssembly монопольно доминировал в качестве языка для описания динамического поведения веб-страниц.
13) CoffeeScript - «синтаксический сахар» поверх JavaScript, быстро уступил свое место TypeScript.
14) Dart — попытка Google заменить JavaScript в веб-разработке. В настоящий момент преимущественно используется при разработке мобильных приложений за счет растущей популярности фреймворка Flutter.
15) C# и Java — используют свои версии виртуальной машины (CLR и JVM, соответственно) для выполнения программ с целью обеспечения платформонезависимости. Тем не менее, долгое время C# (как и весь .NET Framework) считался языком для ОС Windows, до появления кросплатформенной платформы Mono. Универсальные языки.
16) Haskell — язык, реализующий парадигму функционального программирования в чистом виде (не считая, быть может, монад). Позволяет писать чистый и правильный код, учит ломать парадигмы. Однако, достаточно медленный из-за императивной архитектуры современных ЭВМ.
17) Prolog — язык логического программирования, на практике используется редко, представляет больше академический интерес.
18) MATLAB и R — языки, активно использующиеся при математическом моделировании и статистике. Некоторые исследователи рекомендуют использовать эти языки при работе с моделями машинного обучения.

*Вопрос 3
Что такое "компилятор", зачем он нужен и почему некоторые языки обходятся без него?*

Компилятор - один из видов транслятора, программы, преобразующей исходный код на языке программирования в другой, непосредственно понятный исполнителю (машинный, в случае ЭВМ). В отличие от интерпретатора, который преобразует код по мере чтения, компилятор единовременно преобразует всю программу, генерируя исполняемый файл (в некоторых случаях - байт-код для виртуальной машины). Это ускоряет работу программы и позволяет избежать большего числа ошибок времени выполнения; однако, зачастую интерпретируемые языки более динамичны и допускают самомодификацию кода, которой, впрочем, злоупотреблять не стоит ('eval is evil'). Кроме того, компиляция в нативный машинный код делает приложение более защищенным от взлома, чем обычный интерпретируемый скрипт; для скрипта в этом случае применяют обфускацию (намеренное искажение текста программы с целью сокрытия ее смысла для наблюдателя) либо встраивание в исполняемый код вместе с интерпретатором (если допускает лицензия). Тем не менее, оба этих способа малоэффективны для полноценной защиты исходного кода. 

*Вопрос 4
Что такое "фреймворк" и для чего он нужен? Приведите примеры известных вам фреймворков.*

Фреймворк - набор компонентов для разработчика (например, .NET Framework/Mono, VCL/LCL). Как правило, в последнее время под этим понимают Web-фреймворки (React, Angular, Meteor, Vue...), призванные облегчить работу веб-разработчика за счет стандартизации и упрощения процесса создания веб-приложений.

*Вопрос 5
Что за приставка "http://" перед адресами сайтов и почему она всё чаще теперь становится "https://"?*

HTTP - протокол для обмена данными между серверами, в частности, документов с разметкой гипертекста. HTTPS - защищенная, расширенная версия этого протокола, реализующая механизмы для безопасной передачи важной (финансово значимой и другой конфиденциальной) информации по сети. Эти механизмы, в свою очередь, обеспечиваются протоколами, поддерживающими алгоритмы шифрования.

*Вопрос 6
Самая популярная библиотека для разработки фронтенд-приложений, ReactJS, моделирует логику в виде компонентов.
Если бы вам нужно было на ReactJS разработать страницу профиля ВКонтакте (например, https://vk.com/id1), на какие компоненты вы бы её разбили? Почему именно так?*

1) Блок всплывающих системных сообщений (об ошибке, статусе соединения и т.п.)
2) Блок "Верхней строки инструментов"
3) Кнопка (с рисунком и/или надписью)
4) Надпись со ссылкой
4) Поле поиска
5) Блок вызова выпадающего меню
6) Выпадающее меню
7) Боковое меню
8) Пункт меню (пиктограмма + текст, либо '-' для пустой строки)
9) Блок рекламной интеграции
10) Блок ссылок быстрого перехода
11) Ленты (Для надписи "^ Наверх", бокового меню, блоков с видеозаписями и фотографией, основного содержимого)
12) Элементы ленты (рисунок, подпись сверху или снизу)
13) Окно с основной информацией (специфичный элемент ленты)
14) Внутренняя лента поста (лайк, репост, просмотрено)

Руководствовался идеями минимального количества уникальных элементов. Тем не менее, некоторые уникальные элементы приходится обособлять в отдельные компоненты без декомпозиции.

*Вопрос 7
SqlServer, PostgreSQL, SQLLite, MySQL, Oracle, Microsoft Access - разные базы данных с разным функционалом, которые разрабатываются, в основном, разными компаниями с разным видением своего продукта.
Однако все эти базы используют один и тот же язык запросов - SQL, и не планируют от него отказываться. Как так получается? Что такого в SQL, что он подходит всем этим базам?
А если он такой чудесный, то почему многие другие базы данных, вроде MongoDB или Cassandra, его не используют?*

SQL - структурированный язык запросов - основан на реляционной алгебре, которая является расширением алгебры множеств и применяется в реляционных базах данных, к которым и относятся 6 перечисленных в начале.
Но есть и так называемый "noSQL" подход при построении баз данных, который отвергает стандартный реляционный подход в виду его ограничений (например, низкой масштабируемости). К ним и относятся MongoDB и Cassandra. MongoDB, например, использует JSON для описания внтуренней структуры данных.  

*Вопрос 8
Пришлите ссылку на пример вашего кода на C#, за который вам не стыдно. Если кода нет, выполните задание ниже. Оно также поможет, если код есть.
Пожалуйста, не пишите код внутри форм ответов, разместите его на Github и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
Задание:
Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры
Проверку на то, является ли треугольник прямоугольным*

Немного стыдно: https://github.com/RedSerge/fun/tree/master/Experiments/DAISYGen7/DAISYGen/Code

Решение задачи: https://github.com/RedSerge/mindbox_hh

*Вопрос 9
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
Github или Pastebin всё еще удобнее чем поле на hh. По возможности — положите ответ рядом с кодом из первого вопроса.*

Решение задачи: https://github.com/RedSerge/mindbox_hh (см. описание в README.md)

---

Сопроводительное письмо:

---

Интересуюсь программированием с 7 лет, получил профильное образование в этой сфере (магистратура и аспирантура). Остался в научной карьере и академическом программировании, поскольку был заинтересован в собственных исследованиях, требовавших уровня кандидата физико-математических наук. Выигрывал научные конкурсы, хакатон от Wikimedia и Яндекса, а также среди 15 человек из 100+ прошел конкурс от Samsung и был зачислен на краткий курс по построению компиляторов, который успешно завершил, возглавив одну из команд и представив рабочий прототип транслятора для простого (учебного) императивного языка. Участвовал по приглашению в летней школе в Университете Восточной Финляндии, практиковался в программировании моделей машинного обучения (в частности, обучения с подкреплением), был награжден высшим баллом за успешное выполнение проектов (10 ECTS).
Давно (9 лет назад) программировал на C# и Delphi, имел знакомство с Assembler для любительских опытов в сфере реверсивной инженерии. В последнее время программировал в связке Python + Golang, использовал C (иногда Cython) для обеспечения взаимодействия между языками через механизм FFI, JavaScript — для обеспечения интерактивности пользовательского интерфейса (в частности, с помощью технологии AJAX).
В настоящий момент преподаю основы Web-программирования. После завершения аспирантуры захотел попробовать силы в Fullstack-разработке. Но быстро понял, что не хватает релевантного опыта в индустрии, нужна опытная команда и наставник (до этого на работе программировал в одиночку). С этой целью и ищу стажировку.

GitHub: https://github.com/RedSerge/fun

Более полное резюме (но до 2019 года): https://github.com/RedSerge/scans/blob/master/Resume_Popkov_Sergei_10_2019.pdf
