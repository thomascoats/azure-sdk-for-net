// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapPropertiesDestinationsItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DestinationType))
            {
                writer.WritePropertyName("destinationType"u8);
                writer.WriteStringValue(DestinationType.Value.ToString());
            }
            if (Optional.IsDefined(DestinationId))
            {
                writer.WritePropertyName("destinationId"u8);
                writer.WriteStringValue(DestinationId);
            }
            if (Optional.IsDefined(IsolationDomainProperties))
            {
                writer.WritePropertyName("isolationDomainProperties"u8);
                writer.WriteObjectValue(IsolationDomainProperties);
            }
            if (Optional.IsDefined(DestinationTapRuleId))
            {
                writer.WritePropertyName("destinationTapRuleId"u8);
                writer.WriteStringValue(DestinationTapRuleId);
            }
            writer.WriteEndObject();
        }

        internal static NetworkTapPropertiesDestinationsItem DeserializeNetworkTapPropertiesDestinationsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<NetworkTapDestinationType> destinationType = default;
            Optional<ResourceIdentifier> destinationId = default;
            Optional<IsolationDomainProperties> isolationDomainProperties = default;
            Optional<ResourceIdentifier> destinationTapRuleId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationType = new NetworkTapDestinationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("destinationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isolationDomainProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationDomainProperties = IsolationDomainProperties.DeserializeIsolationDomainProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("destinationTapRuleId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationTapRuleId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new NetworkTapPropertiesDestinationsItem(name.Value, Optional.ToNullable(destinationType), destinationId.Value, isolationDomainProperties.Value, destinationTapRuleId.Value);
        }
    }
}
