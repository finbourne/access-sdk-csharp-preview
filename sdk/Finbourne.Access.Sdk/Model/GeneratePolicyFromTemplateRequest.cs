/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3618
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
    /// Generate policy from template
    /// </summary>
    [DataContract(Name = "GeneratePolicyFromTemplateRequest")]
    public partial class GeneratePolicyFromTemplateRequest : IEquatable<GeneratePolicyFromTemplateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePolicyFromTemplateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeneratePolicyFromTemplateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePolicyFromTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateSelection">List of template selection, identifying policy templates to use for generation (required).</param>
        public GeneratePolicyFromTemplateRequest(List<TemplateSelection> templateSelection = default(List<TemplateSelection>))
        {
            // to ensure "templateSelection" is required (not null)
            this.TemplateSelection = templateSelection ?? throw new ArgumentNullException("templateSelection is a required property for GeneratePolicyFromTemplateRequest and cannot be null");
        }

        /// <summary>
        /// List of template selection, identifying policy templates to use for generation
        /// </summary>
        /// <value>List of template selection, identifying policy templates to use for generation</value>
        [DataMember(Name = "templateSelection", IsRequired = true, EmitDefaultValue = false)]
        public List<TemplateSelection> TemplateSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratePolicyFromTemplateRequest {\n");
            sb.Append("  TemplateSelection: ").Append(TemplateSelection).Append("\n");
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
            return this.Equals(input as GeneratePolicyFromTemplateRequest);
        }

        /// <summary>
        /// Returns true if GeneratePolicyFromTemplateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneratePolicyFromTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratePolicyFromTemplateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateSelection == input.TemplateSelection ||
                    this.TemplateSelection != null &&
                    input.TemplateSelection != null &&
                    this.TemplateSelection.SequenceEqual(input.TemplateSelection)
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
                if (this.TemplateSelection != null)
                    hashCode = hashCode * 59 + this.TemplateSelection.GetHashCode();
                return hashCode;
            }
        }

    }
}
