/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3904
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
    /// A PolicyCollection encapsulating one or more Policies and PolicyCollections
    /// </summary>
    [DataContract(Name = "PolicyCollectionResponse")]
    public partial class PolicyCollectionResponse : IEquatable<PolicyCollectionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="policies">The identifiers of the Policies in this collection.</param>
        /// <param name="policyCollections">The identifiers of the PolicyCollections in this collection.</param>
        /// <param name="description">A description of this policy collection.</param>
        /// <param name="links">links.</param>
        public PolicyCollectionResponse(PolicyCollectionId id = default(PolicyCollectionId), List<PolicyId> policies = default(List<PolicyId>), List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>), string description = default(string), List<Link> links = default(List<Link>))
        {
            this.Id = id;
            this.Policies = policies;
            this.PolicyCollections = policyCollections;
            this.Description = description;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public PolicyCollectionId Id { get; set; }

        /// <summary>
        /// The identifiers of the Policies in this collection
        /// </summary>
        /// <value>The identifiers of the Policies in this collection</value>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyId> Policies { get; set; }

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
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyCollectionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  PolicyCollections: ").Append(PolicyCollections).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PolicyCollectionResponse);
        }

        /// <summary>
        /// Returns true if PolicyCollectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCollectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCollectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.PolicyCollections != null)
                    hashCode = hashCode * 59 + this.PolicyCollections.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
