/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3638
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
    /// Response object from the policy API
    /// </summary>
    [DataContract(Name = "PolicyResponse")]
    public partial class PolicyResponse : IEquatable<PolicyResponse>
    {

        /// <summary>
        /// Gets or Sets Grant
        /// </summary>
        [DataMember(Name = "grant", EmitDefaultValue = false)]
        public Grant? Grant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">Description of what the policy is entitling.</param>
        /// <param name="applications">Applications to which the policy applies.</param>
        /// <param name="grant">grant.</param>
        /// <param name="selectors">Selectors that this policy will be applied to.</param>
        /// <param name="_for">\&quot;For Specification\&quot; for when the policy is to be applied.</param>
        /// <param name="_if">\&quot;If Specification\&quot; for when the policy is to be applied.</param>
        /// <param name="when">when.</param>
        /// <param name="how">how.</param>
        /// <param name="links">links.</param>
        public PolicyResponse(PolicyId id = default(PolicyId), string description = default(string), List<string> applications = default(List<string>), Grant? grant = default(Grant?), List<SelectorDefinition> selectors = default(List<SelectorDefinition>), List<ForSpec> _for = default(List<ForSpec>), List<IfExpression> _if = default(List<IfExpression>), WhenSpec when = default(WhenSpec), HowSpec how = default(HowSpec), List<Link> links = default(List<Link>))
        {
            this.Id = id;
            this.Description = description;
            this.Applications = applications;
            this.Grant = grant;
            this.Selectors = selectors;
            this.For = _for;
            this.If = _if;
            this.When = when;
            this.How = how;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public PolicyId Id { get; set; }

        /// <summary>
        /// Description of what the policy is entitling
        /// </summary>
        /// <value>Description of what the policy is entitling</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Applications to which the policy applies
        /// </summary>
        /// <value>Applications to which the policy applies</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// Selectors that this policy will be applied to
        /// </summary>
        /// <value>Selectors that this policy will be applied to</value>
        [DataMember(Name = "selectors", EmitDefaultValue = true)]
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
        [DataMember(Name = "when", EmitDefaultValue = false)]
        public WhenSpec When { get; set; }

        /// <summary>
        /// Gets or Sets How
        /// </summary>
        [DataMember(Name = "how", EmitDefaultValue = false)]
        public HowSpec How { get; set; }

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
            sb.Append("class PolicyResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Grant: ").Append(Grant).Append("\n");
            sb.Append("  Selectors: ").Append(Selectors).Append("\n");
            sb.Append("  For: ").Append(For).Append("\n");
            sb.Append("  If: ").Append(If).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  How: ").Append(How).Append("\n");
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
            return this.Equals(input as PolicyResponse);
        }

        /// <summary>
        /// Returns true if PolicyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
