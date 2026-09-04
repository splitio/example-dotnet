# FME Example .NET Single Page Web Application

[![Documentation](https://img.shields.io/badge/FME_.NET_SDK-documentation-informational)](https://developer.harness.io/docs/feature-management-experimentation/sdks-and-infrastructure/server-side-sdks/net-sdk/)


## Table of Contents
**[Intro](#intro)**<br>
**[Requirements](#requirements)**<br>
**[Quickstart](#quickstart)**<br>
**[Further Reading](#further-reading)**<br>

## Intro

This single page web app shows you how to set up the FME .NET SDK and evaluate an FME feature flag. This is a ASP.NET Core MVC app built with Razor Pages.

![Example.NET](https://github.com/splitio/example-dotnet/blob/main/images/Example.NET.png)

## Requirements

To run the example, you need:
* [VS Code](https://code.visualstudio.com/download) with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension
* [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or [.NET 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) (`dotnet --version`)

## Quickstart

To run the FME .NET SDK in the web app:

1. Log in to [Harness](https://app.harness.io) or create a free account.
1. Navigate to **Feature Management & Experimentation** > **FME Settings** > **Projects** > **View** > **SDK API Keys** and copy a server-side SDK API key for one of your FME environments.
1. Paste your SDK API key as the value of the `sdkKey` variable in `FmeInitializer.cs`.
1. Create a feature flag, initiate the FME environment, define the flag's targeting rules, and assign the flag name to the `featureFlagName` variable in `Index.cshtml.cs`.
1. Run the application, flip to your browser and you should see the treatment for the feature flag on the main page.
 
 You can also set a value for `featureFlagName` and `userKey`, using url parameters as follows:
 
 [http://localhost:7113?featureFlagName=your_feature_flag_name&userKey=user001](http://localhost:7113?featureFlagName=your_feature_flag_name&userKey=user001)

 ## Further Reading

See the [FME .NET SDK](https://developer.harness.io/docs/feature-management-experimentation/sdks-and-infrastructure/server-side-sdks/net-sdk) reference to learn about configuration options, optimizations, and event tracking.

For more information about feature flags, see our [Feature Management](https://developer.harness.io/docs/feature-management-experimentation/feature-management) documentation.

-------

[Harness](https://harness.io) is an autonomous Software Development Lifecycle Platform that provides software delivery, security testing, runtime protection, and cost management, so your team ships code faster, safer, and smarter.
