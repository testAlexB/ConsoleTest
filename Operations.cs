using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleTest
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


    }
}
