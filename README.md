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

- Shape/ShapesApp - главное приложение с демонстрацией использования библиотеки-решения задачи (*доп. пп. 2, 3*)
- Shape/ShapeArea - собственно, сама библиотека (*основное задание + доп. п. 4*)
- Shape/ShapeUnitTest - юнит-тесты (*доп. п. 1*)
