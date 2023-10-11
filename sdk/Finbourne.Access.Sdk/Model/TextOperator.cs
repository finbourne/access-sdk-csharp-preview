/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3340
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
    /// Defines TextOperator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TextOperator
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum EqualsCaseSensitive for value: EqualsCaseSensitive
        /// </summary>
        [EnumMember(Value = "EqualsCaseSensitive")]
        EqualsCaseSensitive = 2,

        /// <summary>
        /// Enum EqualsCaseInsensitive for value: EqualsCaseInsensitive
        /// </summary>
        [EnumMember(Value = "EqualsCaseInsensitive")]
        EqualsCaseInsensitive = 3,

        /// <summary>
        /// Enum NotEqualsCaseSensitive for value: NotEqualsCaseSensitive
        /// </summary>
        [EnumMember(Value = "NotEqualsCaseSensitive")]
        NotEqualsCaseSensitive = 4,

        /// <summary>
        /// Enum NotEqualsCaseInsensitive for value: NotEqualsCaseInsensitive
        /// </summary>
        [EnumMember(Value = "NotEqualsCaseInsensitive")]
        NotEqualsCaseInsensitive = 5,

        /// <summary>
        /// Enum ContainsCaseSensitive for value: ContainsCaseSensitive
        /// </summary>
        [EnumMember(Value = "ContainsCaseSensitive")]
        ContainsCaseSensitive = 6,

        /// <summary>
        /// Enum NotPresentOrNotContainsCaseSensitive for value: NotPresentOrNotContainsCaseSensitive
        /// </summary>
        [EnumMember(Value = "NotPresentOrNotContainsCaseSensitive")]
        NotPresentOrNotContainsCaseSensitive = 7,

        /// <summary>
        /// Enum NotPresent for value: NotPresent
        /// </summary>
        [EnumMember(Value = "NotPresent")]
        NotPresent = 8

    }

}
