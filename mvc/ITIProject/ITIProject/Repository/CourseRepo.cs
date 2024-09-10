using ITIProject.Data;
using ITIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIProject.Repository
{
    public class CourseRepo : ICourseRepo
    {
        ITIContext context;
        public CourseRepo(ITIContext _context)
        {
            context= _context;
        }
        public void Add(Course crs)
        {
            context.Add(crs);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var crs = context.Courses.FirstOrDefault(a => a.CourseId == id);
            context.Courses.Remove(crs);
            context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return context.Courses.ToList();

        }

        public Course GetById(int id)
        {
            return context.Courses.Include(s=>s.Students).SingleOrDefault(x => x.CourseId == id);
        }

        public void Update(Course crs)
        {
            context.Update(crs);
            context.SaveChanges();
        }
    }
}
