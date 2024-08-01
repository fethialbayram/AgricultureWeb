using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _MapPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			AgricultureContext context = new AgricultureContext();
			var values = context.Addresses.Select(x=>x.Map).FirstOrDefault();
			ViewBag.map=values;
			return View();
		}
	}
}
