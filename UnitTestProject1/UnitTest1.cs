using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLiteEF;
using System.Linq;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        DataBase db = new DataBase();
        StudentContext context = new StudentContext("Test.db");
        [TestMethod]
        public void ATestMethod1()
        {
            db.Insert(context, "Test", "Test", 999, 999, 999);
            var listDB = context.Students.ToList();
            Student afterInsert = listDB[listDB.Count - 1];
            Assert.AreEqual("Test", afterInsert.FirstName);
            Assert.AreEqual("Test", afterInsert.LastName);
            Assert.AreEqual(999, afterInsert.Age);
            Assert.AreEqual(999, afterInsert.Group);
            Assert.AreEqual(999, afterInsert.Course);
            context.Students.Remove(afterInsert);
            context.SaveChanges();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Student student = new Student { FirstName = "Test", LastName = "Test", Age = 999, Course = 999, Group = 999 };
            context.Students.Add(student);
            context.SaveChanges();
            var listDB = context.Students.ToList();
            Student toDelete = listDB[listDB.Count - 1];
            db.Delete(context, toDelete);
            var listAfterDelete = context.Students.ToList();
            Student afterDelete = listAfterDelete[listAfterDelete.Count - 1];
            Assert.AreNotEqual("Test", afterDelete.FirstName);
            Assert.AreNotEqual("Test", afterDelete.LastName);
            Assert.AreNotEqual(999, afterDelete.Age);
            Assert.AreNotEqual(999, afterDelete.Course);
            Assert.AreNotEqual(999, afterDelete.Group);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var listDB = context.Students.ToList();
            Student toUpdate = listDB[0];
            int id = toUpdate.Id;
            db.UpdatE(context, "Update", "Update", 555, 555, 555, id);
            var listAfterUpdate = context.Students.ToList();
            Student afterUpdate = listAfterUpdate[0];
            Assert.AreEqual("Update", afterUpdate.FirstName);
            Assert.AreEqual("Update", afterUpdate.LastName);
            Assert.AreEqual(555, afterUpdate.Age);
            Assert.AreEqual(555, afterUpdate.Course);
            Assert.AreEqual(555, afterUpdate.Group);
            db.UpdatE(context, "FirstTestFirstName", "FirstTestLastName", 1, 1, 1, id);
        }
    }
}
