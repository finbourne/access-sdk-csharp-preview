/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.1768
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
    /// SelectorDefinition
    /// </summary>
    [DataContract(Name = "SelectorDefinition")]
    public partial class SelectorDefinition : IEquatable<SelectorDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectorDefinition" /> class.
        /// </summary>
        /// <param name="metadataSelectorDefinition">metadataSelectorDefinition.</param>
        /// <param name="idSelectorDefinition">idSelectorDefinition.</param>
        /// <param name="matchAllSelectorDefinition">matchAllSelectorDefinition.</param>
        /// <param name="policySelectorDefinition">policySelectorDefinition.</param>
        public SelectorDefinition(MetadataSelectorDefinition metadataSelectorDefinition = default(MetadataSelectorDefinition), IdSelectorDefinition idSelectorDefinition = default(IdSelectorDefinition), MatchAllSelectorDefinition matchAllSelectorDefinition = default(MatchAllSelectorDefinition), PolicySelectorDefinition policySelectorDefinition = default(PolicySelectorDefinition))
        {
            this.MetadataSelectorDefinition = metadataSelectorDefinition;
            this.IdSelectorDefinition = idSelectorDefinition;
            this.MatchAllSelectorDefinition = matchAllSelectorDefinition;
            this.PolicySelectorDefinition = policySelectorDefinition;
        }

        /// <summary>
        /// Gets or Sets MetadataSelectorDefinition
        /// </summary>
        [DataMember(Name = "metadataSelectorDefinition", EmitDefaultValue = false)]
        public MetadataSelectorDefinition MetadataSelectorDefinition { get; set; }

        /// <summary>
        /// Gets or Sets IdSelectorDefinition
        /// </summary>
        [DataMember(Name = "idSelectorDefinition", EmitDefaultValue = false)]
        public IdSelectorDefinition IdSelectorDefinition { get; set; }

        /// <summary>
        /// Gets or Sets MatchAllSelectorDefinition
        /// </summary>
        [DataMember(Name = "matchAllSelectorDefinition", EmitDefaultValue = false)]
        public MatchAllSelectorDefinition MatchAllSelectorDefinition { get; set; }

        /// <summary>
        /// Gets or Sets PolicySelectorDefinition
        /// </summary>
        [DataMember(Name = "policySelectorDefinition", EmitDefaultValue = false)]
        public PolicySelectorDefinition PolicySelectorDefinition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectorDefinition {\n");
            sb.Append("  MetadataSelectorDefinition: ").Append(MetadataSelectorDefinition).Append("\n");
            sb.Append("  IdSelectorDefinition: ").Append(IdSelectorDefinition).Append("\n");
            sb.Append("  MatchAllSelectorDefinition: ").Append(MatchAllSelectorDefinition).Append("\n");
            sb.Append("  PolicySelectorDefinition: ").Append(PolicySelectorDefinition).Append("\n");
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
            return this.Equals(input as SelectorDefinition);
        }

        /// <summary>
        /// Returns true if SelectorDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectorDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectorDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataSelectorDefinition == input.MetadataSelectorDefinition ||
                    (this.MetadataSelectorDefinition != null &&
                    this.MetadataSelectorDefinition.Equals(input.MetadataSelectorDefinition))
                ) && 
                (
                    this.IdSelectorDefinition == input.IdSelectorDefinition ||
                    (this.IdSelectorDefinition != null &&
                    this.IdSelectorDefinition.Equals(input.IdSelectorDefinition))
                ) && 
                (
                    this.MatchAllSelectorDefinition == input.MatchAllSelectorDefinition ||
                    (this.MatchAllSelectorDefinition != null &&
                    this.MatchAllSelectorDefinition.Equals(input.MatchAllSelectorDefinition))
                ) && 
                (
                    this.PolicySelectorDefinition == input.PolicySelectorDefinition ||
                    (this.PolicySelectorDefinition != null &&
                    this.PolicySelectorDefinition.Equals(input.PolicySelectorDefinition))
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
                if (this.MetadataSelectorDefinition != null)
                    hashCode = hashCode * 59 + this.MetadataSelectorDefinition.GetHashCode();
                if (this.IdSelectorDefinition != null)
                    hashCode = hashCode * 59 + this.IdSelectorDefinition.GetHashCode();
                if (this.MatchAllSelectorDefinition != null)
                    hashCode = hashCode * 59 + this.MatchAllSelectorDefinition.GetHashCode();
                if (this.PolicySelectorDefinition != null)
                    hashCode = hashCode * 59 + this.PolicySelectorDefinition.GetHashCode();
                return hashCode;
            }
        }

    }
}
