// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    internal class CosmosDBForPostgreSqlPrivateEndpointConnectionOperationSource : IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBForPostgreSqlPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBForPostgreSqlPrivateEndpointConnectionResource IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBForPostgreSqlPrivateEndpointConnectionData.DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(document.RootElement);
            return new CosmosDBForPostgreSqlPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<CosmosDBForPostgreSqlPrivateEndpointConnectionResource> IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBForPostgreSqlPrivateEndpointConnectionData.DeserializeCosmosDBForPostgreSqlPrivateEndpointConnectionData(document.RootElement);
            return new CosmosDBForPostgreSqlPrivateEndpointConnectionResource(_client, data);
        }
    }
}
