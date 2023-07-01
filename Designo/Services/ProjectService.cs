using System.Text.Json;
using Designo.Models;

namespace Designo.Services
{
	public class ProjectService:IProjectService
	{
		public IWebHostEnvironment WebHostEnvironment { get; } = null!;

		public ProjectService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName(string pageName) => Path.Combine(WebHostEnvironment.WebRootPath, "data", pageName, "projects.json");


		public IEnumerable<Project> GetProjects(string pageName)
		{
			using var jsonFileReader = File.OpenText(JsonFileName(pageName));

#pragma warning disable CS8603 // Possible null reference return.
			return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
				
				new JsonSerializerOptions {
				
				PropertyNameCaseInsensitive = true
			
			});
#pragma warning restore CS8603 // Possible null reference return.
		}
	}
}
