/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.2420
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
    /// Defines DateQuality
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DateQuality
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum IsFirstDayOfAnyMonth for value: IsFirstDayOfAnyMonth
        /// </summary>
        [EnumMember(Value = "IsFirstDayOfAnyMonth")]
        IsFirstDayOfAnyMonth = 2,

        /// <summary>
        /// Enum IsLastDayOfAnyMonth for value: IsLastDayOfAnyMonth
        /// </summary>
        [EnumMember(Value = "IsLastDayOfAnyMonth")]
        IsLastDayOfAnyMonth = 3,

        /// <summary>
        /// Enum IsBusinessDayOfAnyMonth for value: IsBusinessDayOfAnyMonth
        /// </summary>
        [EnumMember(Value = "IsBusinessDayOfAnyMonth")]
        IsBusinessDayOfAnyMonth = 4,

        /// <summary>
        /// Enum IsFirstDayOfTheCurrentMonth for value: IsFirstDayOfTheCurrentMonth
        /// </summary>
        [EnumMember(Value = "IsFirstDayOfTheCurrentMonth")]
        IsFirstDayOfTheCurrentMonth = 5,

        /// <summary>
        /// Enum IsLastDayOfTheCurrentMonth for value: IsLastDayOfTheCurrentMonth
        /// </summary>
        [EnumMember(Value = "IsLastDayOfTheCurrentMonth")]
        IsLastDayOfTheCurrentMonth = 6,

        /// <summary>
        /// Enum IsBusinessDayOfTheCurrentMonth for value: IsBusinessDayOfTheCurrentMonth
        /// </summary>
        [EnumMember(Value = "IsBusinessDayOfTheCurrentMonth")]
        IsBusinessDayOfTheCurrentMonth = 7,

        /// <summary>
        /// Enum IsBeforeMidday for value: IsBeforeMidday
        /// </summary>
        [EnumMember(Value = "IsBeforeMidday")]
        IsBeforeMidday = 8,

        /// <summary>
        /// Enum IsBefore5pm for value: IsBefore5pm
        /// </summary>
        [EnumMember(Value = "IsBefore5pm")]
        IsBefore5pm = 9,

        /// <summary>
        /// Enum IsAfter5pm for value: IsAfter5pm
        /// </summary>
        [EnumMember(Value = "IsAfter5pm")]
        IsAfter5pm = 10

    }

}
