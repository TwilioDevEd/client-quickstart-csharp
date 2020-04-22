using System.Configuration;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Voice;

namespace ClientQuickstart.Controllers
{
  public class VoiceController : Controller
  {
    [HttpPost]
    public ActionResult Index(string to)
    {
      var callerId = ConfigurationManager.AppSettings["TwilioCallerId"];

      var response = new VoiceResponse();
      if (!string.IsNullOrEmpty(to))
      {
        var dial = new Dial(callerId: callerId);
        // wrap the phone number or client name in the appropriate TwiML verb
        // by checking if the number given has only digits and format symbols
        if (Regex.IsMatch(to, "^[\\d\\+\\-\\(\\) ]+$"))
        {
          dial.Number(to);
        }
        else
        {
          dial.Client(to);
        }
        response.Append(dial);
      }
      else
      {
        response.Say("Thanks for calling!");
      }
      return Content(response.ToString(), "text/xml");
    }
  }
}