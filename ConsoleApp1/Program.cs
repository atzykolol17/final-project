﻿/*Створити ієрархію класів для продажу товарів Супермаркету
	Продукт( назва, термін споживання, категорія - молочні. хлібобулочні та ін., ціна, кількість)
	Товар (назва, категорія - побутова хімія, текстиль та ін., ціна, кількість)
Створити програму для роботи Супермаркету
	Додавання  продукту(товару) у базу(врахувати, що товар  у базі може бути наявний або ні )
	Збереження бази товарів( у файл)
	Завантаження бази товарів з файлу
	Перегляд  продуктів(товарів), впорядкованих по категоріях
	Пошук певного товару(продукту) з видачею інформації про товар(продукт)
	Видалення певного товару(продукту)  з бази
	Продаж товару(з видачею чеку) */



// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------- Welcome to supermarket");
Console.WriteLine("---Menu---");
Console.WriteLine("1. add new product");
Console.WriteLine("2. save to file");
Console.WriteLine("3. load to file");
Console.WriteLine("4. search product by name");
Console.WriteLine("5. delete product");
Console.WriteLine("6. sell product");