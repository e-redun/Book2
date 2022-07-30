using CommonLib.Models;

namespace CommonLib.Services.Factories
{
    public class PersonFactory
    {
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
