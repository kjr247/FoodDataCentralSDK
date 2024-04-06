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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.FoodDataCentralSDK.Client.SwaggerDateConverter;
namespace IO.FoodDataCentralSDK.Model
{
    /// <summary>
    /// SearchResultFood
    /// </summary>
    [DataContract]
        public partial class SearchResultFood :  IEquatable<SearchResultFood>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultFood" /> class.
        /// </summary>
        /// <param name="fdcId">Unique ID of the food. (required).</param>
        /// <param name="dataType">The type of the food data..</param>
        /// <param name="description">The description of the food. (required).</param>
        /// <param name="foodCode">Any A unique ID identifying the food within FNDDS..</param>
        /// <param name="foodNutrients">foodNutrients.</param>
        /// <param name="publicationDate">Date the item was published to FDC..</param>
        /// <param name="scientificName">The scientific name of the food..</param>
        /// <param name="brandOwner">Brand owner for the food. Only applies to Branded Foods..</param>
        /// <param name="gtinUpc">GTIN or UPC code identifying the food. Only applies to Branded Foods..</param>
        /// <param name="ingredients">The list of ingredients (as it appears on the product label). Only applies to Branded Foods..</param>
        /// <param name="ndbNumber">Unique number assigned for foundation foods. Only applies to Foundation and SRLegacy Foods..</param>
        /// <param name="additionalDescriptions">Any additional descriptions of the food..</param>
        /// <param name="allHighlightFields">allHighlightFields.</param>
        /// <param name="score">Relative score indicating how well the food matches the search criteria..</param>
        public SearchResultFood(int? fdcId = default(int?), string dataType = default(string), string description = default(string), string foodCode = default(string), List<AbridgedFoodNutrient> foodNutrients = default(List<AbridgedFoodNutrient>), string publicationDate = default(string), string scientificName = default(string), string brandOwner = default(string), string gtinUpc = default(string), string ingredients = default(string), int? ndbNumber = default(int?), string additionalDescriptions = default(string), string allHighlightFields = default(string), float? score = default(float?))
        {
            // to ensure "fdcId" is required (not null)
            if (fdcId == null)
            {
                throw new InvalidDataException("fdcId is a required property for SearchResultFood and cannot be null");
            }
            else
            {
                this.FdcId = fdcId;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for SearchResultFood and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.DataType = dataType;
            this.FoodCode = foodCode;
            this.FoodNutrients = foodNutrients;
            this.PublicationDate = publicationDate;
            this.ScientificName = scientificName;
            this.BrandOwner = brandOwner;
            this.GtinUpc = gtinUpc;
            this.Ingredients = ingredients;
            this.NdbNumber = ndbNumber;
            this.AdditionalDescriptions = additionalDescriptions;
            this.AllHighlightFields = allHighlightFields;
            this.Score = score;
        }
        
        /// <summary>
        /// Unique ID of the food.
        /// </summary>
        /// <value>Unique ID of the food.</value>
        [DataMember(Name="fdcId", EmitDefaultValue=false)]
        public int? FdcId { get; set; }

        /// <summary>
        /// The type of the food data.
        /// </summary>
        /// <value>The type of the food data.</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// The description of the food.
        /// </summary>
        /// <value>The description of the food.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Any A unique ID identifying the food within FNDDS.
        /// </summary>
        /// <value>Any A unique ID identifying the food within FNDDS.</value>
        [DataMember(Name="foodCode", EmitDefaultValue=false)]
        public string FoodCode { get; set; }

        /// <summary>
        /// Gets or Sets FoodNutrients
        /// </summary>
        [DataMember(Name="foodNutrients", EmitDefaultValue=false)]
        public List<AbridgedFoodNutrient> FoodNutrients { get; set; }

        /// <summary>
        /// Date the item was published to FDC.
        /// </summary>
        /// <value>Date the item was published to FDC.</value>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// The scientific name of the food.
        /// </summary>
        /// <value>The scientific name of the food.</value>
        [DataMember(Name="scientificName", EmitDefaultValue=false)]
        public string ScientificName { get; set; }

        /// <summary>
        /// Brand owner for the food. Only applies to Branded Foods.
        /// </summary>
        /// <value>Brand owner for the food. Only applies to Branded Foods.</value>
        [DataMember(Name="brandOwner", EmitDefaultValue=false)]
        public string BrandOwner { get; set; }

        /// <summary>
        /// GTIN or UPC code identifying the food. Only applies to Branded Foods.
        /// </summary>
        /// <value>GTIN or UPC code identifying the food. Only applies to Branded Foods.</value>
        [DataMember(Name="gtinUpc", EmitDefaultValue=false)]
        public string GtinUpc { get; set; }

        /// <summary>
        /// The list of ingredients (as it appears on the product label). Only applies to Branded Foods.
        /// </summary>
        /// <value>The list of ingredients (as it appears on the product label). Only applies to Branded Foods.</value>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public string Ingredients { get; set; }

        /// <summary>
        /// Unique number assigned for foundation foods. Only applies to Foundation and SRLegacy Foods.
        /// </summary>
        /// <value>Unique number assigned for foundation foods. Only applies to Foundation and SRLegacy Foods.</value>
        [DataMember(Name="ndbNumber", EmitDefaultValue=false)]
        public int? NdbNumber { get; set; }

        /// <summary>
        /// Any additional descriptions of the food.
        /// </summary>
        /// <value>Any additional descriptions of the food.</value>
        [DataMember(Name="additionalDescriptions", EmitDefaultValue=false)]
        public string AdditionalDescriptions { get; set; }

        /// <summary>
        /// allHighlightFields
        /// </summary>
        /// <value>allHighlightFields</value>
        [DataMember(Name="allHighlightFields", EmitDefaultValue=false)]
        public string AllHighlightFields { get; set; }

        /// <summary>
        /// Relative score indicating how well the food matches the search criteria.
        /// </summary>
        /// <value>Relative score indicating how well the food matches the search criteria.</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultFood {\n");
            sb.Append("  FdcId: ").Append(FdcId).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FoodCode: ").Append(FoodCode).Append("\n");
            sb.Append("  FoodNutrients: ").Append(FoodNutrients).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  ScientificName: ").Append(ScientificName).Append("\n");
            sb.Append("  BrandOwner: ").Append(BrandOwner).Append("\n");
            sb.Append("  GtinUpc: ").Append(GtinUpc).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  NdbNumber: ").Append(NdbNumber).Append("\n");
            sb.Append("  AdditionalDescriptions: ").Append(AdditionalDescriptions).Append("\n");
            sb.Append("  AllHighlightFields: ").Append(AllHighlightFields).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResultFood);
        }

        /// <summary>
        /// Returns true if SearchResultFood instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultFood to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultFood input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FdcId == input.FdcId ||
                    (this.FdcId != null &&
                    this.FdcId.Equals(input.FdcId))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FoodCode == input.FoodCode ||
                    (this.FoodCode != null &&
                    this.FoodCode.Equals(input.FoodCode))
                ) && 
                (
                    this.FoodNutrients == input.FoodNutrients ||
                    this.FoodNutrients != null &&
                    input.FoodNutrients != null &&
                    this.FoodNutrients.SequenceEqual(input.FoodNutrients)
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.ScientificName == input.ScientificName ||
                    (this.ScientificName != null &&
                    this.ScientificName.Equals(input.ScientificName))
                ) && 
                (
                    this.BrandOwner == input.BrandOwner ||
                    (this.BrandOwner != null &&
                    this.BrandOwner.Equals(input.BrandOwner))
                ) && 
                (
                    this.GtinUpc == input.GtinUpc ||
                    (this.GtinUpc != null &&
                    this.GtinUpc.Equals(input.GtinUpc))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    (this.Ingredients != null &&
                    this.Ingredients.Equals(input.Ingredients))
                ) && 
                (
                    this.NdbNumber == input.NdbNumber ||
                    (this.NdbNumber != null &&
                    this.NdbNumber.Equals(input.NdbNumber))
                ) && 
                (
                    this.AdditionalDescriptions == input.AdditionalDescriptions ||
                    (this.AdditionalDescriptions != null &&
                    this.AdditionalDescriptions.Equals(input.AdditionalDescriptions))
                ) && 
                (
                    this.AllHighlightFields == input.AllHighlightFields ||
                    (this.AllHighlightFields != null &&
                    this.AllHighlightFields.Equals(input.AllHighlightFields))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FdcId != null)
                    hashCode = hashCode * 59 + this.FdcId.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FoodCode != null)
                    hashCode = hashCode * 59 + this.FoodCode.GetHashCode();
                if (this.FoodNutrients != null)
                    hashCode = hashCode * 59 + this.FoodNutrients.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.ScientificName != null)
                    hashCode = hashCode * 59 + this.ScientificName.GetHashCode();
                if (this.BrandOwner != null)
                    hashCode = hashCode * 59 + this.BrandOwner.GetHashCode();
                if (this.GtinUpc != null)
                    hashCode = hashCode * 59 + this.GtinUpc.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.NdbNumber != null)
                    hashCode = hashCode * 59 + this.NdbNumber.GetHashCode();
                if (this.AdditionalDescriptions != null)
                    hashCode = hashCode * 59 + this.AdditionalDescriptions.GetHashCode();
                if (this.AllHighlightFields != null)
                    hashCode = hashCode * 59 + this.AllHighlightFields.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}