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
    [Table("ShipMethod", Schema = "Purchasing")]
    public partial class ShipMethod
    {
        #region Members
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipMethodId { get; set; }

        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
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
            ShipMethod other = obj as ShipMethod;
            if (other == null) return false;

            if (ModifiedDate != other.ModifiedDate)
                return false;
            if (Name != other.Name)
                return false;
            if (Rowguid != other.Rowguid)
                return false;
            if (ShipBase != other.ShipBase)
                return false;
            if (ShipRate != other.ShipRate)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ModifiedDate == default(DateTime) ? 0 : ModifiedDate.GetHashCode());
                hash = hash * 23 + (Name == null ? 0 : Name.GetHashCode());
                hash = hash * 23 + (Rowguid == default(Guid) ? 0 : Rowguid.GetHashCode());
                hash = hash * 23 + (ShipBase == default(decimal) ? 0 : ShipBase.GetHashCode());
                hash = hash * 23 + (ShipRate == default(decimal) ? 0 : ShipRate.GetHashCode());
                return hash;
            }
        }
        public static bool operator ==(ShipMethod left, ShipMethod right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ShipMethod left, ShipMethod right)
        {
            return !Equals(left, right);
        }
        #endregion Equals/GetHashCode
    }
}
