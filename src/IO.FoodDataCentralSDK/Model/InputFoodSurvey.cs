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
    /// applies to Survey (FNDDS). Not all inputFoods will have all fields.
    /// </summary>
    [DataContract]
        public partial class InputFoodSurvey :  IEquatable<InputFoodSurvey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFoodSurvey" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="foodDescription">foodDescription.</param>
        /// <param name="ingredientCode">ingredientCode.</param>
        /// <param name="ingredientDescription">ingredientDescription.</param>
        /// <param name="ingredientWeight">ingredientWeight.</param>
        /// <param name="portionCode">portionCode.</param>
        /// <param name="portionDescription">portionDescription.</param>
        /// <param name="sequenceNumber">sequenceNumber.</param>
        /// <param name="surveyFlag">surveyFlag.</param>
        /// <param name="unit">unit.</param>
        /// <param name="inputFood">inputFood.</param>
        /// <param name="retentionFactor">retentionFactor.</param>
        public InputFoodSurvey(int? id = default(int?), float? amount = default(float?), string foodDescription = default(string), int? ingredientCode = default(int?), string ingredientDescription = default(string), float? ingredientWeight = default(float?), string portionCode = default(string), string portionDescription = default(string), int? sequenceNumber = default(int?), int? surveyFlag = default(int?), string unit = default(string), SurveyFoodItem inputFood = default(SurveyFoodItem), RetentionFactor retentionFactor = default(RetentionFactor))
        {
            this.Id = id;
            this.Amount = amount;
            this.FoodDescription = foodDescription;
            this.IngredientCode = ingredientCode;
            this.IngredientDescription = ingredientDescription;
            this.IngredientWeight = ingredientWeight;
            this.PortionCode = portionCode;
            this.PortionDescription = portionDescription;
            this.SequenceNumber = sequenceNumber;
            this.SurveyFlag = surveyFlag;
            this.Unit = unit;
            this.InputFood = inputFood;
            this.RetentionFactor = retentionFactor;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// Gets or Sets FoodDescription
        /// </summary>
        [DataMember(Name="foodDescription", EmitDefaultValue=false)]
        public string FoodDescription { get; set; }

        /// <summary>
        /// Gets or Sets IngredientCode
        /// </summary>
        [DataMember(Name="ingredientCode", EmitDefaultValue=false)]
        public int? IngredientCode { get; set; }

        /// <summary>
        /// Gets or Sets IngredientDescription
        /// </summary>
        [DataMember(Name="ingredientDescription", EmitDefaultValue=false)]
        public string IngredientDescription { get; set; }

        /// <summary>
        /// Gets or Sets IngredientWeight
        /// </summary>
        [DataMember(Name="ingredientWeight", EmitDefaultValue=false)]
        public float? IngredientWeight { get; set; }

        /// <summary>
        /// Gets or Sets PortionCode
        /// </summary>
        [DataMember(Name="portionCode", EmitDefaultValue=false)]
        public string PortionCode { get; set; }

        /// <summary>
        /// Gets or Sets PortionDescription
        /// </summary>
        [DataMember(Name="portionDescription", EmitDefaultValue=false)]
        public string PortionDescription { get; set; }

        /// <summary>
        /// Gets or Sets SequenceNumber
        /// </summary>
        [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets SurveyFlag
        /// </summary>
        [DataMember(Name="surveyFlag", EmitDefaultValue=false)]
        public int? SurveyFlag { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets InputFood
        /// </summary>
        [DataMember(Name="inputFood", EmitDefaultValue=false)]
        public SurveyFoodItem InputFood { get; set; }

        /// <summary>
        /// Gets or Sets RetentionFactor
        /// </summary>
        [DataMember(Name="retentionFactor", EmitDefaultValue=false)]
        public RetentionFactor RetentionFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputFoodSurvey {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FoodDescription: ").Append(FoodDescription).Append("\n");
            sb.Append("  IngredientCode: ").Append(IngredientCode).Append("\n");
            sb.Append("  IngredientDescription: ").Append(IngredientDescription).Append("\n");
            sb.Append("  IngredientWeight: ").Append(IngredientWeight).Append("\n");
            sb.Append("  PortionCode: ").Append(PortionCode).Append("\n");
            sb.Append("  PortionDescription: ").Append(PortionDescription).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  SurveyFlag: ").Append(SurveyFlag).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  InputFood: ").Append(InputFood).Append("\n");
            sb.Append("  RetentionFactor: ").Append(RetentionFactor).Append("\n");
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
            return this.Equals(input as InputFoodSurvey);
        }

        /// <summary>
        /// Returns true if InputFoodSurvey instances are equal
        /// </summary>
        /// <param name="input">Instance of InputFoodSurvey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputFoodSurvey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FoodDescription == input.FoodDescription ||
                    (this.FoodDescription != null &&
                    this.FoodDescription.Equals(input.FoodDescription))
                ) && 
                (
                    this.IngredientCode == input.IngredientCode ||
                    (this.IngredientCode != null &&
                    this.IngredientCode.Equals(input.IngredientCode))
                ) && 
                (
                    this.IngredientDescription == input.IngredientDescription ||
                    (this.IngredientDescription != null &&
                    this.IngredientDescription.Equals(input.IngredientDescription))
                ) && 
                (
                    this.IngredientWeight == input.IngredientWeight ||
                    (this.IngredientWeight != null &&
                    this.IngredientWeight.Equals(input.IngredientWeight))
                ) && 
                (
                    this.PortionCode == input.PortionCode ||
                    (this.PortionCode != null &&
                    this.PortionCode.Equals(input.PortionCode))
                ) && 
                (
                    this.PortionDescription == input.PortionDescription ||
                    (this.PortionDescription != null &&
                    this.PortionDescription.Equals(input.PortionDescription))
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    (this.SequenceNumber != null &&
                    this.SequenceNumber.Equals(input.SequenceNumber))
                ) && 
                (
                    this.SurveyFlag == input.SurveyFlag ||
                    (this.SurveyFlag != null &&
                    this.SurveyFlag.Equals(input.SurveyFlag))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.InputFood == input.InputFood ||
                    (this.InputFood != null &&
                    this.InputFood.Equals(input.InputFood))
                ) && 
                (
                    this.RetentionFactor == input.RetentionFactor ||
                    (this.RetentionFactor != null &&
                    this.RetentionFactor.Equals(input.RetentionFactor))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.FoodDescription != null)
                    hashCode = hashCode * 59 + this.FoodDescription.GetHashCode();
                if (this.IngredientCode != null)
                    hashCode = hashCode * 59 + this.IngredientCode.GetHashCode();
                if (this.IngredientDescription != null)
                    hashCode = hashCode * 59 + this.IngredientDescription.GetHashCode();
                if (this.IngredientWeight != null)
                    hashCode = hashCode * 59 + this.IngredientWeight.GetHashCode();
                if (this.PortionCode != null)
                    hashCode = hashCode * 59 + this.PortionCode.GetHashCode();
                if (this.PortionDescription != null)
                    hashCode = hashCode * 59 + this.PortionDescription.GetHashCode();
                if (this.SequenceNumber != null)
                    hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
                if (this.SurveyFlag != null)
                    hashCode = hashCode * 59 + this.SurveyFlag.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.InputFood != null)
                    hashCode = hashCode * 59 + this.InputFood.GetHashCode();
                if (this.RetentionFactor != null)
                    hashCode = hashCode * 59 + this.RetentionFactor.GetHashCode();
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