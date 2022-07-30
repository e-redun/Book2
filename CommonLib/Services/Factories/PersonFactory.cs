using CommonLib.Models;

namespace CommonLib.Services.Factories
{
    public class PersonFactory
    {
        /// <summary>
        /// Создает экземпляр Person
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="firstname">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns>Экземпляр Person</returns>
        public Person CreatePerson(string surname, string firstname, string patronymic)
        {
            return new Person
            {
                Surname = surname,
                Firstname = firstname,
                Patronymic = patronymic
            };
        }
    }
}
