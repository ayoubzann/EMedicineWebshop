using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMedicine.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Funds { get; set; } = 0;


        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set; }


        [Column(TypeName = "int")]
        public int Status { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }


    }
}
