/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3714
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
    /// Response object for policy generated from template
    /// </summary>
    [DataContract(Name = "GeneratedPolicyComponents")]
    public partial class GeneratedPolicyComponents : IEquatable<GeneratedPolicyComponents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedPolicyComponents" /> class.
        /// </summary>
        /// <param name="applications">Applications to which the policy applies.</param>
        /// <param name="templateMetadata">templateMetadata.</param>
        /// <param name="selectors">Selectors that this policy will be applied to.</param>
        public GeneratedPolicyComponents(List<string> applications = default(List<string>), TemplateMetadata templateMetadata = default(TemplateMetadata), List<SelectorDefinition> selectors = default(List<SelectorDefinition>))
        {
            this.Applications = applications;
            this.TemplateMetadata = templateMetadata;
            this.Selectors = selectors;
        }

        /// <summary>
        /// Applications to which the policy applies
        /// </summary>
        /// <value>Applications to which the policy applies</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMetadata
        /// </summary>
        [DataMember(Name = "templateMetadata", EmitDefaultValue = false)]
        public TemplateMetadata TemplateMetadata { get; set; }

        /// <summary>
        /// Selectors that this policy will be applied to
        /// </summary>
        /// <value>Selectors that this policy will be applied to</value>
        [DataMember(Name = "selectors", EmitDefaultValue = true)]
        public List<SelectorDefinition> Selectors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratedPolicyComponents {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  TemplateMetadata: ").Append(TemplateMetadata).Append("\n");
            sb.Append("  Selectors: ").Append(Selectors).Append("\n");
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
            return this.Equals(input as GeneratedPolicyComponents);
        }

        /// <summary>
        /// Returns true if GeneratedPolicyComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneratedPolicyComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratedPolicyComponents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    input.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
                ) && 
                (
                    this.TemplateMetadata == input.TemplateMetadata ||
                    (this.TemplateMetadata != null &&
                    this.TemplateMetadata.Equals(input.TemplateMetadata))
                ) && 
                (
                    this.Selectors == input.Selectors ||
                    this.Selectors != null &&
                    input.Selectors != null &&
                    this.Selectors.SequenceEqual(input.Selectors)
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.TemplateMetadata != null)
                    hashCode = hashCode * 59 + this.TemplateMetadata.GetHashCode();
                if (this.Selectors != null)
                    hashCode = hashCode * 59 + this.Selectors.GetHashCode();
                return hashCode;
            }
        }

    }
}
