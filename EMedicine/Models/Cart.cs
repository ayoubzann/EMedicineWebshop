using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMedicine.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("UserId")]
        public Users User { get; set; }
        public int UserId { get; set; }


        [ForeignKey("MedicineId")]
        public Medicines Medicine { get; set; }
        public int MedicineId { get; set; }



        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }


        [Column(TypeName = "int")]
        public int Quantity { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }





    }
}
