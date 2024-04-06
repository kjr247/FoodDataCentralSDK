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
    /// SampleFoodItem
    /// </summary>
    [DataContract]
        public partial class SampleFoodItem :  IEquatable<SampleFoodItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleFoodItem" /> class.
        /// </summary>
        /// <param name="fdcId">fdcId (required).</param>
        /// <param name="datatype">datatype.</param>
        /// <param name="description">description (required).</param>
        /// <param name="foodClass">foodClass.</param>
        /// <param name="publicationDate">publicationDate.</param>
        /// <param name="foodAttributes">foodAttributes.</param>
        public SampleFoodItem(int? fdcId = default(int?), string datatype = default(string), string description = default(string), string foodClass = default(string), string publicationDate = default(string), List<FoodCategory> foodAttributes = default(List<FoodCategory>))
        {
            // to ensure "fdcId" is required (not null)
            if (fdcId == null)
            {
                throw new InvalidDataException("fdcId is a required property for SampleFoodItem and cannot be null");
            }
            else
            {
                this.FdcId = fdcId;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for SampleFoodItem and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.Datatype = datatype;
            this.FoodClass = foodClass;
            this.PublicationDate = publicationDate;
            this.FoodAttributes = foodAttributes;
        }
        
        /// <summary>
        /// Gets or Sets FdcId
        /// </summary>
        [DataMember(Name="fdcId", EmitDefaultValue=false)]
        public int? FdcId { get; set; }

        /// <summary>
        /// Gets or Sets Datatype
        /// </summary>
        [DataMember(Name="datatype", EmitDefaultValue=false)]
        public string Datatype { get; set; }

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
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets FoodAttributes
        /// </summary>
        [DataMember(Name="foodAttributes", EmitDefaultValue=false)]
        public List<FoodCategory> FoodAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleFoodItem {\n");
            sb.Append("  FdcId: ").Append(FdcId).Append("\n");
            sb.Append("  Datatype: ").Append(Datatype).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FoodClass: ").Append(FoodClass).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
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
            return this.Equals(input as SampleFoodItem);
        }

        /// <summary>
        /// Returns true if SampleFoodItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleFoodItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleFoodItem input)
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
                    this.Datatype == input.Datatype ||
                    (this.Datatype != null &&
                    this.Datatype.Equals(input.Datatype))
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
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
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
                if (this.Datatype != null)
                    hashCode = hashCode * 59 + this.Datatype.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FoodClass != null)
                    hashCode = hashCode * 59 + this.FoodClass.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
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