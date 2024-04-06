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
    /// FoundationFoodItem
    /// </summary>
    [DataContract]
        public partial class FoundationFoodItem :  IEquatable<FoundationFoodItem>, IValidatableObject, InlineResponse200 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoundationFoodItem" /> class.
        /// </summary>
        /// <param name="fdcId">fdcId (required).</param>
        /// <param name="dataType">dataType (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="foodClass">foodClass.</param>
        /// <param name="footNote">footNote.</param>
        /// <param name="isHistoricalReference">isHistoricalReference.</param>
        /// <param name="ndbNumber">ndbNumber.</param>
        /// <param name="publicationDate">publicationDate.</param>
        /// <param name="scientificName">scientificName.</param>
        /// <param name="foodCategory">foodCategory.</param>
        /// <param name="foodComponents">foodComponents.</param>
        /// <param name="foodNutrients">foodNutrients.</param>
        /// <param name="foodPortions">foodPortions.</param>
        /// <param name="inputFoods">inputFoods.</param>
        /// <param name="nutrientConversionFactors">nutrientConversionFactors.</param>
        public FoundationFoodItem(int? fdcId = default(int?), string dataType = default(string), string description = default(string), string foodClass = default(string), string footNote = default(string), bool? isHistoricalReference = default(bool?), int? ndbNumber = default(int?), string publicationDate = default(string), string scientificName = default(string), FoodCategory foodCategory = default(FoodCategory), List<FoodComponent> foodComponents = default(List<FoodComponent>), List<FoodNutrient> foodNutrients = default(List<FoodNutrient>), List<FoodPortion> foodPortions = default(List<FoodPortion>), List<InputFoodFoundation> inputFoods = default(List<InputFoodFoundation>), List<NutrientConversionFactors> nutrientConversionFactors = default(List<NutrientConversionFactors>))
        {
            // to ensure "fdcId" is required (not null)
            if (fdcId == null)
            {
                throw new InvalidDataException("fdcId is a required property for FoundationFoodItem and cannot be null");
            }
            else
            {
                this.FdcId = fdcId;
            }
            // to ensure "dataType" is required (not null)
            if (dataType == null)
            {
                throw new InvalidDataException("dataType is a required property for FoundationFoodItem and cannot be null");
            }
            else
            {
                this.DataType = dataType;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for FoundationFoodItem and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.FoodClass = foodClass;
            this.FootNote = footNote;
            this.IsHistoricalReference = isHistoricalReference;
            this.NdbNumber = ndbNumber;
            this.PublicationDate = publicationDate;
            this.ScientificName = scientificName;
            this.FoodCategory = foodCategory;
            this.FoodComponents = foodComponents;
            this.FoodNutrients = foodNutrients;
            this.FoodPortions = foodPortions;
            this.InputFoods = inputFoods;
            this.NutrientConversionFactors = nutrientConversionFactors;
        }
        
        /// <summary>
        /// Gets or Sets FdcId
        /// </summary>
        [DataMember(Name="fdcId", EmitDefaultValue=false)]
        public int? FdcId { get; set; }

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
        /// Gets or Sets FootNote
        /// </summary>
        [DataMember(Name="footNote", EmitDefaultValue=false)]
        public string FootNote { get; set; }

        /// <summary>
        /// Gets or Sets IsHistoricalReference
        /// </summary>
        [DataMember(Name="isHistoricalReference", EmitDefaultValue=false)]
        public bool? IsHistoricalReference { get; set; }

        /// <summary>
        /// Gets or Sets NdbNumber
        /// </summary>
        [DataMember(Name="ndbNumber", EmitDefaultValue=false)]
        public int? NdbNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets ScientificName
        /// </summary>
        [DataMember(Name="scientificName", EmitDefaultValue=false)]
        public string ScientificName { get; set; }

        /// <summary>
        /// Gets or Sets FoodCategory
        /// </summary>
        [DataMember(Name="foodCategory", EmitDefaultValue=false)]
        public FoodCategory FoodCategory { get; set; }

        /// <summary>
        /// Gets or Sets FoodComponents
        /// </summary>
        [DataMember(Name="foodComponents", EmitDefaultValue=false)]
        public List<FoodComponent> FoodComponents { get; set; }

        /// <summary>
        /// Gets or Sets FoodNutrients
        /// </summary>
        [DataMember(Name="foodNutrients", EmitDefaultValue=false)]
        public List<FoodNutrient> FoodNutrients { get; set; }

        /// <summary>
        /// Gets or Sets FoodPortions
        /// </summary>
        [DataMember(Name="foodPortions", EmitDefaultValue=false)]
        public List<FoodPortion> FoodPortions { get; set; }

        /// <summary>
        /// Gets or Sets InputFoods
        /// </summary>
        [DataMember(Name="inputFoods", EmitDefaultValue=false)]
        public List<InputFoodFoundation> InputFoods { get; set; }

        /// <summary>
        /// Gets or Sets NutrientConversionFactors
        /// </summary>
        [DataMember(Name="nutrientConversionFactors", EmitDefaultValue=false)]
        public List<NutrientConversionFactors> NutrientConversionFactors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FoundationFoodItem {\n");
            sb.Append("  FdcId: ").Append(FdcId).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FoodClass: ").Append(FoodClass).Append("\n");
            sb.Append("  FootNote: ").Append(FootNote).Append("\n");
            sb.Append("  IsHistoricalReference: ").Append(IsHistoricalReference).Append("\n");
            sb.Append("  NdbNumber: ").Append(NdbNumber).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  ScientificName: ").Append(ScientificName).Append("\n");
            sb.Append("  FoodCategory: ").Append(FoodCategory).Append("\n");
            sb.Append("  FoodComponents: ").Append(FoodComponents).Append("\n");
            sb.Append("  FoodNutrients: ").Append(FoodNutrients).Append("\n");
            sb.Append("  FoodPortions: ").Append(FoodPortions).Append("\n");
            sb.Append("  InputFoods: ").Append(InputFoods).Append("\n");
            sb.Append("  NutrientConversionFactors: ").Append(NutrientConversionFactors).Append("\n");
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
            return this.Equals(input as FoundationFoodItem);
        }

        /// <summary>
        /// Returns true if FoundationFoodItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FoundationFoodItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FoundationFoodItem input)
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
                    this.FoodClass == input.FoodClass ||
                    (this.FoodClass != null &&
                    this.FoodClass.Equals(input.FoodClass))
                ) && 
                (
                    this.FootNote == input.FootNote ||
                    (this.FootNote != null &&
                    this.FootNote.Equals(input.FootNote))
                ) && 
                (
                    this.IsHistoricalReference == input.IsHistoricalReference ||
                    (this.IsHistoricalReference != null &&
                    this.IsHistoricalReference.Equals(input.IsHistoricalReference))
                ) && 
                (
                    this.NdbNumber == input.NdbNumber ||
                    (this.NdbNumber != null &&
                    this.NdbNumber.Equals(input.NdbNumber))
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
                    this.FoodCategory == input.FoodCategory ||
                    (this.FoodCategory != null &&
                    this.FoodCategory.Equals(input.FoodCategory))
                ) && 
                (
                    this.FoodComponents == input.FoodComponents ||
                    this.FoodComponents != null &&
                    input.FoodComponents != null &&
                    this.FoodComponents.SequenceEqual(input.FoodComponents)
                ) && 
                (
                    this.FoodNutrients == input.FoodNutrients ||
                    this.FoodNutrients != null &&
                    input.FoodNutrients != null &&
                    this.FoodNutrients.SequenceEqual(input.FoodNutrients)
                ) && 
                (
                    this.FoodPortions == input.FoodPortions ||
                    this.FoodPortions != null &&
                    input.FoodPortions != null &&
                    this.FoodPortions.SequenceEqual(input.FoodPortions)
                ) && 
                (
                    this.InputFoods == input.InputFoods ||
                    this.InputFoods != null &&
                    input.InputFoods != null &&
                    this.InputFoods.SequenceEqual(input.InputFoods)
                ) && 
                (
                    this.NutrientConversionFactors == input.NutrientConversionFactors ||
                    this.NutrientConversionFactors != null &&
                    input.NutrientConversionFactors != null &&
                    this.NutrientConversionFactors.SequenceEqual(input.NutrientConversionFactors)
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
                if (this.FoodClass != null)
                    hashCode = hashCode * 59 + this.FoodClass.GetHashCode();
                if (this.FootNote != null)
                    hashCode = hashCode * 59 + this.FootNote.GetHashCode();
                if (this.IsHistoricalReference != null)
                    hashCode = hashCode * 59 + this.IsHistoricalReference.GetHashCode();
                if (this.NdbNumber != null)
                    hashCode = hashCode * 59 + this.NdbNumber.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.ScientificName != null)
                    hashCode = hashCode * 59 + this.ScientificName.GetHashCode();
                if (this.FoodCategory != null)
                    hashCode = hashCode * 59 + this.FoodCategory.GetHashCode();
                if (this.FoodComponents != null)
                    hashCode = hashCode * 59 + this.FoodComponents.GetHashCode();
                if (this.FoodNutrients != null)
                    hashCode = hashCode * 59 + this.FoodNutrients.GetHashCode();
                if (this.FoodPortions != null)
                    hashCode = hashCode * 59 + this.FoodPortions.GetHashCode();
                if (this.InputFoods != null)
                    hashCode = hashCode * 59 + this.InputFoods.GetHashCode();
                if (this.NutrientConversionFactors != null)
                    hashCode = hashCode * 59 + this.NutrientConversionFactors.GetHashCode();
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