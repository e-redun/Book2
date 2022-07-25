using CommonLib.Models;

namespace CommonLib.Services
{
    /// <summary>
    /// Интерфейс Json-службы 
    /// </summary>
    public interface IJsonService
    {
        /// <summary>
        /// Сериализует книгу Book
        /// </summary>
        /// <param name="book">Книга</param>
        /// <returns>Строка в json-формате</returns>
        string Serialize(object obj);

        /// <summary>
        /// Десериализует json-строку в книгу Book
        /// </summary>
        /// <param name="jsonDataString">Строка в json-формате</param>
        /// <returns>Книга Book</returns>
        Book Deserialize(string jsonDataString);
    }
}