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
    [Table("StateProvince", Schema = "Person")]
    public partial class StateProvince
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateProvinceId { get; set; }

        public string CountryRegionCode { get; set; }
        public bool IsOnlyStateProvinceFlag { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public string StateProvinceCode { get; set; }
        public int TerritoryId { get; set; }
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
            StateProvince other = obj as StateProvince;
            if (other == null) return false;

            if (CountryRegionCode != other.CountryRegionCode)
                return false;
            if (IsOnlyStateProvinceFlag != other.IsOnlyStateProvinceFlag)
                return false;
            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Name != other.Name)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            if (StateProvinceCode != other.StateProvinceCode)
                return false;
            if (TerritoryId != other.TerritoryId)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (CountryRegionCode == null ? 0 : CountryRegionCode.GetHashCode());
                hash = hash * 23 + (IsOnlyStateProvinceFlag == default(bool) ? 0 : IsOnlyStateProvinceFlag.GetHashCode());
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Name == null ? 0 : Name.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                hash = hash * 23 + (StateProvinceCode == null ? 0 : StateProvinceCode.GetHashCode());
                hash = hash * 23 + (TerritoryId == default(int) ? 0 : TerritoryId.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(StateProvince left, StateProvince right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StateProvince left, StateProvince right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
