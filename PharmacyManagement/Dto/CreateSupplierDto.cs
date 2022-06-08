using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Dto
{
    public class CreateSupplierDto
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierEmail { get; set; }
    }
}
