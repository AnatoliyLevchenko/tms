using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeManagementSystem.BLL.DTO;
using TimeManagementSystem.BLL.Interfaces;
using TimeManagementSystem.Models;

namespace TimeManagementSystem.Controllers
{
    public class ProjectController : Controller
    {
        IProjectService projectService;
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        // GET: Project
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(ProjectViewModel project)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProjectViewModel, ProjectDTO>()).CreateMapper();

            projectService.AddProject(mapper.Map<ProjectViewModel,ProjectDTO>(project));
            return View();
        }
    }
}