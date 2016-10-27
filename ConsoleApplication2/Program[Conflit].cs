using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    public class Teacher
    {
        public int Matricule;
        public String Firstname;
        public String Lastname; 
        public Teacher(String Firstname, String Lastname, int Matricule)
        {
            this.Matricule = Matricule;
            this.Firstname = Firstname;
            this.Lastname = Lastname;

        }
        public String DisplayName()
        {
            return (Firstname + " " + Lastname);
        }
        public int DisplayMatricule()
        {
            return (Matricule);
        }
    }
    public class Student
    {

        public String Firstname;
        public String Lastname;
        public int Matricule;

        public Student(String Firstname, String Lastname, int Matricule)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Matricule = Matricule;

        }
        public String DisplayName()
        {
            return (Firstname + " " + Lastname);
        }
        public int DisplayMatricule()
        {
            return (Matricule);
        }
    }

    public class Shell
    {
        public Shell()
        {

        }


        public int Home()
        {
            Console.WriteLine("\n ***************************" +
                              "\n            MENU7" +
                              "\n ***************************" +
                              "\n " +
                                 "\n 1.   Add a new teacher" +
                                 "\n " +
                                 "\n 2.   Add a new student" +
                                 "\n " +
                                 "\n 3.   Show teacher's list" +
                                 "\n " +
                                 "\n 4.   Show student's list" +
                                 "\n " +
                                 "\n 5.   Show/modify info of a teacher" +
                                 "\n " +
                                 "\n 6.   Show/modify info of a student" +
                                 "\n "


                                 );

            int userentry;
            userentry = int.Parse(Console.ReadLine());
            return userentry;
            


        }

        public string[] CreateTeacher()
        {

            string userentry1;
            string userentry2;
            string userentry3;

            Console.WriteLine("\n   -- New teacher --");

            Console.WriteLine("\n Name :");
            userentry1 = Console.ReadLine();
            Console.WriteLine("\n Surname:");
            userentry2 = Console.ReadLine();
            Console.WriteLine("\n Matricule:");
            userentry3 = Console.ReadLine();
            string[] userentry = { userentry1,userentry2, userentry3 };
            return userentry;
        }

        public string[] CreateStudent()
        {

            string userentry1;
            string userentry2;
            string userentry3;

            Console.WriteLine("\n   -- New student --");

            Console.WriteLine("\n Name :");
            userentry1 = Console.ReadLine();
            Console.WriteLine("\n Surname:");
            userentry2 = Console.ReadLine();
            Console.WriteLine("\n Matricule:");
            userentry3 = Console.ReadLine();
            string[] userentry = { userentry1, userentry2,userentry3};
            return userentry;
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            string[] userentry;
            Shell shell = new Shell();

            int caseSwitch = 0;
            int matricule = 0;
            var student_list = new List<Student>();
            var teacher_list = new List<Teacher>();

            //caseSwitch = shell.Home();
            for (;;) //infinite loop  (not the campus)
                
                switch (caseSwitch)
                {   

                    case 0:
                        Console.Clear();
                        caseSwitch = shell.Home();
                        Console.Clear();
                        break;
                    case 1: //create teacher 

                        userentry = shell.CreateTeacher();
                        teacher_list.Add(new Teacher(userentry[0], userentry[1], int.Parse(userentry[2])));
                        Console.WriteLine("Teacher List.. : ");
                        
                        goto case 0;
                    case 2: //create student
                        userentry = shell.CreateStudent();
                        student_list.Add(new Student(userentry[0], userentry[1], int.Parse(userentry[2])));
                        Console.WriteLine("Student List.. : " );
                        
                        goto case 0;

                    case 3:
                        Console.WriteLine("\n   -- Teacher's list -- \n");
                        foreach (var teacher in teacher_list)
                        {
                            Console.WriteLine("- "  + teacher.DisplayName() +"\n");
                        }
                        Console.WriteLine("\n \n \n Press any key to go back to Menu");
                        Console.ReadKey();
                        goto case 0;
                    case 4:
                        Console.WriteLine("\n   -- Student's list -- \n");
                        foreach (var student in student_list)
                        {
                            Console.WriteLine("- " + student.DisplayName() + "\n");
                        }
                        Console.WriteLine("\n \n \n Press any key to go back to Menu");
                        Console.ReadKey();
                        goto case 0;

                    case 5: //choose teacher
                        Console.WriteLine("\n   -- Teacher's list -- \n");
                        foreach (var teacher in teacher_list)
                        {
                            Console.WriteLine("- " + teacher.DisplayName() + "  " + teacher.DisplayMatricule() + "\n");
                        }
                        Console.WriteLine("\n \n \n Enter a number of matricule: ");
                        matricule = int.Parse(Console.ReadLine());
                        goto case 100;

                    case 6: // choose student
                        Console.WriteLine("\n   -- Student's list -- \n");
                        foreach (var student in student_list)
                        {
                            Console.WriteLine("- " + student.DisplayName() + "  " + student.DisplayMatricule() + "\n");
                        }
                        Console.WriteLine("\n \n \n Enter a number of matricule: ");
                        matricule = int.Parse(Console.ReadLine());
                        goto case 101;

                    case 100: //show teacher by matricule
                        Console.Clear();
                        foreach (var teacher in teacher_list)
                        {
                            if (teacher.DisplayMatricule() == matricule)
                            {
                                Console.WriteLine("\n   -- " + teacher.DisplayName()+ " -- \n");
                            }
                        }
                        Console.WriteLine("\n \n \n Press any key to go back to Menu");
                        Console.ReadKey();
                        goto case 0;

                    case 101: //show student by matricule
                        Console.Clear();
                        foreach (var student in student_list)
                        {
                            if (student.DisplayMatricule() == matricule)
                            {
                                Console.WriteLine("\n   -- " + student.DisplayName() + " -- \n");
                            }
                        }
                        Console.WriteLine("\n \n \n Press any key to go back to Menu");
                        Console.ReadKey();
                        goto case 0;


                }




            


 



            //Console.WriteLine("Name :  " + userentry1);
            Console.ReadKey();


        }
    }
}
