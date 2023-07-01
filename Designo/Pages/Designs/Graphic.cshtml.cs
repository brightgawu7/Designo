using Designo.Models;
using Designo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages.Designs
{
    public class GraphicModel : PageModel
    {
		private readonly IProjectService _projectService;
		private readonly IPageInfoService _pageInfoService;
		private readonly IPageService _pageService;

		public IEnumerable<Project> Projects { get; set; } = null!;
		public PageInfo PageInfo { get; set; } = null!;
		public IEnumerable<Models.Page> Pages { get; set; } = null!;




		public GraphicModel(IProjectService projectService, IPageInfoService pageInfoService, IPageService pageService)
		{
			_projectService = projectService;
			_pageInfoService = pageInfoService;
			_pageService = pageService;
		}


		public void OnGet()
		{
			try
			{
				this.Projects = this._projectService.GetProjects(pageName: "graphicDesign");
				this.PageInfo = this._pageInfoService.GetPageInfo(pageName: "graphicDesign");
				this.Pages = this._pageService.GetPages(pageName: "graphicDesign");

			}
			catch (Exception ex) { }

		}
	}
}
