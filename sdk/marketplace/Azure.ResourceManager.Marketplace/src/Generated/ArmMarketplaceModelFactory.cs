// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMarketplaceModelFactory
    {
        /// <summary> Initializes a new instance of PrivateStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="availability"> Indicates private store availability. </param>
        /// <param name="privateStoreId"> Private Store id. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreName"> Private Store Name. </param>
        /// <param name="tenantId"> Tenant id. </param>
        /// <param name="isGov"> Is government. </param>
        /// <param name="collectionIds"> Gets list of associated collection ids. </param>
        /// <param name="branding"> Gets or sets list of branding characteristics. </param>
        /// <param name="recipients"> Gets or sets list of notified recipients for new requests. </param>
        /// <param name="sendToAllMarketplaceAdmins"> Gets or sets whether to send email to all marketplace admins for new requests. </param>
        /// <returns> A new <see cref="Marketplace.PrivateStoreData"/> instance for mocking. </returns>
        public static PrivateStoreData PrivateStoreData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PrivateStoreAvailability? availability = null, Guid? privateStoreId = null, ETag? eTag = null, string privateStoreName = null, Guid? tenantId = null, bool? isGov = null, IEnumerable<Guid> collectionIds = null, IDictionary<string, string> branding = null, IEnumerable<NotificationRecipient> recipients = null, bool? sendToAllMarketplaceAdmins = null)
        {
            collectionIds ??= new List<Guid>();
            branding ??= new Dictionary<string, string>();
            recipients ??= new List<NotificationRecipient>();

            return new PrivateStoreData(id, name, resourceType, systemData, availability, privateStoreId, eTag, privateStoreName, tenantId, isGov, collectionIds?.ToList(), branding, recipients?.ToList(), sendToAllMarketplaceAdmins);
        }

        /// <summary> Initializes a new instance of NotificationRecipient. </summary>
        /// <param name="principalId"> Principal ID. </param>
        /// <param name="emailAddress"> Email Address. </param>
        /// <param name="displayName"> Display Name. </param>
        /// <returns> A new <see cref="Models.NotificationRecipient"/> instance for mocking. </returns>
        public static NotificationRecipient NotificationRecipient(Guid? principalId = null, string emailAddress = null, string displayName = null)
        {
            return new NotificationRecipient(principalId, emailAddress, displayName);
        }

        /// <summary> Initializes a new instance of AnyExistingOffersInTheCollectionsResult. </summary>
        /// <param name="value"> Boolean answer, true if exists at least a single offer in an enabled collection, otherwise, false. </param>
        /// <returns> A new <see cref="Models.AnyExistingOffersInTheCollectionsResult"/> instance for mocking. </returns>
        public static AnyExistingOffersInTheCollectionsResult AnyExistingOffersInTheCollectionsResult(bool? value = null)
        {
            return new AnyExistingOffersInTheCollectionsResult(value);
        }

        /// <summary> Initializes a new instance of PrivateStoreOfferResult. </summary>
        /// <param name="uniqueOfferId"> Offers unique id. </param>
        /// <param name="offerDisplayName"> It will be displayed prominently in the marketplace. </param>
        /// <param name="publisherDisplayName"> Publisher name that will be displayed prominently in the marketplace. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreId"> Private store unique id. </param>
        /// <param name="createdOn"> Private store offer creation date. </param>
        /// <param name="modifiedOn"> Private store offer modification date. </param>
        /// <param name="specificPlanIdsLimitation"> Plan ids limitation for this offer. </param>
        /// <param name="isUpdateSuppressedDueToIdempotence"> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </param>
        /// <param name="iconFileUris"> Icon File Uris. </param>
        /// <param name="plans"> Offer plans. </param>
        /// <returns> A new <see cref="Models.PrivateStoreOfferResult"/> instance for mocking. </returns>
        public static PrivateStoreOfferResult PrivateStoreOfferResult(string uniqueOfferId = null, string offerDisplayName = null, string publisherDisplayName = null, ETag? eTag = null, Guid? privateStoreId = null, DateTimeOffset? createdOn = null, DateTimeOffset? modifiedOn = null, IEnumerable<string> specificPlanIdsLimitation = null, bool? isUpdateSuppressedDueToIdempotence = null, IReadOnlyDictionary<string, Uri> iconFileUris = null, IEnumerable<PrivateStorePlan> plans = null)
        {
            specificPlanIdsLimitation ??= new List<string>();
            iconFileUris ??= new Dictionary<string, Uri>();
            plans ??= new List<PrivateStorePlan>();

            return new PrivateStoreOfferResult(uniqueOfferId, offerDisplayName, publisherDisplayName, eTag, privateStoreId, createdOn, modifiedOn, specificPlanIdsLimitation?.ToList(), isUpdateSuppressedDueToIdempotence, iconFileUris, plans?.ToList());
        }

        /// <summary> Initializes a new instance of PrivateStorePlan. </summary>
        /// <param name="skuId"> Identifier for this plan. </param>
        /// <param name="planId"> Text identifier for this plan. </param>
        /// <param name="planDisplayName"> Friendly name for the plan for display in the marketplace. </param>
        /// <param name="accessibility"> Plan accessibility. </param>
        /// <param name="altStackReference"> Alternative stack type. </param>
        /// <param name="stackType"> Stack type (classic or arm). </param>
        /// <returns> A new <see cref="Models.PrivateStorePlan"/> instance for mocking. </returns>
        public static PrivateStorePlan PrivateStorePlan(string skuId = null, string planId = null, string planDisplayName = null, PrivateStorePlanAccessibility? accessibility = null, string altStackReference = null, string stackType = null)
        {
            return new PrivateStorePlan(skuId, planId, planDisplayName, accessibility, altStackReference, stackType);
        }

        /// <summary> Initializes a new instance of PrivateStoreBillingAccountsResult. </summary>
        /// <param name="billingAccounts"> Billing accounts list. </param>
        /// <returns> A new <see cref="Models.PrivateStoreBillingAccountsResult"/> instance for mocking. </returns>
        public static PrivateStoreBillingAccountsResult PrivateStoreBillingAccountsResult(IEnumerable<string> billingAccounts = null)
        {
            billingAccounts ??= new List<string>();

            return new PrivateStoreBillingAccountsResult(billingAccounts?.ToList());
        }

        /// <summary> Initializes a new instance of CollectionsToSubscriptionsMappingResult. </summary>
        /// <param name="details"> The map of collections subscriptions. </param>
        /// <returns> A new <see cref="Models.CollectionsToSubscriptionsMappingResult"/> instance for mocking. </returns>
        public static CollectionsToSubscriptionsMappingResult CollectionsToSubscriptionsMappingResult(IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails> details = null)
        {
            details ??= new Dictionary<string, CollectionsSubscriptionsMappingDetails>();

            return new CollectionsToSubscriptionsMappingResult(details);
        }

        /// <summary> Initializes a new instance of CollectionsSubscriptionsMappingDetails. </summary>
        /// <param name="collectionName"> Collection name. </param>
        /// <param name="subscriptions"> Subscriptions ids list. </param>
        /// <returns> A new <see cref="Models.CollectionsSubscriptionsMappingDetails"/> instance for mocking. </returns>
        public static CollectionsSubscriptionsMappingDetails CollectionsSubscriptionsMappingDetails(string collectionName = null, IEnumerable<string> subscriptions = null)
        {
            subscriptions ??= new List<string>();

            return new CollectionsSubscriptionsMappingDetails(collectionName, subscriptions?.ToList());
        }

        /// <summary> Initializes a new instance of PrivateStoreCollectionInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="collectionId"> Gets collection Id. </param>
        /// <param name="collectionName"> Gets or sets collection name. </param>
        /// <param name="claim"> Gets or sets the association with Commercial's Billing Account. </param>
        /// <param name="areAllSubscriptionsSelected"> Indicating whether all subscriptions are selected (=true) or not (=false). </param>
        /// <param name="areAllItemsApproved"> Indicating whether all items are approved for this collection (=true) or not (=false). </param>
        /// <param name="approveAllItemsModifiedOn"> Gets the modified date of all items approved. </param>
        /// <param name="subscriptionsList"> Gets or sets subscription ids list. Empty list indicates all subscriptions are selected, null indicates no update is done, explicit list indicates the explicit selected subscriptions. On insert, null is considered as bad request. </param>
        /// <param name="isEnabled"> Indicating whether the collection is enabled or disabled. </param>
        /// <param name="numberOfOffers"> Gets the number of offers associated with the collection. </param>
        /// <param name="appliedRules"> Gets list of collection rules. </param>
        /// <returns> A new <see cref="Marketplace.PrivateStoreCollectionInfoData"/> instance for mocking. </returns>
        public static PrivateStoreCollectionInfoData PrivateStoreCollectionInfoData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? collectionId = null, string collectionName = null, string claim = null, bool? areAllSubscriptionsSelected = null, bool? areAllItemsApproved = null, DateTimeOffset? approveAllItemsModifiedOn = null, IEnumerable<string> subscriptionsList = null, bool? isEnabled = null, long? numberOfOffers = null, IEnumerable<MarketplaceRule> appliedRules = null)
        {
            subscriptionsList ??= new List<string>();
            appliedRules ??= new List<MarketplaceRule>();

            return new PrivateStoreCollectionInfoData(id, name, resourceType, systemData, collectionId, collectionName, claim, areAllSubscriptionsSelected, areAllItemsApproved, approveAllItemsModifiedOn, subscriptionsList?.ToList(), isEnabled, numberOfOffers, appliedRules?.ToList());
        }

        /// <summary> Initializes a new instance of TransferOffersResult. </summary>
        /// <param name="succeeded"> Succeeded collections. </param>
        /// <param name="failed"> Failed collections. </param>
        /// <returns> A new <see cref="Models.TransferOffersResult"/> instance for mocking. </returns>
        public static TransferOffersResult TransferOffersResult(IEnumerable<PrivateStoreCollectionDetails> succeeded = null, IEnumerable<PrivateStoreCollectionDetails> failed = null)
        {
            succeeded ??= new List<PrivateStoreCollectionDetails>();
            failed ??= new List<PrivateStoreCollectionDetails>();

            return new TransferOffersResult(succeeded?.ToList(), failed?.ToList());
        }

        /// <summary> Initializes a new instance of PrivateStoreCollectionDetails. </summary>
        /// <param name="collectionName"> Collection name. </param>
        /// <param name="collectionId"> Collection id. </param>
        /// <returns> A new <see cref="Models.PrivateStoreCollectionDetails"/> instance for mocking. </returns>
        public static PrivateStoreCollectionDetails PrivateStoreCollectionDetails(string collectionName = null, Guid? collectionId = null)
        {
            return new PrivateStoreCollectionDetails(collectionName, collectionId);
        }

        /// <summary> Initializes a new instance of QueryApprovedPlansResult. </summary>
        /// <param name="details"> A list indicating for each plan which subscriptions are approved. Plan Id is unique. </param>
        /// <returns> A new <see cref="Models.QueryApprovedPlansResult"/> instance for mocking. </returns>
        public static QueryApprovedPlansResult QueryApprovedPlansResult(IEnumerable<QueryApprovedPlansDetails> details = null)
        {
            details ??= new List<QueryApprovedPlansDetails>();

            return new QueryApprovedPlansResult(details?.ToList());
        }

        /// <summary> Initializes a new instance of QueryApprovedPlansDetails. </summary>
        /// <param name="planId"> Plan id. </param>
        /// <param name="subscriptionIds"> Approved subscription ids list. In case all subscriptions are approved for a plan, allSubscriptions flag is true and list is empty ( else flag is set to false). In case both subscriptions list is empty and allSubscriptions flag is false, the plan is not approved for any subscription. </param>
        /// <param name="allSubscriptions"> Indicates whether all subscriptions are approved for this plan. </param>
        /// <returns> A new <see cref="Models.QueryApprovedPlansDetails"/> instance for mocking. </returns>
        public static QueryApprovedPlansDetails QueryApprovedPlansDetails(string planId = null, IEnumerable<string> subscriptionIds = null, bool? allSubscriptions = null)
        {
            subscriptionIds ??= new List<string>();

            return new QueryApprovedPlansDetails(planId, subscriptionIds?.ToList(), allSubscriptions);
        }

        /// <summary> Initializes a new instance of BulkCollectionsActionResult. </summary>
        /// <param name="succeeded"> Succeeded collections. </param>
        /// <param name="failed"> Failed collections. </param>
        /// <returns> A new <see cref="Models.BulkCollectionsActionResult"/> instance for mocking. </returns>
        public static BulkCollectionsActionResult BulkCollectionsActionResult(IEnumerable<PrivateStoreCollectionDetails> succeeded = null, IEnumerable<PrivateStoreCollectionDetails> failed = null)
        {
            succeeded ??= new List<PrivateStoreCollectionDetails>();
            failed ??= new List<PrivateStoreCollectionDetails>();

            return new BulkCollectionsActionResult(succeeded?.ToList(), failed?.ToList());
        }

        /// <summary> Initializes a new instance of PrivateStoreOfferData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uniqueOfferId"> Offers unique id. </param>
        /// <param name="offerDisplayName"> It will be displayed prominently in the marketplace. </param>
        /// <param name="publisherDisplayName"> Publisher name that will be displayed prominently in the marketplace. </param>
        /// <param name="eTag"> Identifier for purposes of race condition. </param>
        /// <param name="privateStoreId"> Private store unique id. </param>
        /// <param name="createdOn"> Private store offer creation date. </param>
        /// <param name="modifiedOn"> Private store offer modification date. </param>
        /// <param name="specificPlanIdsLimitation"> Plan ids limitation for this offer. </param>
        /// <param name="isUpdateSuppressedDueToIdempotence"> Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated. </param>
        /// <param name="iconFileUris"> Icon File Uris. </param>
        /// <param name="plans"> Offer plans. </param>
        /// <returns> A new <see cref="Marketplace.PrivateStoreOfferData"/> instance for mocking. </returns>
        public static PrivateStoreOfferData PrivateStoreOfferData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string uniqueOfferId = null, string offerDisplayName = null, string publisherDisplayName = null, ETag? eTag = null, Guid? privateStoreId = null, DateTimeOffset? createdOn = null, DateTimeOffset? modifiedOn = null, IEnumerable<string> specificPlanIdsLimitation = null, bool? isUpdateSuppressedDueToIdempotence = null, IDictionary<string, Uri> iconFileUris = null, IEnumerable<PrivateStorePlan> plans = null)
        {
            specificPlanIdsLimitation ??= new List<string>();
            iconFileUris ??= new Dictionary<string, Uri>();
            plans ??= new List<PrivateStorePlan>();

            return new PrivateStoreOfferData(id, name, resourceType, systemData, uniqueOfferId, offerDisplayName, publisherDisplayName, eTag, privateStoreId, createdOn, modifiedOn, specificPlanIdsLimitation?.ToList(), isUpdateSuppressedDueToIdempotence, iconFileUris, plans?.ToList());
        }

        /// <summary> Initializes a new instance of CollectionOffersByContext. </summary>
        /// <param name="context"> Offer's context, e.g. subscription ID, tenant ID. </param>
        /// <param name="value"></param>
        /// <returns> A new <see cref="Models.CollectionOffersByContext"/> instance for mocking. </returns>
        public static CollectionOffersByContext CollectionOffersByContext(string context = null, IEnumerable<PrivateStoreOfferResult> value = null)
        {
            value ??= new List<PrivateStoreOfferResult>();

            return new CollectionOffersByContext(context, value?.ToList());
        }

        /// <summary> Initializes a new instance of MarketplaceApprovalRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId"> Gets or sets unique offer id. </param>
        /// <param name="offerDisplayName"> Gets offer display name. </param>
        /// <param name="publisherId"> The offer's publisher id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="isClosed"> Gets a value indicating whether the request is closed. </param>
        /// <param name="messageCode"> Gets or sets the request approval message code. </param>
        /// <returns> A new <see cref="Marketplace.MarketplaceApprovalRequestData"/> instance for mocking. </returns>
        public static MarketplaceApprovalRequestData MarketplaceApprovalRequestData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string offerId = null, string offerDisplayName = null, string publisherId = null, IEnumerable<PrivateStorePlanDetails> plansDetails = null, bool? isClosed = null, long? messageCode = null)
        {
            plansDetails ??= new List<PrivateStorePlanDetails>();

            return new MarketplaceApprovalRequestData(id, name, resourceType, systemData, offerId, offerDisplayName, publisherId, plansDetails?.ToList(), isClosed, messageCode);
        }

        /// <summary> Initializes a new instance of PrivateStorePlanDetails. </summary>
        /// <param name="planId"> Gets or sets Plan Id. </param>
        /// <param name="status"> Gets the plan status. </param>
        /// <param name="requestDate"> Gets request date. </param>
        /// <param name="justification"> Gets or sets user's justification for the plan's request. </param>
        /// <param name="subscriptionId"> Gets or sets the subscription id that the user is requesting to add the plan to. </param>
        /// <param name="subscriptionName"> Gets or sets the subscription name that the user is requesting to add the plan to. </param>
        /// <returns> A new <see cref="Models.PrivateStorePlanDetails"/> instance for mocking. </returns>
        public static PrivateStorePlanDetails PrivateStorePlanDetails(string planId = null, PrivateStorePlanStatus? status = null, BinaryData requestDate = null, string justification = null, string subscriptionId = null, string subscriptionName = null)
        {
            return new PrivateStorePlanDetails(planId, status, requestDate, justification, subscriptionId, subscriptionName);
        }

        /// <summary> Initializes a new instance of QueryApprovalRequestResult. </summary>
        /// <param name="uniqueOfferId"> Gets or sets unique offer id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="eTag"> Gets or sets e-tag field. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <returns> A new <see cref="Models.QueryApprovalRequestResult"/> instance for mocking. </returns>
        public static QueryApprovalRequestResult QueryApprovalRequestResult(string uniqueOfferId = null, IReadOnlyDictionary<string, PrivateStorePlanDetails> plansDetails = null, ETag? eTag = null, long? messageCode = null)
        {
            plansDetails ??= new Dictionary<string, PrivateStorePlanDetails>();

            return new QueryApprovalRequestResult(uniqueOfferId, plansDetails, eTag, messageCode);
        }

        /// <summary> Initializes a new instance of MarketplaceAdminApprovalRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId"> Gets or sets offer Id. </param>
        /// <param name="displayName"> Gets display name. </param>
        /// <param name="publisherId"> Gets or sets publisher Id. </param>
        /// <param name="adminAction"> Gets or sets admin action. </param>
        /// <param name="approvedPlans"> Gets or sets Approved plans ids, empty in case of rejected. </param>
        /// <param name="comment"> Gets or sets admin comment. </param>
        /// <param name="administrator"> Gets or sets admin details. </param>
        /// <param name="plans"> Gets list of plans with requesters details. </param>
        /// <param name="collectionIds"> Gets or sets list of associated collection ids. </param>
        /// <param name="iconUri"> The offer icon url. </param>
        /// <returns> A new <see cref="Marketplace.MarketplaceAdminApprovalRequestData"/> instance for mocking. </returns>
        public static MarketplaceAdminApprovalRequestData MarketplaceAdminApprovalRequestData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string offerId = null, string displayName = null, string publisherId = null, MarketplaceAdminAction? adminAction = null, IEnumerable<string> approvedPlans = null, string comment = null, string administrator = null, IEnumerable<PlanRequesterDetails> plans = null, IEnumerable<Guid> collectionIds = null, Uri iconUri = null)
        {
            approvedPlans ??= new List<string>();
            plans ??= new List<PlanRequesterDetails>();
            collectionIds ??= new List<Guid>();

            return new MarketplaceAdminApprovalRequestData(id, name, resourceType, systemData, offerId, displayName, publisherId, adminAction, approvedPlans?.ToList(), comment, administrator, plans?.ToList(), collectionIds?.ToList(), iconUri);
        }

        /// <summary> Initializes a new instance of PlanRequesterDetails. </summary>
        /// <param name="planId"> Gets the plan id. </param>
        /// <param name="planDisplayName"> Gets the plan display name. </param>
        /// <param name="requesters"> Gets requesters details list. </param>
        /// <returns> A new <see cref="Models.PlanRequesterDetails"/> instance for mocking. </returns>
        public static PlanRequesterDetails PlanRequesterDetails(string planId = null, string planDisplayName = null, IEnumerable<PlanRequesterInfo> requesters = null)
        {
            requesters ??= new List<PlanRequesterInfo>();

            return new PlanRequesterDetails(planId, planDisplayName, requesters?.ToList());
        }

        /// <summary> Initializes a new instance of PlanRequesterInfo. </summary>
        /// <param name="user"> Gets user id. </param>
        /// <param name="date"> Gets request date. </param>
        /// <param name="justification"> Gets justification. </param>
        /// <param name="subscriptionId"> Gets the subscription id that the user is requesting to add the plan to. </param>
        /// <param name="subscriptionName"> Gets the subscription name that the user is requesting to add the plan to. </param>
        /// <returns> A new <see cref="Models.PlanRequesterInfo"/> instance for mocking. </returns>
        public static PlanRequesterInfo PlanRequesterInfo(string user = null, string date = null, string justification = null, string subscriptionId = null, string subscriptionName = null)
        {
            return new PlanRequesterInfo(user, date, justification, subscriptionId, subscriptionName);
        }

        /// <summary> Initializes a new instance of PrivateStoreNotificationsState. </summary>
        /// <param name="stopSellNotifications"></param>
        /// <param name="newNotifications"></param>
        /// <param name="approvalRequests"></param>
        /// <returns> A new <see cref="Models.PrivateStoreNotificationsState"/> instance for mocking. </returns>
        public static PrivateStoreNotificationsState PrivateStoreNotificationsState(IEnumerable<StopSellNotifications> stopSellNotifications = null, IEnumerable<NewPlanNotification> newNotifications = null, IEnumerable<RequestApprovalsDetails> approvalRequests = null)
        {
            stopSellNotifications ??= new List<StopSellNotifications>();
            newNotifications ??= new List<NewPlanNotification>();
            approvalRequests ??= new List<RequestApprovalsDetails>();

            return new PrivateStoreNotificationsState(stopSellNotifications?.ToList(), newNotifications?.ToList(), approvalRequests?.ToList());
        }

        /// <summary> Initializes a new instance of StopSellNotifications. </summary>
        /// <param name="offerId"> Gets offer id. </param>
        /// <param name="displayName"> Gets offer display name. </param>
        /// <param name="isEntire"> Gets a value indicating whether entire offer is in stop sell or only few of its plans. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="iconUri"> Gets or sets the icon url. </param>
        /// <param name="plans"> Gets or sets removed plans notifications. </param>
        /// <returns> A new <see cref="Models.StopSellNotifications"/> instance for mocking. </returns>
        public static StopSellNotifications StopSellNotifications(string offerId = null, string displayName = null, bool? isEntire = null, long? messageCode = null, Uri iconUri = null, IEnumerable<PlanNotificationDetails> plans = null)
        {
            plans ??= new List<PlanNotificationDetails>();

            return new StopSellNotifications(offerId, displayName, isEntire, messageCode, iconUri, plans?.ToList());
        }

        /// <summary> Initializes a new instance of PlanNotificationDetails. </summary>
        /// <param name="planId"> Gets or sets the plan id. </param>
        /// <param name="planDisplayName"> Gets or sets the plan display name. </param>
        /// <returns> A new <see cref="Models.PlanNotificationDetails"/> instance for mocking. </returns>
        public static PlanNotificationDetails PlanNotificationDetails(string planId = null, string planDisplayName = null)
        {
            return new PlanNotificationDetails(planId, planDisplayName);
        }

        /// <summary> Initializes a new instance of NewPlanNotification. </summary>
        /// <param name="offerId"> Gets offer id. </param>
        /// <param name="displayName"> Gets offer display name. </param>
        /// <param name="isFuturePlansEnabled"> Gets a value indicating whether future plans is enabled. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="iconUri"> Gets or sets the icon url. </param>
        /// <param name="plans"> Gets or sets removed plans notifications. </param>
        /// <returns> A new <see cref="Models.NewPlanNotification"/> instance for mocking. </returns>
        public static NewPlanNotification NewPlanNotification(string offerId = null, string displayName = null, bool? isFuturePlansEnabled = null, long? messageCode = null, Uri iconUri = null, IEnumerable<PlanNotificationDetails> plans = null)
        {
            plans ??= new List<PlanNotificationDetails>();

            return new NewPlanNotification(offerId, displayName, isFuturePlansEnabled, messageCode, iconUri, plans?.ToList());
        }

        /// <summary> Initializes a new instance of RequestApprovalsDetails. </summary>
        /// <param name="offerId"> Gets offer id. </param>
        /// <param name="displayName"> Gets offer display name. </param>
        /// <param name="publisherId"> Gets or sets publisher id. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="iconUri"> Gets or sets the icon url. </param>
        /// <param name="plans"> Gets or sets removed plans notifications. </param>
        /// <returns> A new <see cref="Models.RequestApprovalsDetails"/> instance for mocking. </returns>
        public static RequestApprovalsDetails RequestApprovalsDetails(string offerId = null, string displayName = null, string publisherId = null, long? messageCode = null, Uri iconUri = null, IEnumerable<PlanNotificationDetails> plans = null)
        {
            plans ??= new List<PlanNotificationDetails>();

            return new RequestApprovalsDetails(offerId, displayName, publisherId, messageCode, iconUri, plans?.ToList());
        }

        /// <summary> Initializes a new instance of MarketplaceSubscription. </summary>
        /// <param name="id"> The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="displayName"> The subscription display name. </param>
        /// <param name="state"> The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted. </param>
        /// <returns> A new <see cref="Models.MarketplaceSubscription"/> instance for mocking. </returns>
        public static MarketplaceSubscription MarketplaceSubscription(string id = null, string subscriptionId = null, string displayName = null, MarketplaceSubscriptionState? state = null)
        {
            return new MarketplaceSubscription(id, subscriptionId, displayName, state);
        }

        /// <summary> Initializes a new instance of NewPlanNotificationListResult. </summary>
        /// <param name="newPlansNotifications"></param>
        /// <returns> A new <see cref="Models.NewPlanNotificationListResult"/> instance for mocking. </returns>
        public static NewPlanNotificationListResult NewPlanNotificationListResult(IEnumerable<NewPlanNotification> newPlansNotifications = null)
        {
            newPlansNotifications ??= new List<NewPlanNotification>();

            return new NewPlanNotificationListResult(newPlansNotifications?.ToList());
        }

        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsList. </summary>
        /// <param name="stopSellNotifications"></param>
        /// <returns> A new <see cref="Models.StopSellOffersPlansNotificationsList"/> instance for mocking. </returns>
        public static StopSellOffersPlansNotificationsList StopSellOffersPlansNotificationsList(IEnumerable<StopSellOffersPlansNotificationsResult> stopSellNotifications = null)
        {
            stopSellNotifications ??= new List<StopSellOffersPlansNotificationsResult>();

            return new StopSellOffersPlansNotificationsList(stopSellNotifications?.ToList());
        }

        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsResult. </summary>
        /// <param name="offerId"> The offer id. </param>
        /// <param name="displayName"> The offer display name. </param>
        /// <param name="isEntireInStopSell"> A value indicating whether entire offer is in stop sell or only few of its plans. </param>
        /// <param name="messageCode"> The notification message code. </param>
        /// <param name="iconUri"> The icon url. </param>
        /// <param name="plans"> The list of removed plans notifications. </param>
        /// <param name="hasPublicContext"> True if the offer has public plans. </param>
        /// <param name="subscriptionsIds"> The subscriptions related to private plans. </param>
        /// <returns> A new <see cref="Models.StopSellOffersPlansNotificationsResult"/> instance for mocking. </returns>
        public static StopSellOffersPlansNotificationsResult StopSellOffersPlansNotificationsResult(string offerId = null, string displayName = null, bool? isEntireInStopSell = null, long? messageCode = null, Uri iconUri = null, IEnumerable<PlanNotificationDetails> plans = null, bool? hasPublicContext = null, IEnumerable<string> subscriptionsIds = null)
        {
            plans ??= new List<PlanNotificationDetails>();
            subscriptionsIds ??= new List<string>();

            return new StopSellOffersPlansNotificationsResult(offerId, displayName, isEntireInStopSell, messageCode, iconUri, plans?.ToList(), hasPublicContext, subscriptionsIds?.ToList());
        }

        /// <summary> Initializes a new instance of SubscriptionsContextList. </summary>
        /// <param name="subscriptionsIds"></param>
        /// <returns> A new <see cref="Models.SubscriptionsContextList"/> instance for mocking. </returns>
        public static SubscriptionsContextList SubscriptionsContextList(IEnumerable<string> subscriptionsIds = null)
        {
            subscriptionsIds ??= new List<string>();

            return new SubscriptionsContextList(subscriptionsIds?.ToList());
        }
    }
}
