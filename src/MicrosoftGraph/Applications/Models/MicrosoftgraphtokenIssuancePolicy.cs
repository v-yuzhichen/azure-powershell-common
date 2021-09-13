// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.MicrosoftGraph.Applications.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphtokenIssuancePolicy : MicrosoftgraphstsPolicy
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtokenIssuancePolicy
        /// class.
        /// </summary>
        public MicrosoftgraphtokenIssuancePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtokenIssuancePolicy
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="description">Description for this policy.</param>
        /// <param name="displayName">Display name for this policy.</param>
        /// <param name="definition">A string collection containing a JSON
        /// string that defines the rules and settings for a policy. The syntax
        /// for the definition differs for each derived policy type.
        /// Required.</param>
        /// <param name="isOrganizationDefault">If set to true, activates this
        /// policy. There can be many policies for the same policy type, but
        /// only one can be activated as the organization default. Optional,
        /// default value is false.</param>
        public MicrosoftgraphtokenIssuancePolicy(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), System.DateTime? deletedDateTime = default(System.DateTime?), string description = default(string), string displayName = default(string), IList<MicrosoftgraphdirectoryObject> appliesTo = default(IList<MicrosoftgraphdirectoryObject>), IList<string> definition = default(IList<string>), bool? isOrganizationDefault = default(bool?))
            : base(additionalProperties, id, deletedDateTime, description, displayName, appliesTo, definition, isOrganizationDefault)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
