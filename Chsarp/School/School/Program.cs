using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.StudentName = "thomas";
            //student.StandardId = 1;

            //StudentData.Insert(student);

            Student s13 = StudentData.GetByPK(13);
            s13.StudentName = "Mary";
            s13.StandardId = 2;

            StudentData.Update(s13);

            Console.WriteLine(StudentData.GetCount());
            StudentData.Delete(s13);
            Console.WriteLine(StudentData.GetCount());
        }

        private static void PrintToDebugWindow(string log)
        {
            Debug.WriteLine(log);
        }
    }
}
