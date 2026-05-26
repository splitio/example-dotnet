using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;
using Splitio.Services.Logger;

namespace Example.NET
{
    public class FmeInitializer
    {
        public ISplitClient Sdk { get; }

        public FmeInitializer(ILogger<FmeInitializer> logger)
        {
            // CHANGE THIS: Copy and paste your Harness FME server-side SDK API key.
            // In Harness, look under FME Settings | Projects | View | SDK API Keys.
            var sdkKey = "YOUR_SDK_KEY";
            var configurations = new ConfigurationOptions{ Logger = new FmeLogger(logger) };

            var factory = new SplitFactory(sdkKey, configurations);
            Sdk = factory.Client();

            Sdk.BlockUntilReady( 3 * 1000 );    // wait 3 seconds to fetch the FME payload (segments and feature flag definitions)
        }

        private class FmeLogger : ISplitLogger
        {

            // Enable debugging to log SDK initialization, streaming or polling, and
            // feature flag evaluation to your debug console.
            public bool IsDebugEnabled {get; set;} = true;
            private ILogger<FmeInitializer> _logger;

            public FmeLogger(ILogger<FmeInitializer> logger) => _logger = logger;

            public void Error(string message, Exception e) => _logger.LogError      (e, message);
            public void Error(string message             ) => _logger.LogError      (   message);
            public void Debug(string message, Exception e) => _logger.LogDebug      (e, message);
            public void Debug(string message             ) => _logger.LogDebug      (   message);
            public void Warn (string message, Exception e) => _logger.LogWarning    (e, message);
            public void Warn (string message             ) => _logger.LogWarning    (   message);
            public void Info (string message, Exception e) => _logger.LogInformation(e, message);
            public void Info (string message             ) => _logger.LogInformation(   message);
            public void Trace(string message, Exception e) => _logger.LogTrace      (e, message);
            public void Trace(string message             ) => _logger.LogTrace      (   message);
        }
    }
}
