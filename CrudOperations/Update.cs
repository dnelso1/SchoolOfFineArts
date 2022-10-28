using DbRepositories;
using SchoolOfFineArtsModels;

namespace CrudOperations
{
    public class Update
    {
        public Update()
        {

        }

        public void EditTeacher(Teacher t, TeacherRepo tRepo)
        {
            tRepo.Update(t);
        }

        public void EditStudent(Student s, StudentRepo sRepo)
        {
            sRepo.Update(s);
        }

        public void EditCourse(Course c, CourseRepo cRepo)
        {
            cRepo.Update(c);
        }
    }
}
