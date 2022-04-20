using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamil","Mammadov","P324",79,false);
            Console.WriteLine(student.sendNameSurname()); ;
            Console.WriteLine(student.sendStudentFields());
            student.havingAccessToTheNextExam();
        }
    }

       public class Student 
    {
        public string name;
        public string surname;
        public string group;
        public int point;
        public bool isGraudated;
        public Student(string Name,string Surname,string Group, int Point, bool IsGraudated )
        {
            name = Name;
            surname = Surname;
            group = Group;
            point = Point;
            isGraudated = IsGraudated;
        }

        public string sendNameSurname()
        {
            return string.Concat("Name: ",name," Surname: ",surname);
        }
        public string isGraudatedMetod()
        {
            if (isGraudated)
                return "is graudated";
            else
                return "is not graudated";

        }

        public string sendStudentFields()
            
        {
            return string.Concat("Name: ", name, " Surname: ", surname," Group: ", group," Point: ", point," IsGraudated: ", isGraudatedMetod());
        }

        public void havingAccessToTheNextExam()
        {
            if (point > 80)
                Console.WriteLine("Have access to the next exam");
            else
                Console.WriteLine("Have not access to the next exam");
        }

    }

    
}
