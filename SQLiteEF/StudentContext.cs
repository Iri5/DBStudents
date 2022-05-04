using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteEF
{
     class StudentContext : DbContext
    {
        public StudentContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = "DBStudents.db",
                ForeignKeys = true
            }.ConnectionString
        }, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        //one dataset prop for each table:
        public DbSet<Student> Students { get; set; }
    }
}

