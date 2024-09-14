using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Inventory.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescrition { get; set; }
        public decimal ItemPrice { get; set; }

        public SalesOrderDetail salesOrderDetail { get; set; }
    }
}
