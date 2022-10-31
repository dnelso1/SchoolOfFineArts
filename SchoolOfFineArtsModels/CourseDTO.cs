using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfFineArtsModels
{
    public class CourseDTO
    {
        /*
        Id = y.Id, 
        Name = y.Name, 
        Abbreviation = y.Abbreviation,
        Department = y.Department, 
        NumCredits = y.NumCredits,
        TeacherId = y.TeacherId,
        TeacherName = y.Teacher.FriendlyName
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Department { get; set; }
        public int NumCredits { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}
