/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3616
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
    /// Request to create a policy
    /// </summary>
    [DataContract(Name = "PolicyCreationRequest")]
    public partial class PolicyCreationRequest : IEquatable<PolicyCreationRequest>
    {

        /// <summary>
        /// Gets or Sets Grant
        /// </summary>
        [DataMember(Name = "grant", IsRequired = true, EmitDefaultValue = false)]
        public Grant Grant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCreationRequest" /> class.
        /// </summary>
        /// <param name="code">Code of the policy being created (required).</param>
        /// <param name="description">Description of what the policy will be used for.</param>
        /// <param name="applications">Applications this policy is used with.</param>
        /// <param name="grant">grant (required).</param>
        /// <param name="selectors">Selectors that identify what resources this policy qualifies for (required).</param>
        /// <param name="_for">\&quot;For Specification\&quot; for when the policy is to be applied.</param>
        /// <param name="_if">\&quot;If Specification\&quot; for when the policy is to be applied.</param>
        /// <param name="when">when (required).</param>
        /// <param name="how">how.</param>
        public PolicyCreationRequest(string code = default(string), string description = default(string), List<string> applications = default(List<string>), Grant grant = default(Grant), List<SelectorDefinition> selectors = default(List<SelectorDefinition>), List<ForSpec> _for = default(List<ForSpec>), List<IfExpression> _if = default(List<IfExpression>), WhenSpec when = default(WhenSpec), HowSpec how = default(HowSpec))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for PolicyCreationRequest and cannot be null");
            this.Grant = grant;
            // to ensure "selectors" is required (not null)
            this.Selectors = selectors ?? throw new ArgumentNullException("selectors is a required property for PolicyCreationRequest and cannot be null");
            // to ensure "when" is required (not null)
            this.When = when ?? throw new ArgumentNullException("when is a required property for PolicyCreationRequest and cannot be null");
            this.Description = description;
            this.Applications = applications;
            this.For = _for;
            this.If = _if;
            this.How = how;
        }

        /// <summary>
        /// Code of the policy being created
        /// </summary>
        /// <value>Code of the policy being created</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Description of what the policy will be used for
        /// </summary>
        /// <value>Description of what the policy will be used for</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Applications this policy is used with
        /// </summary>
        /// <value>Applications this policy is used with</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// Selectors that identify what resources this policy qualifies for
        /// </summary>
        /// <value>Selectors that identify what resources this policy qualifies for</value>
        [DataMember(Name = "selectors", IsRequired = true, EmitDefaultValue = false)]
        public List<SelectorDefinition> Selectors { get; set; }

        /// <summary>
        /// \&quot;For Specification\&quot; for when the policy is to be applied
        /// </summary>
        /// <value>\&quot;For Specification\&quot; for when the policy is to be applied</value>
        [DataMember(Name = "for", EmitDefaultValue = true)]
        public List<ForSpec> For { get; set; }

        /// <summary>
        /// \&quot;If Specification\&quot; for when the policy is to be applied
        /// </summary>
        /// <value>\&quot;If Specification\&quot; for when the policy is to be applied</value>
        [DataMember(Name = "if", EmitDefaultValue = true)]
        public List<IfExpression> If { get; set; }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", IsRequired = true, EmitDefaultValue = false)]
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
            sb.Append("class PolicyCreationRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
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
            return this.Equals(input as PolicyCreationRequest);
        }

        /// <summary>
        /// Returns true if PolicyCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
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
