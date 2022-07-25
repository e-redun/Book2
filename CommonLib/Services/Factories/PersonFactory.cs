using CommonLib.Models;

namespace CommonLib.Services.Factories
{
    public class PersonFactory
    {
        public Person CreatePerson(string firstname, string surname, string patronymic)
        {
            return new Person
            {
                Firstname = firstname,
                Surname = surname,
                Patronymic = patronymic
            };
        }
    }
}
