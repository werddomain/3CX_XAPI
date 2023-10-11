# IO.Swagger.Api.LicenseStatusApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLicenseStatus**](LicenseStatusApi.md#getlicensestatus) | **GET** /LicenseStatus | Get LicenseStatus
[**LinkPartner**](LicenseStatusApi.md#linkpartner) | **POST** /LicenseStatus/Pbx.LinkPartner | Invoke action LinkPartner
[**PartnerInfo**](LicenseStatusApi.md#partnerinfo) | **GET** /LicenseStatus/Pbx.PartnerInfo(resellerId&#x3D;{resellerId}) | Invoke function PartnerInfo
[**RefreshLicenseStatus**](LicenseStatusApi.md#refreshlicensestatus) | **POST** /LicenseStatus/Pbx.RefreshLicenseStatus | Invoke action RefreshLicenseStatus
[**UnlinkPartner**](LicenseStatusApi.md#unlinkpartner) | **POST** /LicenseStatus/Pbx.UnlinkPartner | Invoke action UnlinkPartner

<a name="getlicensestatus"></a>
# **GetLicenseStatus**
> PbxLicenseStatus GetLicenseStatus (List<string> select, string expand)

Get LicenseStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLicenseStatusExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseStatusApi();
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get LicenseStatus
                PbxLicenseStatus result = apiInstance.GetLicenseStatus(select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseStatusApi.GetLicenseStatus: " + e.Message );
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

[**PbxLicenseStatus**](PbxLicenseStatus.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkpartner"></a>
# **LinkPartner**
> void LinkPartner (LicenseStatusLinkPartnerRequestBody body)

Invoke action LinkPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LinkPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseStatusApi();
            var body = new LicenseStatusLinkPartnerRequestBody(); // LicenseStatusLinkPartnerRequestBody | Action parameters

            try
            {
                // Invoke action LinkPartner
                apiInstance.LinkPartner(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseStatusApi.LinkPartner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LicenseStatusLinkPartnerRequestBody**](LicenseStatusLinkPartnerRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partnerinfo"></a>
# **PartnerInfo**
> PbxResellerInfo PartnerInfo (string resellerId)

Invoke function PartnerInfo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerInfoExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseStatusApi();
            var resellerId = resellerId_example;  // string | Usage: resellerId={resellerId}

            try
            {
                // Invoke function PartnerInfo
                PbxResellerInfo result = apiInstance.PartnerInfo(resellerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseStatusApi.PartnerInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resellerId** | **string**| Usage: resellerId&#x3D;{resellerId} | 

### Return type

[**PbxResellerInfo**](PbxResellerInfo.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshlicensestatus"></a>
# **RefreshLicenseStatus**
> void RefreshLicenseStatus ()

Invoke action RefreshLicenseStatus

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefreshLicenseStatusExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseStatusApi();

            try
            {
                // Invoke action RefreshLicenseStatus
                apiInstance.RefreshLicenseStatus();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseStatusApi.RefreshLicenseStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlinkpartner"></a>
# **UnlinkPartner**
> void UnlinkPartner ()

Invoke action UnlinkPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnlinkPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseStatusApi();

            try
            {
                // Invoke action UnlinkPartner
                apiInstance.UnlinkPartner();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseStatusApi.UnlinkPartner: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

