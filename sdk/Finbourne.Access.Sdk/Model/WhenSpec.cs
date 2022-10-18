/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2404
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
    /// WhenSpec
    /// </summary>
    [DataContract(Name = "WhenSpec")]
    public partial class WhenSpec : IEquatable<WhenSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhenSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhenSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhenSpec" /> class.
        /// </summary>
        /// <param name="activate">activate (required).</param>
        /// <param name="deactivate">deactivate.</param>
        public WhenSpec(DateTimeOffset activate = default(DateTimeOffset), DateTimeOffset? deactivate = default(DateTimeOffset?))
        {
            this.Activate = activate;
            this.Deactivate = deactivate;
        }

        /// <summary>
        /// Gets or Sets Activate
        /// </summary>
        [DataMember(Name = "activate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Activate { get; set; }

        /// <summary>
        /// Gets or Sets Deactivate
        /// </summary>
        [DataMember(Name = "deactivate", EmitDefaultValue = true)]
        public DateTimeOffset? Deactivate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhenSpec {\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
            sb.Append("  Deactivate: ").Append(Deactivate).Append("\n");
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
            return this.Equals(input as WhenSpec);
        }

        /// <summary>
        /// Returns true if WhenSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of WhenSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhenSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activate == input.Activate ||
                    (this.Activate != null &&
                    this.Activate.Equals(input.Activate))
                ) && 
                (
                    this.Deactivate == input.Deactivate ||
                    (this.Deactivate != null &&
                    this.Deactivate.Equals(input.Deactivate))
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
                if (this.Activate != null)
                    hashCode = hashCode * 59 + this.Activate.GetHashCode();
                if (this.Deactivate != null)
                    hashCode = hashCode * 59 + this.Deactivate.GetHashCode();
                return hashCode;
            }
        }

    }
}
