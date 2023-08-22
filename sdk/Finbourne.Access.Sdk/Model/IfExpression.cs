/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3202
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
    /// IfExpression
    /// </summary>
    [DataContract(Name = "IfExpression")]
    public partial class IfExpression : IEquatable<IfExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IfExpression" /> class.
        /// </summary>
        /// <param name="ifRequestHeaderExpression">ifRequestHeaderExpression.</param>
        /// <param name="ifIdentityClaimExpression">ifIdentityClaimExpression.</param>
        /// <param name="ifIdentityScopeExpression">ifIdentityScopeExpression.</param>
        /// <param name="ifFeatureChainExpression">ifFeatureChainExpression.</param>
        public IfExpression(IfRequestHeaderExpression ifRequestHeaderExpression = default(IfRequestHeaderExpression), IfIdentityClaimExpression ifIdentityClaimExpression = default(IfIdentityClaimExpression), IfIdentityScopeExpression ifIdentityScopeExpression = default(IfIdentityScopeExpression), IfFeatureChainExpression ifFeatureChainExpression = default(IfFeatureChainExpression))
        {
            this.IfRequestHeaderExpression = ifRequestHeaderExpression;
            this.IfIdentityClaimExpression = ifIdentityClaimExpression;
            this.IfIdentityScopeExpression = ifIdentityScopeExpression;
            this.IfFeatureChainExpression = ifFeatureChainExpression;
        }

        /// <summary>
        /// Gets or Sets IfRequestHeaderExpression
        /// </summary>
        [DataMember(Name = "ifRequestHeaderExpression", EmitDefaultValue = false)]
        public IfRequestHeaderExpression IfRequestHeaderExpression { get; set; }

        /// <summary>
        /// Gets or Sets IfIdentityClaimExpression
        /// </summary>
        [DataMember(Name = "ifIdentityClaimExpression", EmitDefaultValue = false)]
        public IfIdentityClaimExpression IfIdentityClaimExpression { get; set; }

        /// <summary>
        /// Gets or Sets IfIdentityScopeExpression
        /// </summary>
        [DataMember(Name = "ifIdentityScopeExpression", EmitDefaultValue = false)]
        public IfIdentityScopeExpression IfIdentityScopeExpression { get; set; }

        /// <summary>
        /// Gets or Sets IfFeatureChainExpression
        /// </summary>
        [DataMember(Name = "ifFeatureChainExpression", EmitDefaultValue = false)]
        public IfFeatureChainExpression IfFeatureChainExpression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IfExpression {\n");
            sb.Append("  IfRequestHeaderExpression: ").Append(IfRequestHeaderExpression).Append("\n");
            sb.Append("  IfIdentityClaimExpression: ").Append(IfIdentityClaimExpression).Append("\n");
            sb.Append("  IfIdentityScopeExpression: ").Append(IfIdentityScopeExpression).Append("\n");
            sb.Append("  IfFeatureChainExpression: ").Append(IfFeatureChainExpression).Append("\n");
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
            return this.Equals(input as IfExpression);
        }

        /// <summary>
        /// Returns true if IfExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of IfExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IfExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IfRequestHeaderExpression == input.IfRequestHeaderExpression ||
                    (this.IfRequestHeaderExpression != null &&
                    this.IfRequestHeaderExpression.Equals(input.IfRequestHeaderExpression))
                ) && 
                (
                    this.IfIdentityClaimExpression == input.IfIdentityClaimExpression ||
                    (this.IfIdentityClaimExpression != null &&
                    this.IfIdentityClaimExpression.Equals(input.IfIdentityClaimExpression))
                ) && 
                (
                    this.IfIdentityScopeExpression == input.IfIdentityScopeExpression ||
                    (this.IfIdentityScopeExpression != null &&
                    this.IfIdentityScopeExpression.Equals(input.IfIdentityScopeExpression))
                ) && 
                (
                    this.IfFeatureChainExpression == input.IfFeatureChainExpression ||
                    (this.IfFeatureChainExpression != null &&
                    this.IfFeatureChainExpression.Equals(input.IfFeatureChainExpression))
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
                if (this.IfRequestHeaderExpression != null)
                    hashCode = hashCode * 59 + this.IfRequestHeaderExpression.GetHashCode();
                if (this.IfIdentityClaimExpression != null)
                    hashCode = hashCode * 59 + this.IfIdentityClaimExpression.GetHashCode();
                if (this.IfIdentityScopeExpression != null)
                    hashCode = hashCode * 59 + this.IfIdentityScopeExpression.GetHashCode();
                if (this.IfFeatureChainExpression != null)
                    hashCode = hashCode * 59 + this.IfFeatureChainExpression.GetHashCode();
                return hashCode;
            }
        }

    }
}
