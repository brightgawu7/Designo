using Designo.Models;

namespace Designo.Services
{
	public interface IProjectService
	{
		public IEnumerable<Project> GetProjects(string pageName);
	}
}
