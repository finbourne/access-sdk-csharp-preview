/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3708
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
    /// Response object for a policy template
    /// </summary>
    [DataContract(Name = "PolicyTemplateResponse")]
    public partial class PolicyTemplateResponse : IEquatable<PolicyTemplateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTemplateResponse" /> class.
        /// </summary>
        /// <param name="displayName">Display name of the policy template being created.</param>
        /// <param name="scope">The Scope of the policy template being created.</param>
        /// <param name="code">The Code of the policy template being created.</param>
        /// <param name="description">Description of the policy template being created.</param>
        /// <param name="applications">List of applications that this policy template covers.</param>
        /// <param name="tags">List of policy types that this policy template covers.</param>
        /// <param name="templatedSelectors">The selector definitions of policies included in this policy template.</param>
        public PolicyTemplateResponse(string displayName = default(string), string scope = default(string), string code = default(string), string description = default(string), List<string> applications = default(List<string>), List<string> tags = default(List<string>), List<PolicyTemplatedSelector> templatedSelectors = default(List<PolicyTemplatedSelector>))
        {
            this.DisplayName = displayName;
            this.Scope = scope;
            this.Code = code;
            this.Description = description;
            this.Applications = applications;
            this.Tags = tags;
            this.TemplatedSelectors = templatedSelectors;
        }

        /// <summary>
        /// Display name of the policy template being created
        /// </summary>
        /// <value>Display name of the policy template being created</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The Scope of the policy template being created
        /// </summary>
        /// <value>The Scope of the policy template being created</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The Code of the policy template being created
        /// </summary>
        /// <value>The Code of the policy template being created</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Description of the policy template being created
        /// </summary>
        /// <value>Description of the policy template being created</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// List of applications that this policy template covers
        /// </summary>
        /// <value>List of applications that this policy template covers</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// List of policy types that this policy template covers
        /// </summary>
        /// <value>List of policy types that this policy template covers</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The selector definitions of policies included in this policy template
        /// </summary>
        /// <value>The selector definitions of policies included in this policy template</value>
        [DataMember(Name = "templatedSelectors", EmitDefaultValue = true)]
        public List<PolicyTemplatedSelector> TemplatedSelectors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTemplateResponse {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as PolicyTemplateResponse);
        }

        /// <summary>
        /// Returns true if PolicyTemplateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyTemplateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyTemplateResponse input)
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
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    input.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TemplatedSelectors != null)
                    hashCode = hashCode * 59 + this.TemplatedSelectors.GetHashCode();
                return hashCode;
            }
        }

    }
}
