using System.Web.Mvc;


namespace IDTC.MVC.Controllers
{
    public class ParticipateController : Controller
    {
        public ActionResult EssaySubmissionGuidelines()
        {
            return View();
        }
        public ActionResult VideoSubmissionGuidelines()
        {
            return View();
        }
        public ActionResult PodcastSubmissionGuidelines()
        {
            return View();
        }
        public ActionResult CopyrightInfo()
        {
            return View("NoContent");
        }
    }
}
