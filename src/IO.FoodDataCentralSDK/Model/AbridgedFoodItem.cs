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
    /// AbridgedFoodItem
    /// </summary>
    [DataContract]
        public partial class AbridgedFoodItem :  IEquatable<AbridgedFoodItem>, IValidatableObject, InlineResponse200 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbridgedFoodItem" /> class.
        /// </summary>
        /// <param name="dataType">dataType (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="fdcId">fdcId (required).</param>
        /// <param name="foodNutrients">foodNutrients.</param>
        /// <param name="publicationDate">publicationDate.</param>
        /// <param name="brandOwner">only applies to Branded Foods.</param>
        /// <param name="gtinUpc">only applies to Branded Foods.</param>
        /// <param name="ndbNumber">only applies to Foundation and SRLegacy Foods.</param>
        /// <param name="foodCode">only applies to Survey Foods.</param>
        public AbridgedFoodItem(string dataType = default(string), string description = default(string), int? fdcId = default(int?), List<AbridgedFoodNutrient> foodNutrients = default(List<AbridgedFoodNutrient>), string publicationDate = default(string), string brandOwner = default(string), string gtinUpc = default(string), int? ndbNumber = default(int?), string foodCode = default(string))
        {
            // to ensure "dataType" is required (not null)
            if (dataType == null)
            {
                throw new InvalidDataException("dataType is a required property for AbridgedFoodItem and cannot be null");
            }
            else
            {
                this.DataType = dataType;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AbridgedFoodItem and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "fdcId" is required (not null)
            if (fdcId == null)
            {
                throw new InvalidDataException("fdcId is a required property for AbridgedFoodItem and cannot be null");
            }
            else
            {
                this.FdcId = fdcId;
            }
            this.FoodNutrients = foodNutrients;
            this.PublicationDate = publicationDate;
            this.BrandOwner = brandOwner;
            this.GtinUpc = gtinUpc;
            this.NdbNumber = ndbNumber;
            this.FoodCode = foodCode;
        }
        
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
        /// Gets or Sets FdcId
        /// </summary>
        [DataMember(Name="fdcId", EmitDefaultValue=false)]
        public int? FdcId { get; set; }

        /// <summary>
        /// Gets or Sets FoodNutrients
        /// </summary>
        [DataMember(Name="foodNutrients", EmitDefaultValue=false)]
        public List<AbridgedFoodNutrient> FoodNutrients { get; set; }

        /// <summary>
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// only applies to Branded Foods
        /// </summary>
        /// <value>only applies to Branded Foods</value>
        [DataMember(Name="brandOwner", EmitDefaultValue=false)]
        public string BrandOwner { get; set; }

        /// <summary>
        /// only applies to Branded Foods
        /// </summary>
        /// <value>only applies to Branded Foods</value>
        [DataMember(Name="gtinUpc", EmitDefaultValue=false)]
        public string GtinUpc { get; set; }

        /// <summary>
        /// only applies to Foundation and SRLegacy Foods
        /// </summary>
        /// <value>only applies to Foundation and SRLegacy Foods</value>
        [DataMember(Name="ndbNumber", EmitDefaultValue=false)]
        public int? NdbNumber { get; set; }

        /// <summary>
        /// only applies to Survey Foods
        /// </summary>
        /// <value>only applies to Survey Foods</value>
        [DataMember(Name="foodCode", EmitDefaultValue=false)]
        public string FoodCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbridgedFoodItem {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FdcId: ").Append(FdcId).Append("\n");
            sb.Append("  FoodNutrients: ").Append(FoodNutrients).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  BrandOwner: ").Append(BrandOwner).Append("\n");
            sb.Append("  GtinUpc: ").Append(GtinUpc).Append("\n");
            sb.Append("  NdbNumber: ").Append(NdbNumber).Append("\n");
            sb.Append("  FoodCode: ").Append(FoodCode).Append("\n");
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
            return this.Equals(input as AbridgedFoodItem);
        }

        /// <summary>
        /// Returns true if AbridgedFoodItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AbridgedFoodItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbridgedFoodItem input)
        {
            if (input == null)
                return false;

            return 
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
                    this.FdcId == input.FdcId ||
                    (this.FdcId != null &&
                    this.FdcId.Equals(input.FdcId))
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
                    this.NdbNumber == input.NdbNumber ||
                    (this.NdbNumber != null &&
                    this.NdbNumber.Equals(input.NdbNumber))
                ) && 
                (
                    this.FoodCode == input.FoodCode ||
                    (this.FoodCode != null &&
                    this.FoodCode.Equals(input.FoodCode))
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
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FdcId != null)
                    hashCode = hashCode * 59 + this.FdcId.GetHashCode();
                if (this.FoodNutrients != null)
                    hashCode = hashCode * 59 + this.FoodNutrients.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.BrandOwner != null)
                    hashCode = hashCode * 59 + this.BrandOwner.GetHashCode();
                if (this.GtinUpc != null)
                    hashCode = hashCode * 59 + this.GtinUpc.GetHashCode();
                if (this.NdbNumber != null)
                    hashCode = hashCode * 59 + this.NdbNumber.GetHashCode();
                if (this.FoodCode != null)
                    hashCode = hashCode * 59 + this.FoodCode.GetHashCode();
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
