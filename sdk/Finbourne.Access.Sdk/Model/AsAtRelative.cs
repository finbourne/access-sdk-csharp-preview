/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.       # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3915
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
