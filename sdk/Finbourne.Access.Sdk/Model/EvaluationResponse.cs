/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3714
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
    /// The result of an evaluation request
    /// </summary>
    [DataContract(Name = "EvaluationResponse")]
    public partial class EvaluationResponse : IEquatable<EvaluationResponse>
    {

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = false)]
        public EvaluationResult Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        /// <param name="result">result (required).</param>
        /// <param name="detailedMessage">In the case of the evaluation being denied a message may be returned.</param>
        public EvaluationResponse(EvaluationResult result = default(EvaluationResult), string detailedMessage = default(string))
        {
            this.Result = result;
            this.DetailedMessage = detailedMessage;
        }

        /// <summary>
        /// In the case of the evaluation being denied a message may be returned
        /// </summary>
        /// <value>In the case of the evaluation being denied a message may be returned</value>
        [DataMember(Name = "detailedMessage", EmitDefaultValue = true)]
        public string DetailedMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DetailedMessage: ").Append(DetailedMessage).Append("\n");
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
            return this.Equals(input as EvaluationResponse);
        }

        /// <summary>
        /// Returns true if EvaluationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.DetailedMessage == input.DetailedMessage ||
                    (this.DetailedMessage != null &&
                    this.DetailedMessage.Equals(input.DetailedMessage))
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
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.DetailedMessage != null)
                    hashCode = hashCode * 59 + this.DetailedMessage.GetHashCode();
                return hashCode;
            }
        }

    }
}
