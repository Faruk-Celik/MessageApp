using Microsoft.AspNetCore.Mvc;

namespace MessageApp.WebUI.ViewComponentsForMessageLayout
{
    public class _MessageLayoutFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
