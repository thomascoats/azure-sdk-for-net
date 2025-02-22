// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="ScalingPlanPooledScheduleResource" /> and their operations.
    /// Each <see cref="ScalingPlanPooledScheduleResource" /> in the collection will belong to the same instance of <see cref="ScalingPlanResource" />.
    /// To get a <see cref="ScalingPlanPooledScheduleCollection" /> instance call the GetScalingPlanPooledSchedules method from an instance of <see cref="ScalingPlanResource" />.
    /// </summary>
    public partial class ScalingPlanPooledScheduleCollection : ArmCollection, IEnumerable<ScalingPlanPooledScheduleResource>, IAsyncEnumerable<ScalingPlanPooledScheduleResource>
    {
        private readonly ClientDiagnostics _scalingPlanPooledScheduleClientDiagnostics;
        private readonly ScalingPlanPooledSchedulesRestOperations _scalingPlanPooledScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanPooledScheduleCollection"/> class for mocking. </summary>
        protected ScalingPlanPooledScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanPooledScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScalingPlanPooledScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scalingPlanPooledScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ScalingPlanPooledScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScalingPlanPooledScheduleResource.ResourceType, out string scalingPlanPooledScheduleApiVersion);
            _scalingPlanPooledScheduleRestClient = new ScalingPlanPooledSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scalingPlanPooledScheduleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ScalingPlanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ScalingPlanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a ScalingPlanPooledSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="data"> Object containing ScalingPlanPooledSchedule definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScalingPlanPooledScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scalingPlanScheduleName, ScalingPlanPooledScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scalingPlanPooledScheduleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanPooledScheduleResource>(Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a ScalingPlanPooledSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="data"> Object containing ScalingPlanPooledSchedule definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScalingPlanPooledScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string scalingPlanScheduleName, ScalingPlanPooledScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scalingPlanPooledScheduleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, data, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanPooledScheduleResource>(Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ScalingPlanPooledSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<Response<ScalingPlanPooledScheduleResource>> GetAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _scalingPlanPooledScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ScalingPlanPooledSchedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual Response<ScalingPlanPooledScheduleResource> Get(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _scalingPlanPooledScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ScalingPlanPooledSchedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlanPooledScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScalingPlanPooledScheduleResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanPooledScheduleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanPooledScheduleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanPooledScheduleResource(Client, ScalingPlanPooledScheduleData.DeserializeScalingPlanPooledScheduleData(e)), _scalingPlanPooledScheduleClientDiagnostics, Pipeline, "ScalingPlanPooledScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ScalingPlanPooledSchedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlanPooledScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScalingPlanPooledScheduleResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanPooledScheduleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanPooledScheduleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanPooledScheduleResource(Client, ScalingPlanPooledScheduleData.DeserializeScalingPlanPooledScheduleData(e)), _scalingPlanPooledScheduleClientDiagnostics, Pipeline, "ScalingPlanPooledScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scalingPlanPooledScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _scalingPlanPooledScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScalingPlanPooledScheduleResource>> GetIfExistsAsync(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scalingPlanPooledScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScalingPlanPooledScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}/pooledSchedules/{scalingPlanScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlanPooledSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanScheduleName"> The name of the ScalingPlanSchedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanScheduleName"/> is null. </exception>
        public virtual NullableResponse<ScalingPlanPooledScheduleResource> GetIfExists(string scalingPlanScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanScheduleName, nameof(scalingPlanScheduleName));

            using var scope = _scalingPlanPooledScheduleClientDiagnostics.CreateScope("ScalingPlanPooledScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scalingPlanPooledScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scalingPlanScheduleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScalingPlanPooledScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanPooledScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScalingPlanPooledScheduleResource> IEnumerable<ScalingPlanPooledScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScalingPlanPooledScheduleResource> IAsyncEnumerable<ScalingPlanPooledScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
