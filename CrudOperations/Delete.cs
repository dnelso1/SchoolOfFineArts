using DbRepositories;

namespace CrudOperations
{
    public class Delete
    {
        public Delete()
        {

        }

        public void RemoveTeacher(int id, TeacherRepo tRepo)
        {
            tRepo.Delete(id);
        }

        public void RemoveStudent(int id, StudentRepo sRepo)
        {
            sRepo.Delete(id);
        }

        public void RemoveCourse(int id, CourseRepo cRepo)
        {
            cRepo.Delete(id);
        }

        public (bool, string) RemoveCourseEnrollment(int sId, string sName, int cId, string cName, CourseEnrollmentRepo ceRepo)
        {
            return ceRepo.Delete(sId, sName, cId, cName);
        }
    }
}
