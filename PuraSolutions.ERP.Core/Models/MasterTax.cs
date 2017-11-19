using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class MasterTax
	{
        public int TaxTypeId { get; set; }
        public string TaxTypeName { get; set; }
        public float TaxPercentage { get; set; }
        
	}
}

