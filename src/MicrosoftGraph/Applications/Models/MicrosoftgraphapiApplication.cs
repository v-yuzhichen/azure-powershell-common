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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// apiApplication
    /// </summary>
    public partial class MicrosoftgraphapiApplication
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphapiApplication
        /// class.
        /// </summary>
        public MicrosoftgraphapiApplication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphapiApplication
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="acceptMappedClaims">When true, allows an application
        /// to use claims mapping without specifying a custom signing
        /// key.</param>
        /// <param name="knownClientApplications">Used for bundling consent if
        /// you have a solution that contains two parts: a client app and a
        /// custom web API app. If you set the appID of the client app to this
        /// value, the user only consents once to the client app. Azure AD
        /// knows that consenting to the client means implicitly consenting to
        /// the web API and automatically provisions service principals for
        /// both APIs at the same time. Both the client and the web API app
        /// must be registered in the same tenant.</param>
        /// <param name="oauth2PermissionScopes">The definition of the
        /// delegated permissions exposed by the web API represented by this
        /// application registration. These delegated permissions may be
        /// requested by a client application, and may be granted by users or
        /// administrators during consent. Delegated permissions are sometimes
        /// referred to as OAuth 2.0 scopes.</param>
        /// <param name="preAuthorizedApplications">Lists the client
        /// applications that are pre-authorized with the specified delegated
        /// permissions to access this application's APIs. Users are not
        /// required to consent to any pre-authorized application (for the
        /// permissions specified). However, any additional permissions not
        /// listed in preAuthorizedApplications (requested through incremental
        /// consent for example) will require user consent.</param>
        /// <param name="requestedAccessTokenVersion">Specifies the access
        /// token version expected by this resource. This changes the version
        /// and format of the JWT produced independent of the endpoint or
        /// client used to request the access token.  The endpoint used, v1.0
        /// or v2.0, is chosen by the client and only impacts the version of
        /// id_tokens. Resources need to explicitly configure
        /// requestedAccessTokenVersion to indicate the supported access token
        /// format.  Possible values for requestedAccessTokenVersion are 1, 2,
        /// or null. If the value is null, this defaults to 1, which
        /// corresponds to the v1.0 endpoint.  If signInAudience on the
        /// application is configured as AzureADandPersonalMicrosoftAccount,
        /// the value for this property must be 2</param>
        public MicrosoftgraphapiApplication(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), bool? acceptMappedClaims = default(bool?), IList<System.Guid?> knownClientApplications = default(IList<System.Guid?>), IList<MicrosoftgraphpermissionScope> oauth2PermissionScopes = default(IList<MicrosoftgraphpermissionScope>), IList<MicrosoftgraphpreAuthorizedApplication> preAuthorizedApplications = default(IList<MicrosoftgraphpreAuthorizedApplication>), int? requestedAccessTokenVersion = default(int?))
        {
            AdditionalProperties = additionalProperties;
            AcceptMappedClaims = acceptMappedClaims;
            KnownClientApplications = knownClientApplications;
            Oauth2PermissionScopes = oauth2PermissionScopes;
            PreAuthorizedApplications = preAuthorizedApplications;
            RequestedAccessTokenVersion = requestedAccessTokenVersion;
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
        /// Gets or sets when true, allows an application to use claims mapping
        /// without specifying a custom signing key.
        /// </summary>
        [JsonProperty(PropertyName = "acceptMappedClaims")]
        public bool? AcceptMappedClaims { get; set; }

        /// <summary>
        /// Gets or sets used for bundling consent if you have a solution that
        /// contains two parts: a client app and a custom web API app. If you
        /// set the appID of the client app to this value, the user only
        /// consents once to the client app. Azure AD knows that consenting to
        /// the client means implicitly consenting to the web API and
        /// automatically provisions service principals for both APIs at the
        /// same time. Both the client and the web API app must be registered
        /// in the same tenant.
        /// </summary>
        [JsonProperty(PropertyName = "knownClientApplications")]
        public IList<System.Guid?> KnownClientApplications { get; set; }

        /// <summary>
        /// Gets or sets the definition of the delegated permissions exposed by
        /// the web API represented by this application registration. These
        /// delegated permissions may be requested by a client application, and
        /// may be granted by users or administrators during consent. Delegated
        /// permissions are sometimes referred to as OAuth 2.0 scopes.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2PermissionScopes")]
        public IList<MicrosoftgraphpermissionScope> Oauth2PermissionScopes { get; set; }

        /// <summary>
        /// Gets or sets lists the client applications that are pre-authorized
        /// with the specified delegated permissions to access this
        /// application's APIs. Users are not required to consent to any
        /// pre-authorized application (for the permissions specified).
        /// However, any additional permissions not listed in
        /// preAuthorizedApplications (requested through incremental consent
        /// for example) will require user consent.
        /// </summary>
        [JsonProperty(PropertyName = "preAuthorizedApplications")]
        public IList<MicrosoftgraphpreAuthorizedApplication> PreAuthorizedApplications { get; set; }

        /// <summary>
        /// Gets or sets specifies the access token version expected by this
        /// resource. This changes the version and format of the JWT produced
        /// independent of the endpoint or client used to request the access
        /// token.  The endpoint used, v1.0 or v2.0, is chosen by the client
        /// and only impacts the version of id_tokens. Resources need to
        /// explicitly configure requestedAccessTokenVersion to indicate the
        /// supported access token format.  Possible values for
        /// requestedAccessTokenVersion are 1, 2, or null. If the value is
        /// null, this defaults to 1, which corresponds to the v1.0 endpoint.
        /// If signInAudience on the application is configured as
        /// AzureADandPersonalMicrosoftAccount, the value for this property
        /// must be 2
        /// </summary>
        [JsonProperty(PropertyName = "requestedAccessTokenVersion")]
        public int? RequestedAccessTokenVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RequestedAccessTokenVersion > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RequestedAccessTokenVersion", 2147483647);
            }
            if (RequestedAccessTokenVersion < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RequestedAccessTokenVersion", -2147483648);
            }
        }
    }
}
