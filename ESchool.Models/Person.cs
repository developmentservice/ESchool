using System;
using System.Collections.Generic;
using System.Text;

namespace ESchool.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public string Addres { get; set; }
        public string PhoneNumber { get; set; }
        enum Role
        {
            director,
            teacher,
            student,
            parent
        }

    }
}
