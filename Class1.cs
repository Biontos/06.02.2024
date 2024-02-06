using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Магомедов_Панфилов.Classes
{
    internal class Student
    {
        private string firstname;
        private string lastname;
        private string middlename;
        private string group;
        private double math;
        private double eng;
        private double rus;
        private double chem;
        private double ecol;
        private double avgscore;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public double Math
        {
            get { return math; }
            set { math = value; }
        }

        public double Eng
        {
            get { return eng; }
            set { eng = value; }
        }

        public double Rus
        {
            get { return rus; }
            set { rus = value; }
        }

        public double Chem
        {
            get { return chem; }
            set { chem = value; }
        }

        public double Ecol
        {
            get { return ecol; }
            set { ecol = value; }
        }

        public double AvgScore
        {
            get { return avgscore; }
            set { avgscore = value; }
        }

        public Student()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
            Middlename = string.Empty;
            Group = string.Empty;
            Math = 0;
            Eng = 0;
            Rus = 0;
            Chem = 0;
            Ecol = 0;
            AvgScore = 1;
        }

        public void InToKeyboard()
        {
            Console.WriteLine("Имя");
            Firstname = Console.ReadLine();
            Console.WriteLine("Фамилия");
            Lastname = Console.ReadLine();
            Console.WriteLine("Отчество");
            Middlename = Console.ReadLine();
            Console.WriteLine("Группа");
            Group = Console.ReadLine();
            Console.WriteLine("Математика");
            Math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Английский");
            Eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Русский");
            Rus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Химия");
            Chem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Экология");
            Ecol = Convert.ToDouble(Console.ReadLine());
        }

        public void Avg()
        {
            AvgScore = (Math + Eng + Rus + Chem + Ecol) / 5.0;
        }

        public void OutToScreen()
        {
            Console.WriteLine($"Имя: {Firstname}");
            Console.WriteLine($"Фамилия: {Lastname}");
            Console.WriteLine($"Фамилия: {Lastname}");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"Математика: {Math}");
            Console.WriteLine($"Английский: {Eng}");
            Console.WriteLine($"Русский: {Rus}");
            Console.WriteLine($"Химия: {Chem}");
            Console.WriteLine($"Экология: {Ecol}");
            Console.WriteLine($"Средний балл: {AvgScore.ToString("0.000")}");
            Console.WriteLine("                                 ");
        }
        public static void SaveToFile(List<Student> students, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine(student.Firstname);
                    writer.WriteLine(student.Lastname);
                    writer.WriteLine(student.Middlename);
                    writer.WriteLine(student.Group);
                    writer.WriteLine(student.Math);
                    writer.WriteLine(student.Eng);
                    writer.WriteLine(student.Rus);
                    writer.WriteLine(student.Chem);
                    writer.WriteLine(student.Ecol);
                    writer.WriteLine(student.AvgScore.ToString("0.000"));
                }
                writer.Flush();
            }
        }
    }
}
