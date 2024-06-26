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
    /// FoodNutrient
    /// </summary>
    [DataContract]
        public partial class FoodNutrient :  IEquatable<FoodNutrient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoodNutrient" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="amount">amount.</param>
        /// <param name="dataPoints">dataPoints.</param>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        /// <param name="median">median.</param>
        /// <param name="type">type.</param>
        /// <param name="nutrient">nutrient.</param>
        /// <param name="foodNutrientDerivation">foodNutrientDerivation.</param>
        /// <param name="nutrientAnalysisDetails">nutrientAnalysisDetails.</param>
        public FoodNutrient(int? id = default(int?), float? amount = default(float?), int? dataPoints = default(int?), float? min = default(float?), float? max = default(float?), float? median = default(float?), string type = default(string), Nutrient nutrient = default(Nutrient), FoodNutrientDerivation foodNutrientDerivation = default(FoodNutrientDerivation), NutrientAnalysisDetails nutrientAnalysisDetails = default(NutrientAnalysisDetails))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for FoodNutrient and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.Amount = amount;
            this.DataPoints = dataPoints;
            this.Min = min;
            this.Max = max;
            this.Median = median;
            this.Type = type;
            this.Nutrient = nutrient;
            this.FoodNutrientDerivation = foodNutrientDerivation;
            this.NutrientAnalysisDetails = nutrientAnalysisDetails;
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
        /// Gets or Sets DataPoints
        /// </summary>
        [DataMember(Name="dataPoints", EmitDefaultValue=false)]
        public int? DataPoints { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public float? Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public float? Max { get; set; }

        /// <summary>
        /// Gets or Sets Median
        /// </summary>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public float? Median { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Nutrient
        /// </summary>
        [DataMember(Name="nutrient", EmitDefaultValue=false)]
        public Nutrient Nutrient { get; set; }

        /// <summary>
        /// Gets or Sets FoodNutrientDerivation
        /// </summary>
        [DataMember(Name="foodNutrientDerivation", EmitDefaultValue=false)]
        public FoodNutrientDerivation FoodNutrientDerivation { get; set; }

        /// <summary>
        /// Gets or Sets NutrientAnalysisDetails
        /// </summary>
        [DataMember(Name="nutrientAnalysisDetails", EmitDefaultValue=false)]
        public NutrientAnalysisDetails NutrientAnalysisDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FoodNutrient {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Nutrient: ").Append(Nutrient).Append("\n");
            sb.Append("  FoodNutrientDerivation: ").Append(FoodNutrientDerivation).Append("\n");
            sb.Append("  NutrientAnalysisDetails: ").Append(NutrientAnalysisDetails).Append("\n");
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
            return this.Equals(input as FoodNutrient);
        }

        /// <summary>
        /// Returns true if FoodNutrient instances are equal
        /// </summary>
        /// <param name="input">Instance of FoodNutrient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FoodNutrient input)
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
                    this.DataPoints == input.DataPoints ||
                    (this.DataPoints != null &&
                    this.DataPoints.Equals(input.DataPoints))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Median == input.Median ||
                    (this.Median != null &&
                    this.Median.Equals(input.Median))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Nutrient == input.Nutrient ||
                    (this.Nutrient != null &&
                    this.Nutrient.Equals(input.Nutrient))
                ) && 
                (
                    this.FoodNutrientDerivation == input.FoodNutrientDerivation ||
                    (this.FoodNutrientDerivation != null &&
                    this.FoodNutrientDerivation.Equals(input.FoodNutrientDerivation))
                ) && 
                (
                    this.NutrientAnalysisDetails == input.NutrientAnalysisDetails ||
                    (this.NutrientAnalysisDetails != null &&
                    this.NutrientAnalysisDetails.Equals(input.NutrientAnalysisDetails))
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
                if (this.DataPoints != null)
                    hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Median != null)
                    hashCode = hashCode * 59 + this.Median.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Nutrient != null)
                    hashCode = hashCode * 59 + this.Nutrient.GetHashCode();
                if (this.FoodNutrientDerivation != null)
                    hashCode = hashCode * 59 + this.FoodNutrientDerivation.GetHashCode();
                if (this.NutrientAnalysisDetails != null)
                    hashCode = hashCode * 59 + this.NutrientAnalysisDetails.GetHashCode();
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
