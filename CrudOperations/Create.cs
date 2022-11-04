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
            tRepo.Insert(t);
        }

        public void AddStudent(Student s, StudentRepo sRepo)
        {
            sRepo.Insert(s);
        }

        public void AddCourse(Course c, CourseRepo cRepo)
        {
            cRepo.Insert(c);
        }

        public (bool, string) AddCourseEnrollment(List<Student> students, int cId, string cName, CourseEnrollmentRepo ceRepo)
        {
            return ceRepo.Insert(students, cId, cName, ceRepo);
        }
    }
}
