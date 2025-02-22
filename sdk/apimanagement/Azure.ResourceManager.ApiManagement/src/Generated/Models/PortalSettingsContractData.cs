// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Portal Settings for the Developer Portal. </summary>
    public partial class PortalSettingsContractData : ResourceData
    {
        /// <summary> Initializes a new instance of PortalSettingsContractData. </summary>
        public PortalSettingsContractData()
        {
        }

        /// <summary> Initializes a new instance of PortalSettingsContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uri"> A delegation Url. </param>
        /// <param name="validationKey"> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </param>
        /// <param name="isSubscriptions"> Subscriptions delegation settings. </param>
        /// <param name="isUserRegistration"> User registration delegation settings. </param>
        /// <param name="isRedirectEnabled"> Redirect Anonymous users to the Sign-In page. </param>
        /// <param name="termsOfService"> Terms of service contract properties. </param>
        internal PortalSettingsContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri uri, string validationKey, SubscriptionDelegationSettingProperties isSubscriptions, RegistrationDelegationSettingProperties isUserRegistration, bool? isRedirectEnabled, TermsOfServiceProperties termsOfService) : base(id, name, resourceType, systemData)
        {
            Uri = uri;
            ValidationKey = validationKey;
            IsSubscriptions = isSubscriptions;
            IsUserRegistration = isUserRegistration;
            IsRedirectEnabled = isRedirectEnabled;
            TermsOfService = termsOfService;
        }

        /// <summary> A delegation Url. </summary>
        public Uri Uri { get; set; }
        /// <summary> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </summary>
        public string ValidationKey { get; set; }
        /// <summary> Subscriptions delegation settings. </summary>
        internal SubscriptionDelegationSettingProperties IsSubscriptions { get; set; }
        /// <summary> Enable or disable delegation for subscriptions. </summary>
        public bool? IsSubscriptionDelegationEnabled
        {
            get => IsSubscriptions is null ? default : IsSubscriptions.IsSubscriptionDelegationEnabled;
            set
            {
                if (IsSubscriptions is null)
                    IsSubscriptions = new SubscriptionDelegationSettingProperties();
                IsSubscriptions.IsSubscriptionDelegationEnabled = value;
            }
        }

        /// <summary> User registration delegation settings. </summary>
        internal RegistrationDelegationSettingProperties IsUserRegistration { get; set; }
        /// <summary> Enable or disable delegation for user registration. </summary>
        public bool? IsUserRegistrationDelegationEnabled
        {
            get => IsUserRegistration is null ? default : IsUserRegistration.IsUserRegistrationDelegationEnabled;
            set
            {
                if (IsUserRegistration is null)
                    IsUserRegistration = new RegistrationDelegationSettingProperties();
                IsUserRegistration.IsUserRegistrationDelegationEnabled = value;
            }
        }

        /// <summary> Redirect Anonymous users to the Sign-In page. </summary>
        public bool? IsRedirectEnabled { get; set; }
        /// <summary> Terms of service contract properties. </summary>
        public TermsOfServiceProperties TermsOfService { get; set; }
    }
}
