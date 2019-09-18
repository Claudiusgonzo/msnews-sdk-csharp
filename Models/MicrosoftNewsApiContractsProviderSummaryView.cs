// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MicrosoftNewsAPI.SDK.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftNewsApiContractsProviderSummaryView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsProviderSummaryView class.
        /// </summary>
        public MicrosoftNewsApiContractsProviderSummaryView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsProviderSummaryView class.
        /// </summary>
        public MicrosoftNewsApiContractsProviderSummaryView(string id = default(string), string name = default(string), string logoUrl = default(string))
        {
            Id = id;
            Name = name;
            LogoUrl = logoUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logoUrl")]
        public string LogoUrl { get; set; }

    }
}
