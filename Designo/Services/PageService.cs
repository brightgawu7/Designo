using Designo.Models;
using System.Text.Json;

namespace Designo.Services
{
	public class PageService:IPageService
	{
		public IWebHostEnvironment WebHostEnvironment { get; } = null!;

		public PageService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName(string pageName) => Path.Combine(WebHostEnvironment.WebRootPath, "data", pageName, "pages.json");

		public IEnumerable<Page> GetPages(string pageName)
		{
			using var jsonFileReader = File.OpenText(JsonFileName(pageName));

#pragma warning disable CS8603 // Possible null reference return.
			return JsonSerializer.Deserialize<Page[]>(jsonFileReader.ReadToEnd(),

				new JsonSerializerOptions
				{

					PropertyNameCaseInsensitive = true

				});
#pragma warning restore CS8603 // Possible null reference return.
		}

	}
}
