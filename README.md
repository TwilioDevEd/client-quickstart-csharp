<a  href="https://www.twilio.com">
<img  src="https://static0.twilio.com/marketing/bundles/marketing/img/logos/wordmark-red.svg"  alt="Twilio"  width="250"  />
</a>

# Twilio Client Quickstart for C# (ASP.NET MVC)

![](https://github.com/TwilioDevEd/client-quickstart-csharp/workflows/NetFx/badge.svg)

> We are currently in the process of updating this sample template. If you are encountering any issues with the sample, please open an issue at [github.com/twilio-labs/code-exchange/issues](https://github.com/twilio-labs/code-exchange/issues) and we'll try to help you.

## About

Implementations in other languages:

| Ruby | Java | Python | PHP | Node |
| :--- | :--- | :----- | :-- | :--- |
| [Done](https://github.com/TwilioDevEd/client-quickstart-ruby) | [Done](https://github.com/TwilioDevEd/client-quickstart-java)  | [Done](https://github.com/TwilioDevEd/client-quickstart-python)  | [Done](https://github.com/TwilioDevEd/client-quickstart-php) | [Done](https://github.com/TwilioDevEd/client-quickstart-node)  |

<!--
### How it works

**TODO: Describe how it works**
-->

## Set up

### Requirements

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- A Twilio account - [sign up](https://www.twilio.com/try-twilio)
- [ngrok](https://ngrok.com)

### Twilio Account Settings

This application should give you a ready-made starting point for writing your
own application. Before we begin, we need to collect
all the config values we need to run the application:

| Config&nbsp;Value | Description                                                                                                                                                  |
| :---------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------- |
`TwilioAccountSid` | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/console).
`TwilioTwimlAppSid` | The TwiML application with a voice URL configured to access your server running this app - create one [in the console here](https://www.twilio.com/console/voice/twiml/apps). Also, you will need to configure the Voice "REQUEST URL" on the TwiML app once you've got your server up and running.
`TwilioCallerId` | A Twilio phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164) - you can [get one here](https://www.twilio.com/console/phone-numbers/incoming)
`TwilioApiKey` / `TwilioApiSecret` | Your REST API Key information needed to create an [Access Token](https://www.twilio.com/docs/iam/access-tokens) - create [one here](https://www.twilio.com/console/project/api-keys).

### Local development

After the above requirements have been met:

1. Clone this repository and `cd` into it

```bash
git clone git@github.com:TwilioDevEd/client-quickstart-csharp.git
cd client-quickstart-csharp
```

2. Set your configuration variables

```bash
copy ClientQuickstart/Local.config.example ClientQuickstart/Local.config
```

See [Twilio Account Settings](#twilio-account-settings) to locate the necessary environment variables.

3. Build the solution

4. Run the application

5. Run ngrok (or use the [ngrok Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=DavidProthero.NgrokExtensions)), replacing the two occurrences of `XXXX` in the following command with the port number of your app:

```bash
ngrok http -host-header="localhost:XXXX" XXXX
```

> [Learn 6 awesome reasons why to use ngrok](https://www.twilio.com/blog/2015/09/6-awesome-reasons-to-use-ngrok-when-testing-webhooks.html).

6. When ngrok starts up, it will assign a unique URL to your tunnel. It might be something like `https://asdf456.ngrok.io`. Take note of this.

7. [Configure your TwiML app](https://www.twilio.com/console/voice/twiml/apps)'s Voice "REQUEST URL" to be your ngrok URL plus `/voice`. For example:

  ![screenshot of twiml app](https://s3.amazonaws.com/com.twilio.prod.twilio-docs/images/TwilioClientRequestUrl.original.png)

> **Note:** You must set your webhook urls to the `https` ngrok tunnel created.

You should now be ready to rock! Make some phone calls.
Open it on another device and call yourself. Note that Twilio Client requires
WebRTC enabled browsers, so Edge and Internet Explorer will not work for testing.
We'd recommend Google Chrome or Mozilla Firefox instead.

![screenshot of phone app](https://s3.amazonaws.com/com.twilio.prod.twilio-docs/images/TwilioClientQuickstart.original.png)

That's it!

## Resources

- The CodeExchange repository can be found [here](https://github.com/twilio-labs/code-exchange/).

## Contributing

This template is open source and welcomes contributions. All contributions are subject to our [Code of Conduct](https://github.com/twilio-labs/.github/blob/master/CODE_OF_CONDUCT.md).

[Visit the project on GitHub](https://github.com/twilio-labs/sample-template-dotnet)

## License

[MIT](http://www.opensource.org/licenses/mit-license.html)

## Disclaimer

No warranty expressed or implied. Software is as is.

[twilio]: https://www.twilio.com
