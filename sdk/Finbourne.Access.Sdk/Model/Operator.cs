/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3416
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
    /// Defines Operator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Operator
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum Equals for value: Equals
        /// </summary>
        [EnumMember(Value = "Equals")]
        Equals = 2,

        /// <summary>
        /// Enum NotEquals for value: NotEquals
        /// </summary>
        [EnumMember(Value = "NotEquals")]
        NotEquals = 3,

        /// <summary>
        /// Enum GreaterThan for value: GreaterThan
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        GreaterThan = 4,

        /// <summary>
        /// Enum GreaterThanOrEqualTo for value: GreaterThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "GreaterThanOrEqualTo")]
        GreaterThanOrEqualTo = 5,

        /// <summary>
        /// Enum LessThan for value: LessThan
        /// </summary>
        [EnumMember(Value = "LessThan")]
        LessThan = 6,

        /// <summary>
        /// Enum LessThanOrEqualTo for value: LessThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "LessThanOrEqualTo")]
        LessThanOrEqualTo = 7,

        /// <summary>
        /// Enum In for value: In
        /// </summary>
        [EnumMember(Value = "In")]
        In = 8

    }

}
