using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
