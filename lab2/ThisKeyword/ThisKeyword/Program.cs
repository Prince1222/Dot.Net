using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class Student
    {
        public int id, age;
        public string name, address, subject;
        public Student(int id, string name, string address, string subject, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.subject = subject;
            this.age = age;

        }
        public void showinfo()
        {
            Console.WriteLine(id + "" + name + "" + address + "" + subject + "" + age);
        }
    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Student s = new Student(01, "\t" + "Anik Maharjan", "Balaju", "English", 21);
            Student s2 = new Student(02, "\t" + "Pradeep Shrestha", "Kavresthali", "DotNet", 23);
            s.showinfo();
            s2.showinfo();
            Console.ReadKey();
        }
    }

}