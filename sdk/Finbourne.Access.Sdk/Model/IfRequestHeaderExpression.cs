/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3666
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
    /// IfRequestHeaderExpression
    /// </summary>
    [DataContract(Name = "IfRequestHeaderExpression")]
    public partial class IfRequestHeaderExpression : IEquatable<IfRequestHeaderExpression>
    {

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = false)]
        public TextOperator Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfRequestHeaderExpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IfRequestHeaderExpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfRequestHeaderExpression" /> class.
        /// </summary>
        /// <param name="headerName">headerName (required).</param>
        /// <param name="_operator">_operator (required).</param>
        /// <param name="value">value.</param>
        public IfRequestHeaderExpression(string headerName = default(string), TextOperator _operator = default(TextOperator), string value = default(string))
        {
            // to ensure "headerName" is required (not null)
            this.HeaderName = headerName ?? throw new ArgumentNullException("headerName is a required property for IfRequestHeaderExpression and cannot be null");
            this.Operator = _operator;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets HeaderName
        /// </summary>
        [DataMember(Name = "headerName", IsRequired = true, EmitDefaultValue = false)]
        public string HeaderName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IfRequestHeaderExpression {\n");
            sb.Append("  HeaderName: ").Append(HeaderName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as IfRequestHeaderExpression);
        }

        /// <summary>
        /// Returns true if IfRequestHeaderExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of IfRequestHeaderExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IfRequestHeaderExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeaderName == input.HeaderName ||
                    (this.HeaderName != null &&
                    this.HeaderName.Equals(input.HeaderName))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.HeaderName != null)
                    hashCode = hashCode * 59 + this.HeaderName.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
