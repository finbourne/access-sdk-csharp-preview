/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.       # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3922
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
    /// A fully qualified action identifier
    /// </summary>
    [DataContract(Name = "RequestedActionKey")]
    public partial class RequestedActionKey : IEquatable<RequestedActionKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestedActionKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        /// <param name="entityCode">The type of the resource on which the activity would be performed (required).</param>
        /// <param name="scope">The scope/provider/vendor of the activity (required).</param>
        /// <param name="activity">The identifier of the action to be performed on the resource (required).</param>
        public RequestedActionKey(string entityCode = default(string), string scope = default(string), string activity = default(string))
        {
            // to ensure "entityCode" is required (not null)
            this.EntityCode = entityCode ?? throw new ArgumentNullException("entityCode is a required property for RequestedActionKey and cannot be null");
            // to ensure "scope" is required (not null)
            this.Scope = scope ?? throw new ArgumentNullException("scope is a required property for RequestedActionKey and cannot be null");
            // to ensure "activity" is required (not null)
            this.Activity = activity ?? throw new ArgumentNullException("activity is a required property for RequestedActionKey and cannot be null");
        }

        /// <summary>
        /// The type of the resource on which the activity would be performed
        /// </summary>
        /// <value>The type of the resource on which the activity would be performed</value>
        [DataMember(Name = "entityCode", IsRequired = true, EmitDefaultValue = false)]
        public string EntityCode { get; set; }

        /// <summary>
        /// The scope/provider/vendor of the activity
        /// </summary>
        /// <value>The scope/provider/vendor of the activity</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// The identifier of the action to be performed on the resource
        /// </summary>
        /// <value>The identifier of the action to be performed on the resource</value>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = false)]
        public string Activity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestedActionKey {\n");
            sb.Append("  EntityCode: ").Append(EntityCode).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
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
            return this.Equals(input as RequestedActionKey);
        }

        /// <summary>
        /// Returns true if RequestedActionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestedActionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestedActionKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityCode == input.EntityCode ||
                    (this.EntityCode != null &&
                    this.EntityCode.Equals(input.EntityCode))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
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
                if (this.EntityCode != null)
                    hashCode = hashCode * 59 + this.EntityCode.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                return hashCode;
            }
        }

    }
}
