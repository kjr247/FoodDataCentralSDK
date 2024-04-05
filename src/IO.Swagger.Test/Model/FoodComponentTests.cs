/* 
 * Food Data Central API
 *
 * The FoodData Central API provides REST access to FoodData Central (FDC). It is intended primarily to assist application developers wishing to incorporate nutrient data into their applications or websites.   To take full advantage of the API, developers should familiarize themselves with the database by reading the database documentation available via links on [Data Type Documentation](https://fdc.nal.usda.gov/data-documentation.html). This documentation provides the detailed definitions and descriptions needed to understand the data elements referenced in the API documentation.      Additional details about the API including rate limits, access, and licensing are available on the [FDC website](https://fdc.nal.usda.gov/api-guide.html)
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FoodComponent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FoodComponentTests
    {
        // TODO uncomment below to declare an instance variable for FoodComponent
        //private FoodComponent instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FoodComponent
            //instance = new FoodComponent();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FoodComponent
        /// </summary>
        [Test]
        public void FoodComponentInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FoodComponent
            //Assert.IsInstanceOfType<FoodComponent> (instance, "variable 'instance' is a FoodComponent");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'DataPoints'
        /// </summary>
        [Test]
        public void DataPointsTest()
        {
            // TODO unit test for the property 'DataPoints'
        }
        /// <summary>
        /// Test the property 'GramWeight'
        /// </summary>
        [Test]
        public void GramWeightTest()
        {
            // TODO unit test for the property 'GramWeight'
        }
        /// <summary>
        /// Test the property 'IsRefuse'
        /// </summary>
        [Test]
        public void IsRefuseTest()
        {
            // TODO unit test for the property 'IsRefuse'
        }
        /// <summary>
        /// Test the property 'MinYearAcquired'
        /// </summary>
        [Test]
        public void MinYearAcquiredTest()
        {
            // TODO unit test for the property 'MinYearAcquired'
        }
        /// <summary>
        /// Test the property 'PercentWeight'
        /// </summary>
        [Test]
        public void PercentWeightTest()
        {
            // TODO unit test for the property 'PercentWeight'
        }

    }

}