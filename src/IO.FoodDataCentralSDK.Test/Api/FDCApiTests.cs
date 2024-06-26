/* 
 * Food Data Central API
 *
 * The FoodData Central API provides REST access to FoodData Central (FDC). It is intended primarily to assist application developers wishing to incorporate nutrient data into their applications or websites.   To take full advantage of the API, developers should familiarize themselves with the database by reading the database documentation available via links on [Data Type Documentation](https://fdc.nal.usda.gov/data-documentation.html). This documentation provides the detailed definitions and descriptions needed to understand the data elements referenced in the API documentation.      Additional details about the API including rate limits, access, and licensing are available on the [FDC website](https://fdc.nal.usda.gov/api-guide.html)
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.FoodDataCentralSDK.Client;
using IO.FoodDataCentralSDK.Api;
using IO.FoodDataCentralSDK.Model;

namespace IO.FoodDataCentralSDK.Test
{
    /// <summary>
    ///  Class for testing FDCApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FDCApiTests
    {
        private FDCApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FDCApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FDCApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FDCApi
            //Assert.IsInstanceOfType(typeof(FDCApi), instance, "instance is a FDCApi");
        }

        /// <summary>
        /// Test GetFood
        /// </summary>
        [Test]
        public void GetFoodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fdcId = null;
            //string format = null;
            //List<int?> nutrients = null;
            //var response = instance.GetFood(fdcId, format, nutrients);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        /// <summary>
        /// Test GetFoods
        /// </summary>
        [Test]
        public void GetFoodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> fdcIds = null;
            //string format = null;
            //List<int?> nutrients = null;
            //var response = instance.GetFoods(fdcIds, format, nutrients);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        /// <summary>
        /// Test GetFoodsList
        /// </summary>
        [Test]
        public void GetFoodsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> dataType = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //string sortBy = null;
            //string sortOrder = null;
            //var response = instance.GetFoodsList(dataType, pageSize, pageNumber, sortBy, sortOrder);
            //Assert.IsInstanceOf<List<AbridgedFoodItem>> (response, "response is List<AbridgedFoodItem>");
        }
        /// <summary>
        /// Test GetFoodsSearch
        /// </summary>
        [Test]
        public void GetFoodsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //List<string> dataType = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //string sortBy = null;
            //string sortOrder = null;
            //string brandOwner = null;
            //var response = instance.GetFoodsSearch(query, dataType, pageSize, pageNumber, sortBy, sortOrder, brandOwner);
            //Assert.IsInstanceOf<SearchResult> (response, "response is SearchResult");
        }
        /// <summary>
        /// Test GetJsonSpec
        /// </summary>
        [Test]
        public void GetJsonSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetJsonSpec();
            
        }
        /// <summary>
        /// Test GetYamlSpec
        /// </summary>
        [Test]
        public void GetYamlSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetYamlSpec();
            
        }
        /// <summary>
        /// Test PostFoods
        /// </summary>
        [Test]
        public void PostFoodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FoodsCriteria body = null;
            //var response = instance.PostFoods(body);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        /// <summary>
        /// Test PostFoodsList
        /// </summary>
        [Test]
        public void PostFoodsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FoodListCriteria body = null;
            //var response = instance.PostFoodsList(body);
            //Assert.IsInstanceOf<List<AbridgedFoodItem>> (response, "response is List<AbridgedFoodItem>");
        }
        /// <summary>
        /// Test PostFoodsSearch
        /// </summary>
        [Test]
        public void PostFoodsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FoodSearchCriteria body = null;
            //var response = instance.PostFoodsSearch(body);
            //Assert.IsInstanceOf<SearchResult> (response, "response is SearchResult");
        }
    }

}
