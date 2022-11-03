using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMedicine.Models
{
    public class Orders
    {
        [Key]   
        public int Id { get; set; }


        [ForeignKey("UserId")]
        public Users User { get; set; }
        public int UserId { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string OrderNo { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotal { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string OrderStatus { get; set; }


    }
}
