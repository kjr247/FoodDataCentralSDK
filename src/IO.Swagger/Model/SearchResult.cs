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
    /// SearchResult
    /// </summary>
    [DataContract]
        public partial class SearchResult :  IEquatable<SearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="foodSearchCriteria">foodSearchCriteria.</param>
        /// <param name="totalHits">The total number of foods found matching the search criteria..</param>
        /// <param name="currentPage">The current page of results being returned..</param>
        /// <param name="totalPages">The total number of pages found matching the search criteria..</param>
        /// <param name="foods">The list of foods found matching the search criteria. See Food Fields below..</param>
        public SearchResult(FoodSearchCriteria foodSearchCriteria = default(FoodSearchCriteria), int? totalHits = default(int?), int? currentPage = default(int?), int? totalPages = default(int?), List<SearchResultFood> foods = default(List<SearchResultFood>))
        {
            this.FoodSearchCriteria = foodSearchCriteria;
            this.TotalHits = totalHits;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.Foods = foods;
        }
        
        /// <summary>
        /// Gets or Sets FoodSearchCriteria
        /// </summary>
        [DataMember(Name="foodSearchCriteria", EmitDefaultValue=false)]
        public FoodSearchCriteria FoodSearchCriteria { get; set; }

        /// <summary>
        /// The total number of foods found matching the search criteria.
        /// </summary>
        /// <value>The total number of foods found matching the search criteria.</value>
        [DataMember(Name="totalHits", EmitDefaultValue=false)]
        public int? TotalHits { get; set; }

        /// <summary>
        /// The current page of results being returned.
        /// </summary>
        /// <value>The current page of results being returned.</value>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages found matching the search criteria.
        /// </summary>
        /// <value>The total number of pages found matching the search criteria.</value>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// The list of foods found matching the search criteria. See Food Fields below.
        /// </summary>
        /// <value>The list of foods found matching the search criteria. See Food Fields below.</value>
        [DataMember(Name="foods", EmitDefaultValue=false)]
        public List<SearchResultFood> Foods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  FoodSearchCriteria: ").Append(FoodSearchCriteria).Append("\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Foods: ").Append(Foods).Append("\n");
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
            return this.Equals(input as SearchResult);
        }

        /// <summary>
        /// Returns true if SearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FoodSearchCriteria == input.FoodSearchCriteria ||
                    (this.FoodSearchCriteria != null &&
                    this.FoodSearchCriteria.Equals(input.FoodSearchCriteria))
                ) && 
                (
                    this.TotalHits == input.TotalHits ||
                    (this.TotalHits != null &&
                    this.TotalHits.Equals(input.TotalHits))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.Foods == input.Foods ||
                    this.Foods != null &&
                    input.Foods != null &&
                    this.Foods.SequenceEqual(input.Foods)
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
                if (this.FoodSearchCriteria != null)
                    hashCode = hashCode * 59 + this.FoodSearchCriteria.GetHashCode();
                if (this.TotalHits != null)
                    hashCode = hashCode * 59 + this.TotalHits.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.Foods != null)
                    hashCode = hashCode * 59 + this.Foods.GetHashCode();
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