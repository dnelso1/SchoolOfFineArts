using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;

namespace GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContextOptionsBuilder _optionsBuilder;
        private SchoolOfFineArtsDbContext _context = null;
        private DbSet<T> table = null;  //this is like the DbSet of students, teachers, courses, etc

        public GenericRepository()
        {
            this._context = new SchoolOfFineArtsDbContext();
            table = _context.Set<T>();
        }

        //passes in the context that is made before calling this method
        public GenericRepository(SchoolOfFineArtsDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }


        //passes in the options builder, then builds the context
        public GenericRepository(DbContextOptionsBuilder optionsBuilder)
        {
            _optionsBuilder = optionsBuilder;
            _context = new SchoolOfFineArtsDbContext(_optionsBuilder.Options);
            //this._context = new SchoolOfFineArtsDbContext();
            table = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            using (_context)
            {
                if (table is DbSet<CourseEnrollment>)
                {
                    table = CoursesInfoDTOs;
                    return table.FromSqlRaw("SELECT * FROM dbo.vwCoursesInfo ORDER BY StudentName, Course").ToList();
                }
                else if (table is DbSet<Course>)
                {
                    return table.Include(x => x.Teacher).Select(y => new CourseDTO(){Id = y.Id,
                                                                                                Name = y.Name,
                                                                                                Abbreviation = y.Abbreviation,
                                                                                                Department = y.Department,
                                                                                                NumCredits = y.NumCredits,
                                                                                                TeacherId = y.TeacherId,
                                                                                                TeacherName = y.Teacher.FriendlyName}).ToList();
                }
                return table.ToList();
            }
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
