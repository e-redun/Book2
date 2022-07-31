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
                personFactory.CreatePerson("Толстой", "Лев", "Николаевич")
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

            book.AddBookmark(50, "Наталья и Пьер");

            book.OpenAt(5);
            book.NextPage();

            IJsonService jsonService = new NewtonJsonService();

            string bookJson = jsonService.Serialize(book);

            Console.WriteLine(bookJson);

            // проверка корректности сериализация/десериализации

            book = jsonService.Deserialize(bookJson);

            string bookJson2 = jsonService.Serialize(book);

            if (bookJson == bookJson2)
            {
                Console.WriteLine("Сериализация/десериализация выполняется корректно");
            }
            else
            {
                Console.WriteLine("Сериализация/десериализация выполняется С ОШИБКАМИ");
            }
        }
    }
}