using Microsoft.AspNetCore.Mvc.RazorPages;
using Splitio.Services.Client.Interfaces;

namespace Example.NET.Pages
{
    public class IndexModel : PageModel
    {
        public string? FeatureFlagName { get; set; }
        public string? UserKey { get; set; }
        public string? Treatment { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly ISplitClient _sdk;

        public IndexModel(ILogger<IndexModel> logger,
            SplitioInitializer splitioInitializer)
        {
            _logger = logger;
            _sdk = splitioInitializer.Sdk;
        }

        public void OnGet(string featureFlagName, string userKey)
        {
            if (string.IsNullOrEmpty(featureFlagName))
            {
                // CHANGE THIS: Copy and paste the feature flag name from Split user interface.
                featureFlagName = "DEFAULT_FEATURE_FLAG_NAME";
            }

            if (string.IsNullOrEmpty(userKey))
            {
                // Change this to represent your user or account id. (usually a dynamic value)
                userKey = "user";
            }

            Treatment = _sdk.GetTreatment(userKey, featureFlagName);
            FeatureFlagName = featureFlagName;
            UserKey = userKey;
        }
    }
}