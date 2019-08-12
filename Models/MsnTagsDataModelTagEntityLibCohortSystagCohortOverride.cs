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

    public partial class MsnTagsDataModelTagEntityLibCohortSystagCohortOverride
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibCohortSystagCohortOverride class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibCohortSystagCohortOverride()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibCohortSystagCohortOverride class.
        /// </summary>
        /// <param name="editorsPickListCmsIds">Gets or sets a list of editor
        /// curated Ids</param>
        /// <param name="topOnEditorsPickList">Gets or sets first x
        /// items</param>
        /// <param name="artifactPicks">Gets or sets the artifact picks, name
        /// to system collection id mapping</param>
        public MsnTagsDataModelTagEntityLibCohortSystagCohortOverride(IList<string> editorsPickListCmsIds = default(IList<string>), long? topOnEditorsPickList = default(long?), IDictionary<string, string> artifactPicks = default(IDictionary<string, string>))
        {
            EditorsPickListCmsIds = editorsPickListCmsIds;
            TopOnEditorsPickList = topOnEditorsPickList;
            ArtifactPicks = artifactPicks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of editor curated Ids
        /// </summary>
        [JsonProperty(PropertyName = "editorsPickListCmsIds")]
        public IList<string> EditorsPickListCmsIds { get; set; }

        /// <summary>
        /// Gets or sets first x items
        /// </summary>
        [JsonProperty(PropertyName = "topOnEditorsPickList")]
        public long? TopOnEditorsPickList { get; set; }

        /// <summary>
        /// Gets or sets the artifact picks, name to system collection id
        /// mapping
        /// </summary>
        [JsonProperty(PropertyName = "artifactPicks")]
        public IDictionary<string, string> ArtifactPicks { get; set; }

    }
}
