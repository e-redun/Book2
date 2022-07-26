using CommonLib.Enums;
using CommonLib.Models;
using System;
using System.Collections.Generic;

namespace CommonLib.Services
{
    public class BookService
    {
        public Book CreateBook(string title,            // Название
                               List<Person> authors,    // Авторы
                               int volume,              // Том
                               DateTime signedForPrint, // Дата отдачи в печать
                               int pages,               // Всего страниц
                               FontFamilies fontFamily, // гарнитура
                               Formats format,          // Формат
                               Organization publisher,  // Издательство
                               Organization tipography, // Типография
                               decimal rubPrice         // цена в рублях
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