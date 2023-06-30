using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{

	public class AppDesignModel : PageModel
    {

		public IEnumerable<AWebDesings> MyWebDesings { get; set; } = null!;

		public APageInfo PageInfo { get; set; } = null!;

		public IEnumerable<AOtherPages> OtherPages { get; set; } = null!;


		public void OnGet()
        {
			MyWebDesings = new AWebDesings[] {
				new AWebDesings() {Image=
					"assets/app-design/desktop/image-airfilter.jpg"
					, Name="AIRFILTER" , Description= "Solving the problem of poor indoor air quality by filtering the air"},
				new AWebDesings() {Image=
				"assets/app-design/desktop/image-eyecam.jpg"
				, Name="EYECAM" , Description= "Product that lets you edit your favorite photos and videos at any time"},
				new AWebDesings() {Image=
				"assets/app-design/desktop/image-faceit.jpg"
				, Name="FACEIT" , Description= "Get to meet your favorite internet superstar with the faceit app"},
				new AWebDesings() {Image=
				"assets/app-design/desktop/image-todo.jpg"
				, Name="TODO" , Description= "A todo app that features cloud sync with light and dark mode"},
				new AWebDesings() {Image=
				"assets/app-design/desktop/image-loopstudios.jpg"
				, Name="LOOPSTUDIOS" , Description= "A VR experience app made for Loopstudios"},


			};

			PageInfo = new APageInfo() { Name = "App Design", Description = "Our mobile designs bring intuitive digital solutions\r\n to your customers right at their fingertips." };


			OtherPages = new AOtherPages[]
			{
				new AOtherPages(){Name = "WEB DESIGN", Image ="/assets/home/desktop/image-web-design-small.jpg ", Link="/WebDesign"},
				new AOtherPages(){Name = "GRAPHIC DESIGN", Image =" /assets/home/desktop/image-graphic-design.jpg", Link="/GraphicDesign"}

			};
		}
    }


	public class AWebDesings
	{
		public string Image { get; set; } = null!;
		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;
	}

	public class APageInfo
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
	}


	public class AOtherPages
	{
		public string Name { get; set; } = null!;
		public string Image { get; set; } = null!;
		public string Link { get; set; } = null!;
	}
}
