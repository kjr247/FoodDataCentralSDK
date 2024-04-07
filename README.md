# IO.FoodDataCentralSDK - the C# library for the Food Data Central API

The FoodData Central API provides REST access to FoodData Central (FDC). It is intended primarily to assist application developers wishing to incorporate nutrient data into their applications or websites.   To take full advantage of the API, developers should familiarize themselves with the database by reading the database documentation available via links on [Data Type Documentation](https://fdc.nal.usda.gov/data-documentation.html). This documentation provides the detailed definitions and descriptions needed to understand the data elements referenced in the API documentation.      Additional details about the API including rate limits, access, and licensing are available on the [FDC website](https://fdc.nal.usda.gov/api-guide.html)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

Generation

- API version: 1.0.1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen
    For more information, please visit [https://nal.altarama.com/reft100.aspx?key=FoodData](https://nal.altarama.com/reft100.aspx?key=FoodData)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.FoodDataCentralSDK.Api;
using IO.FoodDataCentralSDK.Client;
using IO.FoodDataCentralSDK.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.FoodDataCentralSDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.FoodDataCentralSDK.Api;
using IO.FoodDataCentralSDK.Client;
using IO.FoodDataCentralSDK.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new FDCApi();
            var fdcId = fdcId_example;  // string | FDC id of the food to retrieve
            var format = format_example;  // string | Optional. 'abridged' for an abridged set of elements, 'full' for all elements (default). (optional) 
            var nutrients = new List<int?>(); // List<int?> | Optional. List of up to 25 nutrient numbers. Only the nutrient information for the specified nutrients will be returned. Should be comma separated list (e.g. nutrients=203,204) or repeating parameters (e.g. nutrients=203&nutrients=204). If a food does not have any matching nutrients, the food will be returned with an empty foodNutrients element. (optional) 

            try
            {
                // Fetches details for one food item by FDC ID
                InlineResponse200 result = apiInstance.GetFood(fdcId, format, nutrients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FDCApi.GetFood: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.nal.usda.gov/fdc*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*FDCApi* | [**GetFood**](docs/FDCApi.md#getfood) | **GET** /v1/food/{fdcId} | Fetches details for one food item by FDC ID
*FDCApi* | [**GetFoods**](docs/FDCApi.md#getfoods) | **GET** /v1/foods | Fetches details for multiple food items using input FDC IDs
*FDCApi* | [**GetFoodsList**](docs/FDCApi.md#getfoodslist) | **GET** /v1/foods/list | Returns a paged list of foods, in the 'abridged' format
*FDCApi* | [**GetFoodsSearch**](docs/FDCApi.md#getfoodssearch) | **GET** /v1/foods/search | Returns a list of foods that matched search (query) keywords
*FDCApi* | [**GetJsonSpec**](docs/FDCApi.md#getjsonspec) | **GET** /v1/json-spec | Returns this documentation in JSON format
*FDCApi* | [**GetYamlSpec**](docs/FDCApi.md#getyamlspec) | **GET** /v1/yaml-spec | Returns this documentation in JSON format
*FDCApi* | [**PostFoods**](docs/FDCApi.md#postfoods) | **POST** /v1/foods | Fetches details for multiple food items using input FDC IDs
*FDCApi* | [**PostFoodsList**](docs/FDCApi.md#postfoodslist) | **POST** /v1/foods/list | Returns a paged list of foods, in the 'abridged' format
*FDCApi* | [**PostFoodsSearch**](docs/FDCApi.md#postfoodssearch) | **POST** /v1/foods/search | Returns a list of foods that matched search (query) keywords

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AbridgedFoodItem](docs/AbridgedFoodItem.md)
 - [Model.AbridgedFoodNutrient](docs/AbridgedFoodNutrient.md)
 - [Model.BrandedFoodItem](docs/BrandedFoodItem.md)
 - [Model.BrandedFoodItemLabelNutrients](docs/BrandedFoodItemLabelNutrients.md)
 - [Model.BrandedFoodItemLabelNutrientsCalcium](docs/BrandedFoodItemLabelNutrientsCalcium.md)
 - [Model.BrandedFoodItemLabelNutrientsCalories](docs/BrandedFoodItemLabelNutrientsCalories.md)
 - [Model.BrandedFoodItemLabelNutrientsCarbohydrates](docs/BrandedFoodItemLabelNutrientsCarbohydrates.md)
 - [Model.BrandedFoodItemLabelNutrientsFat](docs/BrandedFoodItemLabelNutrientsFat.md)
 - [Model.BrandedFoodItemLabelNutrientsFiber](docs/BrandedFoodItemLabelNutrientsFiber.md)
 - [Model.BrandedFoodItemLabelNutrientsIron](docs/BrandedFoodItemLabelNutrientsIron.md)
 - [Model.BrandedFoodItemLabelNutrientsPotassium](docs/BrandedFoodItemLabelNutrientsPotassium.md)
 - [Model.BrandedFoodItemLabelNutrientsProtein](docs/BrandedFoodItemLabelNutrientsProtein.md)
 - [Model.BrandedFoodItemLabelNutrientsSaturatedFat](docs/BrandedFoodItemLabelNutrientsSaturatedFat.md)
 - [Model.BrandedFoodItemLabelNutrientsSugars](docs/BrandedFoodItemLabelNutrientsSugars.md)
 - [Model.BrandedFoodItemLabelNutrientsTransFat](docs/BrandedFoodItemLabelNutrientsTransFat.md)
 - [Model.FoodAttribute](docs/FoodAttribute.md)
 - [Model.FoodAttributeFoodAttributeType](docs/FoodAttributeFoodAttributeType.md)
 - [Model.FoodCategory](docs/FoodCategory.md)
 - [Model.FoodComponent](docs/FoodComponent.md)
 - [Model.FoodListCriteria](docs/FoodListCriteria.md)
 - [Model.FoodNutrient](docs/FoodNutrient.md)
 - [Model.FoodNutrientDerivation](docs/FoodNutrientDerivation.md)
 - [Model.FoodNutrientSource](docs/FoodNutrientSource.md)
 - [Model.FoodPortion](docs/FoodPortion.md)
 - [Model.FoodSearchCriteria](docs/FoodSearchCriteria.md)
 - [Model.FoodUpdateLog](docs/FoodUpdateLog.md)
 - [Model.FoodsCriteria](docs/FoodsCriteria.md)
 - [Model.FoundationFoodItem](docs/FoundationFoodItem.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InputFoodFoundation](docs/InputFoodFoundation.md)
 - [Model.InputFoodSurvey](docs/InputFoodSurvey.md)
 - [Model.MeasureUnit](docs/MeasureUnit.md)
 - [Model.Nutrient](docs/Nutrient.md)
 - [Model.NutrientAcquisitionDetails](docs/NutrientAcquisitionDetails.md)
 - [Model.NutrientAnalysisDetails](docs/NutrientAnalysisDetails.md)
 - [Model.NutrientConversionFactors](docs/NutrientConversionFactors.md)
 - [Model.RetentionFactor](docs/RetentionFactor.md)
 - [Model.SRLegacyFoodItem](docs/SRLegacyFoodItem.md)
 - [Model.SampleFoodItem](docs/SampleFoodItem.md)
 - [Model.SearchResult](docs/SearchResult.md)
 - [Model.SearchResultFood](docs/SearchResultFood.md)
 - [Model.SurveyFoodItem](docs/SurveyFoodItem.md)
 - [Model.WweiaFoodCategory](docs/WweiaFoodCategory.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string


## publish to nuget registry


click on pack.bat

```
cd .\src\IO.FoodDataCentralSDK
..\..\nuget pack -Build -OutputDirectory out FoodDataCentralSDK.csproj
```

add your api key in INSERT_Nuget_API_Key_Here
and create and run publish.bat note that this file is not checked in and is ignored.
be sure to change the version by clicking on the project and opening properties and changing the assembly info. then update the version below as x.x.x.nupkg
```
..\..\nuget push out\FoodDataCentralSDK.1.0.2.nupkg <INSERT_Nuget_API_Key_Here> -Source https://api.nuget.org/v3/index.json
```