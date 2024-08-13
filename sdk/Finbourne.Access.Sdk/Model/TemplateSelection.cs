/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3905
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
    /// A template selection, identifying a policy template to use for generation
    /// </summary>
    [DataContract(Name = "TemplateSelection")]
    public partial class TemplateSelection : IEquatable<TemplateSelection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSelection" /> class.
        /// </summary>
        /// <param name="scope">Scope identifying policy template to use for generation (required).</param>
        /// <param name="code">Code identifying policy template to use for generation (required).</param>
        /// <param name="selectorTags">List of selector tags to optionally filter in the template generation   (Eg: Feature, Data, etc).</param>
        public TemplateSelection(string scope = default(string), string code = default(string), List<string> selectorTags = default(List<string>))
        {
            // to ensure "scope" is required (not null)
            this.Scope = scope ?? throw new ArgumentNullException("scope is a required property for TemplateSelection and cannot be null");
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for TemplateSelection and cannot be null");
            this.SelectorTags = selectorTags;
        }

        /// <summary>
        /// Scope identifying policy template to use for generation
        /// </summary>
        /// <value>Scope identifying policy template to use for generation</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Code identifying policy template to use for generation
        /// </summary>
        /// <value>Code identifying policy template to use for generation</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// List of selector tags to optionally filter in the template generation   (Eg: Feature, Data, etc)
        /// </summary>
        /// <value>List of selector tags to optionally filter in the template generation   (Eg: Feature, Data, etc)</value>
        [DataMember(Name = "selectorTags", EmitDefaultValue = true)]
        public List<string> SelectorTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSelection {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SelectorTags: ").Append(SelectorTags).Append("\n");
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
            return this.Equals(input as TemplateSelection);
        }

        /// <summary>
        /// Returns true if TemplateSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSelection input)
        {
            if (input == null)
                return false;

            return 
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
                    this.SelectorTags == input.SelectorTags ||
                    this.SelectorTags != null &&
                    input.SelectorTags != null &&
                    this.SelectorTags.SequenceEqual(input.SelectorTags)
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.SelectorTags != null)
                    hashCode = hashCode * 59 + this.SelectorTags.GetHashCode();
                return hashCode;
            }
        }

    }
}
