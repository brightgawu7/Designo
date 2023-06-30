using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{
    public class GraphicDesignModel : PageModel
    {

		public IEnumerable<GWebDesings> MyWebDesings { get; set; } = null!;

		public GPageInfo PageInfo { get; set; } = null!;

		public IEnumerable<GOtherPages> OtherPages { get; set; } = null!;
		public void OnGet()
        {
			MyWebDesings = new GWebDesings[] {
				new GWebDesings() {Image=
		
							"assets/graphic-design/desktop/image-change.jpg"
					, Name="TIM BROWN" , Description= "Solving the problem of poor indoor air quality by filtering the air"},
				new GWebDesings() {Image=
						"assets/graphic-design/desktop/image-boxed-water.jpg"
				, Name="BOXED WATER" , Description= "Product that lets you edit your favorite photos and videos at any time"},
				new GWebDesings() {Image=
					"assets/graphic-design/desktop/image-science.jpg"
				, Name="SCIENCE!" , Description= "Get to meet your favorite internet superstar with the faceit app"},
		

			};

			PageInfo = new GPageInfo() { Name = "Graphic Design", Description = "We deliver eye-catching branding materials that are \r\ntailored to meet your business objectives.\r\n" };


			OtherPages = new GOtherPages[]
			{
				new GOtherPages(){Name = "APP DESIGN", Image =" /assets/home/desktop/image-app-design.jpg" , Link="/AppDesign"},

				new GOtherPages(){Name = "WEB DESIGN", Image ="/assets/home/desktop/image-web-design-small.jpg ", Link="/WebDesign"},
	

			};
		}
    }


	public class GWebDesings
	{
		public string Image { get; set; } = null!;
		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;
	}

	public class GPageInfo
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
	}


	public class GOtherPages
	{
		public string Name { get; set; } = null!;
		public string Image { get; set; } = null!;
		public string Link { get; set; } = null!;
	}
}
