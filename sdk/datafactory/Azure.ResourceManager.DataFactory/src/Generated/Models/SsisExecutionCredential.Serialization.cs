// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisExecutionCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domain"u8);
            JsonSerializer.Serialize(writer, Domain);
            writer.WritePropertyName("userName"u8);
            JsonSerializer.Serialize(writer, UserName);
            writer.WritePropertyName("password"u8);
            JsonSerializer.Serialize(writer, Password);
            writer.WriteEndObject();
        }

        internal static SsisExecutionCredential DeserializeSsisExecutionCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> domain = default;
            DataFactoryElement<string> userName = default;
            DataFactorySecretString password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = JsonSerializer.Deserialize<DataFactorySecretString>(property.Value.GetRawText());
                    continue;
                }
            }
            return new SsisExecutionCredential(domain, userName, password);
        }
    }
}
