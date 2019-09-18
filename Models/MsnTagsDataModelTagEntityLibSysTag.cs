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

    public partial class MsnTagsDataModelTagEntityLibSysTag
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibSysTag class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibSysTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibSysTag class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibSysTag(string sourceType = default(string), bool? isEnabled = default(bool?), string feedStreamCmsId = default(string), IList<string> labels = default(IList<string>), IList<string> editorsPickListCmsIds = default(IList<string>), IList<string> cmsODataQuerys = default(IList<string>), long? topOnEditorsPickList = default(long?), IDictionary<string, string> artifactPicks = default(IDictionary<string, string>), IList<string> synonyms = default(IList<string>), IList<string> relatedFeedIds = default(IList<string>), bool? isEditorCurationEnabled = default(bool?), bool? isAutoCurationEnabled = default(bool?), bool? isBingBackfillEnabled = default(bool?), bool? isMsnBackfillEnabled = default(bool?), bool? isCmsODataQueryEnabled = default(bool?), bool? isSuggestionEnabled = default(bool?), bool? isLocation = default(bool?), MsnTagsDataModelTagEntityLibArtifactDataImage image = default(MsnTagsDataModelTagEntityLibArtifactDataImage), int? sourceIndex = default(int?), int? startRound = default(int?), int? endRound = default(int?), int? takePerRound = default(int?), bool? isTopStory = default(bool?), IList<string> cmsSourceIds = default(IList<string>), MsnTagsDataModelTagEntityLibLocation location = default(MsnTagsDataModelTagEntityLibLocation), IList<MsnTagsDataModelTagEntityLibLocation> locations = default(IList<MsnTagsDataModelTagEntityLibLocation>), int? popularity = default(int?), string originalSource = default(string), IDictionary<string, MsnTagsDataModelTagEntityLibCohortSystagCohortOverride> cohortOverride = default(IDictionary<string, MsnTagsDataModelTagEntityLibCohortSystagCohortOverride>), string canonicalName = default(string), string lowercaseName = default(string), string feedType = default(string), string name = default(string), string ownerId = default(string), long? itemCount = default(long?), string type = default(string), string url = default(string), string sourceHref = default(string), string locale = default(string), string adaptiveCard = default(string), string createdDateTime = default(string), string updatedDateTime = default(string), bool? deleted = default(bool?), string _et = default(string), string id = default(string), string _t = default(string))
        {
            SourceType = sourceType;
            IsEnabled = isEnabled;
            FeedStreamCmsId = feedStreamCmsId;
            Labels = labels;
            EditorsPickListCmsIds = editorsPickListCmsIds;
            CmsODataQuerys = cmsODataQuerys;
            TopOnEditorsPickList = topOnEditorsPickList;
            ArtifactPicks = artifactPicks;
            Synonyms = synonyms;
            RelatedFeedIds = relatedFeedIds;
            IsEditorCurationEnabled = isEditorCurationEnabled;
            IsAutoCurationEnabled = isAutoCurationEnabled;
            IsBingBackfillEnabled = isBingBackfillEnabled;
            IsMsnBackfillEnabled = isMsnBackfillEnabled;
            IsCmsODataQueryEnabled = isCmsODataQueryEnabled;
            IsSuggestionEnabled = isSuggestionEnabled;
            IsLocation = isLocation;
            Image = image;
            SourceIndex = sourceIndex;
            StartRound = startRound;
            EndRound = endRound;
            TakePerRound = takePerRound;
            IsTopStory = isTopStory;
            CmsSourceIds = cmsSourceIds;
            Location = location;
            Locations = locations;
            Popularity = popularity;
            OriginalSource = originalSource;
            CohortOverride = cohortOverride;
            CanonicalName = canonicalName;
            LowercaseName = lowercaseName;
            FeedType = feedType;
            Name = name;
            OwnerId = ownerId;
            ItemCount = itemCount;
            Type = type;
            Url = url;
            SourceHref = sourceHref;
            Locale = locale;
            AdaptiveCard = adaptiveCard;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            Deleted = deleted;
            this._et = _et;
            Id = id;
            this._t = _t;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceType")]
        public string SourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedStreamCmsId")]
        public string FeedStreamCmsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "editorsPickListCmsIds")]
        public IList<string> EditorsPickListCmsIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cmsODataQuerys")]
        public IList<string> CmsODataQuerys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topOnEditorsPickList")]
        public long? TopOnEditorsPickList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "artifactPicks")]
        public IDictionary<string, string> ArtifactPicks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "synonyms")]
        public IList<string> Synonyms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedFeedIds")]
        public IList<string> RelatedFeedIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isEditorCurationEnabled")]
        public bool? IsEditorCurationEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAutoCurationEnabled")]
        public bool? IsAutoCurationEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isBingBackfillEnabled")]
        public bool? IsBingBackfillEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isMsnBackfillEnabled")]
        public bool? IsMsnBackfillEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCmsODataQueryEnabled")]
        public bool? IsCmsODataQueryEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSuggestionEnabled")]
        public bool? IsSuggestionEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isLocation")]
        public bool? IsLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public MsnTagsDataModelTagEntityLibArtifactDataImage Image { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceIndex")]
        public int? SourceIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startRound")]
        public int? StartRound { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endRound")]
        public int? EndRound { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "takePerRound")]
        public int? TakePerRound { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isTopStory")]
        public bool? IsTopStory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cmsSourceIds")]
        public IList<string> CmsSourceIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public MsnTagsDataModelTagEntityLibLocation Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<MsnTagsDataModelTagEntityLibLocation> Locations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "popularity")]
        public int? Popularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originalSource")]
        public string OriginalSource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cohortOverride")]
        public IDictionary<string, MsnTagsDataModelTagEntityLibCohortSystagCohortOverride> CohortOverride { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canonicalName")]
        public string CanonicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lowercaseName")]
        public string LowercaseName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedType")]
        public string FeedType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public string OwnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemCount")]
        public long? ItemCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceHref")]
        public string SourceHref { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveCard")]
        public string AdaptiveCard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_et")]
        public string _et { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_t")]
        public string _t { get; set; }

    }
}
