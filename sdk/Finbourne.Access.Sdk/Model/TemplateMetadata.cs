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
    /// Extra policy template metadata information, used during a generation request
    /// </summary>
    [DataContract(Name = "TemplateMetadata")]
    public partial class TemplateMetadata : IEquatable<TemplateMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateMetadata" /> class.
        /// </summary>
        /// <param name="templateSelection">List of policy templates used for a generation request.</param>
        /// <param name="buildAsAt">Policy template build AsAt time used for a generation request.</param>
        public TemplateMetadata(List<TemplateSelection> templateSelection = default(List<TemplateSelection>), DateTimeOffset buildAsAt = default(DateTimeOffset))
        {
            this.TemplateSelection = templateSelection;
            this.BuildAsAt = buildAsAt;
        }

        /// <summary>
        /// List of policy templates used for a generation request
        /// </summary>
        /// <value>List of policy templates used for a generation request</value>
        [DataMember(Name = "templateSelection", EmitDefaultValue = true)]
        public List<TemplateSelection> TemplateSelection { get; set; }

        /// <summary>
        /// Policy template build AsAt time used for a generation request
        /// </summary>
        /// <value>Policy template build AsAt time used for a generation request</value>
        [DataMember(Name = "buildAsAt", EmitDefaultValue = false)]
        public DateTimeOffset BuildAsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateMetadata {\n");
            sb.Append("  TemplateSelection: ").Append(TemplateSelection).Append("\n");
            sb.Append("  BuildAsAt: ").Append(BuildAsAt).Append("\n");
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
            return this.Equals(input as TemplateMetadata);
        }

        /// <summary>
        /// Returns true if TemplateMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateSelection == input.TemplateSelection ||
                    this.TemplateSelection != null &&
                    input.TemplateSelection != null &&
                    this.TemplateSelection.SequenceEqual(input.TemplateSelection)
                ) && 
                (
                    this.BuildAsAt == input.BuildAsAt ||
                    (this.BuildAsAt != null &&
                    this.BuildAsAt.Equals(input.BuildAsAt))
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
                if (this.BuildAsAt != null)
                    hashCode = hashCode * 59 + this.BuildAsAt.GetHashCode();
                return hashCode;
            }
        }

    }
}
