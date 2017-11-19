using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class Bank
	{
        public int BankId { get; set; }
        public int Under { get; set; }
        public int AreaId { get; set; }
        public float OpeningBalance { get; set; }
        public string CreditType { get; set; }
        public long BankAccNo { get; set; }
        public string BankAccType { get; set; }
	}
}

