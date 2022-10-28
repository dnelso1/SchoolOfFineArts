using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;

namespace DbRepositories
{
    public class TeacherRepo
    {
        private DbContextOptionsBuilder _optionsBuilder;

        public TeacherRepo(DbContextOptionsBuilder optionsBuilder)
        {
            _optionsBuilder = optionsBuilder;
        }

        public List<Teacher> GetAll()
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                return context.Teachers.ToList();
            }
        }

        public Teacher GetSingle(int dataId)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var t = context.Teachers.SingleOrDefault(teacher => teacher.Id == dataId);
                return t;
            }
        }

        public void Add(Teacher t)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var existingTeacher = context.Teachers.SingleOrDefault(teacher => teacher.FirstName.ToLower() == t.FirstName.ToLower()
                                                                    && teacher.LastName.ToLower() == t.LastName.ToLower()
                                                                    && teacher.Age == t.Age);

                if (existingTeacher is null)
                {
                    context.Teachers.Add(t);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Teacher already exists. Did you mean to update?");
                }
            }
        }

        public void Update(Teacher t)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var existingTeacher = context.Teachers.SingleOrDefault(teacher => teacher.Id == t.Id);

                if (existingTeacher is not null)
                {
                    existingTeacher.FirstName = t.FirstName;
                    existingTeacher.LastName = t.LastName;
                    existingTeacher.Age = t.Age;
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Teacher not found. Could not update");
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var d = context.Teachers.SingleOrDefault(t => t.Id == id);
                if (d is not null)
                {
                    context.Teachers.Remove(d);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Teacher not found. Could not delete.");
                }
            }
        }
    }
}
