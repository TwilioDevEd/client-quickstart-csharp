# Twilio Client Quickstart for C# (ASP.NET MVC)

This application should give you a ready-made starting point for writing your
own voice apps with Twilio Client. Before we begin, we need to collect
all the config values we need to run the application:

| Config&nbsp;Value  | Description |
| :-------------  |:------------- |
Account&nbsp;SID | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/console).
Auth&nbsp;Token | Used to authenticate - [just like the above, you'll find this here](https://www.twilio.com/console).
TwiML&nbsp;App&nbsp;SID | The TwiML application with a voice URL configured to access your server running this app - create one [in the console here](https://www.twilio.com//console/phone-numbers/dev-tools/twiml-apps). Also, you will need to configure the Voice "REQUEST URL" on the TwiML app once you've got your server up and running.
Twilio&nbsp;Phone&nbsp;# | A Twilio phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164) - you can [get one here](https://www.twilio.com/console/phone-numbers/incoming)

## Setting Up The Application

1. After downloading or cloning this application, create a new file in `ClientQuickstart`
(at the same level as `ClientQuickstart\Web.config`) called `Local.config`.

2. Next, open up `ClientQuickstart.sln` in Visual Studio.  Edit `Local.config` 
with the four values we obtained above:

    ```xml
    <appSettings>
      <add key="TwilioAccountSid" value="ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" />
      <add key="TwilioAuthToken" value="your_auth_token" />
      <add key="TwilioTwimlAppSid" value="APXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" />
      <add key="TwilioCallerId" value="+1XXXYYYZZZZ" />
    </appSettings>
    ```

3. Hit `F5` or the Play button, and you should land on the home page of our 
basic voice application. The URL in your browser should be `localhost:XXXX`,
where `XXXX` is the port number of your app. Take note of this port number.

4. [Download and install ngrok](https://ngrok.com/download)

> [Learn 6 awesome reasons why to use ngrok](https://www.twilio.com/blog/2015/09/6-awesome-reasons-to-use-ngrok-when-testing-webhooks.html).

5. Run ngrok, replacing the two occurrences of `XXXX` in the following
command with the port number of your app:

    ```bash
    ngrok http -host-header="localhost:XXXX" XXXX
    ```

6. When ngrok starts up, it will assign a unique URL to your tunnel.
It might be something like `https://asdf456.ngrok.io`. Take note of this.

7. [Configure your TwiML app](https://www.twilio.com/console/voice/twiml/apps)'s
Voice "REQUEST URL" to be your ngrok URL plus `/voice`. For example:

    ![screenshot of twiml app](https://s3.amazonaws.com/com.twilio.prod.twilio-docs/images/TwilioClientRequestUrl.original.png)

> **Note:** You must set your webhook urls to the `https` ngrok tunnel created.

You should now be ready to rock! Make some phone calls.
Open it on another device and call yourself. Note that Twilio Client requires
WebRTC enabled browsers, so Edge and Internet Explorer will not work for testing.
We'd recommend Google Chrome or Mozilla Firefox instead.

![screenshot of phone app](https://s3.amazonaws.com/com.twilio.prod.twilio-docs/images/TwilioClientQuickstart.original.png)

## License

MIT
