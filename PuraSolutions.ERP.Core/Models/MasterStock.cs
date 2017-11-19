using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class MasterStock
	{
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public float ItemRate { get; set; }
        public int GodownTypeId { get; set; }
        public string BatchNo { get; set; }
        public DateTime ExpiryDate { get; set; }        
	}
}

