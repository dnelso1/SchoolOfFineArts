using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;

namespace DbRepositories
{
    public class CourseRepo
    {
        private DbContextOptionsBuilder _optionsBuilder;

        public CourseRepo(DbContextOptionsBuilder optionsBuilder)
        {
            _optionsBuilder = optionsBuilder;
        }

        public List<CourseDTO> GetAll()
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                return context.Courses.Include(x => x.Teacher).Select(y => new CourseDTO(){Id = y.Id, 
                                                                                Name = y.Name, 
                                                                                Abbreviation = y.Abbreviation,
                                                                                Department = y.Department, 
                                                                                NumCredits = y.NumCredits,
                                                                                TeacherId = y.TeacherId,
                                                                                TeacherName = y.Teacher.FriendlyName}).ToList();
            }
        }

        public Course GetSingle(int dataId)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var c = context.Courses.SingleOrDefault(course => course.Id == dataId);
                return c;
            }
        }

        public void Add(Course c)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                // build an existing course to check if it exists
                var existingCourse = context.Courses.SingleOrDefault(course => course.Name.ToLower() == c.Name.ToLower()
                                                                && course.Abbreviation.ToLower() == c.Abbreviation.ToLower()
                                                                && course.TeacherId == c.TeacherId);
                //var teacher = context.Teachers.SingleOrDefault(t => t.Id == c.TeacherId);

                if (existingCourse is null)
                {
                    //c.Teacher = teacher;
                    context.Courses.Add(c);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Course already exists. Did you mean to update?");
                }
            }
        }

        public void Update(Course c)
        {
            // ensure Course not in database
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var existingCourse = context.Courses.SingleOrDefault(course => course.Id == c.Id);

                if (existingCourse is not null)
                {
                    existingCourse.Name = c.Name;
                    existingCourse.Abbreviation = c.Abbreviation;
                    existingCourse.Department = c.Department;
                    existingCourse.NumCredits = c.NumCredits;
                    existingCourse.TeacherId = c.TeacherId;
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Course not found. Could not update.");
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var d = context.Courses.SingleOrDefault(c => c.Id == id);
                if (d is not null)
                {
                    context.Courses.Remove(d);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Course not found. Could not delete.");
                }
            }
        }
    }
}