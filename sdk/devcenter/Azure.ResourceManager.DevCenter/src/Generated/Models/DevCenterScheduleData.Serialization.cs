// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterScheduleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduledType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ScheduledType.Value.ToString());
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DevCenterScheduleData DeserializeDevCenterScheduleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevCenterScheduledType> type0 = default;
            Optional<DevCenterScheduledFrequency> frequency = default;
            Optional<string> time = default;
            Optional<string> timeZone = default;
            Optional<DevCenterScheduleEnableStatus> state = default;
            Optional<DevCenterProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new DevCenterScheduledType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = new DevCenterScheduledFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("time"u8))
                        {
                            time = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new DevCenterScheduleEnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DevCenterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DevCenterScheduleData(id, name, type, systemData.Value, Optional.ToNullable(type0), Optional.ToNullable(frequency), time.Value, timeZone.Value, Optional.ToNullable(state), Optional.ToNullable(provisioningState));
        }
    }
}
