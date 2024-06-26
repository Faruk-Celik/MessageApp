using Microsoft.AspNetCore.Mvc;

namespace MessageApp.WebUI.ViewComponentsForMessageLayout
{
    public class _MessageLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
