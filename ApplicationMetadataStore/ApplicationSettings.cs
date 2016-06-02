﻿using Microsoft.Research.MultiWorldTesting.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationMetadataStore
{
    public class ApplicationSettings
    {
        public string SubscriptionId { get; set; }

        public string AzureResourceGroupName { get; set; }
        public DecisionType DecisionType { get; set; }

        public int? NumActions { get; set; }

        public TrainFrequency TrainFrequency { get; set; }

        public string TrainArguments { get; set; }

        public string ApplicationID { get; set; }

        public string ConnectionString { get; set; }

        public string InterEventHubSendConnectionString { get; set; }

        public string ObserEventHubSendConnectionString { get; set; }

        public string ModelId { get; set; }

        public bool IsExplorationEnabled { get; set; }

        public int ExperimentalUnitDuration { get; set; }

        public string ModelBlobUri { get; set; }

        public string SettingsBlobUri { get; set; }
    }
}