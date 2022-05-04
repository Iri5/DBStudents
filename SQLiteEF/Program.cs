using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace SQLiteEF
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            StudentContext context = new StudentContext();

            //Student stu = new Student()
            //{
            //    FirstName = "lo",
            //    LastName = "br",
            //    Age = 52,
            //    Course = 64,
            //    Group = 28
            //};
            //context.Students.Add(stu);
            //context.SaveChanges();
            //Student stud = new Student()
            //{
            //    FirstName = "gt",
            //    LastName = "vu",
            //    Age = 5,
            //    Course = 4,
            //    Group = 4

            //};
            //context.Students.Add(stud);
            //context.SaveChanges();
            //Student stude = new Student()
            //{
            //    FirstName = "glmmknht",
            //    LastName = "v'[ihkfu",
            //    Age = 258,
            //    Course = 1245,
            //    Group = 15
            //};
            //context.Students.Add(stude);
            //context.SaveChanges();
            //Student stue = new Student()
            //{
            //    FirstName = "ouiytdrsrdv",
            //    LastName = "v",
            //    Age = 1,
            //    Course = 1,
            //    Group = 1
            //};
            //context.Students.Add(stue);
            //context.SaveChanges();
            //var ctx = new StudentContext();
            //var person = ctx.Students.Find(6);
            //ctx.Students.Remove(person);
            //var person1 = ctx.Students.Find(7);
            //ctx.Students.Remove(person);
            //ctx.Students.Remove(person1);
            //ctx.SaveChanges();
            //ctx.Dispose();

        }
    }
}
