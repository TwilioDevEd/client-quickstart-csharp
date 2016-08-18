using System.Configuration;
using System.Web.Mvc;
using Faker;
using Faker.Extensions;
using Twilio;

namespace ClientQuickstart.Controllers
{
  public class TokenController : Controller
  {
    // GET: /token
    public ActionResult Index()
    {
      // Load Twilio configuration from Web.config
      var accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
      var authToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
      var appSid = ConfigurationManager.AppSettings["TwilioTwimlAppSid"];

      // Create a random identity for the client
      var identity = Internet.UserName().AlphanumericOnly();

      // Create an Access Token generator
      var capability = new TwilioCapability(accountSid, authToken);
      capability.AllowClientOutgoing(appSid);
      capability.AllowClientIncoming(identity);
      var token = capability.GenerateToken();

      return Json(new
      {
        identity,
        token
      }, JsonRequestBehavior.AllowGet);
    }
  }
}
