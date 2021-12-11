using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniHackStart.Models
{   
    public class MyTeacher
    {
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FacultyName { get; set; }
    }
    public class TeacherModel
    {


        public string FacultyName { get; set; }

        public List<MyTeacher>  MyTeacherList {get;set;}
    }
}
