using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCFirstCode.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string CollegeName { get; set; }

        public string Email { get; set; }

        public int Mobile { get; set; }

        //public string State{ get; set; }

    }

    public class StudentDbcontext : DbContext
         {

        public DbSet<Student> Students { get; set; }
    
          }
  }






