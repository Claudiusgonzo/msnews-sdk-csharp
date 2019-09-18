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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftNewsApiContractsFeedItemViewV1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsFeedItemViewV1 class.
        /// </summary>
        public MicrosoftNewsApiContractsFeedItemViewV1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftNewsApiContractsFeedItemViewV1 class.
        /// </summary>
        public MicrosoftNewsApiContractsFeedItemViewV1(string id = default(string), string type = default(string), string section = default(string), string nextPageUrl = default(string), string title = default(string), string subTitle = default(string), string abstractProperty = default(string), string url = default(string), string locale = default(string), IList<MsnTagsDataModelTagEntityLibArtifactDataTag> topics = default(IList<MsnTagsDataModelTagEntityLibArtifactDataTag>), int? galleryItemCount = default(int?), MsnTagsDataModelTagEntityLibArtifactDataVideoMetadata videoMetadata = default(MsnTagsDataModelTagEntityLibArtifactDataVideoMetadata), MsnTagsDataModelTagEntityLibArtifactDataAudioMetadata audioMetadata = default(MsnTagsDataModelTagEntityLibArtifactDataAudioMetadata), IList<MsnTagsDataModelTagEntityLibArtifactDataExternalVideoFile> externalVideoFiles = default(IList<MsnTagsDataModelTagEntityLibArtifactDataExternalVideoFile>), IList<MsnTagsDataModelTagEntityLibArtifactDataImage> images = default(IList<MsnTagsDataModelTagEntityLibArtifactDataImage>), MicrosoftNewsApiContractsProviderSummaryView provider = default(MicrosoftNewsApiContractsProviderSummaryView), string category = default(string), string publishedDateTime = default(string), MicrosoftNewsApiContractsSourceFeedView feed = default(MicrosoftNewsApiContractsSourceFeedView), IList<MicrosoftNewsApiContractsFeedItemViewV1> subCards = default(IList<MicrosoftNewsApiContractsFeedItemViewV1>))
        {
            Id = id;
            Type = type;
            Section = section;
            NextPageUrl = nextPageUrl;
            Title = title;
            SubTitle = subTitle;
            AbstractProperty = abstractProperty;
            Url = url;
            Locale = locale;
            Topics = topics;
            GalleryItemCount = galleryItemCount;
            VideoMetadata = videoMetadata;
            AudioMetadata = audioMetadata;
            ExternalVideoFiles = externalVideoFiles;
            Images = images;
            Provider = provider;
            Category = category;
            PublishedDateTime = publishedDateTime;
            Feed = feed;
            SubCards = subCards;
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
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "section")]
        public string Section { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextPageUrl")]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subTitle")]
        public string SubTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abstract")]
        public string AbstractProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topics")]
        public IList<MsnTagsDataModelTagEntityLibArtifactDataTag> Topics { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "galleryItemCount")]
        public int? GalleryItemCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "videoMetadata")]
        public MsnTagsDataModelTagEntityLibArtifactDataVideoMetadata VideoMetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "audioMetadata")]
        public MsnTagsDataModelTagEntityLibArtifactDataAudioMetadata AudioMetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "externalVideoFiles")]
        public IList<MsnTagsDataModelTagEntityLibArtifactDataExternalVideoFile> ExternalVideoFiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<MsnTagsDataModelTagEntityLibArtifactDataImage> Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public MicrosoftNewsApiContractsProviderSummaryView Provider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedDateTime")]
        public string PublishedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feed")]
        public MicrosoftNewsApiContractsSourceFeedView Feed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subCards")]
        public IList<MicrosoftNewsApiContractsFeedItemViewV1> SubCards { get; set; }

    }
}
