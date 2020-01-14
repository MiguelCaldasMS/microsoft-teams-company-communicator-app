﻿// <copyright file="AuthenticationOptions.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Authentication
{
    /// <summary>
    /// Options used for creating the authentication.
    /// </summary>
    public class AuthenticationOptions
    {
        /// <summary>
        /// Gets or sets the Azure active directory client ID.
        /// </summary>
        public string AzureAd_ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Azure active directory tenant ID.
        /// </summary>
        public string AzureAd_TenantId { get; set; }

        /// <summary>
        /// Gets or sets the Azure active directory application ID URI.
        /// </summary>
        public string AzureAd_ApplicationIdURI { get; set; }

        /// <summary>
        /// Gets or sets the Azure active directory valid issuers.
        /// </summary>
        public string AzureAd_ValidIssuers { get; set; }
    }
}
