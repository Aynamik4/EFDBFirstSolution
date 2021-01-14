using EFDBFirstClassLibrary.Models.Entities;
using System;

namespace EFDBFirstClassLibrary
{
    public static class DBLib
    {
        static EFDBFirstContext EFDBFirst = new EFDBFirstContext();

        public static void AddPerson(string firstName, string lastName, int birthYear)
        {
            Person p = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthYear = birthYear
            };

            EFDBFirst.People.Add(p);
            EFDBFirst.SaveChanges();
        }
    }
}
