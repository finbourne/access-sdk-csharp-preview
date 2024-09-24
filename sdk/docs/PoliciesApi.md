# Finbourne.Access.Sdk.Api.PoliciesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToPolicyCollection**](PoliciesApi.md#addtopolicycollection) | **POST** /api/policycollections/{code}/add | AddToPolicyCollection: Add To PolicyCollection
[**CreatePolicy**](PoliciesApi.md#createpolicy) | **POST** /api/policies | CreatePolicy: Create Policy
[**CreatePolicyCollection**](PoliciesApi.md#createpolicycollection) | **POST** /api/policycollections | CreatePolicyCollection: Create PolicyCollection
[**DeletePolicy**](PoliciesApi.md#deletepolicy) | **DELETE** /api/policies/{code} | DeletePolicy: Delete Policy
[**DeletePolicyCollection**](PoliciesApi.md#deletepolicycollection) | **DELETE** /api/policycollections/{code} | DeletePolicyCollection: Delete PolicyCollection
[**Evaluate**](PoliciesApi.md#evaluate) | **POST** /api/me | Evaluate: Run one or more evaluations
[**GetOwnPolicies**](PoliciesApi.md#getownpolicies) | **GET** /api/me | GetOwnPolicies: Get policies of requesting user
[**GetPolicy**](PoliciesApi.md#getpolicy) | **GET** /api/policies/{code} | GetPolicy: Get Policy
[**GetPolicyCollection**](PoliciesApi.md#getpolicycollection) | **GET** /api/policycollections/{code} | GetPolicyCollection: Get PolicyCollection
[**ListPolicies**](PoliciesApi.md#listpolicies) | **GET** /api/policies | ListPolicies: List Policies
[**ListPolicyCollections**](PoliciesApi.md#listpolicycollections) | **GET** /api/policycollections | ListPolicyCollections: List PolicyCollections
[**PagePolicies**](PoliciesApi.md#pagepolicies) | **GET** /api/policies/page | PagePolicies: Page Policies
[**PagePolicyCollections**](PoliciesApi.md#pagepolicycollections) | **GET** /api/policycollections/page | PagePolicyCollections: Page PolicyCollections
[**RemoveFromPolicyCollection**](PoliciesApi.md#removefrompolicycollection) | **POST** /api/policycollections/{code}/remove | RemoveFromPolicyCollection: Remove From PolicyCollection
[**UpdatePolicy**](PoliciesApi.md#updatepolicy) | **PUT** /api/policies/{code} | UpdatePolicy: Update Policy
[**UpdatePolicyCollection**](PoliciesApi.md#updatepolicycollection) | **PUT** /api/policycollections/{code} | UpdatePolicyCollection: Update PolicyCollection


<a name="addtopolicycollection"></a>
# **AddToPolicyCollection**
> PolicyCollectionResponse AddToPolicyCollection (string code, AddToPolicyCollectionRequest addToPolicyCollectionRequest, string scope = null)

AddToPolicyCollection: Add To PolicyCollection

Add Policies and/or PolicyCollections to a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddToPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the PolicyCollection
            var addToPolicyCollectionRequest = new AddToPolicyCollectionRequest(); // AddToPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to add to the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // AddToPolicyCollection: Add To PolicyCollection
                PolicyCollectionResponse result = apiInstance.AddToPolicyCollection(code, addToPolicyCollectionRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.AddToPolicyCollection: " + e.Message );
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
 **code** | **string**| The code of the PolicyCollection | 
 **addToPolicyCollectionRequest** | [**AddToPolicyCollectionRequest**](AddToPolicyCollectionRequest.md)| Ids of the PolicyCollections and/or Policies to add to the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpolicy"></a>
# **CreatePolicy**
> PolicyResponse CreatePolicy (PolicyCreationRequest policyCreationRequest)

CreatePolicy: Create Policy

Creates a Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreatePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var policyCreationRequest = new PolicyCreationRequest(); // PolicyCreationRequest | The definition of the Policy

            try
            {
                // CreatePolicy: Create Policy
                PolicyResponse result = apiInstance.CreatePolicy(policyCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicy: " + e.Message );
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
 **policyCreationRequest** | [**PolicyCreationRequest**](PolicyCreationRequest.md)| The definition of the Policy | 

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpolicycollection"></a>
# **CreatePolicyCollection**
> PolicyCollectionResponse CreatePolicyCollection (PolicyCollectionCreationRequest policyCollectionCreationRequest)

CreatePolicyCollection: Create PolicyCollection

Creates a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreatePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var policyCollectionCreationRequest = new PolicyCollectionCreationRequest(); // PolicyCollectionCreationRequest | The definition of the PolicyCollection

            try
            {
                // CreatePolicyCollection: Create PolicyCollection
                PolicyCollectionResponse result = apiInstance.CreatePolicyCollection(policyCollectionCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicyCollection: " + e.Message );
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
 **policyCollectionCreationRequest** | [**PolicyCollectionCreationRequest**](PolicyCollectionCreationRequest.md)| The definition of the PolicyCollection | 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string code, string scope = null)

DeletePolicy: Delete Policy

Deletes an identified Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeletePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the Policy
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // DeletePolicy: Delete Policy
                apiInstance.DeletePolicy(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicy: " + e.Message );
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
 **code** | **string**| The code of the Policy | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

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

<a name="deletepolicycollection"></a>
# **DeletePolicyCollection**
> void DeletePolicyCollection (string code, string scope = null)

DeletePolicyCollection: Delete PolicyCollection

Deletes an identified PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeletePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // DeletePolicyCollection: Delete PolicyCollection
                apiInstance.DeletePolicyCollection(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicyCollection: " + e.Message );
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
 **code** | **string**| The code of the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

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

<a name="evaluate"></a>
# **Evaluate**
> Dictionary&lt;string, EvaluationResponse&gt; Evaluate (Dictionary<string, EvaluationRequest> requestBody, List<string> applications = null)

Evaluate: Run one or more evaluations

Given a dictionary of evaluation requests (keyed by any arbitrary correlation identifier), each will be evaluated according to the current user's policies (deduced from the provided OAuth token).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class EvaluateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var requestBody = new Dictionary<string, EvaluationRequest>(); // Dictionary<string, EvaluationRequest> | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation).
            var applications = new List<string>(); // List<string> | Optional. The application type of the roles and policies to use when evaluating. (optional) 

            try
            {
                // Evaluate: Run one or more evaluations
                Dictionary<string, EvaluationResponse> result = apiInstance.Evaluate(requestBody, applications);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.Evaluate: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, EvaluationRequest&gt;**](EvaluationRequest.md)| A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation). | 
 **applications** | [**List&lt;string&gt;**](string.md)| Optional. The application type of the roles and policies to use when evaluating. | [optional] 

### Return type

[**Dictionary&lt;string, EvaluationResponse&gt;**](EvaluationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Run an evaluation against the current user&#39;s entitlements |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownpolicies"></a>
# **GetOwnPolicies**
> ICollection&lt;AttachedPolicyDefinitionResponse&gt; GetOwnPolicies (List<string> applications = null)

GetOwnPolicies: Get policies of requesting user

Gets all Policies for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetOwnPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var applications = new List<string>(); // List<string> | Optional. Filter on the applications that the policies apply to (optional) 

            try
            {
                // GetOwnPolicies: Get policies of requesting user
                ICollection<AttachedPolicyDefinitionResponse> result = apiInstance.GetOwnPolicies(applications);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetOwnPolicies: " + e.Message );
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
 **applications** | [**List&lt;string&gt;**](string.md)| Optional. Filter on the applications that the policies apply to | [optional] 

### Return type

[**ICollection&lt;AttachedPolicyDefinitionResponse&gt;**](AttachedPolicyDefinitionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get policies and licences of current user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicy"></a>
# **GetPolicy**
> PolicyResponse GetPolicy (string code, string scope = null)

GetPolicy: Get Policy

Gets an identified Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the Policy
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // GetPolicy: Get Policy
                PolicyResponse result = apiInstance.GetPolicy(code, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicy: " + e.Message );
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
 **code** | **string**| The code of the Policy | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a specific Policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicycollection"></a>
# **GetPolicyCollection**
> PolicyCollectionResponse GetPolicyCollection (string code, string scope = null)

GetPolicyCollection: Get PolicyCollection

Gets an identified PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // GetPolicyCollection: Get PolicyCollection
                PolicyCollectionResponse result = apiInstance.GetPolicyCollection(code, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicyCollection: " + e.Message );
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
 **code** | **string**| The code of the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpolicies"></a>
# **ListPolicies**
> ICollection&lt;PolicyResponse&gt; ListPolicies (string scope = null)

ListPolicies: List Policies

Gets all Policies in a scope. For pagination support, use PagePolicies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The requested scope (optional) 

            try
            {
                // ListPolicies: List Policies
                ICollection<PolicyResponse> result = apiInstance.ListPolicies(scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicies: " + e.Message );
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
 **scope** | **string**| Optional. Will use the default scope if not provided. The requested scope | [optional] 

### Return type

[**ICollection&lt;PolicyResponse&gt;**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpolicycollections"></a>
# **ListPolicyCollections**
> ICollection&lt;PolicyCollectionResponse&gt; ListPolicyCollections (string scope = null)

ListPolicyCollections: List PolicyCollections

Gets all PolicyCollections in a scope. For pagination support, use PagePolicyCollections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListPolicyCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The requested scope (optional) 

            try
            {
                // ListPolicyCollections: List PolicyCollections
                ICollection<PolicyCollectionResponse> result = apiInstance.ListPolicyCollections(scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicyCollections: " + e.Message );
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
 **scope** | **string**| Optional. Will use the default scope if not provided. The requested scope | [optional] 

### Return type

[**ICollection&lt;PolicyCollectionResponse&gt;**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagepolicies"></a>
# **PagePolicies**
> ResourceListOfPolicyResponse PagePolicies (string sortBy = null, int? limit = null, string filter = null, string page = null)

PagePolicies: Page Policies

Gets all Policies with pagination support.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class PagePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var sortBy = sortBy_example;  // string | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var page = page_example;  // string | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // PagePolicies: Page Policies
                ResourceListOfPolicyResponse result = apiInstance.PagePolicies(sortBy, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.PagePolicies: " + e.Message );
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
 **sortBy** | **string**| Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **limit** | **int?**| Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **page** | **string**| Optional. Paging token returned from a previous result | [optional] 

### Return type

[**ResourceListOfPolicyResponse**](ResourceListOfPolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagepolicycollections"></a>
# **PagePolicyCollections**
> ResourceListOfPolicyCollectionResponse PagePolicyCollections (string sortBy = null, int? limit = null, string filter = null, string page = null)

PagePolicyCollections: Page PolicyCollections

Gets all PolicyCollections with pagination support.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class PagePolicyCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var sortBy = sortBy_example;  // string | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var page = page_example;  // string | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // PagePolicyCollections: Page PolicyCollections
                ResourceListOfPolicyCollectionResponse result = apiInstance.PagePolicyCollections(sortBy, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.PagePolicyCollections: " + e.Message );
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
 **sortBy** | **string**| Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **limit** | **int?**| Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **page** | **string**| Optional. Paging token returned from a previous result | [optional] 

### Return type

[**ResourceListOfPolicyCollectionResponse**](ResourceListOfPolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefrompolicycollection"></a>
# **RemoveFromPolicyCollection**
> PolicyCollectionResponse RemoveFromPolicyCollection (string code, RemoveFromPolicyCollectionRequest removeFromPolicyCollectionRequest, string scope = null)

RemoveFromPolicyCollection: Remove From PolicyCollection

Remove Policies and/or PolicyCollections from a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemoveFromPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the PolicyCollection
            var removeFromPolicyCollectionRequest = new RemoveFromPolicyCollectionRequest(); // RemoveFromPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to remove from the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // RemoveFromPolicyCollection: Remove From PolicyCollection
                PolicyCollectionResponse result = apiInstance.RemoveFromPolicyCollection(code, removeFromPolicyCollectionRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.RemoveFromPolicyCollection: " + e.Message );
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
 **code** | **string**| The code of the PolicyCollection | 
 **removeFromPolicyCollectionRequest** | [**RemoveFromPolicyCollectionRequest**](RemoveFromPolicyCollectionRequest.md)| Ids of the PolicyCollections and/or Policies to remove from the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepolicy"></a>
# **UpdatePolicy**
> PolicyResponse UpdatePolicy (string code, PolicyUpdateRequest policyUpdateRequest, string scope = null)

UpdatePolicy: Update Policy

Updates a Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdatePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the Policy
            var policyUpdateRequest = new PolicyUpdateRequest(); // PolicyUpdateRequest | The updated definition of the Policy
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // UpdatePolicy: Update Policy
                PolicyResponse result = apiInstance.UpdatePolicy(code, policyUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicy: " + e.Message );
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
 **code** | **string**| The code of the Policy | 
 **policyUpdateRequest** | [**PolicyUpdateRequest**](PolicyUpdateRequest.md)| The updated definition of the Policy | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepolicycollection"></a>
# **UpdatePolicyCollection**
> PolicyCollectionResponse UpdatePolicyCollection (string code, PolicyCollectionUpdateRequest policyCollectionUpdateRequest, string scope = null)

UpdatePolicyCollection: Update PolicyCollection

Updates a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdatePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = code_example;  // string | The code of the PolicyCollection
            var policyCollectionUpdateRequest = new PolicyCollectionUpdateRequest(); // PolicyCollectionUpdateRequest | The updated definition of the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // UpdatePolicyCollection: Update PolicyCollection
                PolicyCollectionResponse result = apiInstance.UpdatePolicyCollection(code, policyCollectionUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicyCollection: " + e.Message );
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
 **code** | **string**| The code of the PolicyCollection | 
 **policyCollectionUpdateRequest** | [**PolicyCollectionUpdateRequest**](PolicyCollectionUpdateRequest.md)| The updated definition of the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

