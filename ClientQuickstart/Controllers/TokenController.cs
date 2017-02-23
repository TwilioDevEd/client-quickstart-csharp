using System.Configuration;
using System.Web.Mvc;
using Faker;
using Faker.Extensions;
using Twilio.Jwt;
using System.Collections.Generic;
using Twilio.Jwt.Client;

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
      var scopes = new HashSet<IScope>
      {
          { new IncomingClientScope(identity) },
          { new OutgoingClientScope(appSid) }
      };
      var capability = new ClientCapability(accountSid, authToken);
      var token = capability.ToJwt();

      return Json(new
      {
        identity,
        token
      }, JsonRequestBehavior.AllowGet);
    }
  }
}
