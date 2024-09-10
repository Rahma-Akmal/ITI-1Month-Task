using ITIProject.Models;

namespace ITIProject.Repository
{
    public interface ICourseRepo
    {
        public List<Course> GetAll();
        public Course GetById(int id);
        public void Add(Course crs);
        public void Update(Course crs);
        public void DeleteById(int id);
    }
}
