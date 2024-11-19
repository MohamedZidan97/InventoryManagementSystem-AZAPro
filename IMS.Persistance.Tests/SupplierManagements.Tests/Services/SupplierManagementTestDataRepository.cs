using IMS.Application.Features.Product;
using IMS.Application.Interfaces;
using IMS.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IMS.Application.Features.Product.ProductManagementModel;

namespace IMS.Persistance.Tests.SupplierManagements.Tests.Services
{
    public class SupplierManagementTestDataRepository : IBaseRepo<Supplier>
    {
        private IEnumerable<Supplier> _suppliers;
        public SupplierManagementTestDataRepository() {

            // mimic expensive creation process
            Thread.Sleep(3000);

            // Initialize with dummy data
            _suppliers = new List<Supplier>
        {
            new Supplier
            {
                SupplierId = 1,
                SupplierName = "Supplier 1",
                ContactInfo = "ContactInfo 1"
            },
            new Supplier
            {
                SupplierId = 2,
                SupplierName = "Supplier 2",
                ContactInfo = "ContactInfo 2"
            },
            new Supplier
            {
                SupplierId = 3,
                SupplierName = "Supplier 3",
                ContactInfo = "ContactInfo 3"
            }
        };

        }


        public Task<GeneralResponse> AddAsync(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplier>> GetAllAsync()
        {

            return Task.FromResult(_suppliers.AsEnumerable());
        }

        public Task<Supplier> GetByIdAsync(int id)
        {
            var supplier = _suppliers.FirstOrDefault(s => s.SupplierId == id);
            return Task.FromResult(supplier);
        }

        public Task<GeneralResponse> UpdateAsync(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
