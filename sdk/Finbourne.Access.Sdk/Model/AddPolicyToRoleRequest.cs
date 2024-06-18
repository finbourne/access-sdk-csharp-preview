/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3853
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
    /// Request body used to add Policies to a Role
    /// </summary>
    [DataContract(Name = "AddPolicyToRoleRequest")]
    public partial class AddPolicyToRoleRequest : IEquatable<AddPolicyToRoleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyToRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddPolicyToRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyToRoleRequest" /> class.
        /// </summary>
        /// <param name="policies">Identifiers of policies to add to a role (required).</param>
        public AddPolicyToRoleRequest(List<PolicyId> policies = default(List<PolicyId>))
        {
            // to ensure "policies" is required (not null)
            this.Policies = policies ?? throw new ArgumentNullException("policies is a required property for AddPolicyToRoleRequest and cannot be null");
        }

        /// <summary>
        /// Identifiers of policies to add to a role
        /// </summary>
        /// <value>Identifiers of policies to add to a role</value>
        [DataMember(Name = "policies", IsRequired = true, EmitDefaultValue = false)]
        public List<PolicyId> Policies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPolicyToRoleRequest {\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as AddPolicyToRoleRequest);
        }

        /// <summary>
        /// Returns true if AddPolicyToRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddPolicyToRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddPolicyToRoleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }

    }
}
