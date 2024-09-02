/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.       # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3923
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
    /// Templated selector for a policy template
    /// </summary>
    [DataContract(Name = "PolicyTemplatedSelector")]
    public partial class PolicyTemplatedSelector : IEquatable<PolicyTemplatedSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTemplatedSelector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyTemplatedSelector() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTemplatedSelector" /> class.
        /// </summary>
        /// <param name="application">The application that this selector definition applies to (required).</param>
        /// <param name="tag">The type of policy that this selector definition applies to (required).</param>
        /// <param name="selector">selector (required).</param>
        public PolicyTemplatedSelector(string application = default(string), string tag = default(string), SelectorDefinition selector = default(SelectorDefinition))
        {
            // to ensure "application" is required (not null)
            this.Application = application ?? throw new ArgumentNullException("application is a required property for PolicyTemplatedSelector and cannot be null");
            // to ensure "tag" is required (not null)
            this.Tag = tag ?? throw new ArgumentNullException("tag is a required property for PolicyTemplatedSelector and cannot be null");
            // to ensure "selector" is required (not null)
            this.Selector = selector ?? throw new ArgumentNullException("selector is a required property for PolicyTemplatedSelector and cannot be null");
        }

        /// <summary>
        /// The application that this selector definition applies to
        /// </summary>
        /// <value>The application that this selector definition applies to</value>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// The type of policy that this selector definition applies to
        /// </summary>
        /// <value>The type of policy that this selector definition applies to</value>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Selector
        /// </summary>
        [DataMember(Name = "selector", IsRequired = true, EmitDefaultValue = false)]
        public SelectorDefinition Selector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTemplatedSelector {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
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
            return this.Equals(input as PolicyTemplatedSelector);
        }

        /// <summary>
        /// Returns true if PolicyTemplatedSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyTemplatedSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyTemplatedSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Selector == input.Selector ||
                    (this.Selector != null &&
                    this.Selector.Equals(input.Selector))
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
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Selector != null)
                    hashCode = hashCode * 59 + this.Selector.GetHashCode();
                return hashCode;
            }
        }

    }
}
