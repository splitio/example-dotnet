## Example Demo application to show Split .NET SDK

This is a single page that shows how to set up the .NET SDK. Follow the instructions below to make the changes 
needed using the information obtained from Split user interface.

### Get started

 * Log in to Split user interface, go to the "Admin Tab" -> "API keys" and copy an SDK key.
 * Paste your SDK key, in `sdkKey` variable in SplitioInitializer.cs
 * Create a feature flag and assign its name to the variable `featureFlagName` in Index.cshtml.cs
 * Run your application, open your browser and you should see the treatment for the feature flag specified.
 
 You can also set a value for `featureFlagName` and `userKey`, using url parameters as follows:
 
 [http://localhost:7113?featureFlagName=test-net&userKey=test-id](http://localhost:7113?featureFlagName=test-net&userKey=test-id)