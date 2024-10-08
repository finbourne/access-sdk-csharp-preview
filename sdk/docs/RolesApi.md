# Finbourne.Access.Sdk.Api.RolesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPolicyCollectionToRole**](RolesApi.md#addpolicycollectiontorole) | **POST** /api/roles/{scope}/{code}/policycollections | AddPolicyCollectionToRole: Add policy collections to a role
[**CreateRole**](RolesApi.md#createrole) | **POST** /api/roles | CreateRole: Create Role
[**DeleteRole**](RolesApi.md#deleterole) | **DELETE** /api/roles/{code} | DeleteRole: Delete Role
[**GetRole**](RolesApi.md#getrole) | **GET** /api/roles/{code} | GetRole: Get Role
[**ListRoles**](RolesApi.md#listroles) | **GET** /api/roles | ListRoles: List Roles
[**RemovePolicyCollectionFromRole**](RolesApi.md#removepolicycollectionfromrole) | **DELETE** /api/roles/{scope}/{code}/policycollections/{policycollectionscope}/{policycollectioncode} | RemovePolicyCollectionFromRole: Remove policy collection from role
[**UpdateRole**](RolesApi.md#updaterole) | **PUT** /api/roles/{code} | UpdateRole: Update Role


<a name="addpolicycollectiontorole"></a>
# **AddPolicyCollectionToRole**
> RoleResponse AddPolicyCollectionToRole (string scope, string code, AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequest)

AddPolicyCollectionToRole: Add policy collections to a role

Assigns policy collections to a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddPolicyCollectionToRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var scope = scope_example;  // string | The scope of the Role
            var code = code_example;  // string | The code of the Role
            var addPolicyCollectionToRoleRequest = new AddPolicyCollectionToRoleRequest(); // AddPolicyCollectionToRoleRequest | The policy collections to add

            try
            {
                // AddPolicyCollectionToRole: Add policy collections to a role
                RoleResponse result = apiInstance.AddPolicyCollectionToRole(scope, code, addPolicyCollectionToRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.AddPolicyCollectionToRole: " + e.Message );
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
 **scope** | **string**| The scope of the Role | 
 **code** | **string**| The code of the Role | 
 **addPolicyCollectionToRoleRequest** | [**AddPolicyCollectionToRoleRequest**](AddPolicyCollectionToRoleRequest.md)| The policy collections to add | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AddPolicyCollectionToRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrole"></a>
# **CreateRole**
> RoleResponse CreateRole (RoleCreationRequest roleCreationRequest)

CreateRole: Create Role

Creates a Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var roleCreationRequest = new RoleCreationRequest(); // RoleCreationRequest | The definition of the Role

            try
            {
                // CreateRole: Create Role
                RoleResponse result = apiInstance.CreateRole(roleCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message );
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
 **roleCreationRequest** | [**RoleCreationRequest**](RoleCreationRequest.md)| The definition of the Role | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string code, string scope = null)

DeleteRole: Delete Role

Deletes an identified Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var code = code_example;  // string | The code of the Role
            var scope = scope_example;  // string | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // DeleteRole: Delete Role
                apiInstance.DeleteRole(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **scope** | **string**| &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional] 

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

<a name="getrole"></a>
# **GetRole**
> RoleResponse GetRole (string code, string scope = null)

GetRole: Get Role

Gets an identified Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var code = code_example;  // string | The code of the Role
            var scope = scope_example;  // string | Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // GetRole: Get Role
                RoleResponse result = apiInstance.GetRole(code, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **scope** | **string**| Optional. Will use default scope if not supplied. The scope of the Role | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listroles"></a>
# **ListRoles**
> ICollection&lt;RoleResponse&gt; ListRoles (string scope = null)

ListRoles: List Roles

Gets all Roles in a scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var scope = scope_example;  // string | Optional. Will use all scopes if not supplied. The requested scope (optional) 

            try
            {
                // ListRoles: List Roles
                ICollection<RoleResponse> result = apiInstance.ListRoles(scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.ListRoles: " + e.Message );
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
 **scope** | **string**| Optional. Will use all scopes if not supplied. The requested scope | [optional] 

### Return type

[**ICollection&lt;RoleResponse&gt;**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Roles |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removepolicycollectionfromrole"></a>
# **RemovePolicyCollectionFromRole**
> RoleResponse RemovePolicyCollectionFromRole (string scope, string code, string policycollectionscope, string policycollectioncode)

RemovePolicyCollectionFromRole: Remove policy collection from role

Removes a policy collection from a role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemovePolicyCollectionFromRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var scope = scope_example;  // string | The scope of the Role
            var code = code_example;  // string | The code of the Role
            var policycollectionscope = policycollectionscope_example;  // string | The scope of policy collection to remove from the Role
            var policycollectioncode = policycollectioncode_example;  // string | The code of the policy collection to remove from the Role

            try
            {
                // RemovePolicyCollectionFromRole: Remove policy collection from role
                RoleResponse result = apiInstance.RemovePolicyCollectionFromRole(scope, code, policycollectionscope, policycollectioncode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.RemovePolicyCollectionFromRole: " + e.Message );
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
 **scope** | **string**| The scope of the Role | 
 **code** | **string**| The code of the Role | 
 **policycollectionscope** | **string**| The scope of policy collection to remove from the Role | 
 **policycollectioncode** | **string**| The code of the policy collection to remove from the Role | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RemovePolicyCollectionFromRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> RoleResponse UpdateRole (string code, RoleUpdateRequest roleUpdateRequest, string scope = null, string beforeScope = null, string beforeCode = null, string afterScope = null, string afterCode = null)

UpdateRole: Update Role

Updates a Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var code = code_example;  // string | The code of the Role
            var roleUpdateRequest = new RoleUpdateRequest(); // RoleUpdateRequest | The updated definition of the Role
            var scope = scope_example;  // string | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 
            var beforeScope = beforeScope_example;  // string | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var beforeCode = beforeCode_example;  // string | Optional. The code of the Role (optional) 
            var afterScope = afterScope_example;  // string | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var afterCode = afterCode_example;  // string | Optional. The code of the Role (optional) 

            try
            {
                // UpdateRole: Update Role
                RoleResponse result = apiInstance.UpdateRole(code, roleUpdateRequest, scope, beforeScope, beforeCode, afterScope, afterCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **roleUpdateRequest** | [**RoleUpdateRequest**](RoleUpdateRequest.md)| The updated definition of the Role | 
 **scope** | **string**| &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional] 
 **beforeScope** | **string**| Optional. The scope of the Role. Will use default scope if not supplied. | [optional] 
 **beforeCode** | **string**| Optional. The code of the Role | [optional] 
 **afterScope** | **string**| Optional. The scope of the Role. Will use default scope if not supplied. | [optional] 
 **afterCode** | **string**| Optional. The code of the Role | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

