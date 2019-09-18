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

    public partial class MsnTagsDataModelTagEntityLibArtifactDataImage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataImage class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataImage class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataImage(int? width = default(int?), int? height = default(int?), int? quality = default(int?), string url = default(string), string attribution = default(string), string title = default(string), MsnTagsDataModelTagEntityLibArtifactDataFocalRegion focalRegion = default(MsnTagsDataModelTagEntityLibArtifactDataFocalRegion), string source = default(string))
        {
            Width = width;
            Height = height;
            Quality = quality;
            Url = url;
            Attribution = attribution;
            Title = title;
            FocalRegion = focalRegion;
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public int? Quality { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attribution")]
        public string Attribution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "focalRegion")]
        public MsnTagsDataModelTagEntityLibArtifactDataFocalRegion FocalRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

    }
}
