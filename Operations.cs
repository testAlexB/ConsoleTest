using System.Collections.Generic;

namespace Lab_1
{
    public class Operations
    {
        /// <summary>
        /// Ссылка на подпункт раздела #3
        /// </summary>
        /// <param name="students">Данный параметр отвечает за представление информации обо всех студентах</param>
        /// <param name="group">Здесь содержится поисковый запрос пользователя по номеру группы</param>
        /// <returns>Список студентов группы group</returns>
        static public List<StudentInfo> FindByGroup(List<StudentInfo> students, string group) 
        {
            List<StudentInfo> result = new List<StudentInfo>();

            foreach (StudentInfo student in students)
            {
                if(student.НомерГруппы == group)
                {
                    result.Add(student);
                }
            }

            return result;
        }

        /// <summary>
        /// Функция вычисления среднего балла студента
        /// </summary>
        /// <param name="Оценки">Содержит список целочисленных значений, содержащие оценки по предметам</param>
        /// <returns>Значение среднего балла</returns>
        static public double AverageBall(List<int> Оценки)
        {
            int Сумма = 0;
            foreach (int Балл in Оценки)
            {
                Сумма += Балл;
            }

            return (double)Сумма / (double)Оценки.Count;
        }

        /// <summary>
        /// Функция сравнения двух студентов по среднему баллу
        /// </summary>
        /// <param name="student1">Информация о каком-то студенте из списка</param>
        /// <param name="student2">Информация о другом студенте списка (выбранного в качестве сравнения)</param>
        /// <returns>1 - student1 успешнее student2, 0 - их успех одинаков, -1 - student1 отстаёт от student2</returns>
        static public int CompareStudentsByAvgBall(StudentInfo student1, StudentInfo student2)
        {
            double b1 = AverageBall(student1.Оценки);
            double b2 = AverageBall(student2.Оценки);

            if(b1 > b2) 
            {
                return -1;
            }

            if (b1 == b2) return 0;

            return 1;
        }
    }
}
