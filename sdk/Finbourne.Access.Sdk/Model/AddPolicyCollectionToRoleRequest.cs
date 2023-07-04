/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3091
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
    /// Request body used to add Policy Collections to a Role
    /// </summary>
    [DataContract(Name = "AddPolicyCollectionToRoleRequest")]
    public partial class AddPolicyCollectionToRoleRequest : IEquatable<AddPolicyCollectionToRoleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyCollectionToRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddPolicyCollectionToRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyCollectionToRoleRequest" /> class.
        /// </summary>
        /// <param name="policyCollections">Identifiers of policy collections to add to a role (required).</param>
        public AddPolicyCollectionToRoleRequest(List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>))
        {
            // to ensure "policyCollections" is required (not null)
            this.PolicyCollections = policyCollections ?? throw new ArgumentNullException("policyCollections is a required property for AddPolicyCollectionToRoleRequest and cannot be null");
        }

        /// <summary>
        /// Identifiers of policy collections to add to a role
        /// </summary>
        /// <value>Identifiers of policy collections to add to a role</value>
        [DataMember(Name = "policyCollections", IsRequired = true, EmitDefaultValue = false)]
        public List<PolicyCollectionId> PolicyCollections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPolicyCollectionToRoleRequest {\n");
            sb.Append("  PolicyCollections: ").Append(PolicyCollections).Append("\n");
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
            return this.Equals(input as AddPolicyCollectionToRoleRequest);
        }

        /// <summary>
        /// Returns true if AddPolicyCollectionToRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddPolicyCollectionToRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddPolicyCollectionToRoleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyCollections == input.PolicyCollections ||
                    this.PolicyCollections != null &&
                    input.PolicyCollections != null &&
                    this.PolicyCollections.SequenceEqual(input.PolicyCollections)
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
                if (this.PolicyCollections != null)
                    hashCode = hashCode * 59 + this.PolicyCollections.GetHashCode();
                return hashCode;
            }
        }

    }
}
