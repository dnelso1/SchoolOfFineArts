using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;

namespace DbRepositories
{
    public class StudentRepo
    {
        private DbContextOptionsBuilder _optionsBuilder;

        public StudentRepo(DbContextOptionsBuilder optionsBuilder)
        {
            _optionsBuilder = optionsBuilder;
        }

        public List<Student> GetAll()
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                return context.Students.ToList();
            }
        }

        public Student GetSingle(int dataId)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var s = context.Students.SingleOrDefault(student => student.Id == dataId);
                return s;
            }
        }

        public void Add(Student s)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var existingStudent = context.Students.SingleOrDefault(student => student.FirstName.ToLower() == s.FirstName.ToLower()
                                                                && student.LastName.ToLower() == s.LastName.ToLower()
                                                                && student.DateOfBirth == s.DateOfBirth);

                if (existingStudent is null)
                {
                    context.Students.Add(s);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Student already exists. Did you mean to update?");
                }
            }
        }

        public void Update(Student s)
        {
            // ensure Student not in database
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var existingStudent = context.Students.SingleOrDefault(student => student.Id == s.Id);

                if (existingStudent is not null)
                {
                    existingStudent.FirstName = s.FirstName;
                    existingStudent.LastName = s.LastName;
                    existingStudent.DateOfBirth = s.DateOfBirth;
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Student not found. Could not update.");
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options))
            {
                var d = context.Students.SingleOrDefault(s => s.Id == id);
                if (d is not null)
                {
                    context.Students.Remove(d);
                    context.SaveChanges();
                }
                else
                {
                    //MessageBox.Show("Student not found. Could not delete.");
                }
            }
        }
    }
}