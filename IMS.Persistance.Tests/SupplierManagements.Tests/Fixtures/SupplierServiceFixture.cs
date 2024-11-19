using AutoMapper;
using IMS.Application.Interfaces;
using IMS.Domain.Entites;
using IMS.Persistance.Repositories;
using IMS.Persistance.Repositories.EntitiesRepo;
using IMS.Persistance.Tests.SupplierManagements.Tests.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Persistance.Tests.SupplierManagements.Tests.Fixtures
{
    public class SupplierServiceFixture : IDisposable
    {
        public IBaseRepo<Supplier> SupplierManagementTestDataRepository
        ;
        public SupplierRepo SupplierRepo;

        public IBaseRepo<userSupplier> userSupRepo; 

       private readonly Mock<IMapper> _mockMapper;
        private readonly ApplicationDbContext context;

        public SupplierServiceFixture(ApplicationDbContext context)
        {
            SupplierManagementTestDataRepository =
                new SupplierManagementTestDataRepository();
                     _mockMapper = new Mock<IMapper>();
            userSupRepo = new BaseRepo<userSupplier>(context);

            SupplierRepo = new SupplierRepo(null,
                 null, SupplierManagementTestDataRepository, null

                  );
            this.context = context;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
