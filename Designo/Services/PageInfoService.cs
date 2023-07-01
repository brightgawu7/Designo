using System.Text.Json;
using Designo.Models;

namespace Designo.Services
{
	public class PageInfoService:IPageInfoService
	{
		public IWebHostEnvironment WebHostEnvironment { get; } = null!;

		public PageInfoService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}


		private string JsonFileName(string pageName) => Path.Combine(WebHostEnvironment.WebRootPath, "data", pageName, "info.json");


		public PageInfo GetPageInfo(string pageName)
		{
			using var jsonFileReader = File.OpenText(JsonFileName(pageName));
#pragma warning disable CS8603 // Possible null reference return.
			return JsonSerializer.Deserialize<PageInfo>(jsonFileReader.ReadToEnd(),

					new JsonSerializerOptions
					{

						PropertyNameCaseInsensitive = true

					});
#pragma warning restore CS8603 // Possible null reference return.
		}
	}
}
