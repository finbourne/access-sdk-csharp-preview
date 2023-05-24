/*
 * FINBOURNE Access Management API
 *
 * ### Introduction    This page documents the LUSID Access Management APIs from FINBOURNE Technology, which allow authorised users to query and update their access control policies and roles within the LUSID platform's Identity and Access Management system.    
 *
 * The version of the OpenAPI document: 0.0.3001
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
    /// The possible results of an evaluation
    /// </summary>
    /// <value>The possible results of an evaluation</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EvaluationResult
    {
        /// <summary>
        /// Enum Denied for value: Denied
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied = 1,

        /// <summary>
        /// Enum Granted for value: Granted
        /// </summary>
        [EnumMember(Value = "Granted")]
        Granted = 2,

        /// <summary>
        /// Enum DeniedAsLicenceRequired for value: DeniedAsLicenceRequired
        /// </summary>
        [EnumMember(Value = "DeniedAsLicenceRequired")]
        DeniedAsLicenceRequired = 3

    }

}
