using CommonLib.Enums;
using CommonLib.Models;
using System;
using System.Collections.Generic;

namespace CommonLib.Services
{
    public class BookService
    {
        /// <summary>
        /// Создает книгу
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="authors">Список авторов</param>
        /// <param name="volume">Том</param>
        /// <param name="signedForPrint">Дата отдачи в печать</param>
        /// <param name="pages">Всего страниц</param>
        /// <param name="fontFamily">Гарнитура</param>
        /// <param name="format">Формат</param>
        /// <param name="publisher">Издательство</param>
        /// <param name="tipography">Типография</param>
        /// <param name="rubPrice">Цена в рублях</param>
        /// <returns>Книга</returns>
        public Book CreateBook(string title,            // Название
                               List<Person> authors,    // Авторы
                               int volume,              // Том
                               DateTime signedForPrint, // Дата отдачи в печать
                               int pages,               // Всего страниц
                               FontFamilies fontFamily, // Гарнитура
                               Formats format,          // Формат
                               Organization publisher,  // Издательство
                               Organization tipography, // Типография
                               decimal rubPrice         // Цена в рублях
                               )
        {

            return new Book()
            {
                Title = title,                   // Название
                Authors = authors,               // Авторы
                Volume = volume,                 // Том
                SignedForPrint = signedForPrint, // Дата отдачи в печать
                Pages = pages,                   // Всего страниц
                FontFamily = fontFamily,         // гарнитура
                Format = format,                 // Формат
                Publisher = publisher,           // Издательство
                Tipography = tipography,         // Типография
                RubPrice = rubPrice              // цена в рублях
            };
        }
    }
}