// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ElasticPoolsOperations
    /// </summary>
    public static partial class ElasticPoolsOperationsExtensions
    {
        /// <summary>
        /// Returns elastic pool  metrics.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='filter'>
        /// An OData filter expression that describes a subset of metrics to return.
        /// </param>
        public static System.Collections.Generic.IEnumerable<Metric> ListMetrics(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string filter)
        {
                return ((IElasticPoolsOperations)operations).ListMetricsAsync(resourceGroupName, serverName, elasticPoolName, filter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Returns elastic pool  metrics.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='filter'>
        /// An OData filter expression that describes a subset of metrics to return.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Metric>> ListMetricsAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string filter, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, filter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Returns elastic pool metric definitions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static System.Collections.Generic.IEnumerable<MetricDefinition> ListMetricDefinitions(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                return ((IElasticPoolsOperations)operations).ListMetricDefinitionsAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Returns elastic pool metric definitions.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MetricDefinition>> ListMetricDefinitionsAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all elastic pools in a server.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ElasticPool> ListByServer(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, long? skip = default(long?))
        {
                return ((IElasticPoolsOperations)operations).ListByServerAsync(resourceGroupName, serverName, skip).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all elastic pools in a server.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ElasticPool>> ListByServerAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, skip, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static ElasticPool Get(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                return ((IElasticPoolsOperations)operations).GetAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ElasticPool> GetAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static ElasticPool CreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
        {
                return ((IElasticPoolsOperations)operations).CreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ElasticPool> CreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static void Delete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                ((IElasticPoolsOperations)operations).DeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static ElasticPool Update(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters)
        {
                return ((IElasticPoolsOperations)operations).UpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ElasticPool> UpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Failovers an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool to failover.
        /// </param>
        public static void Failover(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                ((IElasticPoolsOperations)operations).FailoverAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Failovers an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool to failover.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task FailoverAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.FailoverWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Creates or updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static ElasticPool BeginCreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters)
        {
                return ((IElasticPoolsOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ElasticPool> BeginCreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPool parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static void BeginDelete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                ((IElasticPoolsOperations)operations).BeginDeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        public static ElasticPool BeginUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters)
        {
                return ((IElasticPoolsOperations)operations).BeginUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ElasticPool> BeginUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolUpdate parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Failovers an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool to failover.
        /// </param>
        public static void BeginFailover(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
        {
                ((IElasticPoolsOperations)operations).BeginFailoverAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Failovers an elastic pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='elasticPoolName'>
        /// The name of the elastic pool to failover.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginFailoverAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginFailoverWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets all elastic pools in a server.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ElasticPool> ListByServerNext(this IElasticPoolsOperations operations, string nextPageLink)
        {
                return ((IElasticPoolsOperations)operations).ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all elastic pools in a server.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ElasticPool>> ListByServerNextAsync(this IElasticPoolsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
