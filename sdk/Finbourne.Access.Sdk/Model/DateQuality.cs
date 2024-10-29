/*
 * FINBOURNE Access Management API
 *
 * Access enables precise control over data and operations by managing permissions through a comprehensive role-based access control (RBAC) system. It works in conjunction with the Identity SDK.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"604\">604</a>|Policy Collection Does Not Exist|  | | <a name=\"605\">605</a>|Licence Not Found|  | | <a name=\"606\">606</a>|Insufficient Permissions|  | | <a name=\"607\">607</a>|Delegation Actions Must Use Policy Selector|  | | <a name=\"608\">608</a>|Incorrect Selector For Type|  | | <a name=\"609\">609</a>|Invalid Policy Scopes For Role Attachment|  | | <a name=\"610\">610</a>|Invalid Policy Types For Role Attachment|  | | <a name=\"611\">611</a>|Policy Actions Must Use Policy Selector|  | | <a name=\"612\">612</a>|Policy Collection With Code Already Exists|  | | <a name=\"613\">613</a>|Policy With Code Already Exists|  | | <a name=\"614\">614</a>|Role Resource Type Does Not Support Licences|  | | <a name=\"615\">615</a>|Role With Code Already Exists|  | | <a name=\"616\">616</a>|Target User Does Not Exist|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"772\">772</a>|Policy Does Not Exist|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"877\">877</a>|Policy Template With Code Already Exists|  | | <a name=\"878\">878</a>|Policy Template Does Not Exist|  | 
 *
 * The version of the OpenAPI document: 0.0.3991
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
