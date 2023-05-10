using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;

namespace Example.NET
{
    public class SplitioInitializer
    {
        public ISplitClient Sdk { get; }

        public SplitioInitializer()
        {
            var sdkKey = "<your SDK KEY here>";
            var configurations = new ConfigurationOptions();

            var factory = new SplitFactory(sdkKey, configurations);
            Sdk = factory.Client();
        }
    }
}
