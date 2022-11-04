using DbRepositories;
using SchoolOfFineArtsModels;
using System.ComponentModel;

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

        public List<CoursesInfoDTO> DisplayCoursesInfoDTOs(CourseEnrollmentRepo ceRepo)
        {
            var ceList = ceRepo.GetAll();
            return ceList;
        }

        public Teacher DisplaySingle(int dataId, TeacherRepo tRepo)
        {
            var t = tRepo.GetById(dataId);
            return t;
        }

        public Student DisplaySingle(int dataId, StudentRepo sRepo)
        {
            var s = sRepo.GetById(dataId);
            return s;
        }

        public Course DisplaySingle(int dataId, CourseRepo cRepo)
        {
            var c = cRepo.GetById(dataId);
            return c;
        }

        public CoursesInfoDTO DisplaySingle(int courseId, int studentId, CourseEnrollmentRepo ceRepo)
        {
            var ciDTO = ceRepo.GetById(courseId, studentId);
            return ciDTO;
        }
    }
}
