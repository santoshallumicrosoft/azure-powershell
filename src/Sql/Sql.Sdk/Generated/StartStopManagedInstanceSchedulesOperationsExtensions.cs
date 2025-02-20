// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StartStopManagedInstanceSchedulesOperations.
    /// </summary>
    public static partial class StartStopManagedInstanceSchedulesOperationsExtensions
    {
            /// <summary>
            /// Lists the managed instance's Start/Stop schedules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static IPage<StartStopManagedInstanceSchedule> ListByInstance(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.ListByInstanceAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the managed instance's Start/Stop schedules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StartStopManagedInstanceSchedule>> ListByInstanceAsync(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static StartStopManagedInstanceSchedule Get(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StartStopManagedInstanceSchedule> GetAsync(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance Start/Stop schedule.
            /// </param>
            public static StartStopManagedInstanceSchedule CreateOrUpdate(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName, StartStopManagedInstanceSchedule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='parameters'>
            /// The requested managed instance Start/Stop schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StartStopManagedInstanceSchedule> CreateOrUpdateAsync(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName, StartStopManagedInstanceSchedule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            public static void Delete(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName)
            {
                operations.DeleteAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the managed instance's Start/Stop schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStartStopManagedInstanceSchedulesOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the managed instance's Start/Stop schedules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StartStopManagedInstanceSchedule> ListByInstanceNext(this IStartStopManagedInstanceSchedulesOperations operations, string nextPageLink)
            {
                return operations.ListByInstanceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the managed instance's Start/Stop schedules.
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
            public static async Task<IPage<StartStopManagedInstanceSchedule>> ListByInstanceNextAsync(this IStartStopManagedInstanceSchedulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
