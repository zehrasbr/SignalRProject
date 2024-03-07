using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
