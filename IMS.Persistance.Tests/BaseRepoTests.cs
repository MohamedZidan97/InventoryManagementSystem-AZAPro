using IMS.Domain.Entites;
using IMS.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Persistance.Tests
{
    public class BaseRepoTests
    {

        private readonly BaseRepo<Supplier> _baseRepo;
       
        private readonly ApplicationDbContext _inMemoryDb;

        public BaseRepoTests(ApplicationDbContext inMemoryDb)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

            _inMemoryDb = new ApplicationDbContext(options);

            // Initialize BaseRepo with the in-memory context
            _baseRepo = new BaseRepo<Supplier>(_inMemoryDb);
        }

        [Fact]
        public async Task AddAsync_ShouldAddEntityToDbSet_ReturnDone()
        {
            // Arrange
            var supplier = new Supplier { SupplierName = "Test Supplier", ContactInfo = "123456" };

            // Act
            var result = await _baseRepo.AddAsync(supplier);

            // Assert
           
            Assert.True(result.Done);
            Assert.NotNull(await _inMemoryDb.Set<Supplier>().FirstOrDefaultAsync(s => s.SupplierName == "Test Supplier"));

        }
    }
}
