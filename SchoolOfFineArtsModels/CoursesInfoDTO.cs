using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfFineArtsModels
{
    public class CoursesInfoDTO
    {
        /*
         SELECT ce.CourseId, 
            CONCAT(c.Abbreviation, ' - ', c.Name) as Course, 
            c.Department, 
            c.TeacherId, 
            CONCAT(t.LastName, ', ', t.FirstName) as TeacherName, 
            ce.StudentId, 
            CONCAT(s.LastName, ', ', s.FirstName) as StudentName, 
            
            FROM CourseEnrollment ce
            JOIN Courses c ON c.Id = ce.CourseId
            JOIN Students s ON s.Id = ce.StudentId
            JOIN Teachers t ON c.TeacherId = t.Id
         */
        public int CourseId { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
