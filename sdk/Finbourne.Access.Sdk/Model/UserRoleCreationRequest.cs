/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2861
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Access.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Access.Sdk.Model
{
    /// <summary>
    /// Dto used to request creating a user&#39;s role
    /// </summary>
    [DataContract(Name = "UserRoleCreationRequest")]
    public partial class UserRoleCreationRequest : IEquatable<UserRoleCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRoleCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleCreationRequest" /> class.
        /// </summary>
        /// <param name="userId">The Id of the user for whom to create the role. (required).</param>
        /// <param name="resource">resource (required).</param>
        public UserRoleCreationRequest(string userId = default(string), PolicyIdRoleResource resource = default(PolicyIdRoleResource))
        {
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for UserRoleCreationRequest and cannot be null");
            // to ensure "resource" is required (not null)
            this.Resource = resource ?? throw new ArgumentNullException("resource is a required property for UserRoleCreationRequest and cannot be null");
        }

        /// <summary>
        /// The Id of the user for whom to create the role.
        /// </summary>
        /// <value>The Id of the user for whom to create the role.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        public PolicyIdRoleResource Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoleCreationRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserRoleCreationRequest);
        }

        /// <summary>
        /// Returns true if UserRoleCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRoleCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoleCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }

    }
}
