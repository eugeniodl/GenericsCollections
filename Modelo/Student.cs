using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(int id, string name,
            string lastname, int age)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
