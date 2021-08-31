﻿using System.Collections.Generic;

namespace CollectStats_Functions
{
    public class AppOptions
    {
        public string TenantId { get; set; }
        public string AzureTokenProviderString { get; set; }
        public string Organization { get; set; }

        public string GithubAppPrivateKey { get; set; }
        public int GithubAppId { get; set; }
        public long GithubAppInstallationId { get; set; }
    }
}

