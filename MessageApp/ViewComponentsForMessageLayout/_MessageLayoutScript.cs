using Microsoft.AspNetCore.Mvc;

namespace MessageApp.WebUI.ViewComponentsForMessageLayout
{
    public class _MessageLayoutScript :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
