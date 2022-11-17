# feature-flags-dotnet-core-web-api-sample

The app is showcasing the use of ConfigCat's feature flags in a ASP .NET Core Web API app.
ConfigCat's user targeting system is used where the api behaves differently depending on user accounts type (users with premium tag or not).
A feature flag is used in order to change the API behavior, where the segment `movement` is shown or hidden depending on the flag setting.

------------------------------------------------------------
movement show

```
[
  {
    "date": "2022-11-07T16:32:10.2919244+01:00",
    "id": 1,
    "carBrand": "Hyundai",
    "stockPrice": 94,
    "volume24h": 383345006,
    "movement": [
      {
        "key": "change",
        "value": "-9"
      },
      {
        "key": "multiplier",
        "value": "17"
      },
      {
        "key": "spread",
        "value": "61"
      }
    ]
  }, ... ]
```

Movement hidden

```
 {
    "date": "2022-11-07T16:13:41.8473912+01:00",
    "id": 4,
    "carBrand": "Abarth",
    "stockPrice": 193,
    "volume24h": 74446081,
    "movement": null
  }
```

## Setup and Run

- clone repository
- use command "dotnet run" in a terminal OR run using and IDE
- Connect to the ConfigCat dashboard to enable/disable the feature flag.

## Learn more

- ASP.NET [Documentation](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0) 
- Learn more about ConfigCat's feature flags [here](https://configcat.com/featureflags/)

[**ConfigCat**](https://configcat.com) also supports many other frameworks and languages. Check out the full list of supported SDKs [here](https://configcat.com/docs/sdk-reference/overview/).

You can also explore other code samples for various languages, frameworks, and topics here in the [ConfigCat labs](https://github.com/configcat-labs) on GitHub.

Keep up with ConfigCat on [Twitter](https://twitter.com/configcat), [Facebook](https://www.facebook.com/configcat), [LinkedIn](https://www.linkedin.com/company/configcat/), and [GitHub](https://github.com/configcat).

## Author
[Emil Kovacevic](https://github.com/emilkovacevic)

## Contributions
Contributions are welcome!
