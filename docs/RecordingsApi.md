# IO.Swagger.Api.RecordingsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Archive**](RecordingsApi.md#archive) | **POST** /Recordings/Pbx.Archive | Invoke action Archive
[**DownloadRecording**](RecordingsApi.md#downloadrecording) | **GET** /Recordings/Pbx.DownloadRecording(recId&#x3D;{recId}) | Invoke function DownloadRecording
[**GetRecordingRepositorySettings**](RecordingsApi.md#getrecordingrepositorysettings) | **GET** /Recordings/Pbx.GetRecordingRepositorySettings() | Invoke function GetRecordingRepositorySettings
[**GetRecordingSettings**](RecordingsApi.md#getrecordingsettings) | **GET** /Recordings/Pbx.GetRecordingSettings() | Invoke function GetRecordingSettings
[**PurgeArchive**](RecordingsApi.md#purgearchive) | **POST** /Recordings/Pbx.PurgeArchive | Invoke action PurgeArchive
[**PurgeLocal**](RecordingsApi.md#purgelocal) | **POST** /Recordings/Pbx.PurgeLocal | Invoke action PurgeLocal
[**SetRecordingRepositorySettings**](RecordingsApi.md#setrecordingrepositorysettings) | **POST** /Recordings/Pbx.SetRecordingRepositorySettings | Invoke action SetRecordingRepositorySettings
[**SetRecordingSettings**](RecordingsApi.md#setrecordingsettings) | **POST** /Recordings/Pbx.SetRecordingSettings | Invoke action SetRecordingSettings

<a name="archive"></a>
# **Archive**
> void Archive ()

Invoke action Archive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ArchiveExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();

            try
            {
                // Invoke action Archive
                apiInstance.Archive();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.Archive: " + e.Message );
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

<a name="downloadrecording"></a>
# **DownloadRecording**
> PbxIActionResult DownloadRecording (int? recId)

Invoke function DownloadRecording

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadRecordingExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();
            var recId = 56;  // int? | Usage: recId={recId}

            try
            {
                // Invoke function DownloadRecording
                PbxIActionResult result = apiInstance.DownloadRecording(recId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.DownloadRecording: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recId** | **int?**| Usage: recId&#x3D;{recId} | 

### Return type

[**PbxIActionResult**](PbxIActionResult.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecordingrepositorysettings"></a>
# **GetRecordingRepositorySettings**
> PbxRecordingRepositorySettings GetRecordingRepositorySettings ()

Invoke function GetRecordingRepositorySettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecordingRepositorySettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();

            try
            {
                // Invoke function GetRecordingRepositorySettings
                PbxRecordingRepositorySettings result = apiInstance.GetRecordingRepositorySettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.GetRecordingRepositorySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxRecordingRepositorySettings**](PbxRecordingRepositorySettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecordingsettings"></a>
# **GetRecordingSettings**
> PbxRecordingSettings GetRecordingSettings ()

Invoke function GetRecordingSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecordingSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();

            try
            {
                // Invoke function GetRecordingSettings
                PbxRecordingSettings result = apiInstance.GetRecordingSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.GetRecordingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxRecordingSettings**](PbxRecordingSettings.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purgearchive"></a>
# **PurgeArchive**
> void PurgeArchive ()

Invoke action PurgeArchive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurgeArchiveExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();

            try
            {
                // Invoke action PurgeArchive
                apiInstance.PurgeArchive();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.PurgeArchive: " + e.Message );
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

<a name="purgelocal"></a>
# **PurgeLocal**
> void PurgeLocal ()

Invoke action PurgeLocal

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurgeLocalExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();

            try
            {
                // Invoke action PurgeLocal
                apiInstance.PurgeLocal();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.PurgeLocal: " + e.Message );
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

<a name="setrecordingrepositorysettings"></a>
# **SetRecordingRepositorySettings**
> void SetRecordingRepositorySettings (RecordingsSetRecordingRepositorySettingsRequestBody body)

Invoke action SetRecordingRepositorySettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetRecordingRepositorySettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();
            var body = new RecordingsSetRecordingRepositorySettingsRequestBody(); // RecordingsSetRecordingRepositorySettingsRequestBody | Action parameters

            try
            {
                // Invoke action SetRecordingRepositorySettings
                apiInstance.SetRecordingRepositorySettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.SetRecordingRepositorySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordingsSetRecordingRepositorySettingsRequestBody**](RecordingsSetRecordingRepositorySettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setrecordingsettings"></a>
# **SetRecordingSettings**
> void SetRecordingSettings (RecordingsSetRecordingSettingsRequestBody body)

Invoke action SetRecordingSettings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetRecordingSettingsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecordingsApi();
            var body = new RecordingsSetRecordingSettingsRequestBody(); // RecordingsSetRecordingSettingsRequestBody | Action parameters

            try
            {
                // Invoke action SetRecordingSettings
                apiInstance.SetRecordingSettings(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingsApi.SetRecordingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordingsSetRecordingSettingsRequestBody**](RecordingsSetRecordingSettingsRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

