/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2474
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
    /// NonTransitiveSupervisorRoleResource
    /// </summary>
    [DataContract(Name = "NonTransitiveSupervisorRoleResource")]
    public partial class NonTransitiveSupervisorRoleResource : IEquatable<NonTransitiveSupervisorRoleResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonTransitiveSupervisorRoleResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonTransitiveSupervisorRoleResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonTransitiveSupervisorRoleResource" /> class.
        /// </summary>
        /// <param name="roles">roles (required).</param>
        public NonTransitiveSupervisorRoleResource(List<Dictionary<string, string>> roles = default(List<Dictionary<string, string>>))
        {
            // to ensure "roles" is required (not null)
            this.Roles = roles ?? throw new ArgumentNullException("roles is a required property for NonTransitiveSupervisorRoleResource and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", IsRequired = true, EmitDefaultValue = false)]
        public List<Dictionary<string, string>> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonTransitiveSupervisorRoleResource {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as NonTransitiveSupervisorRoleResource);
        }

        /// <summary>
        /// Returns true if NonTransitiveSupervisorRoleResource instances are equal
        /// </summary>
        /// <param name="input">Instance of NonTransitiveSupervisorRoleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonTransitiveSupervisorRoleResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }

    }
}
