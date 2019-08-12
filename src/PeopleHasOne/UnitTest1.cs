using System;
using System.Linq;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace PeopleHasOne
{
    

    public class UnitTest1
    {
        private PeopleDbContext _context;
        private Person _testPerson;

        public UnitTest1()
        {
            _context = new PeopleDbContext();
            //_testPerson = new Person()
            //{
            //    Email = "abc@email.com",
            //    Address = new Address()
            //    {
            //        City = "Boston",
            //        State = "MA",
            //        Zipcode = "12345",
            //        Line1 = "123 main st",
            //        Line2 = "Apt 2"
            //    }
            //};

            //_context.People.Add(_testPerson);
            //_context.SaveChanges();
        }



        [Fact]
        public void Test1()
        {

            var person = _context.People.Include(p => p.Address).FirstOrDefault();
        }
    }
}
