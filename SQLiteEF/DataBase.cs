namespace SQLiteEF
{
    public class DataBase
    {
        public void Insert(StudentContext context, string firstn, string lastn, int age, int course, int group)
        {
            Student student = new Student()
            {
                FirstName = firstn,
                LastName = lastn,
                Age = age,
                Course = course,
                Group = group
            };
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void UpdatE(StudentContext context, string firstn, string lastn, int age, int course, int group, int id)
        {
            var item = context.Students.Find(id);
            item.FirstName = firstn;
            item.LastName = lastn;
            item.Age = age;
            item.Course = course;
            item.Group = group;
            context.SaveChanges();
        }
        public void Delete(StudentContext context, Student item)
        {
            context.Students.Remove(item);
            context.SaveChanges();
        }
    }
}
