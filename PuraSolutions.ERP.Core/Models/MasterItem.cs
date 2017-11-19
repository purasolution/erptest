using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class MasterItem
	{
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public int CompanyId { get; set; }
        public int PackingSize { get; set; }
        public float MRP { get; set; }
        public int ReorderLevel { get; set; }
        public float CreditSaleRate { get; set; }
        public float CashSaleRate { get; set; }        
	}
}

