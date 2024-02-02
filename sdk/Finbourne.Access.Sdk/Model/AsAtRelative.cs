/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3667
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
    /// AsAtRelative
    /// </summary>
    [DataContract(Name = "AsAtRelative")]
    public partial class AsAtRelative : IEquatable<AsAtRelative>
    {

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public PointInTimeSpecification? Date { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public DateUnit? Unit { get; set; }

        /// <summary>
        /// Gets or Sets RelativeToDateTime
        /// </summary>
        [DataMember(Name = "relativeToDateTime", EmitDefaultValue = false)]
        public RelativeToDateTime? RelativeToDateTime { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsAtRelative" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="adjustment">adjustment.</param>
        /// <param name="unit">unit.</param>
        /// <param name="relativeToDateTime">relativeToDateTime.</param>
        public AsAtRelative(PointInTimeSpecification? date = default(PointInTimeSpecification?), int adjustment = default(int), DateUnit? unit = default(DateUnit?), RelativeToDateTime? relativeToDateTime = default(RelativeToDateTime?))
        {
            this.Date = date;
            this.Adjustment = adjustment;
            this.Unit = unit;
            this.RelativeToDateTime = relativeToDateTime;
        }

        /// <summary>
        /// Gets or Sets Adjustment
        /// </summary>
        [DataMember(Name = "adjustment", EmitDefaultValue = true)]
        public int Adjustment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsAtRelative {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  RelativeToDateTime: ").Append(RelativeToDateTime).Append("\n");
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
            return this.Equals(input as AsAtRelative);
        }

        /// <summary>
        /// Returns true if AsAtRelative instances are equal
        /// </summary>
        /// <param name="input">Instance of AsAtRelative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsAtRelative input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    this.Date.Equals(input.Date)
                ) && 
                (
                    this.Adjustment == input.Adjustment ||
                    this.Adjustment.Equals(input.Adjustment)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
                ) && 
                (
                    this.RelativeToDateTime == input.RelativeToDateTime ||
                    this.RelativeToDateTime.Equals(input.RelativeToDateTime)
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
                hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Adjustment.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.RelativeToDateTime.GetHashCode();
                return hashCode;
            }
        }

    }
}
