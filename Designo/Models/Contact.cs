using System.ComponentModel.DataAnnotations;

namespace Designo.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="Can't be empty")]
		public string Name { get; set; } = null!;


		[Required(ErrorMessage ="Can't be empty")]
		public string Email { get; set; } = null!;

		
		public string? Phone { get; set; }

		
		[Required(ErrorMessage ="Can't be empty")]
		[MinLength(10, ErrorMessage ="Message too short.")]
		public string Message { get; set; } = null!;


	}
}
