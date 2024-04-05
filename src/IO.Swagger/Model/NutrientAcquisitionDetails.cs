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
    /// NutrientAcquisitionDetails
    /// </summary>
    [DataContract]
        public partial class NutrientAcquisitionDetails :  IEquatable<NutrientAcquisitionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutrientAcquisitionDetails" /> class.
        /// </summary>
        /// <param name="sampleUnitId">sampleUnitId.</param>
        /// <param name="purchaseDate">purchaseDate.</param>
        /// <param name="storeCity">storeCity.</param>
        /// <param name="storeState">storeState.</param>
        public NutrientAcquisitionDetails(int? sampleUnitId = default(int?), string purchaseDate = default(string), string storeCity = default(string), string storeState = default(string))
        {
            this.SampleUnitId = sampleUnitId;
            this.PurchaseDate = purchaseDate;
            this.StoreCity = storeCity;
            this.StoreState = storeState;
        }
        
        /// <summary>
        /// Gets or Sets SampleUnitId
        /// </summary>
        [DataMember(Name="sampleUnitId", EmitDefaultValue=false)]
        public int? SampleUnitId { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=false)]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Gets or Sets StoreCity
        /// </summary>
        [DataMember(Name="storeCity", EmitDefaultValue=false)]
        public string StoreCity { get; set; }

        /// <summary>
        /// Gets or Sets StoreState
        /// </summary>
        [DataMember(Name="storeState", EmitDefaultValue=false)]
        public string StoreState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NutrientAcquisitionDetails {\n");
            sb.Append("  SampleUnitId: ").Append(SampleUnitId).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  StoreCity: ").Append(StoreCity).Append("\n");
            sb.Append("  StoreState: ").Append(StoreState).Append("\n");
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
            return this.Equals(input as NutrientAcquisitionDetails);
        }

        /// <summary>
        /// Returns true if NutrientAcquisitionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of NutrientAcquisitionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutrientAcquisitionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SampleUnitId == input.SampleUnitId ||
                    (this.SampleUnitId != null &&
                    this.SampleUnitId.Equals(input.SampleUnitId))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.StoreCity == input.StoreCity ||
                    (this.StoreCity != null &&
                    this.StoreCity.Equals(input.StoreCity))
                ) && 
                (
                    this.StoreState == input.StoreState ||
                    (this.StoreState != null &&
                    this.StoreState.Equals(input.StoreState))
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
                if (this.SampleUnitId != null)
                    hashCode = hashCode * 59 + this.SampleUnitId.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                if (this.StoreCity != null)
                    hashCode = hashCode * 59 + this.StoreCity.GetHashCode();
                if (this.StoreState != null)
                    hashCode = hashCode * 59 + this.StoreState.GetHashCode();
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
