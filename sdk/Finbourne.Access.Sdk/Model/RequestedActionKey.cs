/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3334
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
    /// A fully qualified action identifier
    /// </summary>
    [DataContract(Name = "RequestedActionKey")]
    public partial class RequestedActionKey : IEquatable<RequestedActionKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestedActionKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedActionKey" /> class.
        /// </summary>
        /// <param name="entityCode">The type of the resource on which the activity would be performed (required).</param>
        /// <param name="scope">The scope/provider/vendor of the activity (required).</param>
        /// <param name="activity">The identifier of the action to be performed on the resource (required).</param>
        public RequestedActionKey(string entityCode = default(string), string scope = default(string), string activity = default(string))
        {
            // to ensure "entityCode" is required (not null)
            this.EntityCode = entityCode ?? throw new ArgumentNullException("entityCode is a required property for RequestedActionKey and cannot be null");
            // to ensure "scope" is required (not null)
            this.Scope = scope ?? throw new ArgumentNullException("scope is a required property for RequestedActionKey and cannot be null");
            // to ensure "activity" is required (not null)
            this.Activity = activity ?? throw new ArgumentNullException("activity is a required property for RequestedActionKey and cannot be null");
        }

        /// <summary>
        /// The type of the resource on which the activity would be performed
        /// </summary>
        /// <value>The type of the resource on which the activity would be performed</value>
        [DataMember(Name = "entityCode", IsRequired = true, EmitDefaultValue = false)]
        public string EntityCode { get; set; }

        /// <summary>
        /// The scope/provider/vendor of the activity
        /// </summary>
        /// <value>The scope/provider/vendor of the activity</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// The identifier of the action to be performed on the resource
        /// </summary>
        /// <value>The identifier of the action to be performed on the resource</value>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = false)]
        public string Activity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestedActionKey {\n");
            sb.Append("  EntityCode: ").Append(EntityCode).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
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
            return this.Equals(input as RequestedActionKey);
        }

        /// <summary>
        /// Returns true if RequestedActionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestedActionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestedActionKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityCode == input.EntityCode ||
                    (this.EntityCode != null &&
                    this.EntityCode.Equals(input.EntityCode))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
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
                if (this.EntityCode != null)
                    hashCode = hashCode * 59 + this.EntityCode.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                return hashCode;
            }
        }

    }
}
