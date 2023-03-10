/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2835
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
    /// Base properties to create or update a policy collection
    /// </summary>
    [DataContract(Name = "RemoveFromPolicyCollectionRequest")]
    public partial class RemoveFromPolicyCollectionRequest : IEquatable<RemoveFromPolicyCollectionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveFromPolicyCollectionRequest" /> class.
        /// </summary>
        /// <param name="policies">The identifiers of the Policies to be removed from the collection..</param>
        /// <param name="policyCollections">The identifiers of the PolicyCollections to be removed from the collection..</param>
        public RemoveFromPolicyCollectionRequest(List<PolicyId> policies = default(List<PolicyId>), List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>))
        {
            this.Policies = policies;
            this.PolicyCollections = policyCollections;
        }

        /// <summary>
        /// The identifiers of the Policies to be removed from the collection.
        /// </summary>
        /// <value>The identifiers of the Policies to be removed from the collection.</value>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyId> Policies { get; set; }

        /// <summary>
        /// The identifiers of the PolicyCollections to be removed from the collection.
        /// </summary>
        /// <value>The identifiers of the PolicyCollections to be removed from the collection.</value>
        [DataMember(Name = "policyCollections", EmitDefaultValue = true)]
        public List<PolicyCollectionId> PolicyCollections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveFromPolicyCollectionRequest {\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as RemoveFromPolicyCollectionRequest);
        }

        /// <summary>
        /// Returns true if RemoveFromPolicyCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveFromPolicyCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveFromPolicyCollectionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
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
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.PolicyCollections != null)
                    hashCode = hashCode * 59 + this.PolicyCollections.GetHashCode();
                return hashCode;
            }
        }

    }
}
