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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// FoodUpdateLog
    /// </summary>
    [DataContract]
        public partial class FoodUpdateLog :  IEquatable<FoodUpdateLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodUpdateLog" /> class.
        /// </summary>
        /// <param name="fdcId">fdcId.</param>
        /// <param name="availableDate">availableDate.</param>
        /// <param name="brandOwner">brandOwner.</param>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="description">description.</param>
        /// <param name="foodClass">foodClass.</param>
        /// <param name="gtinUpc">gtinUpc.</param>
        /// <param name="householdServingFullText">householdServingFullText.</param>
        /// <param name="ingredients">ingredients.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="publicationDate">publicationDate.</param>
        /// <param name="servingSize">servingSize.</param>
        /// <param name="servingSizeUnit">servingSizeUnit.</param>
        /// <param name="brandedFoodCategory">brandedFoodCategory.</param>
        /// <param name="changes">changes.</param>
        /// <param name="foodAttributes">foodAttributes.</param>
        public FoodUpdateLog(int? fdcId = default(int?), string availableDate = default(string), string brandOwner = default(string), string dataSource = default(string), string dataType = default(string), string description = default(string), string foodClass = default(string), string gtinUpc = default(string), string householdServingFullText = default(string), string ingredients = default(string), string modifiedDate = default(string), string publicationDate = default(string), int? servingSize = default(int?), string servingSizeUnit = default(string), string brandedFoodCategory = default(string), string changes = default(string), List<FoodAttribute> foodAttributes = default(List<FoodAttribute>))
        {
            this.FdcId = fdcId;
            this.AvailableDate = availableDate;
            this.BrandOwner = brandOwner;
            this.DataSource = dataSource;
            this.DataType = dataType;
            this.Description = description;
            this.FoodClass = foodClass;
            this.GtinUpc = gtinUpc;
            this.HouseholdServingFullText = householdServingFullText;
            this.Ingredients = ingredients;
            this.ModifiedDate = modifiedDate;
            this.PublicationDate = publicationDate;
            this.ServingSize = servingSize;
            this.ServingSizeUnit = servingSizeUnit;
            this.BrandedFoodCategory = brandedFoodCategory;
            this.Changes = changes;
            this.FoodAttributes = foodAttributes;
        }
        
        /// <summary>
        /// Gets or Sets FdcId
        /// </summary>
        [DataMember(Name="fdcId", EmitDefaultValue=false)]
        public int? FdcId { get; set; }

        /// <summary>
        /// Gets or Sets AvailableDate
        /// </summary>
        [DataMember(Name="availableDate", EmitDefaultValue=false)]
        public string AvailableDate { get; set; }

        /// <summary>
        /// Gets or Sets BrandOwner
        /// </summary>
        [DataMember(Name="brandOwner", EmitDefaultValue=false)]
        public string BrandOwner { get; set; }

        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FoodClass
        /// </summary>
        [DataMember(Name="foodClass", EmitDefaultValue=false)]
        public string FoodClass { get; set; }

        /// <summary>
        /// Gets or Sets GtinUpc
        /// </summary>
        [DataMember(Name="gtinUpc", EmitDefaultValue=false)]
        public string GtinUpc { get; set; }

        /// <summary>
        /// Gets or Sets HouseholdServingFullText
        /// </summary>
        [DataMember(Name="householdServingFullText", EmitDefaultValue=false)]
        public string HouseholdServingFullText { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public string Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets ServingSize
        /// </summary>
        [DataMember(Name="servingSize", EmitDefaultValue=false)]
        public int? ServingSize { get; set; }

        /// <summary>
        /// Gets or Sets ServingSizeUnit
        /// </summary>
        [DataMember(Name="servingSizeUnit", EmitDefaultValue=false)]
        public string ServingSizeUnit { get; set; }

        /// <summary>
        /// Gets or Sets BrandedFoodCategory
        /// </summary>
        [DataMember(Name="brandedFoodCategory", EmitDefaultValue=false)]
        public string BrandedFoodCategory { get; set; }

        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public string Changes { get; set; }

        /// <summary>
        /// Gets or Sets FoodAttributes
        /// </summary>
        [DataMember(Name="foodAttributes", EmitDefaultValue=false)]
        public List<FoodAttribute> FoodAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FoodUpdateLog {\n");
            sb.Append("  FdcId: ").Append(FdcId).Append("\n");
            sb.Append("  AvailableDate: ").Append(AvailableDate).Append("\n");
            sb.Append("  BrandOwner: ").Append(BrandOwner).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FoodClass: ").Append(FoodClass).Append("\n");
            sb.Append("  GtinUpc: ").Append(GtinUpc).Append("\n");
            sb.Append("  HouseholdServingFullText: ").Append(HouseholdServingFullText).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  ServingSize: ").Append(ServingSize).Append("\n");
            sb.Append("  ServingSizeUnit: ").Append(ServingSizeUnit).Append("\n");
            sb.Append("  BrandedFoodCategory: ").Append(BrandedFoodCategory).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  FoodAttributes: ").Append(FoodAttributes).Append("\n");
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
            return this.Equals(input as FoodUpdateLog);
        }

        /// <summary>
        /// Returns true if FoodUpdateLog instances are equal
        /// </summary>
        /// <param name="input">Instance of FoodUpdateLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FoodUpdateLog input)
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
                    this.AvailableDate == input.AvailableDate ||
                    (this.AvailableDate != null &&
                    this.AvailableDate.Equals(input.AvailableDate))
                ) && 
                (
                    this.BrandOwner == input.BrandOwner ||
                    (this.BrandOwner != null &&
                    this.BrandOwner.Equals(input.BrandOwner))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
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
                    this.FoodClass == input.FoodClass ||
                    (this.FoodClass != null &&
                    this.FoodClass.Equals(input.FoodClass))
                ) && 
                (
                    this.GtinUpc == input.GtinUpc ||
                    (this.GtinUpc != null &&
                    this.GtinUpc.Equals(input.GtinUpc))
                ) && 
                (
                    this.HouseholdServingFullText == input.HouseholdServingFullText ||
                    (this.HouseholdServingFullText != null &&
                    this.HouseholdServingFullText.Equals(input.HouseholdServingFullText))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    (this.Ingredients != null &&
                    this.Ingredients.Equals(input.Ingredients))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.ServingSize == input.ServingSize ||
                    (this.ServingSize != null &&
                    this.ServingSize.Equals(input.ServingSize))
                ) && 
                (
                    this.ServingSizeUnit == input.ServingSizeUnit ||
                    (this.ServingSizeUnit != null &&
                    this.ServingSizeUnit.Equals(input.ServingSizeUnit))
                ) && 
                (
                    this.BrandedFoodCategory == input.BrandedFoodCategory ||
                    (this.BrandedFoodCategory != null &&
                    this.BrandedFoodCategory.Equals(input.BrandedFoodCategory))
                ) && 
                (
                    this.Changes == input.Changes ||
                    (this.Changes != null &&
                    this.Changes.Equals(input.Changes))
                ) && 
                (
                    this.FoodAttributes == input.FoodAttributes ||
                    this.FoodAttributes != null &&
                    input.FoodAttributes != null &&
                    this.FoodAttributes.SequenceEqual(input.FoodAttributes)
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
                if (this.AvailableDate != null)
                    hashCode = hashCode * 59 + this.AvailableDate.GetHashCode();
                if (this.BrandOwner != null)
                    hashCode = hashCode * 59 + this.BrandOwner.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FoodClass != null)
                    hashCode = hashCode * 59 + this.FoodClass.GetHashCode();
                if (this.GtinUpc != null)
                    hashCode = hashCode * 59 + this.GtinUpc.GetHashCode();
                if (this.HouseholdServingFullText != null)
                    hashCode = hashCode * 59 + this.HouseholdServingFullText.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.ServingSize != null)
                    hashCode = hashCode * 59 + this.ServingSize.GetHashCode();
                if (this.ServingSizeUnit != null)
                    hashCode = hashCode * 59 + this.ServingSizeUnit.GetHashCode();
                if (this.BrandedFoodCategory != null)
                    hashCode = hashCode * 59 + this.BrandedFoodCategory.GetHashCode();
                if (this.Changes != null)
                    hashCode = hashCode * 59 + this.Changes.GetHashCode();
                if (this.FoodAttributes != null)
                    hashCode = hashCode * 59 + this.FoodAttributes.GetHashCode();
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