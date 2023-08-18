/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3198
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
    /// Response object from the role API
    /// </summary>
    [DataContract(Name = "RoleResponse")]
    public partial class RoleResponse : IEquatable<RoleResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="roleHierarchyIndex">The hierarchical index of the role (required).</param>
        /// <param name="description">The description of the role.</param>
        /// <param name="resource">resource (required).</param>
        /// <param name="when">when (required).</param>
        /// <param name="permission">The action key of the role (required).</param>
        /// <param name="limit">The identifiers of the role with the maximum privileges that this role can have.</param>
        /// <param name="links">links.</param>
        public RoleResponse(RoleId id = default(RoleId), int roleHierarchyIndex = default(int), string description = default(string), RoleResourceRequest resource = default(RoleResourceRequest), WhenSpec when = default(WhenSpec), string permission = default(string), Dictionary<string, string> limit = default(Dictionary<string, string>), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for RoleResponse and cannot be null");
            this.RoleHierarchyIndex = roleHierarchyIndex;
            // to ensure "resource" is required (not null)
            this.Resource = resource ?? throw new ArgumentNullException("resource is a required property for RoleResponse and cannot be null");
            // to ensure "when" is required (not null)
            this.When = when ?? throw new ArgumentNullException("when is a required property for RoleResponse and cannot be null");
            // to ensure "permission" is required (not null)
            this.Permission = permission ?? throw new ArgumentNullException("permission is a required property for RoleResponse and cannot be null");
            this.Description = description;
            this.Limit = limit;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public RoleId Id { get; set; }

        /// <summary>
        /// The hierarchical index of the role
        /// </summary>
        /// <value>The hierarchical index of the role</value>
        [DataMember(Name = "roleHierarchyIndex", IsRequired = true, EmitDefaultValue = true)]
        public int RoleHierarchyIndex { get; set; }

        /// <summary>
        /// The description of the role
        /// </summary>
        /// <value>The description of the role</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        public RoleResourceRequest Resource { get; set; }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", IsRequired = true, EmitDefaultValue = false)]
        public WhenSpec When { get; set; }

        /// <summary>
        /// The action key of the role
        /// </summary>
        /// <value>The action key of the role</value>
        [DataMember(Name = "permission", IsRequired = true, EmitDefaultValue = false)]
        public string Permission { get; set; }

        /// <summary>
        /// The identifiers of the role with the maximum privileges that this role can have
        /// </summary>
        /// <value>The identifiers of the role with the maximum privileges that this role can have</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public Dictionary<string, string> Limit { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoleHierarchyIndex: ").Append(RoleHierarchyIndex).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as RoleResponse);
        }

        /// <summary>
        /// Returns true if RoleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RoleHierarchyIndex == input.RoleHierarchyIndex ||
                    this.RoleHierarchyIndex.Equals(input.RoleHierarchyIndex)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit != null &&
                    input.Limit != null &&
                    this.Limit.SequenceEqual(input.Limit)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.RoleHierarchyIndex.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
