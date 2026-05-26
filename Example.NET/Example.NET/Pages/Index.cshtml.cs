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
            FmeInitializer fmeInitializer)
        {
            _logger = logger;
            _sdk = fmeInitializer.Sdk;
        }

        public void OnGet(string featureFlagName, string userKey)
        {
            if (string.IsNullOrEmpty(featureFlagName))
            {
                // CHANGE THIS: Copy and paste the feature flag name from Harness FME.
                featureFlagName = "DEFAULT_FEATURE_FLAG_NAME";
            }

            if (string.IsNullOrEmpty(userKey))
            {
                // CHANGE THIS: Provide a user or account ID (usually a dynamic value). This value
                // is used for feature flag targeting (for matching with a flag targeting rule and
                // for percentage distribution within a targeting rule).
                userKey = "user001";
            }

            Treatment = _sdk.GetTreatment(userKey, featureFlagName);    // Evaluate the feature flag for the given user or account.
                                                                        // Feature flag impressions (evaluation info) should appear
                                                                        // in Live tail soon after you run the demo.
            FeatureFlagName = featureFlagName;
            UserKey = userKey;
        }
    }
}