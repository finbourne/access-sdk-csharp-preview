/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3673
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
    /// AsAtPredicateContract
    /// </summary>
    [DataContract(Name = "AsAtPredicateContract")]
    public partial class AsAtPredicateContract : IEquatable<AsAtPredicateContract>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsAtPredicateContract" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="dateTimeOffset">dateTimeOffset.</param>
        public AsAtPredicateContract(string value = default(string), DateTimeOffset? dateTimeOffset = default(DateTimeOffset?))
        {
            this.Value = value;
            this.DateTimeOffset = dateTimeOffset;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeOffset
        /// </summary>
        [DataMember(Name = "dateTimeOffset", EmitDefaultValue = true)]
        public DateTimeOffset? DateTimeOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsAtPredicateContract {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DateTimeOffset: ").Append(DateTimeOffset).Append("\n");
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
            return this.Equals(input as AsAtPredicateContract);
        }

        /// <summary>
        /// Returns true if AsAtPredicateContract instances are equal
        /// </summary>
        /// <param name="input">Instance of AsAtPredicateContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsAtPredicateContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.DateTimeOffset == input.DateTimeOffset ||
                    (this.DateTimeOffset != null &&
                    this.DateTimeOffset.Equals(input.DateTimeOffset))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DateTimeOffset != null)
                    hashCode = hashCode * 59 + this.DateTimeOffset.GetHashCode();
                return hashCode;
            }
        }

    }
}
