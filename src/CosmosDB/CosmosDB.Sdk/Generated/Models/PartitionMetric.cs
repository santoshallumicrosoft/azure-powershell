// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// The metric values for a single partition.
    /// </summary>
    public partial class PartitionMetric : Metric
    {
        /// <summary>
        /// Initializes a new instance of the PartitionMetric class.
        /// </summary>
        public PartitionMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartitionMetric class.
        /// </summary>

        /// <param name="startTime">The start time for the metric (ISO-8601 format).
        /// </param>

        /// <param name="endTime">The end time for the metric (ISO-8601 format).
        /// </param>

        /// <param name="timeGrain">The time grain to be used to summarize the metric values.
        /// </param>

        /// <param name="unit">The unit of the metric.
        /// Possible values include: 'Count', 'Bytes', 'Seconds', 'Percent',
        /// 'CountPerSecond', 'BytesPerSecond', 'Milliseconds'</param>

        /// <param name="name">The name information for the metric.
        /// </param>

        /// <param name="metricValues">The metric values for the specified time window and timestep.
        /// </param>

        /// <param name="partitionId">The partition id (GUID identifier) of the metric values.
        /// </param>

        /// <param name="partitionKeyRangeId">The partition key range id (integer identifier) of the metric values.
        /// </param>
        public PartitionMetric(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string timeGrain = default(string), string unit = default(string), MetricName name = default(MetricName), System.Collections.Generic.IList<MetricValue> metricValues = default(System.Collections.Generic.IList<MetricValue>), string partitionId = default(string), string partitionKeyRangeId = default(string))

        : base(startTime, endTime, timeGrain, unit, name, metricValues)
        {
            this.PartitionId = partitionId;
            this.PartitionKeyRangeId = partitionKeyRangeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the partition id (GUID identifier) of the metric values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "partitionId")]
        public string PartitionId {get; private set; }

        /// <summary>
        /// Gets the partition key range id (integer identifier) of the metric values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "partitionKeyRangeId")]
        public string PartitionKeyRangeId {get; private set; }
    }
}