# Finbourne.Access.Sdk.Api.PolicyTemplatesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePolicyTemplate**](PolicyTemplatesApi.md#createpolicytemplate) | **POST** /api/policytemplates | [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template
[**DeletePolicyTemplate**](PolicyTemplatesApi.md#deletepolicytemplate) | **DELETE** /api/policytemplates/{code} | [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template
[**GeneratePolicyFromTemplate**](PolicyTemplatesApi.md#generatepolicyfromtemplate) | **POST** /api/policytemplates/$generatepolicy | [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template
[**GetPolicyTemplate**](PolicyTemplatesApi.md#getpolicytemplate) | **GET** /api/policytemplates/{code} | [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template
[**ListPolicyTemplates**](PolicyTemplatesApi.md#listpolicytemplates) | **GET** /api/policytemplates | [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates
[**UpdatePolicyTemplate**](PolicyTemplatesApi.md#updatepolicytemplate) | **PUT** /api/policytemplates/{code} | [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template


<a name="createpolicytemplate"></a>
# **CreatePolicyTemplate**
> PolicyTemplateResponse CreatePolicyTemplate (PolicyTemplateCreationRequest policyTemplateCreationRequest)

[EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template

Creates a Policy Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreatePolicyTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var policyTemplateCreationRequest = new PolicyTemplateCreationRequest(); // PolicyTemplateCreationRequest | The definition of the policy template

            try
            {
                // [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template
                PolicyTemplateResponse result = apiInstance.CreatePolicyTemplate(policyTemplateCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.CreatePolicyTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyTemplateCreationRequest** | [**PolicyTemplateCreationRequest**](PolicyTemplateCreationRequest.md)| The definition of the policy template | 

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepolicytemplate"></a>
# **DeletePolicyTemplate**
> void DeletePolicyTemplate (string code, string scope = null)

[EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template

Deletes an identified Policy Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeletePolicyTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var code = code_example;  // string | The code of the Policy Template
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy Template (optional) 

            try
            {
                // [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template
                apiInstance.DeletePolicyTemplate(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.DeletePolicyTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the Policy Template | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy Template | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatepolicyfromtemplate"></a>
# **GeneratePolicyFromTemplate**
> GeneratedPolicyComponents GeneratePolicyFromTemplate (GeneratePolicyFromTemplateRequest generatePolicyFromTemplateRequest, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template

Generates policies from templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GeneratePolicyFromTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var generatePolicyFromTemplateRequest = new GeneratePolicyFromTemplateRequest(); // GeneratePolicyFromTemplateRequest | Definition of the generate request
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 

            try
            {
                // [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template
                GeneratedPolicyComponents result = apiInstance.GeneratePolicyFromTemplate(generatePolicyFromTemplateRequest, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.GeneratePolicyFromTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generatePolicyFromTemplateRequest** | [**GeneratePolicyFromTemplateRequest**](GeneratePolicyFromTemplateRequest.md)| Definition of the generate request | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 

### Return type

[**GeneratedPolicyComponents**](GeneratedPolicyComponents.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicytemplate"></a>
# **GetPolicyTemplate**
> PolicyTemplateResponse GetPolicyTemplate (string code, DateTimeOffset? asAt = null, string scope = null)

[EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template

Gets an identified Policy Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetPolicyTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var code = code_example;  // string | The code of the Policy Template
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data. If not specified defaults to current time (optional) 
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy Template (optional) 

            try
            {
                // [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template
                PolicyTemplateResponse result = apiInstance.GetPolicyTemplate(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.GetPolicyTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the Policy Template | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data. If not specified defaults to current time | [optional] 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy Template | [optional] 

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a specific Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpolicytemplates"></a>
# **ListPolicyTemplates**
> ICollection&lt;PolicyTemplateResponse&gt; ListPolicyTemplates (DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListPolicyTemplates: List Policy Templates

Gets all Policy Templates with pagination support.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListPolicyTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 

            try
            {
                // [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates
                ICollection<PolicyTemplateResponse> result = apiInstance.ListPolicyTemplates(asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.ListPolicyTemplates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 

### Return type

[**ICollection&lt;PolicyTemplateResponse&gt;**](PolicyTemplateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Policy Templates |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepolicytemplate"></a>
# **UpdatePolicyTemplate**
> PolicyTemplateResponse UpdatePolicyTemplate (string code, PolicyTemplateUpdateRequest policyTemplateUpdateRequest = null)

[EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template

Updates an identified Policy Template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdatePolicyTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PolicyTemplatesApi(config);
            var code = code_example;  // string | Code of the policy template to update
            var policyTemplateUpdateRequest = new PolicyTemplateUpdateRequest(); // PolicyTemplateUpdateRequest | Definition of the updated policy template (optional) 

            try
            {
                // [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template
                PolicyTemplateResponse result = apiInstance.UpdatePolicyTemplate(code, policyTemplateUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PolicyTemplatesApi.UpdatePolicyTemplate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Code of the policy template to update | 
 **policyTemplateUpdateRequest** | [**PolicyTemplateUpdateRequest**](PolicyTemplateUpdateRequest.md)| Definition of the updated policy template | [optional] 

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
