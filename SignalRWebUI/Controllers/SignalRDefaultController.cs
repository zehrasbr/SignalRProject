using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Indeyx()
		{
			return View();
		}
	}
}
