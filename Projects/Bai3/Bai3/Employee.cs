using System;
using System.Collections.Generic;

namespace Bai3
{
   abstract class Employee
    {
        Date date;
        Address address;
        private string name;
        public Employee(string name, int year, int month, int day)
        {
            date = new Date(year, month, day);
            this.name = name;
            address = null;
        }
        ~Employee()
        {
            address = null;
            date = null;
        }
        public void SetAddress(string street, string city)
        {
            address = new Address(street, city);
        }
        public Address Address
        { 
            get { return address; }
            set { address = value; }
        }
        public virtual string DisplayStat()
        {
            return (date.DisplayStat() + address.DisplayStat() + name);
        }
        public abstract double CalcPay()
        {

        }
    }
}
