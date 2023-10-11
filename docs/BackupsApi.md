# IO.Swagger.Api.BackupsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Backup**](BackupsApi.md#backup) | **POST** /Backups/Pbx.Backup | Invoke action Backup
[**DeleteBackup**](BackupsApi.md#deletebackup) | **DELETE** /Backups({FileName}) | Delete entity from Backups
[**GetBackupExtras**](BackupsApi.md#getbackupextras) | **GET** /Backups({FileName})/Pbx.GetBackupExtras() | Invoke function GetBackupExtras
[**GetBackupRepositorySettings**](BackupsApi.md#getbackuprepositorysettings) | **GET** /Backups/Pbx.GetBackupRepositorySettings() | Invoke function GetBackupRepositorySettings
[**GetBackupSettings**](BackupsApi.md#getbackupsettings) | **GET** /Backups/Pbx.GetBackupSettings() | Invoke function GetBackupSettings
[**GetCanCreateBackup**](BackupsApi.md#getcancreatebackup) | **GET** /Backups/Pbx.GetCanCreateBackup() | Invoke function GetCanCreateBackup
[**GetRestoreSettings**](BackupsApi.md#getrestoresettings) | **GET** /Backups/Pbx.GetRestoreSettings() | Invoke function GetRestoreSettings
[**ListBackup**](BackupsApi.md#listbackup) | **GET** /Backups | Get entities from Backups
[**Restore**](BackupsApi.md#restore) | **POST** /Backups({FileName})/Pbx.Restore | Invoke action Restore
[**SetBackupRepositorySettings**](BackupsApi.md#setbackuprepositorysettings) | **POST** /Backups/Pbx.SetBackupRepositorySettings | Invoke action SetBackupRepositorySettings
[**SetBackupSettings**](BackupsApi.md#setbackupsettings) | **POST** /Backups/Pbx.SetBackupSettings | Invoke action SetBackupSettings
[**SetRestoreSettings**](BackupsApi.md#setrestoresettings) | **POST** /Backups/Pbx.SetRestoreSettings | Invoke action SetRestoreSettings

<a name="backup"></a>
# **Backup**
> void Backup (BackupsBackupRequestBody body)

Invoke action Backup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BackupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var body = new BackupsBackupRequestBody(); // BackupsBackupRequestBody | Action parameters

            try
            {
                // Invoke action Backup
                apiInstance.Backup(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.Backup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupsBackupRequestBody**](BackupsBackupRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebackup"></a>
# **DeleteBackup**
> void DeleteBackup (string fileName, string ifMatch)

Delete entity from Backups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBackupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var fileName = fileName_example;  // string | The unique identifier of Backup
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Backups
                apiInstance.DeleteBackup(fileName, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.DeleteBackup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| The unique identifier of Backup | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbackupextras"></a>
# **GetBackupExtras**
> PbxBackupExtras GetBackupExtras (string fileName)

Invoke function GetBackupExtras

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBackupExtrasExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var fileName = fileName_example;  // string | The unique identifier of Backup

            try
            {
                // Invoke function GetBackupExtras
                PbxBackupExtras result = apiInstance.GetBackupExtras(fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.GetBackupExtras: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| The unique identifier of Backup | 

### Return type

[**PbxBackupExtras**](PbxBackupExtras.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbackuprepositorysettings"></a>
# **GetBackupRepositorySettings**
> PbxBackupRepositorySettings GetBackupRepositorySettings ()

Invoke function GetBackupRepositorySettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBackupRepositorySettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();

            try
            {
                // Invoke function GetBackupRepositorySettings
                PbxBackupRepositorySettings result = apiInstance.GetBackupRepositorySettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.GetBackupRepositorySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxBackupRepositorySettings**](PbxBackupRepositorySettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbackupsettings"></a>
# **GetBackupSettings**
> PbxBackupSettings GetBackupSettings ()

Invoke function GetBackupSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBackupSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();

            try
            {
                // Invoke function GetBackupSettings
                PbxBackupSettings result = apiInstance.GetBackupSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.GetBackupSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxBackupSettings**](PbxBackupSettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcancreatebackup"></a>
# **GetCanCreateBackup**
> InlineResponse200 GetCanCreateBackup ()

Invoke function GetCanCreateBackup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCanCreateBackupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();

            try
            {
                // Invoke function GetCanCreateBackup
                InlineResponse200 result = apiInstance.GetCanCreateBackup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.GetCanCreateBackup: " + e.Message );
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

<a name="getrestoresettings"></a>
# **GetRestoreSettings**
> PbxRestoreSettings GetRestoreSettings ()

Invoke function GetRestoreSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRestoreSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();

            try
            {
                // Invoke function GetRestoreSettings
                PbxRestoreSettings result = apiInstance.GetRestoreSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.GetRestoreSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxRestoreSettings**](PbxRestoreSettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbackup"></a>
# **ListBackup**
> PbxBackupCollectionResponse ListBackup (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Backups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListBackupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entities from Backups
                PbxBackupCollectionResponse result = apiInstance.ListBackup(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.ListBackup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxBackupCollectionResponse**](PbxBackupCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restore"></a>
# **Restore**
> void Restore (BackupsBackupRestoreRequestBody body, string fileName)

Invoke action Restore

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestoreExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var body = new BackupsBackupRestoreRequestBody(); // BackupsBackupRestoreRequestBody | Action parameters
            var fileName = fileName_example;  // string | The unique identifier of Backup

            try
            {
                // Invoke action Restore
                apiInstance.Restore(body, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.Restore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupsBackupRestoreRequestBody**](BackupsBackupRestoreRequestBody.md)| Action parameters | 
 **fileName** | **string**| The unique identifier of Backup | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbackuprepositorysettings"></a>
# **SetBackupRepositorySettings**
> void SetBackupRepositorySettings (BackupsSetBackupRepositorySettingsRequestBody body)

Invoke action SetBackupRepositorySettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetBackupRepositorySettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var body = new BackupsSetBackupRepositorySettingsRequestBody(); // BackupsSetBackupRepositorySettingsRequestBody | Action parameters

            try
            {
                // Invoke action SetBackupRepositorySettings
                apiInstance.SetBackupRepositorySettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.SetBackupRepositorySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupsSetBackupRepositorySettingsRequestBody**](BackupsSetBackupRepositorySettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbackupsettings"></a>
# **SetBackupSettings**
> void SetBackupSettings (BackupsSetBackupSettingsRequestBody body)

Invoke action SetBackupSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetBackupSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var body = new BackupsSetBackupSettingsRequestBody(); // BackupsSetBackupSettingsRequestBody | Action parameters

            try
            {
                // Invoke action SetBackupSettings
                apiInstance.SetBackupSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.SetBackupSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupsSetBackupSettingsRequestBody**](BackupsSetBackupSettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setrestoresettings"></a>
# **SetRestoreSettings**
> void SetRestoreSettings (BackupsSetRestoreSettingsRequestBody body)

Invoke action SetRestoreSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetRestoreSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BackupsApi();
            var body = new BackupsSetRestoreSettingsRequestBody(); // BackupsSetRestoreSettingsRequestBody | Action parameters

            try
            {
                // Invoke action SetRestoreSettings
                apiInstance.SetRestoreSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupsApi.SetRestoreSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackupsSetRestoreSettingsRequestBody**](BackupsSetRestoreSettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

