/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3262
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
    /// MetadataSelectorDefinition
    /// </summary>
    [DataContract(Name = "MetadataSelectorDefinition")]
    public partial class MetadataSelectorDefinition : IEquatable<MetadataSelectorDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSelectorDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataSelectorDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSelectorDefinition" /> class.
        /// </summary>
        /// <param name="expressions">expressions (required).</param>
        /// <param name="actions">actions (required).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        public MetadataSelectorDefinition(List<MetadataExpression> expressions = default(List<MetadataExpression>), List<ActionId> actions = default(List<ActionId>), string name = default(string), string description = default(string))
        {
            // to ensure "expressions" is required (not null)
            this.Expressions = expressions ?? throw new ArgumentNullException("expressions is a required property for MetadataSelectorDefinition and cannot be null");
            // to ensure "actions" is required (not null)
            this.Actions = actions ?? throw new ArgumentNullException("actions is a required property for MetadataSelectorDefinition and cannot be null");
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Expressions
        /// </summary>
        [DataMember(Name = "expressions", IsRequired = true, EmitDefaultValue = false)]
        public List<MetadataExpression> Expressions { get; set; }

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
            sb.Append("class MetadataSelectorDefinition {\n");
            sb.Append("  Expressions: ").Append(Expressions).Append("\n");
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
            return this.Equals(input as MetadataSelectorDefinition);
        }

        /// <summary>
        /// Returns true if MetadataSelectorDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataSelectorDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataSelectorDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expressions == input.Expressions ||
                    this.Expressions != null &&
                    input.Expressions != null &&
                    this.Expressions.SequenceEqual(input.Expressions)
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
                if (this.Expressions != null)
                    hashCode = hashCode * 59 + this.Expressions.GetHashCode();
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
