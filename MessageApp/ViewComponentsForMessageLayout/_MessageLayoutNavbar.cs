using Microsoft.AspNetCore.Mvc;

namespace MessageApp.WebUI.ViewComponentsForMessageLayout
{
    public class _MessageLayoutNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
