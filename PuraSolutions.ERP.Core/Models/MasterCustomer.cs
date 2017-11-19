using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class MasterCustomer
	{
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
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
        public int SalesmanId { get; set; }
        public long BankAccNo { get; set; }
        public string BankAccType { get; set; }
        public string Remark { get; set; }
        public float CreditLimit { get; set; }
        public int CreditLimitDays { get; set; }
        public String ContactPersonName { get; set; }
	}
}

