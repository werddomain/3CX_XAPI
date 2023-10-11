# IO.Swagger.Api.UpdatesApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClientCrmUpdates**](UpdatesApi.md#getclientcrmupdates) | **GET** /GetClientCrmUpdates() | Invoke functionImport GetClientCrmUpdates
[**GetPromptSetUpdates**](UpdatesApi.md#getpromptsetupdates) | **GET** /GetPromptSetUpdates() | Invoke functionImport GetPromptSetUpdates
[**GetServerCrmUpdates**](UpdatesApi.md#getservercrmupdates) | **GET** /GetServerCrmUpdates() | Invoke functionImport GetServerCrmUpdates
[**GetUpdateSettings**](UpdatesApi.md#getupdatesettings) | **GET** /GetUpdateSettings() | Invoke functionImport GetUpdateSettings
[**GetUpdates**](UpdatesApi.md#getupdates) | **GET** /GetUpdates() | Invoke functionImport GetUpdates
[**GetUpdatesStats**](UpdatesApi.md#getupdatesstats) | **GET** /GetUpdatesStats() | Invoke functionImport GetUpdatesStats
[**HasDebianUpgrade**](UpdatesApi.md#hasdebianupgrade) | **GET** /HasDebianUpgrade() | Invoke functionImport HasDebianUpgrade
[**InstallUpdates**](UpdatesApi.md#installupdates) | **POST** /InstallUpdates | Invoke actionImport InstallUpdates
[**SetUpdateSettings**](UpdatesApi.md#setupdatesettings) | **POST** /SetUpdateSettings | Invoke actionImport SetUpdateSettings
[**UpgradeDebian**](UpdatesApi.md#upgradedebian) | **POST** /UpgradeDebian | Invoke actionImport UpgradeDebian

<a name="getclientcrmupdates"></a>
# **GetClientCrmUpdates**
> PbxUpdateList GetClientCrmUpdates ()

Invoke functionImport GetClientCrmUpdates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientCrmUpdatesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetClientCrmUpdates
                PbxUpdateList result = apiInstance.GetClientCrmUpdates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetClientCrmUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdateList**](PbxUpdateList.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpromptsetupdates"></a>
# **GetPromptSetUpdates**
> PbxUpdateList GetPromptSetUpdates ()

Invoke functionImport GetPromptSetUpdates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPromptSetUpdatesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetPromptSetUpdates
                PbxUpdateList result = apiInstance.GetPromptSetUpdates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetPromptSetUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdateList**](PbxUpdateList.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservercrmupdates"></a>
# **GetServerCrmUpdates**
> PbxUpdateList GetServerCrmUpdates ()

Invoke functionImport GetServerCrmUpdates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetServerCrmUpdatesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetServerCrmUpdates
                PbxUpdateList result = apiInstance.GetServerCrmUpdates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetServerCrmUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdateList**](PbxUpdateList.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupdatesettings"></a>
# **GetUpdateSettings**
> PbxUpdateSettings GetUpdateSettings ()

Invoke functionImport GetUpdateSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUpdateSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetUpdateSettings
                PbxUpdateSettings result = apiInstance.GetUpdateSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdateSettings**](PbxUpdateSettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupdates"></a>
# **GetUpdates**
> PbxUpdateList GetUpdates ()

Invoke functionImport GetUpdates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUpdatesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetUpdates
                PbxUpdateList result = apiInstance.GetUpdates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdateList**](PbxUpdateList.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupdatesstats"></a>
# **GetUpdatesStats**
> PbxUpdatesStats GetUpdatesStats ()

Invoke functionImport GetUpdatesStats

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUpdatesStatsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport GetUpdatesStats
                PbxUpdatesStats result = apiInstance.GetUpdatesStats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.GetUpdatesStats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxUpdatesStats**](PbxUpdatesStats.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hasdebianupgrade"></a>
# **HasDebianUpgrade**
> InlineResponse200 HasDebianUpgrade ()

Invoke functionImport HasDebianUpgrade

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HasDebianUpgradeExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke functionImport HasDebianUpgrade
                InlineResponse200 result = apiInstance.HasDebianUpgrade();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.HasDebianUpgrade: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="installupdates"></a>
# **InstallUpdates**
> void InstallUpdates (ActionImportInstallUpdatesRequestBody body)

Invoke actionImport InstallUpdates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InstallUpdatesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();
            var body = new ActionImportInstallUpdatesRequestBody(); // ActionImportInstallUpdatesRequestBody | Action parameters

            try
            {
                // Invoke actionImport InstallUpdates
                apiInstance.InstallUpdates(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.InstallUpdates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionImportInstallUpdatesRequestBody**](ActionImportInstallUpdatesRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupdatesettings"></a>
# **SetUpdateSettings**
> void SetUpdateSettings (ActionImportSetUpdateSettingsRequestBody body)

Invoke actionImport SetUpdateSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetUpdateSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();
            var body = new ActionImportSetUpdateSettingsRequestBody(); // ActionImportSetUpdateSettingsRequestBody | Action parameters

            try
            {
                // Invoke actionImport SetUpdateSettings
                apiInstance.SetUpdateSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.SetUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActionImportSetUpdateSettingsRequestBody**](ActionImportSetUpdateSettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upgradedebian"></a>
# **UpgradeDebian**
> void UpgradeDebian ()

Invoke actionImport UpgradeDebian

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpgradeDebianExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi();

            try
            {
                // Invoke actionImport UpgradeDebian
                apiInstance.UpgradeDebian();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UpdatesApi.UpgradeDebian: " + e.Message );
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

