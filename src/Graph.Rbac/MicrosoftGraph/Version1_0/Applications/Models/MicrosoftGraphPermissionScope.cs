// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// permissionScope
    /// </summary>
    public partial class MicrosoftGraphPermissionScope
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphPermissionScope
        /// class.
        /// </summary>
        public MicrosoftGraphPermissionScope()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphPermissionScope
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="adminConsentDescription">A description of the
        /// delegated permissions, intended to be read by an administrator
        /// granting the permission on behalf of all users. This text appears
        /// in tenant-wide admin consent experiences.</param>
        /// <param name="adminConsentDisplayName">The permission's title,
        /// intended to be read by an administrator granting the permission on
        /// behalf of all users.</param>
        /// <param name="id">Unique delegated permission identifier inside the
        /// collection of delegated permissions defined for a resource
        /// application.</param>
        /// <param name="isEnabled">When creating or updating a permission,
        /// this property must be set to true (which is the default). To delete
        /// a permission, this property must first be set to false.  At that
        /// point, in a subsequent call, the permission may be removed.</param>
        /// <param name="type">Specifies whether this delegated permission
        /// should be considered safe for non-admin users to consent to on
        /// behalf of themselves, or whether an administrator should be
        /// required for consent to the permissions. This will be the default
        /// behavior, but each customer can choose to customize the behavior in
        /// their organization (by allowing, restricting or limiting user
        /// consent to this delegated permission.)</param>
        /// <param name="userConsentDescription">A description of the delegated
        /// permissions, intended to be read by a user granting the permission
        /// on their own behalf. This text appears in consent experiences where
        /// the user is consenting only on behalf of themselves.</param>
        /// <param name="userConsentDisplayName">A title for the permission,
        /// intended to be read by a user granting the permission on their own
        /// behalf. This text appears in consent experiences where the user is
        /// consenting only on behalf of themselves.</param>
        /// <param name="value">Specifies the value to include in the scp
        /// (scope) claim in access tokens. Must not exceed 120 characters in
        /// length. Allowed characters are : ! # $ % &amp; ' ( ) * + , - . / :
        /// ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges
        /// 0-9, A-Z and a-z. Any other character, including the space
        /// character, are not allowed. May not begin with ..</param>
        public MicrosoftGraphPermissionScope(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string adminConsentDescription = default(string), string adminConsentDisplayName = default(string), System.Guid? id = default(System.Guid?), bool? isEnabled = default(bool?), string origin = default(string), string type = default(string), string userConsentDescription = default(string), string userConsentDisplayName = default(string), string value = default(string))
        {
            AdditionalProperties = additionalProperties;
            AdminConsentDescription = adminConsentDescription;
            AdminConsentDisplayName = adminConsentDisplayName;
            Id = id;
            IsEnabled = isEnabled;
            Origin = origin;
            Type = type;
            UserConsentDescription = userConsentDescription;
            UserConsentDisplayName = userConsentDisplayName;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets a description of the delegated permissions, intended
        /// to be read by an administrator granting the permission on behalf of
        /// all users. This text appears in tenant-wide admin consent
        /// experiences.
        /// </summary>
        [JsonProperty(PropertyName = "adminConsentDescription")]
        public string AdminConsentDescription { get; set; }

        /// <summary>
        /// Gets or sets the permission's title, intended to be read by an
        /// administrator granting the permission on behalf of all users.
        /// </summary>
        [JsonProperty(PropertyName = "adminConsentDisplayName")]
        public string AdminConsentDisplayName { get; set; }

        /// <summary>
        /// Gets or sets unique delegated permission identifier inside the
        /// collection of delegated permissions defined for a resource
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets when creating or updating a permission, this property
        /// must be set to true (which is the default). To delete a permission,
        /// this property must first be set to false.  At that point, in a
        /// subsequent call, the permission may be removed.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this delegated permission should be
        /// considered safe for non-admin users to consent to on behalf of
        /// themselves, or whether an administrator should be required for
        /// consent to the permissions. This will be the default behavior, but
        /// each customer can choose to customize the behavior in their
        /// organization (by allowing, restricting or limiting user consent to
        /// this delegated permission.)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a description of the delegated permissions, intended
        /// to be read by a user granting the permission on their own behalf.
        /// This text appears in consent experiences where the user is
        /// consenting only on behalf of themselves.
        /// </summary>
        [JsonProperty(PropertyName = "userConsentDescription")]
        public string UserConsentDescription { get; set; }

        /// <summary>
        /// Gets or sets a title for the permission, intended to be read by a
        /// user granting the permission on their own behalf. This text appears
        /// in consent experiences where the user is consenting only on behalf
        /// of themselves.
        /// </summary>
        [JsonProperty(PropertyName = "userConsentDisplayName")]
        public string UserConsentDisplayName { get; set; }

        /// <summary>
        /// Gets or sets specifies the value to include in the scp (scope)
        /// claim in access tokens. Must not exceed 120 characters in length.
        /// Allowed characters are : ! # $ % &amp;amp; ' ( ) * + , - . / : ;  =
        /// ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z
        /// and a-z. Any other character, including the space character, are
        /// not allowed. May not begin with ..
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}