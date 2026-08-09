# feature-flags-dotnet-core-web-api-sample

This app shows an example of using ConfigCat's feature flags in an ASP.NET Core Web API app. With the help of user targeting 
the API behaves differently: it renders a full list of weather forecasts only to users with a premium account type.

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
  }
]
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
- ConfigCat SDK for .NET [Reference](https://configcat.com/docs/sdk-reference/dotnet/generic-host/)
- Learn more about ConfigCat's feature flags [here](https://configcat.com/featureflags/)

[**ConfigCat**](https://configcat.com) also supports many other frameworks and languages. Check out the full list of supported SDKs [here](https://configcat.com/docs/sdk-reference/overview/).

You can also explore other code samples for various languages, frameworks, and topics here in the [ConfigCat labs](https://github.com/configcat-labs) on GitHub.

Keep up with ConfigCat on [X](https://x.com/configcat), [Facebook](https://www.facebook.com/configcat), [LinkedIn](https://www.linkedin.com/company/configcat/), [GitHub](https://github.com/configcat), and the [News & Product Updates](https://configcat.com/docs/news/) page.

## Authors

- [EMIL KOVAČEVIĆ](https://github.com/emilkovacevic)
- [Chavez Harris](https://github.com/codedbychavez)

## Contributions

Contributions are welcome!
