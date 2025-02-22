// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Router Channel Configuration. </summary>
    public partial class AcsRouterChannelConfiguration
    {
        /// <summary> Initializes a new instance of AcsRouterChannelConfiguration. </summary>
        internal AcsRouterChannelConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AcsRouterChannelConfiguration. </summary>
        /// <param name="channelId"> Channel ID for Router Job. </param>
        /// <param name="capacityCostPerJob"> Capacity Cost Per Job for Router Job. </param>
        /// <param name="maxNumberOfJobs"> Max Number of Jobs for Router Job. </param>
        internal AcsRouterChannelConfiguration(string channelId, int? capacityCostPerJob, int? maxNumberOfJobs)
        {
            ChannelId = channelId;
            CapacityCostPerJob = capacityCostPerJob;
            MaxNumberOfJobs = maxNumberOfJobs;
        }

        /// <summary> Channel ID for Router Job. </summary>
        public string ChannelId { get; }
        /// <summary> Capacity Cost Per Job for Router Job. </summary>
        public int? CapacityCostPerJob { get; }
        /// <summary> Max Number of Jobs for Router Job. </summary>
        public int? MaxNumberOfJobs { get; }
    }
}
