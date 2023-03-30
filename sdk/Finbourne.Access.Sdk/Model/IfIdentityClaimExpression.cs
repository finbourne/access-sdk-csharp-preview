/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2891
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
    /// IfIdentityClaimExpression
    /// </summary>
    [DataContract(Name = "IfIdentityClaimExpression")]
    public partial class IfIdentityClaimExpression : IEquatable<IfIdentityClaimExpression>
    {

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = false)]
        public TextOperator Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfIdentityClaimExpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IfIdentityClaimExpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfIdentityClaimExpression" /> class.
        /// </summary>
        /// <param name="claimType">claimType (required).</param>
        /// <param name="claimValueType">claimValueType (required).</param>
        /// <param name="claimIssuer">claimIssuer.</param>
        /// <param name="claimOriginalIssuer">claimOriginalIssuer.</param>
        /// <param name="_operator">_operator (required).</param>
        /// <param name="value">value.</param>
        public IfIdentityClaimExpression(string claimType = default(string), string claimValueType = default(string), string claimIssuer = default(string), string claimOriginalIssuer = default(string), TextOperator _operator = default(TextOperator), string value = default(string))
        {
            // to ensure "claimType" is required (not null)
            this.ClaimType = claimType ?? throw new ArgumentNullException("claimType is a required property for IfIdentityClaimExpression and cannot be null");
            // to ensure "claimValueType" is required (not null)
            this.ClaimValueType = claimValueType ?? throw new ArgumentNullException("claimValueType is a required property for IfIdentityClaimExpression and cannot be null");
            this.Operator = _operator;
            this.ClaimIssuer = claimIssuer;
            this.ClaimOriginalIssuer = claimOriginalIssuer;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ClaimType
        /// </summary>
        [DataMember(Name = "claimType", IsRequired = true, EmitDefaultValue = false)]
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or Sets ClaimValueType
        /// </summary>
        [DataMember(Name = "claimValueType", IsRequired = true, EmitDefaultValue = false)]
        public string ClaimValueType { get; set; }

        /// <summary>
        /// Gets or Sets ClaimIssuer
        /// </summary>
        [DataMember(Name = "claimIssuer", EmitDefaultValue = true)]
        public string ClaimIssuer { get; set; }

        /// <summary>
        /// Gets or Sets ClaimOriginalIssuer
        /// </summary>
        [DataMember(Name = "claimOriginalIssuer", EmitDefaultValue = true)]
        public string ClaimOriginalIssuer { get; set; }

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
            sb.Append("class IfIdentityClaimExpression {\n");
            sb.Append("  ClaimType: ").Append(ClaimType).Append("\n");
            sb.Append("  ClaimValueType: ").Append(ClaimValueType).Append("\n");
            sb.Append("  ClaimIssuer: ").Append(ClaimIssuer).Append("\n");
            sb.Append("  ClaimOriginalIssuer: ").Append(ClaimOriginalIssuer).Append("\n");
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
            return this.Equals(input as IfIdentityClaimExpression);
        }

        /// <summary>
        /// Returns true if IfIdentityClaimExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of IfIdentityClaimExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IfIdentityClaimExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClaimType == input.ClaimType ||
                    (this.ClaimType != null &&
                    this.ClaimType.Equals(input.ClaimType))
                ) && 
                (
                    this.ClaimValueType == input.ClaimValueType ||
                    (this.ClaimValueType != null &&
                    this.ClaimValueType.Equals(input.ClaimValueType))
                ) && 
                (
                    this.ClaimIssuer == input.ClaimIssuer ||
                    (this.ClaimIssuer != null &&
                    this.ClaimIssuer.Equals(input.ClaimIssuer))
                ) && 
                (
                    this.ClaimOriginalIssuer == input.ClaimOriginalIssuer ||
                    (this.ClaimOriginalIssuer != null &&
                    this.ClaimOriginalIssuer.Equals(input.ClaimOriginalIssuer))
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
                if (this.ClaimType != null)
                    hashCode = hashCode * 59 + this.ClaimType.GetHashCode();
                if (this.ClaimValueType != null)
                    hashCode = hashCode * 59 + this.ClaimValueType.GetHashCode();
                if (this.ClaimIssuer != null)
                    hashCode = hashCode * 59 + this.ClaimIssuer.GetHashCode();
                if (this.ClaimOriginalIssuer != null)
                    hashCode = hashCode * 59 + this.ClaimOriginalIssuer.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
