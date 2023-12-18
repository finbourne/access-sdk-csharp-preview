/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3552
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
    /// RoleResourceRequest
    /// </summary>
    [DataContract(Name = "RoleResourceRequest")]
    public partial class RoleResourceRequest : IEquatable<RoleResourceRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResourceRequest" /> class.
        /// </summary>
        /// <param name="nonTransitiveSupervisorRoleResource">nonTransitiveSupervisorRoleResource.</param>
        /// <param name="policyIdRoleResource">policyIdRoleResource.</param>
        public RoleResourceRequest(NonTransitiveSupervisorRoleResource nonTransitiveSupervisorRoleResource = default(NonTransitiveSupervisorRoleResource), PolicyIdRoleResource policyIdRoleResource = default(PolicyIdRoleResource))
        {
            this.NonTransitiveSupervisorRoleResource = nonTransitiveSupervisorRoleResource;
            this.PolicyIdRoleResource = policyIdRoleResource;
        }

        /// <summary>
        /// Gets or Sets NonTransitiveSupervisorRoleResource
        /// </summary>
        [DataMember(Name = "nonTransitiveSupervisorRoleResource", EmitDefaultValue = false)]
        public NonTransitiveSupervisorRoleResource NonTransitiveSupervisorRoleResource { get; set; }

        /// <summary>
        /// Gets or Sets PolicyIdRoleResource
        /// </summary>
        [DataMember(Name = "policyIdRoleResource", EmitDefaultValue = false)]
        public PolicyIdRoleResource PolicyIdRoleResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResourceRequest {\n");
            sb.Append("  NonTransitiveSupervisorRoleResource: ").Append(NonTransitiveSupervisorRoleResource).Append("\n");
            sb.Append("  PolicyIdRoleResource: ").Append(PolicyIdRoleResource).Append("\n");
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
            return this.Equals(input as RoleResourceRequest);
        }

        /// <summary>
        /// Returns true if RoleResourceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleResourceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResourceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NonTransitiveSupervisorRoleResource == input.NonTransitiveSupervisorRoleResource ||
                    (this.NonTransitiveSupervisorRoleResource != null &&
                    this.NonTransitiveSupervisorRoleResource.Equals(input.NonTransitiveSupervisorRoleResource))
                ) && 
                (
                    this.PolicyIdRoleResource == input.PolicyIdRoleResource ||
                    (this.PolicyIdRoleResource != null &&
                    this.PolicyIdRoleResource.Equals(input.PolicyIdRoleResource))
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
                if (this.NonTransitiveSupervisorRoleResource != null)
                    hashCode = hashCode * 59 + this.NonTransitiveSupervisorRoleResource.GetHashCode();
                if (this.PolicyIdRoleResource != null)
                    hashCode = hashCode * 59 + this.PolicyIdRoleResource.GetHashCode();
                return hashCode;
            }
        }

    }
}
