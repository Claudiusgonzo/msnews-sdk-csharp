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

    public partial class MicrosoftNewsApiContractsSourceFeedView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsSourceFeedView class.
        /// </summary>
        public MicrosoftNewsApiContractsSourceFeedView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsSourceFeedView class.
        /// </summary>
        /// <param name="id">The unique identifier for the Feed</param>
        /// <param name="feedName">The name of the feed</param>
        public MicrosoftNewsApiContractsSourceFeedView(string id = default(string), string feedName = default(string))
        {
            Id = id;
            FeedName = feedName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier for the Feed
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the feed
        /// </summary>
        [JsonProperty(PropertyName = "feedName")]
        public string FeedName { get; set; }

    }
}