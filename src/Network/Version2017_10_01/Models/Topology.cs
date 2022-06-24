// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Topology of the specified resource group.
    /// </summary>
    public partial class Topology
    {
        /// <summary>
        /// Initializes a new instance of the Topology class.
        /// </summary>
        public Topology()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Topology class.
        /// </summary>
        /// <param name="id">GUID representing the operation id.</param>
        /// <param name="createdDateTime">The datetime when the topology was
        /// initially created for the resource group.</param>
        /// <param name="lastModified">The datetime when the topology was last
        /// modified.</param>
        /// <param name="resources"></param>
        public Topology(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), IList<TopologyResource> resources = default(IList<TopologyResource>))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastModified = lastModified;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets GUID representing the operation id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the datetime when the topology was initially created for the
        /// resource group.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets the datetime when the topology was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<TopologyResource> Resources { get; set; }

    }
}
