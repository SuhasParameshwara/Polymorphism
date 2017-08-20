using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStudent
{
    interface Person
    {
        void getGradeStudent(char grade);
        void getDescriptionStudent(string name, string email, char grade);
        void getSubject(string name, string sub);
        void getDescriptionLecturer(string name, string sub);
        void getDeparment(string name, string dept);
        void getDescriptionEmployee(string name, string dept);
    }
    class Student : Person
    {
        public string name;
        public string email;
        public char grade;
        public Student(string name, string email, char grade)
        {
            this.name = name;
            this.email = email;
            this.grade = grade;
        }

        public void getGradeStudent(char grade)
        {
            Console.WriteLine("\nGrade: " + grade);
        }

        public void getDescriptionStudent(string name, string email, char grade)
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nEmail: " + email);
            getGradeStudent(grade);
        }

        public void getSubject(string name, string sub) { }
        public void getDescriptionLecturer(string name, string sub) { }

        public void getDeparment(string name, string dept)
        {
            throw new NotImplementedException();
        }

        public void getDescriptionEmployee(string name, string dept) { }
    }
    class Lecturer : Person
    {
        public string name;
        public string email;
        public string sub;

        public Lecturer(string name, string sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void getDescriptionLecturer(string name, string sub)
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nSubject : " + sub);
            getSubject(name,sub);
        }
        public void getSubject(string name, string sub)
        {
            Console.WriteLine("{0} teaches {1}", name, sub);
        }
        public void getDescriptionStudent(string name, string email, char grade) { }

        public void getGradeStudent(char grade) { }

        public void getDeparment(string name, string dept) { }
        public void getDescriptionEmployee(string name, string dept) { }
    }
    class Employee : Person
    {
        public string dept;
        public string name;

        public Employee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }

        public void getDeparment(string name, string dept)
        {
            Console.WriteLine("{0} belongs to {1} department.", name, dept);
        }

        public void getDescriptionEmployee(string name, string dept)
        {

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nDepartment : " + dept);
            getDeparment(name, dept);
        }

        public void getDescriptionLecturer(string name, string sub) { }
        public void getDescriptionStudent(string name, string email, char grade) { }
        public void getGradeStudent(char grade) { }
        public void getSubject(string name, string sub) { }
    }
    class PersonViewer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            char ch = ' ';
            try
            {
                string name = null;
                Console.WriteLine("------------------STUDENT REGISTRATION SYSTEM-----------------------\n");
                Console.WriteLine("\nEnter the number of students to register: \n");
                int size = int.Parse(Console.ReadLine());
                Student[] objStudent = new Student[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nEnter the student {0} details\n", i + 1);
                    Console.WriteLine("\nEnter the name:\n");
                    name = Console.ReadLine();
                    Console.WriteLine("\nEnter the email-id:\n");
                    string email = Console.ReadLine();
                    Console.WriteLine("\nEnter the grade:\n");
                    char grade = char.Parse(Console.ReadLine());
                    objStudent[i] = new Student(name, email, grade);
                    Console.WriteLine("------------------------------------------------------------------");
                }
                Console.WriteLine("\n------------------LECTURER REGISTRATION SYSTEM-----------------------\n");
                Console.WriteLine("\nEnter the number of lecturer to register: \n");
                size = int.Parse(Console.ReadLine());
                Lecturer[] objLecturer = new Lecturer[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nEnter the lecturer {0} details\n", i + 1);
                    Console.WriteLine("\nEnter the name:\n");
                    name = Console.ReadLine();
                    Console.WriteLine("\nEnter the subject you teach :\n");
                    string sub = Console.ReadLine();
                    objLecturer[i] = new Lecturer(name, sub);
                    Console.WriteLine("\n------------------------------------------------------------------");
                }
                Console.WriteLine("\n------------------EMPLOYEE REGISTRATION SYSTEM-----------------------\n");
                Console.WriteLine("\nEnter the number of employee to register: \n");
                size = int.Parse(Console.ReadLine());
                Employee[] objEmployee = new Employee[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nEnter the employee {0} details\n", i + 1);
                    Console.WriteLine("\nEnter the name:\n");
                    name = Console.ReadLine();
                    Console.WriteLine("\nEnter the department you work :\n");
                    string dept = Console.ReadLine();
                    objEmployee[i] = new Employee(name, dept);
                    Console.WriteLine("\n------------------------------------------------------------------");
                }
                Console.WriteLine("\n--------------------------STUDENT DATABSE----------------------------\n");
                do
                {
                    Console.WriteLine("\nEnter the student name to be searched: \n");
                    name = Console.ReadLine();
                    int index = -1;
                    for (int i = 0; i < size; i++)
                    {
                        if (objStudent[i].name.Equals(name))
                        {
                            index = i;

                        }
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("\nSorry invalid name!");
                    }
                    else
                    {
                        objStudent[index].getDescriptionStudent(objStudent[index].name, objStudent[index].email, objStudent[index].grade);
                    }
                    Console.WriteLine("\nDo you want to continue the search? (Y/N)\n");
                    ch = char.Parse(Console.ReadLine());
                } while (ch != 'n' && ch != 'N');
                Console.WriteLine("\n--------------------------LECTURER DATABSE----------------------------\n");
                do
                {
                    Console.WriteLine("\nEnter the lecture name to be searched: \n");
                    name = Console.ReadLine();
                    int index = -1;
                    for (int i = 0; i < size; i++)
                    {
                        if (objLecturer[i].name.Equals(name))
                        {
                            index = i;

                        }
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("\nSorry invalid name!");
                    }
                    else
                    {
                        objLecturer[index].getDescriptionLecturer(objLecturer[index].name, objLecturer[index].sub);
                    }
                    Console.WriteLine("\nDo you want to continue the search? (Y/N)\n");
                    ch = char.Parse(Console.ReadLine());
                } while (ch != 'n' && ch != 'N');
                Console.WriteLine("\n--------------------------EMPLOYEE DATABSE----------------------------\n");
                do
                {
                    Console.WriteLine("\nEnter the employee name to be searched: \n");
                    name = Console.ReadLine();
                    int index = -1;
                    for (int i = 0; i < size; i++)
                    {
                        if (objEmployee[i].name.Equals(name))
                        {
                            index = i;

                        }
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("\nSorry invalid name!");
                    }
                    else
                    {
                        objEmployee[index].getDescriptionEmployee(objEmployee[index].name, objEmployee[index].dept);
                    }
                    Console.WriteLine("\nDo you want to continue the search? (Y/N)\n");
                    ch = char.Parse(Console.ReadLine());
                } while (ch != 'n' && ch != 'N');
            }
            catch (Exception e)
            {
                Console.WriteLine("\nInvalid Format!");
            }
            Console.ReadLine();
        }
    }
}
