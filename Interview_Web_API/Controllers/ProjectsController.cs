using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Interview_Web_API.Models;
using Interview_Web_API.Services;
using Interview_Web_API.Database;
using System.Security.Principal;

namespace Interview_Web_API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsService _projectsService;
        private readonly UsersService _usersService;



        public ProjectsController(ProjectsService projectsService, UsersService usersService)
        {
            _projectsService = projectsService;
            _usersService = usersService;
        }



        [HttpPost("{projectId}/users")]
        public IActionResult AddUserToProject(int projectId, [FromBody] User user)
        {
            var project = _projectsService.GetProjectById(projectId);

            if (project == null)
            {
                return NotFound();
            }

            _usersService.AddUser(user);
            return StatusCode(201);
        }

        [HttpGet("{projectId}/users")]
        public IActionResult GetUsersByProjectId(int projectId)
        {
            var project = _projectsService.GetProjectById(projectId);

            if (project == null)
            {
                return NotFound();
            }

            var users = _usersService.GetUsersByProjectId(projectId);

            return Ok(users);
        }

        [HttpDelete("{projectId}")]
        public IActionResult DeleteProject(int projectId)
        {
            var project = _projectsService.GetProjectById(projectId);

            if (project == null)
            {
                return NotFound();
            }

            _usersService.DeleteUsersByProjectId(projectId);
            _projectsService.DeleteProjectById(projectId);

            return NoContent();
        }


    }


}
