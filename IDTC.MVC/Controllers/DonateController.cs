using System.Web.Mvc;


namespace IDTC.MVC.Controllers
{
    
    
    public class DonateController : Controller
    {
        
        public ActionResult BecomeSponsor()
        {
            return View();
        }

        public ActionResult Donate()
        {
            return View("NoContent");
        }

        public ActionResult Friends()
        {
            return View("NoContent");
        }
    }
}
