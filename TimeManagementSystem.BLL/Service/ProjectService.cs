using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagementSystem.BLL.DTO;
using TimeManagementSystem.BLL.Infrastructure;
using TimeManagementSystem.BLL.Interfaces;
using TimeManagementSystem.DAL.Entities;
using TimeManagementSystem.DAL.Interfaces;
using TimeManagementSystem.DAL.Repositories;

namespace TimeManagementSystem.BLL.Service
{
    class ProjectService : IProjectService
    {
        IUnitOfWork Database { get; set; }

        public ProjectService(IUnitOfWork UoW)
        {
            Database = UoW;
        }
        public void AddProject(string name, string abbreviation, string Description, string Effort, string Timeline, string Milestone, DateTime InitialDate)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDTO>()).CreateMapper();
                var ListOfProjects = mapper.Map<IEnumerable<Project>, List<ProjectDTO>>(Database.Projects.GetAll());
                foreach (var item in ListOfProjects)
                {
                    if (item.Name == name) throw new ValidationException("Name must be unique", "Error");
                    if (item.Abbreviation == abbreviation) throw new ValidationException("Abbreviation must be unique", "Error");
                }
                Project project = new Project()
                  { Name = name,
                    Abbreviation = abbreviation,
                    Description = Description,
                    InitialEffort = Effort,
                    InitialTimeline = Timeline,
                    InitialMilestones = Milestone,
                    InitialDate = InitialDate };
                Database.Projects.Create(project);
            }
            catch
            {

            }
        }
    }
}
