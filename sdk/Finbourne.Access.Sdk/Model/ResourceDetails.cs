/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3746
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
    /// Details about the resource being requested that may be pertinent to the entitlement evaluation
    /// </summary>
    [DataContract(Name = "ResourceDetails")]
    public partial class ResourceDetails : IEquatable<ResourceDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetails" /> class.
        /// </summary>
        /// <param name="id">The identifier of the resource being evaluated (required).</param>
        /// <param name="metadata">Any metadata associated with the resource being requested.</param>
        public ResourceDetails(Dictionary<string, string> id = default(Dictionary<string, string>), Dictionary<string, List<EntitlementMetadata>> metadata = default(Dictionary<string, List<EntitlementMetadata>>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ResourceDetails and cannot be null");
            this.Metadata = metadata;
        }

        /// <summary>
        /// The identifier of the resource being evaluated
        /// </summary>
        /// <value>The identifier of the resource being evaluated</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Id { get; set; }

        /// <summary>
        /// Any metadata associated with the resource being requested
        /// </summary>
        /// <value>Any metadata associated with the resource being requested</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, List<EntitlementMetadata>> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as ResourceDetails);
        }

        /// <summary>
        /// Returns true if ResourceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }

    }
}
