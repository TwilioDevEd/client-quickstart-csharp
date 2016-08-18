using System.Web.Mvc;

namespace ClientQuickstart.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}