using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;
using Splitio.Services.Logger;

namespace Example.NET
{
    public class SplitioInitializer
    {
        public ISplitClient Sdk { get; }

        public SplitioInitializer(ILogger<SplitioInitializer> logger)
        {
            var sdkKey = "<your SDK KEY here>";
            var configurations = new ConfigurationOptions{ Logger = new FmeLogger(logger) };

            var factory = new SplitFactory(sdkKey, configurations);
            Sdk = factory.Client();
        }

        private class FmeLogger : ISplitLogger
        {
            public bool IsDebugEnabled {get; set;} = true;
            private ILogger<SplitioInitializer> _logger;

            public FmeLogger(ILogger<SplitioInitializer> logger) => _logger = logger;

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
