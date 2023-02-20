/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2771
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
    /// EffectiveDateHasQuality
    /// </summary>
    [DataContract(Name = "EffectiveDateHasQuality")]
    public partial class EffectiveDateHasQuality : IEquatable<EffectiveDateHasQuality>
    {

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public DateQuality? Quality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveDateHasQuality" /> class.
        /// </summary>
        /// <param name="quality">quality.</param>
        public EffectiveDateHasQuality(DateQuality? quality = default(DateQuality?))
        {
            this.Quality = quality;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EffectiveDateHasQuality {\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
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
            return this.Equals(input as EffectiveDateHasQuality);
        }

        /// <summary>
        /// Returns true if EffectiveDateHasQuality instances are equal
        /// </summary>
        /// <param name="input">Instance of EffectiveDateHasQuality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EffectiveDateHasQuality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quality == input.Quality ||
                    this.Quality.Equals(input.Quality)
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
                hashCode = hashCode * 59 + this.Quality.GetHashCode();
                return hashCode;
            }
        }

    }
}
