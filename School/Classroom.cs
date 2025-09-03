using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252.School
{
    internal class Classroom
    {
        private List<Student> students;
        private string name;

        public string Name { get { return name; } }

        public Classroom(string name)
        {
            students = new List<Student>();
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public int PassedStudents()
        {
            int count = 0;
            foreach (Student s in students)
            {
                if(s.GetAverage() >= 13)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
