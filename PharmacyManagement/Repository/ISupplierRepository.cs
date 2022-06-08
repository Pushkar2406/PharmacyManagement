using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacyManagement.Models;

namespace PharmacyManagement.Repository
{
    public interface ISupplierRepository
    {
        SupplierDetail Create(SupplierDetail supplierDetail);
        IEnumerable<SupplierDetail> GetAll();

        SupplierDetail GetSupplier(int id);
        void DeleteSupplier(int id);
        void UpdateSupplier(SupplierDetail supplierDetail);
    }
}
