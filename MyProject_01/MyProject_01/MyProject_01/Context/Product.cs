//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProject_01.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string ShortDes { get; set; }
        public string FullDes { get; set; }
        public Nullable<double> Price { get; set; }

        [NotMapped]
        public System.Web.HttpPostedFileBase ImageUpLoad1 { get; set; }

    }
}
