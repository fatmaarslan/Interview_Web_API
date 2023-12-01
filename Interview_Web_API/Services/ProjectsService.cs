using Interview_Web_API.Database;
using Interview_Web_API.Models;

namespace Interview_Web_API.Services
{
    public class ProjectsService
    {
        private readonly DataContext _context;

        public ProjectsService(DataContext context)
        {
            _context = context;
        }

        public Project GetProjectById(int projectId)
        {
            return _context.Projects.FirstOrDefault(p => p.id == projectId);
        }

        public void DeleteProjectById(int projectId)
        {
            var projectToDelete = _context.Projects.FirstOrDefault(p => p.id == projectId);

            if (projectToDelete != null)
            {
                _context.Projects.Remove(projectToDelete);
                _context.SaveChanges();
            }
        }
    }

}
