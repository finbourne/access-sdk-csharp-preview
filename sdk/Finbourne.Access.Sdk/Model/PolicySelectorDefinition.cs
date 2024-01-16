/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3600
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
    /// PolicySelectorDefinition
    /// </summary>
    [DataContract(Name = "PolicySelectorDefinition")]
    public partial class PolicySelectorDefinition : IEquatable<PolicySelectorDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicySelectorDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicySelectorDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicySelectorDefinition" /> class.
        /// </summary>
        /// <param name="identityRestriction">identityRestriction.</param>
        /// <param name="restrictionSelectors">restrictionSelectors.</param>
        /// <param name="actions">actions (required).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        public PolicySelectorDefinition(Dictionary<string, string> identityRestriction = default(Dictionary<string, string>), List<SelectorDefinition> restrictionSelectors = default(List<SelectorDefinition>), List<ActionId> actions = default(List<ActionId>), string name = default(string), string description = default(string))
        {
            // to ensure "actions" is required (not null)
            this.Actions = actions ?? throw new ArgumentNullException("actions is a required property for PolicySelectorDefinition and cannot be null");
            this.IdentityRestriction = identityRestriction;
            this.RestrictionSelectors = restrictionSelectors;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets IdentityRestriction
        /// </summary>
        [DataMember(Name = "identityRestriction", EmitDefaultValue = true)]
        public Dictionary<string, string> IdentityRestriction { get; set; }

        /// <summary>
        /// Gets or Sets RestrictionSelectors
        /// </summary>
        [DataMember(Name = "restrictionSelectors", EmitDefaultValue = true)]
        public List<SelectorDefinition> RestrictionSelectors { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = false)]
        public List<ActionId> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicySelectorDefinition {\n");
            sb.Append("  IdentityRestriction: ").Append(IdentityRestriction).Append("\n");
            sb.Append("  RestrictionSelectors: ").Append(RestrictionSelectors).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as PolicySelectorDefinition);
        }

        /// <summary>
        /// Returns true if PolicySelectorDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicySelectorDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicySelectorDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityRestriction == input.IdentityRestriction ||
                    this.IdentityRestriction != null &&
                    input.IdentityRestriction != null &&
                    this.IdentityRestriction.SequenceEqual(input.IdentityRestriction)
                ) && 
                (
                    this.RestrictionSelectors == input.RestrictionSelectors ||
                    this.RestrictionSelectors != null &&
                    input.RestrictionSelectors != null &&
                    this.RestrictionSelectors.SequenceEqual(input.RestrictionSelectors)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.IdentityRestriction != null)
                    hashCode = hashCode * 59 + this.IdentityRestriction.GetHashCode();
                if (this.RestrictionSelectors != null)
                    hashCode = hashCode * 59 + this.RestrictionSelectors.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
