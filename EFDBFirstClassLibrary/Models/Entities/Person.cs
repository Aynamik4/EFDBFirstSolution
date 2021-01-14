using System;
using System.Collections.Generic;

#nullable disable

namespace EFDBFirstClassLibrary.Models.Entities
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BirthYear { get; set; }
    }
}
