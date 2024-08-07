/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3904
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
    /// Specification for a server side evaluation of entitlement.
    /// </summary>
    [DataContract(Name = "EvaluationRequest")]
    public partial class EvaluationRequest : IEquatable<EvaluationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRequest" /> class.
        /// </summary>
        /// <param name="request">request (required).</param>
        /// <param name="resource">resource (required).</param>
        public EvaluationRequest(RequestDetails request = default(RequestDetails), ResourceDetails resource = default(ResourceDetails))
        {
            // to ensure "request" is required (not null)
            this.Request = request ?? throw new ArgumentNullException("request is a required property for EvaluationRequest and cannot be null");
            // to ensure "resource" is required (not null)
            this.Resource = resource ?? throw new ArgumentNullException("resource is a required property for EvaluationRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", IsRequired = true, EmitDefaultValue = false)]
        public RequestDetails Request { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        public ResourceDetails Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationRequest {\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as EvaluationRequest);
        }

        /// <summary>
        /// Returns true if EvaluationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }

    }
}
