# IO.Swagger.Api.LicenseInfoApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditLicenseInfo**](LicenseInfoApi.md#editlicenseinfo) | **POST** /LicenseInfo/Pbx.EditLicenseInfo | Invoke action EditLicenseInfo
[**GetLicenseInfo**](LicenseInfoApi.md#getlicenseinfo) | **GET** /LicenseInfo | Get LicenseInfo
[**ReplaceLicenseKey**](LicenseInfoApi.md#replacelicensekey) | **POST** /LicenseInfo/Pbx.ReplaceLicenseKey | Invoke action ReplaceLicenseKey

<a name="editlicenseinfo"></a>
# **EditLicenseInfo**
> void EditLicenseInfo (LicenseInfoEditLicenseInfoRequestBody body)

Invoke action EditLicenseInfo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditLicenseInfoExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseInfoApi();
            var body = new LicenseInfoEditLicenseInfoRequestBody(); // LicenseInfoEditLicenseInfoRequestBody | Action parameters

            try
            {
                // Invoke action EditLicenseInfo
                apiInstance.EditLicenseInfo(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseInfoApi.EditLicenseInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LicenseInfoEditLicenseInfoRequestBody**](LicenseInfoEditLicenseInfoRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicenseinfo"></a>
# **GetLicenseInfo**
> PbxLicenseInfo GetLicenseInfo (List<string> select, string expand)

Get LicenseInfo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLicenseInfoExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseInfoApi();
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get LicenseInfo
                PbxLicenseInfo result = apiInstance.GetLicenseInfo(select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseInfoApi.GetLicenseInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxLicenseInfo**](PbxLicenseInfo.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacelicensekey"></a>
# **ReplaceLicenseKey**
> void ReplaceLicenseKey (LicenseInfoReplaceLicenseKeyRequestBody body)

Invoke action ReplaceLicenseKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceLicenseKeyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseInfoApi();
            var body = new LicenseInfoReplaceLicenseKeyRequestBody(); // LicenseInfoReplaceLicenseKeyRequestBody | Action parameters

            try
            {
                // Invoke action ReplaceLicenseKey
                apiInstance.ReplaceLicenseKey(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseInfoApi.ReplaceLicenseKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LicenseInfoReplaceLicenseKeyRequestBody**](LicenseInfoReplaceLicenseKeyRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

