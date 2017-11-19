using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class CreditCashTax
	{
        public int PurchaseSaleId { get; set; }
        public int TaxTypeId { get; set; }
        public string Operation { get; set; }
        public float Percentage { get; set; }
        public float TaxAmount { get; set; }
        
	}
}

