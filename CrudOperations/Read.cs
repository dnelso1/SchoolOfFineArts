using DbRepositories;
using SchoolOfFineArtsModels;

namespace CrudOperations
{
    public class Read
    {
        public Read()
        {

        }

        public List<Teacher> DisplayTeachers(TeacherRepo tRepo)
        {
            var tList = tRepo.GetAll();
            return tList;
        }

        public List<Student> DisplayStudents(StudentRepo sRepo)
        {
            var sList = sRepo.GetAll();
            return sList;
        }

        public List<CourseDTO> DisplayCourses(CourseRepo cRepo)
        {
            var cList = cRepo.GetAll();
            return cList;
        }

        public Teacher DisplaySingle(int dataId, TeacherRepo tRepo)
        {
            var t = tRepo.GetSingle(dataId);
            return t;
        }

        public Student DisplaySingle(int dataId, StudentRepo sRepo)
        {
            var s = sRepo.GetSingle(dataId);
            return s;
        }

        public Course DisplaySingle(int dataId, CourseRepo cRepo)
        {
            var c = cRepo.GetSingle(dataId);
            return c;
        }
    }
}
