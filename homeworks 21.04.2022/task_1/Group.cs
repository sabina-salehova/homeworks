using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Group
    {
        public string no;
        public int limit = 0;
        Student[] studentArray = new Student[0];

        public Group(string No, int Limit)
        {
            no = No;
            limit = Limit;
        }
        public void addStudent(Student student)
        {
            if (limit > 0)
            {
                if (studentArray.Length < limit)
                {
                    Array.Resize(ref studentArray, studentArray.Length + 1);
                    studentArray[studentArray.Length - 1] = student;
                }
                else
                    Console.WriteLine("The group is full to the maximum.");
            }
            else
                Console.WriteLine("Limit of students in the group is zero.");

        }

        public Student[] getStudent()
        {
            return studentArray;
        }
    }
}
