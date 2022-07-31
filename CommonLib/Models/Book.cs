using CommonLib.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CommonLib.Models
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book
    {
        #region Свойства

        [JsonProperty("Название")]
        public string Title { get; set; }

        [JsonProperty("Том")]
        public int Volume { get; set; }

        [JsonProperty("Авторы")]
        public List<Person> Authors { get; set; }

        [JsonProperty("Подписано в печать")]
        public DateTime SignedForPrint { get; set; }

        [JsonProperty("Формат")]
        public Formats Format { get; set; }

        [JsonProperty("Гарнитура")]
        public FontFamilies FontFamily { get; set; }

        [JsonProperty("Количество страниц")]
        public int Pages { get; set; }

        [JsonProperty("Издательство")]
        public Organization Publisher { get; set; }

        [JsonProperty("Типография")]
        public Organization Tipography { get; set; }

        [JsonProperty("Цена руб.")]
        public decimal RubPrice { get; set; }

        [JsonProperty("Закладки")]
        public Dictionary<int, string> Bookmarks { get; private set; } = new Dictionary<int, string>();

        [JsonProperty("Состояние открыта/закрыта")]
        public States State { get; private set; }

        [JsonProperty("Текущая страница")]
        public int? CurrentPage { get; private set; }

        #endregion

        #region Методы

        /// <summary>
        /// Открывает книгу на странице
        /// </summary>
        /// <param name="page">Страница</param>
        public void OpenAt(int page)
        {

            if (page > 0 && page < Pages)
            {
                State = States.Open;
                CurrentPage = page;
            }
            else
            {
                Console.WriteLine($"Страницы с номером {page} не существует");
            }
        }

        /// <summary>
        /// Закрывае книгу
        /// </summary>
        public void Close()
        {
            State = States.Closed;
            CurrentPage = null;
        }

        /// <summary>
        /// Делает следующую страницу текущей
        /// </summary>
        public void NextPage()
        {
            if (State == States.Open && CurrentPage < Pages)
            {
                CurrentPage++;
            }
        }

        /// <summary>
        /// Делает предыдущую страницу текущей
        /// </summary>
        public void PrevPage()
        {
            if (State == States.Open && CurrentPage > 1)
            {
                CurrentPage--;
            }
        }

        /// <summary>
        /// Добавляет закладку
        /// </summary>
        /// <param name="note">Пояснение</param>
        /// <param name="page">Страница</param>
        public void AddBookmark(int page, string note)
        {
            try
            {
                Bookmarks.Add(page, note);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Закладка на стр. {page} уже существует");
            }
        }

        /// <summary>
        /// Удаляет закладку на странице
        /// </summary>
        /// <param name="page">Страница</param>
        public void DeleteBookmark(int page)
        {
            try
            {
                Bookmarks.Remove(page);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"На стр. {page} не существует закладки");
            }
        }

        #endregion
    }
}