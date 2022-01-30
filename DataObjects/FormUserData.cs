using System;
using System.Collections.Generic;

namespace DotNetFramework.DataObjects
{
    class FormUserData
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Subjects { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public enum Hobby
        {
            Sports = 1,
            Reading = 2,
            Music = 3
        }
    }
}
