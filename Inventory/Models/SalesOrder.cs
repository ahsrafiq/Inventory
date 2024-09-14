using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class SalesOrder
    {
        [Key]
        public int SoId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }

        ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
