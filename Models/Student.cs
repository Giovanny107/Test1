using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Student
    {
        public string Name { get; set; }

        public int Language { get; set; }

        public int Science { get; set; }

        public int Social { get; set; }

        public int Maths { get; set; }

        public List<Student> Students;

        public Student()
        {
            Students = new List<Student>
            {
                new Student { Name = "Anna Taylor", Language = 90, Science = 85, Social = 86, Maths = 89},
                new Student { Name = "Mark Smith", Language = 82, Science = 75, Social = 89, Maths = 86},
                new Student { Name = "John Doe", Language = 89, Science = 76, Social = 94, Maths = 82},
                new Student { Name = "Jack Jones", Language = 93, Science = 73, Social = 97, Maths = 90},
                new Student { Name = "Melody Queens", Language = 87, Science = 89, Social = 80, Maths = 83},
                new Student { Name = "Noah Menac", Language = 86, Science = 90, Social = 83, Maths = 85}
            };
        }
    }
}
