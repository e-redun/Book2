using CommonLib.Enums;
using CommonLib.Models;
using System;
using System.Collections.Generic;

namespace CommonLib.Services
{
    public class BookService
    {
        public Book CreateBook(string title,
                               List<Person> authors,
                               int volume,
                               DateTime signedForPrint,
                               int pages,
                               FontFamilies fontFamily,
                               Formats format,
                               Organization publisher,
                               Organization tipography,
                               decimal rubPrice
                               )
        {

            return new Book()
            {
                Title = title,
                Authors = authors,
                Volume = volume,
                SignedForPrint = signedForPrint,
                Pages = pages,
                FontFamily = fontFamily,
                Format = format,
                Publisher = publisher,
                Tipography = tipography,
                RubPrice = rubPrice
            };
        }
    }
}