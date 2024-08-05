using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new AgricultureContext();

            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();

            ViewBag.announcementTrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = context.Announcements.Where(x => x.Status == false).Count();

            return View();  
        }
    }
}
