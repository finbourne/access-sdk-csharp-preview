/*
 * FINBOURNE Access Management API
 *
 * Access enables precise control over data and operations by managing permissions through a comprehensive role-based access control (RBAC) system. It works in conjunction with the Identity SDK.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3994
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
