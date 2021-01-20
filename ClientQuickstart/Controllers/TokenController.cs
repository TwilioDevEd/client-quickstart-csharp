using System.Configuration;
using System.Web.Mvc;
using Faker;
using Faker.Extensions;
using System.Collections.Generic;
using Twilio.Jwt.AccessToken;

namespace ClientQuickstart.Controllers
{
  public class TokenController : Controller
  {
    // GET: /token
    public ActionResult Index()
    {
      // Load Twilio configuration from Web.config
      var twilioAccountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
      var appSid = ConfigurationManager.AppSettings["TwilioTwimlAppSid"];
      var twilioApiKey = ConfigurationManager.AppSettings["TwilioApiKey"];
      var twilioApiSecret = ConfigurationManager.AppSettings["TwilioApiSecret"];

      // Create a random identity for the client
      var identity = Internet.UserName().AlphanumericOnly();

      // Create a Voice grant for this token
      var grant = new VoiceGrant();
      grant.OutgoingApplicationSid = appSid;

      // Optional: add to allow incoming calls
      grant.IncomingAllow = true;

      var grants = new HashSet<IGrant>
        {
            { grant }
        };

      // Create an Access Token generator
      var accessToken = new Token(
          twilioAccountSid,
          twilioApiKey,
          twilioApiSecret,
          identity,
          grants: grants);

      var token = accessToken.ToJwt();

      return Json(new
      {
        identity,
        token
      }, JsonRequestBehavior.AllowGet);
    }
  }
}
