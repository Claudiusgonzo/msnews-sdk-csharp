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

    public partial class MsnTagsDataModelTagEntityLibArtifactDataTag
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataTag class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataTag class.
        /// </summary>
        /// <param name="label">Gets or sets Label</param>
        /// <param name="weight">Gets or sets Weight</param>
        /// <param name="feedId">Gets or sets FeedId</param>
        /// <param name="locale">Gets or sets the locale.</param>
        public MsnTagsDataModelTagEntityLibArtifactDataTag(string label = default(string), double? weight = default(double?), string feedId = default(string), string locale = default(string))
        {
            Label = label;
            Weight = weight;
            FeedId = feedId;
            Locale = locale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets Weight
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or sets FeedId
        /// </summary>
        [JsonProperty(PropertyName = "feedId")]
        public string FeedId { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
