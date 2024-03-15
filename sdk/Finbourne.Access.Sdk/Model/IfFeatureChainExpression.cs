/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3745
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
    /// IfFeatureChainExpression
    /// </summary>
    [DataContract(Name = "IfFeatureChainExpression")]
    public partial class IfFeatureChainExpression : IEquatable<IfFeatureChainExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IfFeatureChainExpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IfFeatureChainExpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfFeatureChainExpression" /> class.
        /// </summary>
        /// <param name="selectors">selectors (required).</param>
        public IfFeatureChainExpression(List<SelectorDefinition> selectors = default(List<SelectorDefinition>))
        {
            // to ensure "selectors" is required (not null)
            this.Selectors = selectors ?? throw new ArgumentNullException("selectors is a required property for IfFeatureChainExpression and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Selectors
        /// </summary>
        [DataMember(Name = "selectors", IsRequired = true, EmitDefaultValue = false)]
        public List<SelectorDefinition> Selectors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IfFeatureChainExpression {\n");
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
            return this.Equals(input as IfFeatureChainExpression);
        }

        /// <summary>
        /// Returns true if IfFeatureChainExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of IfFeatureChainExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IfFeatureChainExpression input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Selectors != null)
                    hashCode = hashCode * 59 + this.Selectors.GetHashCode();
                return hashCode;
            }
        }

    }
}
