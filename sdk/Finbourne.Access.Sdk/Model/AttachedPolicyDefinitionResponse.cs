/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.       # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3946
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
    /// AttachedPolicyDefinitionResponse
    /// </summary>
    [DataContract(Name = "AttachedPolicyDefinitionResponse")]
    public partial class AttachedPolicyDefinitionResponse : IEquatable<AttachedPolicyDefinitionResponse>
    {

        /// <summary>
        /// Gets or Sets PolicyType
        /// </summary>
        [DataMember(Name = "policyType", EmitDefaultValue = false)]
        public PolicyType? PolicyType { get; set; }

        /// <summary>
        /// Gets or Sets Grant
        /// </summary>
        [DataMember(Name = "grant", EmitDefaultValue = false)]
        public Grant? Grant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedPolicyDefinitionResponse" /> class.
        /// </summary>
        /// <param name="sourceRole">sourceRole.</param>
        /// <param name="roleHierarchyIndex">roleHierarchyIndex.</param>
        /// <param name="description">description.</param>
        /// <param name="applications">applications.</param>
        /// <param name="policyType">policyType.</param>
        /// <param name="id">id.</param>
        /// <param name="grant">grant.</param>
        /// <param name="selectors">selectors.</param>
        /// <param name="_for">_for.</param>
        /// <param name="_if">_if.</param>
        /// <param name="when">when.</param>
        /// <param name="how">how.</param>
        public AttachedPolicyDefinitionResponse(RoleId sourceRole = default(RoleId), int roleHierarchyIndex = default(int), string description = default(string), List<string> applications = default(List<string>), PolicyType? policyType = default(PolicyType?), PolicyId id = default(PolicyId), Grant? grant = default(Grant?), List<SelectorDefinition> selectors = default(List<SelectorDefinition>), List<ForSpec> _for = default(List<ForSpec>), List<IfExpression> _if = default(List<IfExpression>), WhenSpec when = default(WhenSpec), HowSpec how = default(HowSpec))
        {
            this.SourceRole = sourceRole;
            this.RoleHierarchyIndex = roleHierarchyIndex;
            this.Description = description;
            this.Applications = applications;
            this.PolicyType = policyType;
            this.Id = id;
            this.Grant = grant;
            this.Selectors = selectors;
            this.For = _for;
            this.If = _if;
            this.When = when;
            this.How = how;
        }

        /// <summary>
        /// Gets or Sets SourceRole
        /// </summary>
        [DataMember(Name = "sourceRole", EmitDefaultValue = false)]
        public RoleId SourceRole { get; set; }

        /// <summary>
        /// Gets or Sets RoleHierarchyIndex
        /// </summary>
        [DataMember(Name = "roleHierarchyIndex", EmitDefaultValue = true)]
        public int RoleHierarchyIndex { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public PolicyId Id { get; set; }

        /// <summary>
        /// Gets or Sets Selectors
        /// </summary>
        [DataMember(Name = "selectors", EmitDefaultValue = true)]
        public List<SelectorDefinition> Selectors { get; set; }

        /// <summary>
        /// Gets or Sets For
        /// </summary>
        [DataMember(Name = "for", EmitDefaultValue = true)]
        public List<ForSpec> For { get; set; }

        /// <summary>
        /// Gets or Sets If
        /// </summary>
        [DataMember(Name = "if", EmitDefaultValue = true)]
        public List<IfExpression> If { get; set; }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", EmitDefaultValue = false)]
        public WhenSpec When { get; set; }

        /// <summary>
        /// Gets or Sets How
        /// </summary>
        [DataMember(Name = "how", EmitDefaultValue = false)]
        public HowSpec How { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedPolicyDefinitionResponse {\n");
            sb.Append("  SourceRole: ").Append(SourceRole).Append("\n");
            sb.Append("  RoleHierarchyIndex: ").Append(RoleHierarchyIndex).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  PolicyType: ").Append(PolicyType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Grant: ").Append(Grant).Append("\n");
            sb.Append("  Selectors: ").Append(Selectors).Append("\n");
            sb.Append("  For: ").Append(For).Append("\n");
            sb.Append("  If: ").Append(If).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  How: ").Append(How).Append("\n");
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
            return this.Equals(input as AttachedPolicyDefinitionResponse);
        }

        /// <summary>
        /// Returns true if AttachedPolicyDefinitionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachedPolicyDefinitionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachedPolicyDefinitionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceRole == input.SourceRole ||
                    (this.SourceRole != null &&
                    this.SourceRole.Equals(input.SourceRole))
                ) && 
                (
                    this.RoleHierarchyIndex == input.RoleHierarchyIndex ||
                    this.RoleHierarchyIndex.Equals(input.RoleHierarchyIndex)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    input.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
                ) && 
                (
                    this.PolicyType == input.PolicyType ||
                    this.PolicyType.Equals(input.PolicyType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Grant == input.Grant ||
                    this.Grant.Equals(input.Grant)
                ) && 
                (
                    this.Selectors == input.Selectors ||
                    this.Selectors != null &&
                    input.Selectors != null &&
                    this.Selectors.SequenceEqual(input.Selectors)
                ) && 
                (
                    this.For == input.For ||
                    this.For != null &&
                    input.For != null &&
                    this.For.SequenceEqual(input.For)
                ) && 
                (
                    this.If == input.If ||
                    this.If != null &&
                    input.If != null &&
                    this.If.SequenceEqual(input.If)
                ) && 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
                ) && 
                (
                    this.How == input.How ||
                    (this.How != null &&
                    this.How.Equals(input.How))
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
                if (this.SourceRole != null)
                    hashCode = hashCode * 59 + this.SourceRole.GetHashCode();
                hashCode = hashCode * 59 + this.RoleHierarchyIndex.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Grant.GetHashCode();
                if (this.Selectors != null)
                    hashCode = hashCode * 59 + this.Selectors.GetHashCode();
                if (this.For != null)
                    hashCode = hashCode * 59 + this.For.GetHashCode();
                if (this.If != null)
                    hashCode = hashCode * 59 + this.If.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                if (this.How != null)
                    hashCode = hashCode * 59 + this.How.GetHashCode();
                return hashCode;
            }
        }

    }
}
