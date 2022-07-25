using CommonLib.Enums;
using CommonLib.Models;
using CommonLib.Services;
using CommonLib.Services.Factories;
using System;
using System.Collections.Generic;

namespace ClassBook
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonFactory personFactory = new PersonFactory();

            List<Person> authors = new List<Person>
            {
                personFactory.CreatePerson("Лев", "Толстой", "Николаевич")
            };

            BookService bookService = new BookService();

            Book book = bookService.CreateBook("Война и Мир",                                       // Название
                                                authors,                                            // Авторы
                                                1,                                                  // Том
                                                new DateTime(2020, 3, 26),                          // Дата отдачи в печать
                                                500,                                                // Всего страниц
                                                FontFamilies.ScholBook,                             // гарнитура
                                                Formats.F60_90_16,                                  // Формат
                                                new Organization("Чук и Гек", "г. Пермь"),          // Издательство
                                                new Organization("Чип и Дейл", "г. Екатеринбург"),  // Типография
                                                1500                                                // цена в рублях
                                                );


            book.AddBookmark("Наталья и Пьер", 50);

            book.OpenAt(5);
            book.NextPage();

            IJsonService jsonService = new NewtonJsonService();

            string bookJson = jsonService.Serialize(book);

            Console.WriteLine(bookJson);

            // проверка

            book = jsonService.Deserialize(bookJson);

            bookJson = jsonService.Serialize(book);

            Console.WriteLine(bookJson);
        }
    }
}