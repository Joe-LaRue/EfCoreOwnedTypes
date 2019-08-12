using System;
using System.Collections.Generic;
using System.Text;


namespace PeopleOwnsOne
{
    public class EmailAddress
    {
        public string Address { get; private set; }


        public EmailAddress(string emailAddress)
        {
            if (!emailAddress.Contains("@"))
            {
                throw new Exception("Invalid email address format!");
            }

            Address = emailAddress;
        }

        public string DomainName { get { return Address.Substring(Address.IndexOf("@") + 1); } }


        public EmailAddress()
        {

        }


    }
}
