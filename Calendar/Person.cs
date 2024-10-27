using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Person
    {
        public static int Count = 0;
        public int Id { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public DateOnly Birthdate { get; set; }
        public override string  ToString()
        {
            return $"{this.LastName}";
        }
        public Person(string lastName, string middleName, string firstName, DateTime birthDate)
        {
            LastName = lastName ;
            MiddleName = middleName;   
            FirstName = firstName ;
            Birthdate = DateOnly.FromDateTime(birthDate) ;
        }
        public Person() 
        {
            Count++;
            Id = Count;
        }
    }

}
