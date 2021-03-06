/*
 * Bank Guarantee
 *
 * This Service Domain handles the pricing and issuance of a broad range of bank guarantee instruments
 *
 * OpenAPI spec version: 10.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BankGuarantee.Transport.WebApiHttpTrigger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BankGuaranteeDefinitionandPricingTask : IEquatable<BankGuaranteeDefinitionandPricingTask>
    { 
        /// <summary>
        /// Gets or Sets Preconditions
        /// </summary>

        [DataMember(Name="Preconditions")]
        public Object Preconditions { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>

        [DataMember(Name="Schedule")]
        public Object Schedule { get; set; }

        /// <summary>
        /// Gets or Sets BusinessService
        /// </summary>

        [DataMember(Name="BusinessService")]
        public Object BusinessService { get; set; }

        /// <summary>
        /// Gets or Sets Postconditions
        /// </summary>

        [DataMember(Name="Postconditions")]
        public Object Postconditions { get; set; }

        /// <summary>
        /// Gets or Sets BankGuaranteeTransactionReference
        /// </summary>

        [DataMember(Name="BankGuaranteeTransactionReference")]
        public string BankGuaranteeTransactionReference { get; set; }

        /// <summary>
        /// Gets or Sets BankGuaranteeDefinitionandPricingTaskReference
        /// </summary>

        [DataMember(Name="BankGuaranteeDefinitionandPricingTaskReference")]
        public string BankGuaranteeDefinitionandPricingTaskReference { get; set; }

        /// <summary>
        /// Gets or Sets BankGuaranteeDefinitionandPricingTaskType
        /// </summary>

        [DataMember(Name="BankGuaranteeDefinitionandPricingTaskType")]
        public string BankGuaranteeDefinitionandPricingTaskType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankGuaranteeDefinitionandPricingTask {\n");
            sb.Append("  Preconditions: ").Append(Preconditions).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  BusinessService: ").Append(BusinessService).Append("\n");
            sb.Append("  Postconditions: ").Append(Postconditions).Append("\n");
            sb.Append("  BankGuaranteeTransactionReference: ").Append(BankGuaranteeTransactionReference).Append("\n");
            sb.Append("  BankGuaranteeDefinitionandPricingTaskReference: ").Append(BankGuaranteeDefinitionandPricingTaskReference).Append("\n");
            sb.Append("  BankGuaranteeDefinitionandPricingTaskType: ").Append(BankGuaranteeDefinitionandPricingTaskType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BankGuaranteeDefinitionandPricingTask)obj);
        }

        /// <summary>
        /// Returns true if BankGuaranteeDefinitionandPricingTask instances are equal
        /// </summary>
        /// <param name="other">Instance of BankGuaranteeDefinitionandPricingTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankGuaranteeDefinitionandPricingTask other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Preconditions == other.Preconditions ||
                    Preconditions != null &&
                    Preconditions.Equals(other.Preconditions)
                ) && 
                (
                    Schedule == other.Schedule ||
                    Schedule != null &&
                    Schedule.Equals(other.Schedule)
                ) && 
                (
                    BusinessService == other.BusinessService ||
                    BusinessService != null &&
                    BusinessService.Equals(other.BusinessService)
                ) && 
                (
                    Postconditions == other.Postconditions ||
                    Postconditions != null &&
                    Postconditions.Equals(other.Postconditions)
                ) && 
                (
                    BankGuaranteeTransactionReference == other.BankGuaranteeTransactionReference ||
                    BankGuaranteeTransactionReference != null &&
                    BankGuaranteeTransactionReference.Equals(other.BankGuaranteeTransactionReference)
                ) && 
                (
                    BankGuaranteeDefinitionandPricingTaskReference == other.BankGuaranteeDefinitionandPricingTaskReference ||
                    BankGuaranteeDefinitionandPricingTaskReference != null &&
                    BankGuaranteeDefinitionandPricingTaskReference.Equals(other.BankGuaranteeDefinitionandPricingTaskReference)
                ) && 
                (
                    BankGuaranteeDefinitionandPricingTaskType == other.BankGuaranteeDefinitionandPricingTaskType ||
                    BankGuaranteeDefinitionandPricingTaskType != null &&
                    BankGuaranteeDefinitionandPricingTaskType.Equals(other.BankGuaranteeDefinitionandPricingTaskType)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Preconditions != null)
                    hashCode = hashCode * 59 + Preconditions.GetHashCode();
                    if (Schedule != null)
                    hashCode = hashCode * 59 + Schedule.GetHashCode();
                    if (BusinessService != null)
                    hashCode = hashCode * 59 + BusinessService.GetHashCode();
                    if (Postconditions != null)
                    hashCode = hashCode * 59 + Postconditions.GetHashCode();
                    if (BankGuaranteeTransactionReference != null)
                    hashCode = hashCode * 59 + BankGuaranteeTransactionReference.GetHashCode();
                    if (BankGuaranteeDefinitionandPricingTaskReference != null)
                    hashCode = hashCode * 59 + BankGuaranteeDefinitionandPricingTaskReference.GetHashCode();
                    if (BankGuaranteeDefinitionandPricingTaskType != null)
                    hashCode = hashCode * 59 + BankGuaranteeDefinitionandPricingTaskType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankGuaranteeDefinitionandPricingTask left, BankGuaranteeDefinitionandPricingTask right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankGuaranteeDefinitionandPricingTask left, BankGuaranteeDefinitionandPricingTask right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
