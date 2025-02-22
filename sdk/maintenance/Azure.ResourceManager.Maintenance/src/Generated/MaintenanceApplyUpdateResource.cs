// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary>
    /// A Class representing a MaintenanceApplyUpdate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MaintenanceApplyUpdateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMaintenanceApplyUpdateResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetMaintenanceApplyUpdate method.
    /// </summary>
    public partial class MaintenanceApplyUpdateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MaintenanceApplyUpdateResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string providerName, string resourceType, string resourceName, string applyUpdateName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _maintenanceApplyUpdateApplyUpdatesClientDiagnostics;
        private readonly ApplyUpdatesRestOperations _maintenanceApplyUpdateApplyUpdatesRestClient;
        private readonly MaintenanceApplyUpdateData _data;

        /// <summary> Initializes a new instance of the <see cref="MaintenanceApplyUpdateResource"/> class for mocking. </summary>
        protected MaintenanceApplyUpdateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MaintenanceApplyUpdateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MaintenanceApplyUpdateResource(ArmClient client, MaintenanceApplyUpdateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenanceApplyUpdateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MaintenanceApplyUpdateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _maintenanceApplyUpdateApplyUpdatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maintenance", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string maintenanceApplyUpdateApplyUpdatesApiVersion);
            _maintenanceApplyUpdateApplyUpdatesRestClient = new ApplyUpdatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, maintenanceApplyUpdateApplyUpdatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Maintenance/applyUpdates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MaintenanceApplyUpdateData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Track maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MaintenanceApplyUpdateResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateResource.Get");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Track maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MaintenanceApplyUpdateResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateResource.Get");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceApplyUpdateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Apply maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_CreateOrUpdateOrCancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ApplyUpdate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MaintenanceApplyUpdateResource>> UpdateAsync(WaitUntil waitUntil, MaintenanceApplyUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateResource.Update");
            scope.Start();
            try
            {
                var response = await _maintenanceApplyUpdateApplyUpdatesRestClient.CreateOrUpdateOrCancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MaintenanceArmOperation<MaintenanceApplyUpdateResource>(Response.FromValue(new MaintenanceApplyUpdateResource(Client, response), response.GetRawResponse()));
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
        /// Apply maintenance updates to resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{providerName}/{resourceType}/{resourceName}/providers/Microsoft.Maintenance/applyUpdates/{applyUpdateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplyUpdates_CreateOrUpdateOrCancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ApplyUpdate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MaintenanceApplyUpdateResource> Update(WaitUntil waitUntil, MaintenanceApplyUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceApplyUpdateApplyUpdatesClientDiagnostics.CreateScope("MaintenanceApplyUpdateResource.Update");
            scope.Start();
            try
            {
                var response = _maintenanceApplyUpdateApplyUpdatesRestClient.CreateOrUpdateOrCancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MaintenanceArmOperation<MaintenanceApplyUpdateResource>(Response.FromValue(new MaintenanceApplyUpdateResource(Client, response), response.GetRawResponse()));
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
    }
}
