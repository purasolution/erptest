using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraSolutions.ERP.Core.Models
{

    public class Employee
	{
        public int EmployeeId { get; set; }
        public int Under { get; set; }
        public int AreaId { get; set; }
        public float OpeningBalance { get; set; }
        public string CreditType { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public long BankAccNo { get; set; }
        public string BankAccType { get; set; }
        public string Remark { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public float Payment { get; set; }
        public string Qualification { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
        public string Photo { get; set; }        
	}
}

