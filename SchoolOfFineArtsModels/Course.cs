﻿using System.ComponentModel.DataAnnotations;

namespace SchoolOfFineArtsModels
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Abbreviation { get; set; }
        [Required, StringLength(50)]
        public string Department { get; set; }
        [Required, StringLength(50)]
        public int NumCredits { get; set; }
        [Required]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();
    }
}
