using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Address
    {
        private string city;
        private string street;
        public Address(string street,string city)
        {
            this.street = street;
            this.city = city;
        }
        public string DisplayStat()
        {
            return (street + "" + city);
        }
    }
}
