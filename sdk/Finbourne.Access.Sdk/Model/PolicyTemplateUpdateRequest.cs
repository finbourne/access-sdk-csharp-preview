/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3744
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
    /// Update policy template request
    /// </summary>
    [DataContract(Name = "PolicyTemplateUpdateRequest")]
    public partial class PolicyTemplateUpdateRequest : IEquatable<PolicyTemplateUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTemplateUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyTemplateUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTemplateUpdateRequest" /> class.
        /// </summary>
        /// <param name="displayName">The display name of the policy template being created (required).</param>
        /// <param name="description">Description of the policy template being craeted (required).</param>
        /// <param name="templatedSelectors">The selector definitions of policies included in this policy template (required).</param>
        public PolicyTemplateUpdateRequest(string displayName = default(string), string description = default(string), List<PolicyTemplatedSelector> templatedSelectors = default(List<PolicyTemplatedSelector>))
        {
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for PolicyTemplateUpdateRequest and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for PolicyTemplateUpdateRequest and cannot be null");
            // to ensure "templatedSelectors" is required (not null)
            this.TemplatedSelectors = templatedSelectors ?? throw new ArgumentNullException("templatedSelectors is a required property for PolicyTemplateUpdateRequest and cannot be null");
        }

        /// <summary>
        /// The display name of the policy template being created
        /// </summary>
        /// <value>The display name of the policy template being created</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Description of the policy template being craeted
        /// </summary>
        /// <value>Description of the policy template being craeted</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The selector definitions of policies included in this policy template
        /// </summary>
        /// <value>The selector definitions of policies included in this policy template</value>
        [DataMember(Name = "templatedSelectors", IsRequired = true, EmitDefaultValue = false)]
        public List<PolicyTemplatedSelector> TemplatedSelectors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTemplateUpdateRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TemplatedSelectors: ").Append(TemplatedSelectors).Append("\n");
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
            return this.Equals(input as PolicyTemplateUpdateRequest);
        }

        /// <summary>
        /// Returns true if PolicyTemplateUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyTemplateUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyTemplateUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TemplatedSelectors == input.TemplatedSelectors ||
                    this.TemplatedSelectors != null &&
                    input.TemplatedSelectors != null &&
                    this.TemplatedSelectors.SequenceEqual(input.TemplatedSelectors)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TemplatedSelectors != null)
                    hashCode = hashCode * 59 + this.TemplatedSelectors.GetHashCode();
                return hashCode;
            }
        }

    }
}
