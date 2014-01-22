using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1.Controllers
{
    public class Person
    {
        public int Id;
        public string LastName;
        public string GivenNames;
        public int Age;
        public string PhotoUrl;

        public Person(int id, string lastName, string givenNames, int age, string photoURL)
        {
            Id = id;
            LastName = lastName;
            GivenNames = givenNames;
            Age = age;
            PhotoUrl = photoURL;
        }

        public string toString()
        {
            return String.Format("{2} {1} ID - {0}, is {3} years old", Id, LastName, GivenNames, Age); 
        }
    }

    public class Grade
    {
        public string Code;
        public string LetterGrade;

        public Grade(string code, string letterGrade)
        {
            Code = code;
            LetterGrade = letterGrade;
        }

        public string toString()
        {
            return String.Format("Course Code: {0}        Grade: {1} \n", Code, LetterGrade);
        }
    }

    public class Transcript
    {
        public Person student;
        public ICollection<Grade> Grades;
        public double GPA;
        public Transcript(Person person)
        {
            student = person;
            this.Grades = new List<Grade>();
            GPA = 0;
        }
    }
}