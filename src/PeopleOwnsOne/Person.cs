using PeopleOwnsOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleOwnsOne
{
    public class Person
    {
        public int Id { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public Address Address{ get; set; }
    }
}
