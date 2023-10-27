/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3396
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
    /// LusidValidationProblemDetails
    /// </summary>
    [DataContract(Name = "LusidValidationProblemDetails")]
    public partial class LusidValidationProblemDetails : IEquatable<LusidValidationProblemDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidValidationProblemDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LusidValidationProblemDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidValidationProblemDetails" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="errorDetails">errorDetails.</param>
        /// <param name="code">code (required).</param>
        /// <param name="errors">errors.</param>
        /// <param name="type">type.</param>
        /// <param name="title">title.</param>
        /// <param name="status">status.</param>
        /// <param name="detail">detail.</param>
        /// <param name="instance">instance.</param>
        public LusidValidationProblemDetails(string name = default(string), List<Dictionary<string, string>> errorDetails = default(List<Dictionary<string, string>>), int code = default(int), Dictionary<string, List<string>> errors = default(Dictionary<string, List<string>>), string type = default(string), string title = default(string), int? status = default(int?), string detail = default(string), string instance = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for LusidValidationProblemDetails and cannot be null");
            this.Code = code;
            this.ErrorDetails = errorDetails;
            this.Errors = errors;
            this.Type = type;
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name = "errorDetails", EmitDefaultValue = true)]
        public List<Dictionary<string, string>> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public int Code { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = true)]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name = "instance", EmitDefaultValue = true)]
        public string Instance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LusidValidationProblemDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
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
            return this.Equals(input as LusidValidationProblemDetails);
        }

        /// <summary>
        /// Returns true if LusidValidationProblemDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LusidValidationProblemDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LusidValidationProblemDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ErrorDetails == input.ErrorDetails ||
                    this.ErrorDetails != null &&
                    input.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(input.ErrorDetails)
                ) && 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                return hashCode;
            }
        }

    }
}
