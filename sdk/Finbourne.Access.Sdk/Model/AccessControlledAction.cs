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
    /// AccessControlledAction
    /// </summary>
    [DataContract(Name = "AccessControlledAction")]
    public partial class AccessControlledAction : IEquatable<AccessControlledAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessControlledAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledAction" /> class.
        /// </summary>
        /// <param name="description">description (required).</param>
        /// <param name="action">action (required).</param>
        /// <param name="limitedSet">limitedSet.</param>
        /// <param name="links">links.</param>
        public AccessControlledAction(string description = default(string), ActionId action = default(ActionId), List<IdSelectorDefinition> limitedSet = default(List<IdSelectorDefinition>), List<Link> links = default(List<Link>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for AccessControlledAction and cannot be null");
            // to ensure "action" is required (not null)
            this.Action = action ?? throw new ArgumentNullException("action is a required property for AccessControlledAction and cannot be null");
            this.LimitedSet = limitedSet;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = false)]
        public ActionId Action { get; set; }

        /// <summary>
        /// Gets or Sets LimitedSet
        /// </summary>
        [DataMember(Name = "limitedSet", EmitDefaultValue = true)]
        public List<IdSelectorDefinition> LimitedSet { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessControlledAction {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  LimitedSet: ").Append(LimitedSet).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as AccessControlledAction);
        }

        /// <summary>
        /// Returns true if AccessControlledAction instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlledAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlledAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.LimitedSet == input.LimitedSet ||
                    this.LimitedSet != null &&
                    input.LimitedSet != null &&
                    this.LimitedSet.SequenceEqual(input.LimitedSet)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.LimitedSet != null)
                    hashCode = hashCode * 59 + this.LimitedSet.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
