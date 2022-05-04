using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Data.SQLite;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLiteEF
{
   
    public class Student
{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
    }
}
