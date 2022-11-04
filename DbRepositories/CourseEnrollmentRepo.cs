using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbRepositories
{
    public class CourseEnrollmentRepo
    {
        private DbContextOptionsBuilder _optionsBuilder;

        public CourseEnrollmentRepo(DbContextOptionsBuilder optionsBuilder)
        {
            _optionsBuilder = optionsBuilder;
        }

        public List<CoursesInfoDTO> GetAll()
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                return context.CoursesInfoDTOs.FromSqlRaw("SELECT * FROM dbo.vwCoursesInfo ORDER BY StudentName, Course").ToList();
            }
        }

        public CoursesInfoDTO GetById(int courseId, int studentId)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var ciDTO = context.CoursesInfoDTOs.FromSqlRaw($"SELECT * FROM dbo.vwCoursesInfo AS ci WHERE ci.CourseId = {courseId} AND ci.StudentId = {studentId}").Single();
                return ciDTO;
            }
        }

        public (bool, string) Insert(List<Student> students, int cId, string cName)
        {
            bool modified = false;
            string msg = string.Empty;
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                //check if Course is valid
                var existingCourse = context.Courses.Include(x => x.CourseEnrollments).SingleOrDefault(t => t.Id == cId);
                if (existingCourse is null)
                {
                    //MessageBox.Show("Course does not exist.");
                    return (false, "Course does not exist.");
                }

                //iterate the Students
                foreach (var s in students)
                {
                    //check if Student is valid
                    var existingStudent = context.Students.Include(x => x.CourseEnrollments).SingleOrDefault(stu => stu.Id == s.Id);
                    if (existingStudent is null)
                    {
                        //MessageBox.Show($"{existingStudent.FriendlyName} does not exist.");
                        msg = $"{existingStudent.FriendlyName} does not exist.";
                        continue;
                    }

                    //iterate through the student's CourseEnrollments
                    var courseExists = false;
                    foreach (var enrollment in existingStudent.CourseEnrollments)
                    {
                        if (enrollment.CourseId == existingCourse.Id)
                        {
                            //MessageBox.Show($"{existingStudent.FriendlyName} is already in {courseName}");
                            msg = $"{existingStudent.FriendlyName} is already in {cName}";
                            courseExists = true;
                            break;
                        }
                    }

                    //if the course exists, continue to the next student
                    if (courseExists)
                    {
                        continue;
                    }

                    //create and add association
                    CourseEnrollment ce = new CourseEnrollment();
                    ce.StudentId = existingStudent.Id;
                    ce.CourseId = existingCourse.Id;
                    //ce.Student = existingStudent;
                    //ce.Course = existingCourse;
                    existingStudent.CourseEnrollments.Add(ce);
                    //existingCourse.CourseEnrollments.Add(ce);

                    modified = true;
                }
                if (modified)
                {
                    //MessageBox.Show($"Successfully added student(s) to {cName}");
                    msg = $"Successfully added student(s) to {cName}";
                    context.SaveChanges();
                    return (true, msg);
                }
            }
            return (false, msg);
        }

        public void Update(CourseEnrollment ce)
        {
            //// ensure Course not in database
            //using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            //{
            //    var existingCourse = context.CoursesInfoDTOs.SingleOrDefault(course => course.Id == ce.Id);

            //    if (existingCourse is not null)
            //    {
            //        existingCourse.Name = ce.Name;
            //        existingCourse.Abbreviation = ce.Abbreviation;
            //        existingCourse.Department = ce.Department;
            //        existingCourse.NumCredits = ce.NumCredits;
            //        existingCourse.TeacherId = ce.TeacherId;
            //        context.SaveChanges();
            //    }
            //    else
            //    {
            //        //MessageBox.Show("Course not found. Could not update.");
            //    }
            //}
        }

        public (bool, string) Delete(int studentId, string studentName, int courseId, string courseName)
        {
            var msg = string.Empty;
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                //var studentName = txtSelectedStudent.Text;
                //var courseName = txtSelectedCourse.Text;

                //check if Course is valid
                var existingCourse = context.Courses.Include(x => x.CourseEnrollments).SingleOrDefault(y => y.Id == courseId);
                if (existingCourse is null)
                {
                    //MessageBox.Show($"{courseName} does not exist.");
                    return (false, courseName);
                }

                //check if Student is valid
                var existingStudent = context.Students.Include(x => x.CourseEnrollments).SingleOrDefault(s => s.Id == studentId);
                if (existingStudent is null)
                {
                    //MessageBox.Show($"{existingStudent.FriendlyName} does not exist.");
                    msg = $"{existingStudent.FriendlyName} does not exist.";
                    return (false, msg);
                }

                //iterate through the student's CourseEnrollments
                var foundEnrollment = new CourseEnrollment();
                foreach (var e in existingStudent.CourseEnrollments)
                {
                    if (e.CourseId == courseId)
                    {
                        foundEnrollment = e;
                        break;
                    }
                }

                //remove association
                foundEnrollment.StudentId = existingStudent.Id;
                foundEnrollment.CourseId = existingCourse.Id;

                if (foundEnrollment.Id > 0 && foundEnrollment.StudentId == studentId && foundEnrollment.CourseId == courseId)
                {
                    existingStudent.CourseEnrollments.Remove(foundEnrollment);
                    context.SaveChanges();
                    //MessageBox.Show($"Successfully removed {existingStudent.FriendlyName} from {courseName}");
                    msg = $"Successfully removed {existingStudent.FriendlyName} from {courseName}.";
                    return (true, msg);
                }

                msg = $"Could not remove {existingStudent.FriendlyName} from {courseName}.";
            }
            return (false, msg);
        }
    }
}
