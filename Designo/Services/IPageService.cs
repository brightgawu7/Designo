using Designo.Models;

namespace Designo.Services
{
	public interface IPageService
	{
		public IEnumerable<Page> GetPages(string pageName);

	}
}
