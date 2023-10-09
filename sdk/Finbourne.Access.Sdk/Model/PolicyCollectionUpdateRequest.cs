/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3320
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
    /// Update an existing PolicyCollection
    /// </summary>
    [DataContract(Name = "PolicyCollectionUpdateRequest")]
    public partial class PolicyCollectionUpdateRequest : IEquatable<PolicyCollectionUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionUpdateRequest" /> class.
        /// </summary>
        /// <param name="policies">The identifiers of the Policies in this collection.</param>
        /// <param name="metadata">Any relevant metadata associated with this resource for controlling access to this resource.</param>
        /// <param name="policyCollections">The identifiers of the PolicyCollections in this collection.</param>
        /// <param name="description">A description of this policy collection.</param>
        public PolicyCollectionUpdateRequest(List<PolicyId> policies = default(List<PolicyId>), Dictionary<string, List<EntitlementMetadata>> metadata = default(Dictionary<string, List<EntitlementMetadata>>), List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>), string description = default(string))
        {
            this.Policies = policies;
            this.Metadata = metadata;
            this.PolicyCollections = policyCollections;
            this.Description = description;
        }

        /// <summary>
        /// The identifiers of the Policies in this collection
        /// </summary>
        /// <value>The identifiers of the Policies in this collection</value>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyId> Policies { get; set; }

        /// <summary>
        /// Any relevant metadata associated with this resource for controlling access to this resource
        /// </summary>
        /// <value>Any relevant metadata associated with this resource for controlling access to this resource</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, List<EntitlementMetadata>> Metadata { get; set; }

        /// <summary>
        /// The identifiers of the PolicyCollections in this collection
        /// </summary>
        /// <value>The identifiers of the PolicyCollections in this collection</value>
        [DataMember(Name = "policyCollections", EmitDefaultValue = true)]
        public List<PolicyCollectionId> PolicyCollections { get; set; }

        /// <summary>
        /// A description of this policy collection
        /// </summary>
        /// <value>A description of this policy collection</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyCollectionUpdateRequest {\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PolicyCollections: ").Append(PolicyCollections).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as PolicyCollectionUpdateRequest);
        }

        /// <summary>
        /// Returns true if PolicyCollectionUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCollectionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCollectionUpdateRequest input)
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
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PolicyCollections == input.PolicyCollections ||
                    this.PolicyCollections != null &&
                    input.PolicyCollections != null &&
                    this.PolicyCollections.SequenceEqual(input.PolicyCollections)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PolicyCollections != null)
                    hashCode = hashCode * 59 + this.PolicyCollections.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
