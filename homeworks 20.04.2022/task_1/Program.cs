using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter admin username: ");
            string username = Console.ReadLine();
            Console.Write("Please enter admin password: ");
            string password = Console.ReadLine();
            Console.Write("Section: ");
            string section = Console.ReadLine();
            bool isSuperAdmin = createSuperAdmin();

            Admin admin = new Admin(username,password,isSuperAdmin,section);

            Console.WriteLine(" \n---  R E S U L T --- ");
            printAdmin(admin);

        }

        public static bool createSuperAdmin()
        {
            Console.Write("Is Super Admin (please neter \"yes\" or \"no\")?: ");
            string isSuperAdmin = Console.ReadLine();
            while (isSuperAdmin.ToLower()!="yes" & isSuperAdmin.ToLower() != "no")
            {
                Console.Write("Please neter \"yes\" or \"no\": ");
                isSuperAdmin = Console.ReadLine();
            }
            if (isSuperAdmin.ToLower() == "yes")
                return true;
            return false;
        }

        public static void printAdmin(Admin admin)
        {
            Console.WriteLine("\n Username: " + admin._username + " \n Password: "+ admin._password + " \n isSuperAdmin: "+ admin.isSuperAdmin+ " \n Section: " + admin.section);
        
        }



        
    }
}
