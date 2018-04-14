using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementSystem.BLL.Interfaces
{
    interface IProjectService
    {
        void AddProject(string name, string abbreviation, string Description, string Effort, string Timeline, string Milestone, DateTime InitialDate);
    }
}
