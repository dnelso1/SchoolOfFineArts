using System.ComponentModel.DataAnnotations;

namespace SchoolOfFineArtsModels
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public virtual List<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();

        public override string ToString()
        {
            return $"{LastName}, {FirstName} (ID: {Id})";
        }
    }
}
