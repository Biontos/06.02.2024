using Магомедов_Панфилов.Classes;
using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();
        for (int i = 0; i < 1; i++)
        {
            Student stud = new Student();
            stud.InToKeyboard();
            stud.Avg();
            studentList.Add(stud);
        }

        foreach (Student student in studentList)
            student.OutToScreen();
        string fileName = "TextFile1.txt";
        Student.SaveToFile(studentList, fileName);
        Console.WriteLine("Данные сохранены в файле.");
    }
}