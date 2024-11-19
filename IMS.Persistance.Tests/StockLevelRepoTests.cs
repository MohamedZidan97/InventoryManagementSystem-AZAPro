//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Moq;
//using Xunit;
//using IMS.Persistance.Repositories.EntitiesRepo;
//using IMS.Domain.Entites;
//using Microsoft.AspNetCore.Identity;
//using AutoMapper;
//using IMS.Application.Interfaces;
//using IMS.Application.Interfaces.IEntitiesRepo;
//using Microsoft.EntityFrameworkCore;
//using System;
//using _VC.Application.Contents.MailServicesIntr;
//using IMS.Persistance;


//namespace IMS.Persistance.Tests
//{
//    public class StockLevelRepoTests
//    {
//        private readonly Mock<UserManager<ApplicationUser>> _mockUserManager;
//        private readonly Mock<IEmailServices> _mockEmailServices;
//        private readonly Mock<IProductRepo> _mockProductRepo;
//       // private readonly ApplicationDbContext _mockContext;
//        private readonly Mock<IMapper> _mockMapper;
//        private readonly Mock<IBaseRepo<StockLevel>> _mockBaseRepo;
//        private readonly StockLevelRepo _stockLevelRepo;
//        private readonly InMemoryDbContext context;

//        public StockLevelRepoTests(InMemoryDbContext context)
//        {
//            _mockUserManager = new Mock<UserManager<ApplicationUser>>(
//                new Mock<IUserStore<ApplicationUser>>().Object, null, null, null, null, null, null, null, null
//            );
//            _mockEmailServices = new Mock<IEmailServices>();
//            _mockProductRepo = new Mock<IProductRepo>();
//           // _mockContext = new ApplicationDbContext();
//            _mockMapper = new Mock<IMapper>();
//            _mockBaseRepo = new Mock<IBaseRepo<StockLevel>>();
//            this.context = context;

//            _stockLevelRepo = new StockLevelRepo(
//                _mockUserManager.Object, _mockEmailServices.Object, _mockProductRepo.Object,
//                context, _mockMapper.Object, _mockBaseRepo.Object
//            );
//        }

//        // Test methods will go here


//        [Fact]
//        public async Task GetCurrentStockAsync_ShouldReturnCorrectStockLevel()
//        {
//            // Arrange
//            int productId = 1;
//            var stockLevels = new List<StockLevel>
//    {
//        new StockLevel { ProductId = productId, Quantity = 10, Sell = false },
//        new StockLevel { ProductId = productId, Quantity = 5, Sell = true }
//    };

//            _mockBaseRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(stockLevels);

//            // Act
//            var result = await _stockLevelRepo.GetCurrentStockAsync(productId);

//            // Assert
//            Assert.Equal(5, result); // Expected stock: 10 (buy) - 5 (sell) = 5
//        }

//    }
//}