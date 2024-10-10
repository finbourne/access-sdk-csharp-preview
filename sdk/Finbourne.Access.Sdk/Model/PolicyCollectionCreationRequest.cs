/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.       # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3957
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
    /// Create a PolicyCollection, a logical group of Policies or other PolicyCollections
    /// </summary>
    [DataContract(Name = "PolicyCollectionCreationRequest")]
    public partial class PolicyCollectionCreationRequest : IEquatable<PolicyCollectionCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolicyCollectionCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCollectionCreationRequest" /> class.
        /// </summary>
        /// <param name="code">The identifier for the PolicyCollection being created (required).</param>
        /// <param name="policies">The identifiers of the Policies in this collection.</param>
        /// <param name="metadata">Any relevant metadata associated with this resource for controlling access to this resource.</param>
        /// <param name="policyCollections">The identifiers of the PolicyCollections in this collection.</param>
        /// <param name="description">A description of this policy collection.</param>
        public PolicyCollectionCreationRequest(string code = default(string), List<PolicyId> policies = default(List<PolicyId>), Dictionary<string, List<EntitlementMetadata>> metadata = default(Dictionary<string, List<EntitlementMetadata>>), List<PolicyCollectionId> policyCollections = default(List<PolicyCollectionId>), string description = default(string))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for PolicyCollectionCreationRequest and cannot be null");
            this.Policies = policies;
            this.Metadata = metadata;
            this.PolicyCollections = policyCollections;
            this.Description = description;
        }

        /// <summary>
        /// The identifier for the PolicyCollection being created
        /// </summary>
        /// <value>The identifier for the PolicyCollection being created</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The identifiers of the Policies in this collection
        /// </summary>
        /// <value>The identifiers of the Policies in this collection</value>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyId> Policies { get; set; }

        /// <summary>
        /// Any relevant metadata associated with this resource for controlling access to this resource
        /// </summary>
        /// <value>Any relevant metadata associated with this resource for controlling access to this resource</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, List<EntitlementMetadata>> Metadata { get; set; }

        /// <summary>
        /// The identifiers of the PolicyCollections in this collection
        /// </summary>
        /// <value>The identifiers of the PolicyCollections in this collection</value>
        [DataMember(Name = "policyCollections", EmitDefaultValue = true)]
        public List<PolicyCollectionId> PolicyCollections { get; set; }

        /// <summary>
        /// A description of this policy collection
        /// </summary>
        /// <value>A description of this policy collection</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyCollectionCreationRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PolicyCollections: ").Append(PolicyCollections).Append("\n");
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
            return this.Equals(input as PolicyCollectionCreationRequest);
        }

        /// <summary>
        /// Returns true if PolicyCollectionCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCollectionCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCollectionCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PolicyCollections == input.PolicyCollections ||
                    this.PolicyCollections != null &&
                    input.PolicyCollections != null &&
                    this.PolicyCollections.SequenceEqual(input.PolicyCollections)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PolicyCollections != null)
                    hashCode = hashCode * 59 + this.PolicyCollections.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
