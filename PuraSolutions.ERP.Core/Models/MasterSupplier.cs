using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class MasterSupplier
	{
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int Under { get; set; }
        public int AreaId { get; set; }
        public float OpeningBalance { get; set; }
        public string CreditType { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string CSTRegNo { get; set; }
        public string OutOfState { get; set; }
        public string TaxFreeArea { get; set; }
        public string BankAccNo { get; set; }
        public string BankAccType { get; set; }
        public string Remark { get; set; }
        public string ContactPersonName { get; set; }
	}
}

