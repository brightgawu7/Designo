using Designo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{
	public class ContactModel : PageModel
	{
		[BindProperty]
		public Contact Contact { get; set; } = null!;
		public void OnGet()
		{

		}
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				if (ModelState["Contact.Name"]?.Errors.Count > 0)
				{
					ViewData["InvalidName"] = true;
				}

				if (ModelState["Contact.Email"]?.Errors.Count > 0)
				{
					ViewData["InvalidEmail"] = true;
				}

				if (ModelState["Contact.Message"]?.Errors.Count > 0)
				{
					ViewData["InvalidMessage"] = true;
				}
				TempData["error"] = "The provided details are invalid or incorrect.";

				return Page();

			}
			
			
			TempData["success"] = "Email has been sent. We will be in touch with you shortly.";
			return RedirectToPage("/Index");

		}
	}
}
