using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{
    public class CreditCashPurchase
    {
        public int PurchaseId { get; set; }
        public string PurchaseType { get; set; }
        public string RefNo { get; set; }
        public DateTime BillDate { get; set; }
        public int OrderId { get; set; }
        public int DeliveryChallanId { get; set; }
        public int GodownTypeId { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemId { get; set; }
        public string BatchNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public float ProductRate { get; set; }
        public float CashPaid { get; set; }
        public float RoundOfValue { get; set; }
        public float TotalAmount { get; set; }
        public float GrossAmount { get; set; }
        public int OrderTypeId { get; set; }        
	}
}

