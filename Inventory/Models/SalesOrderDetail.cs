using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class SalesOrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int SoId { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public int TotalQty { get; set; }

        [ForeignKey("SoId")]
        public SalesOrder SalesOrder { get; set; }

        [ForeignKey("Item")]
        public Item Item { get; set; }
    }
}
