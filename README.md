# Twilio Client Quickstart for C# (ASP.NET MVC)

This application should give you a ready-made starting point for writing your
own voice apps with Twilio Client. Before we begin, we need to collect
all the config values we need to run the application:

| Config Value  | Description |
| :-------------  |:------------- |
Account SID | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/console).
Auth Token | Used to authenticate - [just like the above, you'll find this here](https://www.twilio.com/console).
TwiML App SID | The TwiML application with a voice URL configured to access your server running this app. [See here for more information](https://www.twilio.com/docs/guides/client/server).
Twilio Phone # | A Twilio phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164) - you can [get one here](https://www.twilio.com/console/phone-numbers/incoming)

## Setting Up The Application

After downloading or cloning this application, create a new file in `ClientQuickstart`
(at the same level as `ClientQuickstart\Web.config`) called `Local.config`.

Next, open up `ClientQuickstart.sln` in Visual Studio.  Edit `Local.config` 
with the four values we obtained above:

```xml
<appSettings>
  <add key="TwilioAccountSid" value="ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" />
  <add key="TwilioAuthToken" value="your_auth_token" />
  <add key="TwilioTwimlAppSid" value="APXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" />
  <add key="TwilioCallerId" value="+1XXXYYYZZZZ" />
</appSettings>
```

You should now be ready to rock! Hit `F5` or the Play button, and you should 
land on the home page of our basic voice application. Make some phone calls.
Open it on another device and call yourself. Note that Twilio Client requires
WebRTC enabled browsers, so Edge and Internet Explorer will not work for testing.
We'd recommend Google Chrome or Mozilla Firefox instead.

![screenshot of chat app](https://s3.amazonaws.com/com.twilio.prod.twilio-docs/images/TwilioClientQuickstart.original.png)

## License

MIT
