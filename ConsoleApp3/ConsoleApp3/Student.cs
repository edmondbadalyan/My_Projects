using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {    
          
        static public string academyName = "Academy Top";
        //public static string GetAcademyName() => academyName;
        public static string AcademyName => academyName; 
        public Student (string name,int grade) {
            this.name = name;
            this.grade = grade; 
        }

        public Student() : this("Vasya", 10) { }


        private string name = "";
        public string Name
        {
            get => name;
            set => this.name = value;

        }

        //public string GetName() => name;
        //public void SetName(string name) => this.name = name;

        private int grade;
        public int Grade
        {
            get => grade;
            set => this.grade = value;
        }


        //public int GetGrade() => grade;
        //public void SetGrade(int grade) => this.grade = grade;









    }
}
