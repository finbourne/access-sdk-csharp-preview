/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2626
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
    /// ForSpec
    /// </summary>
    [DataContract(Name = "ForSpec")]
    public partial class ForSpec : IEquatable<ForSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForSpec" /> class.
        /// </summary>
        /// <param name="asAtRangeForSpec">asAtRangeForSpec.</param>
        /// <param name="asAtRelative">asAtRelative.</param>
        /// <param name="effectiveDateHasQuality">effectiveDateHasQuality.</param>
        /// <param name="effectiveDateRelative">effectiveDateRelative.</param>
        /// <param name="effectiveRange">effectiveRange.</param>
        public ForSpec(AsAtRangeForSpec asAtRangeForSpec = default(AsAtRangeForSpec), AsAtRelative asAtRelative = default(AsAtRelative), EffectiveDateHasQuality effectiveDateHasQuality = default(EffectiveDateHasQuality), EffectiveDateRelative effectiveDateRelative = default(EffectiveDateRelative), EffectiveRange effectiveRange = default(EffectiveRange))
        {
            this.AsAtRangeForSpec = asAtRangeForSpec;
            this.AsAtRelative = asAtRelative;
            this.EffectiveDateHasQuality = effectiveDateHasQuality;
            this.EffectiveDateRelative = effectiveDateRelative;
            this.EffectiveRange = effectiveRange;
        }

        /// <summary>
        /// Gets or Sets AsAtRangeForSpec
        /// </summary>
        [DataMember(Name = "asAtRangeForSpec", EmitDefaultValue = false)]
        public AsAtRangeForSpec AsAtRangeForSpec { get; set; }

        /// <summary>
        /// Gets or Sets AsAtRelative
        /// </summary>
        [DataMember(Name = "asAtRelative", EmitDefaultValue = false)]
        public AsAtRelative AsAtRelative { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDateHasQuality
        /// </summary>
        [DataMember(Name = "effectiveDateHasQuality", EmitDefaultValue = false)]
        public EffectiveDateHasQuality EffectiveDateHasQuality { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDateRelative
        /// </summary>
        [DataMember(Name = "effectiveDateRelative", EmitDefaultValue = false)]
        public EffectiveDateRelative EffectiveDateRelative { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveRange
        /// </summary>
        [DataMember(Name = "effectiveRange", EmitDefaultValue = false)]
        public EffectiveRange EffectiveRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForSpec {\n");
            sb.Append("  AsAtRangeForSpec: ").Append(AsAtRangeForSpec).Append("\n");
            sb.Append("  AsAtRelative: ").Append(AsAtRelative).Append("\n");
            sb.Append("  EffectiveDateHasQuality: ").Append(EffectiveDateHasQuality).Append("\n");
            sb.Append("  EffectiveDateRelative: ").Append(EffectiveDateRelative).Append("\n");
            sb.Append("  EffectiveRange: ").Append(EffectiveRange).Append("\n");
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
            return this.Equals(input as ForSpec);
        }

        /// <summary>
        /// Returns true if ForSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of ForSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsAtRangeForSpec == input.AsAtRangeForSpec ||
                    (this.AsAtRangeForSpec != null &&
                    this.AsAtRangeForSpec.Equals(input.AsAtRangeForSpec))
                ) && 
                (
                    this.AsAtRelative == input.AsAtRelative ||
                    (this.AsAtRelative != null &&
                    this.AsAtRelative.Equals(input.AsAtRelative))
                ) && 
                (
                    this.EffectiveDateHasQuality == input.EffectiveDateHasQuality ||
                    (this.EffectiveDateHasQuality != null &&
                    this.EffectiveDateHasQuality.Equals(input.EffectiveDateHasQuality))
                ) && 
                (
                    this.EffectiveDateRelative == input.EffectiveDateRelative ||
                    (this.EffectiveDateRelative != null &&
                    this.EffectiveDateRelative.Equals(input.EffectiveDateRelative))
                ) && 
                (
                    this.EffectiveRange == input.EffectiveRange ||
                    (this.EffectiveRange != null &&
                    this.EffectiveRange.Equals(input.EffectiveRange))
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
                if (this.AsAtRangeForSpec != null)
                    hashCode = hashCode * 59 + this.AsAtRangeForSpec.GetHashCode();
                if (this.AsAtRelative != null)
                    hashCode = hashCode * 59 + this.AsAtRelative.GetHashCode();
                if (this.EffectiveDateHasQuality != null)
                    hashCode = hashCode * 59 + this.EffectiveDateHasQuality.GetHashCode();
                if (this.EffectiveDateRelative != null)
                    hashCode = hashCode * 59 + this.EffectiveDateRelative.GetHashCode();
                if (this.EffectiveRange != null)
                    hashCode = hashCode * 59 + this.EffectiveRange.GetHashCode();
                return hashCode;
            }
        }

    }
}
