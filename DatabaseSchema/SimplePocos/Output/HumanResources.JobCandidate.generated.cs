﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by dotnet-codegencs tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MyNamespace
{
    [Table("JobCandidate", Schema = "HumanResources")]
    public partial class JobCandidate
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobCandidateId { get; set; }

        public int? BusinessEntityId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Resume { get; set; }
        #endregion Members

        #region Equals/GetHashCode
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            JobCandidate other = obj as JobCandidate;
            if (other == null) return false;

            if (BusinessEntityId != other.BusinessEntityId)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Resume != other.Resume)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BusinessEntityId == null ? 0 : BusinessEntityId.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Resume == null ? 0 : Resume.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(JobCandidate left, JobCandidate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JobCandidate left, JobCandidate right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
