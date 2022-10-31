using System.ComponentModel.DataAnnotations;

namespace SchoolOfFineArtsModels
{
    public class CourseEnrollment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
