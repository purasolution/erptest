using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class PurchaseSaleOrder
	{
        public int OrderId { get; set; }
        public int OrderTypeId { get; set; }
        public string RegNo { get; set; }
        public DateTime OrderDate { get; set; }
        public int SupplierCustomerId { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public float ProductRate { get; set; }
        public float TotalAmount { get; set; }
        public float GrossAmount { get; set; }
	}
}

