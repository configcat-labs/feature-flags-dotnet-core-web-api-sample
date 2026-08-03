# feature-flags-dotnet-core-web-api-sample

This app shows an example of using ConfigCat's feature flags in an ASP.NET Core Web API app. With the help of user targeting 
the API behaves differently, and renders a list of weather forecasts to users with a premium account type when toggled on.

### When the flag is on

```bash
[
  {
    "date": "2026-08-03",
    "temperatureC": 21,
    "temperatureF": 69,
    "summary": "Sweltering"
  },
  {
    "date": "2026-08-04",
    "temperatureC": 34,
    "temperatureF": 93,
    "summary": "Mild"
  },
  {
    "date": "2026-08-05",
    "temperatureC": 41,
    "temperatureF": 105,
    "summary": "Chilly"
  },
  {
    "date": "2026-08-06",
    "temperatureC": 18,
    "temperatureF": 64,
    "summary": "Sweltering"
  },
  {
    "date": "2026-08-07",
    "temperatureC": 33,
    "temperatureF": 91,
    "summary": "Balmy"
  }
]
```

### When the flag is off

```bash
[]
```

## Setup and Run

1. Clone this repository
2. Open the project in Visual Studio Code
3. Add your ConfigCat SDK Key to `appsettings.json`
4. Launch the Web API in your browser with the following command:

```bash
dotnet run --launch-profile https
```

## Learn more

- ASP.NET [Documentation](https://learn.microsoft.com/en-us/aspnet/core/) 
- Learn more about ConfigCat's feature flags [here](https://configcat.com/featureflags/)

[**ConfigCat**](https://configcat.com) also supports many other frameworks and languages. Check out the full list of supported SDKs [here](https://configcat.com/docs/sdk-reference/overview/).

You can also explore other code samples for various languages, frameworks, and topics here in the [ConfigCat labs](https://github.com/configcat-labs) on GitHub.

Keep up with ConfigCat on [X](https://x.com/configcat), [Facebook](https://www.facebook.com/configcat), [LinkedIn](https://www.linkedin.com/company/configcat/), and [GitHub](https://github.com/configcat).

## Author
- [EMIL KOVAČEVIĆ](https://github.com/emilkovacevic)
- [Chavez Harris](https://github.com/codedbychavez)

## Contributions
Contributions are welcome!
