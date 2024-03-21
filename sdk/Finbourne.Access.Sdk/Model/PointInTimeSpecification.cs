/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3752
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
    /// Defines PointInTimeSpecification
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PointInTimeSpecification
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum Now for value: Now
        /// </summary>
        [EnumMember(Value = "Now")]
        Now = 2,

        /// <summary>
        /// Enum FirstOfMonth for value: FirstOfMonth
        /// </summary>
        [EnumMember(Value = "FirstOfMonth")]
        FirstOfMonth = 3,

        /// <summary>
        /// Enum FirstBusinessDayOfTheMonth for value: FirstBusinessDayOfTheMonth
        /// </summary>
        [EnumMember(Value = "FirstBusinessDayOfTheMonth")]
        FirstBusinessDayOfTheMonth = 4,

        /// <summary>
        /// Enum LastDayOfTheMonth for value: LastDayOfTheMonth
        /// </summary>
        [EnumMember(Value = "LastDayOfTheMonth")]
        LastDayOfTheMonth = 5,

        /// <summary>
        /// Enum LastBusinessDayOfMonth for value: LastBusinessDayOfMonth
        /// </summary>
        [EnumMember(Value = "LastBusinessDayOfMonth")]
        LastBusinessDayOfMonth = 6,

        /// <summary>
        /// Enum FirstDayOfYear for value: FirstDayOfYear
        /// </summary>
        [EnumMember(Value = "FirstDayOfYear")]
        FirstDayOfYear = 7,

        /// <summary>
        /// Enum LastDayOfYear for value: LastDayOfYear
        /// </summary>
        [EnumMember(Value = "LastDayOfYear")]
        LastDayOfYear = 8

    }

}
