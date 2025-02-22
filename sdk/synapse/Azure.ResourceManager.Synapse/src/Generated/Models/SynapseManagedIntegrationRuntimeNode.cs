// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Properties of integration runtime node. </summary>
    public partial class SynapseManagedIntegrationRuntimeNode
    {
        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntimeNode. </summary>
        internal SynapseManagedIntegrationRuntimeNode()
        {
            Errors = new ChangeTrackingList<SynapseManagedIntegrationRuntimeError>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntimeNode. </summary>
        /// <param name="nodeId"> The managed integration runtime node id. </param>
        /// <param name="status"> The managed integration runtime node status. </param>
        /// <param name="errors"> The errors that occurred on this integration runtime node. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SynapseManagedIntegrationRuntimeNode(string nodeId, SynapseManagedIntegrationRuntimeNodeStatus? status, IReadOnlyList<SynapseManagedIntegrationRuntimeError> errors, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            NodeId = nodeId;
            Status = status;
            Errors = errors;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The managed integration runtime node id. </summary>
        public string NodeId { get; }
        /// <summary> The managed integration runtime node status. </summary>
        public SynapseManagedIntegrationRuntimeNodeStatus? Status { get; }
        /// <summary> The errors that occurred on this integration runtime node. </summary>
        public IReadOnlyList<SynapseManagedIntegrationRuntimeError> Errors { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
