/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2682
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
    /// MetadataExpression
    /// </summary>
    [DataContract(Name = "MetadataExpression")]
    public partial class MetadataExpression : IEquatable<MetadataExpression>
    {

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = false)]
        public Operator Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataExpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataExpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataExpression" /> class.
        /// </summary>
        /// <param name="metadataKey">metadataKey (required).</param>
        /// <param name="_operator">_operator (required).</param>
        /// <param name="textValue">textValue.</param>
        public MetadataExpression(string metadataKey = default(string), Operator _operator = default(Operator), string textValue = default(string))
        {
            // to ensure "metadataKey" is required (not null)
            this.MetadataKey = metadataKey ?? throw new ArgumentNullException("metadataKey is a required property for MetadataExpression and cannot be null");
            this.Operator = _operator;
            this.TextValue = textValue;
        }

        /// <summary>
        /// Gets or Sets MetadataKey
        /// </summary>
        [DataMember(Name = "metadataKey", IsRequired = true, EmitDefaultValue = false)]
        public string MetadataKey { get; set; }

        /// <summary>
        /// Gets or Sets TextValue
        /// </summary>
        [DataMember(Name = "textValue", EmitDefaultValue = true)]
        public string TextValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataExpression {\n");
            sb.Append("  MetadataKey: ").Append(MetadataKey).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
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
            return this.Equals(input as MetadataExpression);
        }

        /// <summary>
        /// Returns true if MetadataExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataKey == input.MetadataKey ||
                    (this.MetadataKey != null &&
                    this.MetadataKey.Equals(input.MetadataKey))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.TextValue == input.TextValue ||
                    (this.TextValue != null &&
                    this.TextValue.Equals(input.TextValue))
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
                if (this.MetadataKey != null)
                    hashCode = hashCode * 59 + this.MetadataKey.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.TextValue != null)
                    hashCode = hashCode * 59 + this.TextValue.GetHashCode();
                return hashCode;
            }
        }

    }
}
