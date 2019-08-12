using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleHasOne
{
    public class Person
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Address Address{ get; set; }
    }
}
