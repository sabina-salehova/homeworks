using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = createGroup();
            string answerForExit = "no", answerForAddStudent, answerForLimit;

            while (answerForExit.ToLower().Trim() != "yes")
            {
                if (answerForExit.ToLower().Trim() != "yes")
                {
                    do
                    {
                        Console.Write("\nDo you want to add a student to the group? (please enter \"yes\" or \"no\"): ");
                        answerForAddStudent = checkYesOrNoAnswer(Console.ReadLine());
                        if (group.getStudent().Length >= group.limit & answerForAddStudent.ToLower().Trim() == "yes")
                        {
                            Console.WriteLine(" --- The group is full to the maximum or limit of students in the group is zero.");
                            break;
                        }
                        if (answerForAddStudent.ToLower().Trim() == "yes")
                        {
                            Console.Write("Please enter name of student: ");
                            string name = Console.ReadLine();
                            Console.Write("Please enter surname of student: ");
                            string surname = Console.ReadLine();
                            Student student = new Student(name, surname);
                            group.addStudent(student);
                        }

                    } while (answerForAddStudent.ToLower().Trim() == "yes");

                    do
                    {
                        Console.Write("\nDo you want to increase the group student limit? (please enter \"yes\" or \"no\"): ");
                        answerForLimit = checkYesOrNoAnswer(Console.ReadLine());
                        int newLimit;
                        if (answerForLimit.ToLower().Trim() != "no")
                        {
                            Console.Write($" --- Currently the limit is {group.limit}, enter a new value: ");
                            newLimit = checkIntegerNumber(Console.ReadLine());
                            if (newLimit <= group.limit)
                            {
                                Console.WriteLine(" --- not correct limit value");

                            }
                            else
                            {
                                group.limit = newLimit;
                                break;
                            }

                        }

                    } while (answerForLimit.ToLower().Trim() != "no");
                }
                Console.Write("\nDo you want to exit the program? (please enter \"yes\" or \"no\"): ");
                answerForExit = checkYesOrNoAnswer(Console.ReadLine());
            };

            Console.WriteLine("\n ----- R E S U L T ----- \n");
            printStudentArray(group);
        }

        public static Group createGroup()
        {
            Console.Write("Please enter group no: ");
            string no = Console.ReadLine();
            Console.Write("Please enter limit of students in group: ");
            int limit = checkIntegerNumber(Console.ReadLine());
            Group group = new Group(no, limit);
            return group;
        }

        public static void printStudentArray(Group group)
        {
            Console.WriteLine($" Name of group: {group.no}");
            Console.WriteLine($" Limit student of group: {group.limit}");
            Student[] arr = group.getStudent();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($" Student {(i + 1)}: {arr[i].name} {arr[i].surname}");
            }
            if (arr.Length == 0 || arr == null)
            {
                Console.Write(" No students have been added to the group yet. \n");
            }
        }

        public static string checkYesOrNoAnswer(string str)
        {
            while (str.ToLower() != "yes" & str.ToLower() != "no")
            {
                Console.Write("Please enter \"yes\" or \"no\": ");
                str = Console.ReadLine();
            }
            return str;
        }

        public static int checkIntegerNumber(string str)
        {
            int number;
            while (!int.TryParse(str, out number))
            {
                Console.Write("Please enter correct integer number: ");
                str = Console.ReadLine();
            }

            return Convert.ToInt32(number);
        
        }


    }
}
