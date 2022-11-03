using DbRepositories;
using SchoolOfFineArtsModels;

namespace CrudOperations
{
    public class Create
    {
        public Create()
        {

        }

        public void AddTeacher(Teacher t, TeacherRepo tRepo)
        {
            tRepo.Add(t);
        }

        public void AddStudent(Student s, StudentRepo sRepo)
        {
            sRepo.Add(s);
        }

        public void AddCourse(Course c, CourseRepo cRepo)
        {
            cRepo.Add(c);
        }

        public (bool, string) AddCourseEnrollment(List<Student> students, int cId, string cName, CourseEnrollmentRepo ceRepo)
        {
            return ceRepo.Add(students, cId, cName, ceRepo);
        }
    }
}
