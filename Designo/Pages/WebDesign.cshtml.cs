using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{
	public class WebDesignModel : PageModel
	{
		public IEnumerable<WebDesings> MyWebDesings { get; set; } = null!;

		public PageInfo PageInfo { get; set; } = null!;

		public IEnumerable<OtherPages> OtherPages { get; set; } = null!;

		public WebDesignModel()
		{
			MyWebDesings = new WebDesings[] {
				new WebDesings() {Image="/assets/web-design/desktop/image-express.jpg", Name="EXPRESS" , Description= "A multi-carrier shipping website for ecommerce businesses"},
				new WebDesings() {Image="/assets/web-design/desktop/image-transfer.jpg", Name="TRANSFER" , Description= "Site for low-cost money transfers and sending money within seconds"},
				new WebDesings() {Image="/assets/web-design/desktop/image-photon.jpg", Name="PHOTON" , Description= "A state-of-the-art music player with high-resolution audio and DSP effects"},
				new WebDesings() {Image="/assets/web-design/desktop/image-builder.jpg", Name="BUILDER" , Description= "Connects users with local contractors based on their location "},
				new WebDesings() {Image="/assets/web-design/desktop/image-blogr.jpg", Name="BLOGR" , Description= "	Blogr is a platform for creating an online blog or publication"},
				new WebDesings() {Image="/assets/web-design/desktop/image-camp.jpg", Name="CAMP" , Description= "Get expert training in coding, data, design, and digital marketing"}


			};

			PageInfo = new PageInfo() { Name = "Web Design", Description = "We build websites that serve as powerful marketing tools and bring memorable brand experiences." };


			OtherPages = new OtherPages[]
			{
				new OtherPages(){Name = "APP DESIGN", Image ="/assets/home/desktop/image-app-design.jpg ", Link="/AppDesign"},
				new OtherPages(){Name = "GRAPHIC DESIGN", Image =" /assets/home/desktop/image-graphic-design.jpg", Link="/GraphicDesign"}

			};

		}

		public void OnGet()
		{
		}
	}

	public class WebDesings
	{
		public string Image { get; set; } = null!;
		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;
	}

	public class PageInfo
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
	}


	public class OtherPages
	{
		public string Name { get; set; } = null!;
		public string Image { get; set; } = null!;
		public string Link { get; set; } = null!;
	}

}
