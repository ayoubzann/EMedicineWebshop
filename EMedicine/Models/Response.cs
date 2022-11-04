using System.ComponentModel.DataAnnotations.Schema;

namespace EMedicine.Models
{
    public class Response
    {

        [Column(TypeName = "int")]
        public int StatusCode { get; set; }


        [Column(TypeName = "nvarchar(1000)")]
        public string StatusMessage { get; set; }


        public ICollection<Users> listUsers { get; set; }
        public Users user { get; set; }


        public ICollection<Medicines> listMedicines { get; set; }
        public Medicines Medicine { get; set; }

        public ICollection<Cart> listCart { get; set; }

        public ICollection<Orders> listOrders { get; set; }
        public Orders Orders { get; set; }

        public ICollection<OrderItems> listItems { get; set; }
        public OrderItems OrderItems { get; set; }

    }
}
