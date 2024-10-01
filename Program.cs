using System;
using System.Collections.Generic;
using Lab_1;

namespace ConsoleTest
{
    class Program
    {
        static void Main()
        {
            List<StudentInfo> students = new List<StudentInfo>();
            students.Add(new StudentInfo { ФИО = "Петров Иван Иванович", НомерГруппы = "Э-30", Оценки = new List<int> { 2, 2, 2 } });
            students.Add(new StudentInfo { ФИО = "Иванов Ваня", НомерГруппы = "П-30", Оценки = new List<int> { 5, 5, 4, 3, 4 } });
            students.Add(new StudentInfo { ФИО = "Кириллова Виктория Сергеевна", НомерГруппы = "П-30", Оценки = new List<int> { 3, 3, 4, 3, 5, 3 } });

            Console.Write("Введите номер группы: ");
            string group = Console.ReadLine();

            List<StudentInfo>  filterStudents = Operations.FindByGroup(students, group);


            Console.ReadKey();
        }
    }
}
