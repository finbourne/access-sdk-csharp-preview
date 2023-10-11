/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3332
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
    /// Defines RelativeToDateTime
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RelativeToDateTime
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum BeforeOrOn for value: BeforeOrOn
        /// </summary>
        [EnumMember(Value = "BeforeOrOn")]
        BeforeOrOn = 2,

        /// <summary>
        /// Enum Before for value: Before
        /// </summary>
        [EnumMember(Value = "Before")]
        Before = 3,

        /// <summary>
        /// Enum OnDayOf for value: OnDayOf
        /// </summary>
        [EnumMember(Value = "OnDayOf")]
        OnDayOf = 4,

        /// <summary>
        /// Enum AfterOrOn for value: AfterOrOn
        /// </summary>
        [EnumMember(Value = "AfterOrOn")]
        AfterOrOn = 5,

        /// <summary>
        /// Enum After for value: After
        /// </summary>
        [EnumMember(Value = "After")]
        After = 6,

        /// <summary>
        /// Enum Exactly for value: Exactly
        /// </summary>
        [EnumMember(Value = "Exactly")]
        Exactly = 7

    }

}
