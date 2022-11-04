using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMedicine.Models
{
    public class Medicines
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string Manufacturer { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }


        [Column(TypeName = "int")]
        public int Quantity { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime ExpDate { get; set; } 


        [Column(TypeName = "nvarchar(250)")]
        public string ImageUrl { get; set; }


        [Column(TypeName = "int")]
        public int Status { get; set; }


        [Column(TypeName = "nvarchar(250)")]
        public string Type { get; set; }

    }
}
