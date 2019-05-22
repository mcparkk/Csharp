using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentData
    {
        private static SchoolDBEntities CreateContext()
        {
            SchoolDBEntities context = new SchoolDBEntities();
            context.Database.Log = PrintToConsoleWindow;
            return context;
        }

        public static int GetCount()
        {
            using (var context = CreateContext())
            {
                return context.Students.Count();
            }
        }

        public static List<Student> GetAll()
        {
            using (var context = CreateContext())
            {
                return context.Students.ToList();
            }
        }

        public static Student GetByPK(int studentId)
        {
            using (var context = CreateContext())
            {
                return context.Students.FirstOrDefault(x => x.StudentID == studentId);
            }
        }

        public static void Insert(Student student)
        {
            using (var context = CreateContext())
            {
                //context.Students.Add(student);
                context.Entry(student).State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public static void Update(Student student)
        {
            using (var context = CreateContext())
            {
                context.Entry(student).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Student student)
        {
            using (var context = CreateContext())
            {
                context.Entry(student).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }
    }
}
