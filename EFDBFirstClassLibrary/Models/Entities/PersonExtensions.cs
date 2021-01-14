using System;
using System.Collections.Generic;
using System.Text;

namespace EFDBFirstClassLibrary.Models.Entities
{
    public partial class Person
    {
        public int? Age
        {
            get => DateTime.Now.Year - BirthYear;
        }
    }
}
