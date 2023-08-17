/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3192
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
    /// IfIdentityScopeExpression
    /// </summary>
    [DataContract(Name = "IfIdentityScopeExpression")]
    public partial class IfIdentityScopeExpression : IEquatable<IfIdentityScopeExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IfIdentityScopeExpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IfIdentityScopeExpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IfIdentityScopeExpression" /> class.
        /// </summary>
        /// <param name="scopeName">scopeName (required).</param>
        public IfIdentityScopeExpression(string scopeName = default(string))
        {
            // to ensure "scopeName" is required (not null)
            this.ScopeName = scopeName ?? throw new ArgumentNullException("scopeName is a required property for IfIdentityScopeExpression and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ScopeName
        /// </summary>
        [DataMember(Name = "scopeName", IsRequired = true, EmitDefaultValue = false)]
        public string ScopeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IfIdentityScopeExpression {\n");
            sb.Append("  ScopeName: ").Append(ScopeName).Append("\n");
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
            return this.Equals(input as IfIdentityScopeExpression);
        }

        /// <summary>
        /// Returns true if IfIdentityScopeExpression instances are equal
        /// </summary>
        /// <param name="input">Instance of IfIdentityScopeExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IfIdentityScopeExpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeName == input.ScopeName ||
                    (this.ScopeName != null &&
                    this.ScopeName.Equals(input.ScopeName))
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
                if (this.ScopeName != null)
                    hashCode = hashCode * 59 + this.ScopeName.GetHashCode();
                return hashCode;
            }
        }

    }
}
