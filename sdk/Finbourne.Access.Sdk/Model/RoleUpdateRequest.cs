/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3709
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
    /// Role update does not allow the changing of the id
    /// </summary>
    [DataContract(Name = "RoleUpdateRequest")]
    public partial class RoleUpdateRequest : IEquatable<RoleUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUpdateRequest" /> class.
        /// </summary>
        /// <param name="description">The description of the role.</param>
        /// <param name="resource">resource (required).</param>
        /// <param name="when">when (required).</param>
        public RoleUpdateRequest(string description = default(string), RoleResourceRequest resource = default(RoleResourceRequest), WhenSpec when = default(WhenSpec))
        {
            // to ensure "resource" is required (not null)
            this.Resource = resource ?? throw new ArgumentNullException("resource is a required property for RoleUpdateRequest and cannot be null");
            // to ensure "when" is required (not null)
            this.When = when ?? throw new ArgumentNullException("when is a required property for RoleUpdateRequest and cannot be null");
            this.Description = description;
        }

        /// <summary>
        /// The description of the role
        /// </summary>
        /// <value>The description of the role</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        public RoleResourceRequest Resource { get; set; }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", IsRequired = true, EmitDefaultValue = false)]
        public WhenSpec When { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleUpdateRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
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
            return this.Equals(input as RoleUpdateRequest);
        }

        /// <summary>
        /// Returns true if RoleUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                return hashCode;
            }
        }

    }
}
