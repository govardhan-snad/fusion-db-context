using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class AssetTable
    {
        public int Id { get; set; }
        public int? Empid { get; set; }
        public string AssetType { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public bool Isdeleted { get; set; }

        public virtual Employeedatum Emp { get; set; }
    }
}
