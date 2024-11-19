//using AutoMapper;
//using IMS.Application.Interfaces;
//using IMS.Application.Interfaces.IEntitiesRepo;
//using IMS.Domain.Entites;
//using IMS.Persistance.Repositories.EntitiesRepo;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Moq;
//using Org.BouncyCastle.Utilities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static IMS.Application.Features.Product.ProductManagementModel;

//namespace IMS.Persistance.Tests
//{
//    public class ProductRepoTests
//    {
//        private readonly Mock<ApplicationDbContext> _mockDbContext;
//        private readonly Mock<IMapper> _mockMapper;
//        private readonly Mock<IBaseRepo<Product>> _mockBaseRepo;
//        private readonly Mock<DbSet<Product>> _mockSet;

//        //private readonly ProductRepo _productRepo;

//        public ProductRepoTests()
//        {
//            _mockDbContext = new Mock<ApplicationDbContext>();
//            _mockMapper = new Mock<IMapper>();
//            _mockBaseRepo = new Mock<IBaseRepo<Product>>();
//            _mockSet = new Mock<DbSet<Product>>();

//            _mockDbContext.Setup(p => p.products).Returns(_mockSet.Object);
//            // Initialize the ProductRepo with mocked dependencies
//            // _productRepo = new ProductRepo(_mockDbContext.Object, _mockMapper.Object, _mockBaseRepo.Object);
//        }

//        //[Fact]
//        //public async Task GetAllProductsAsync_ShouldReturnProductsForUser()
//        //{
//        //    // Arrange
//        //    var userId = "test-user-id";
//        //    var Products = new List<Product>
//        //    {
//        //    new Product { ProductId = 1, ProductName = "Test Product 1", Price = 10, ApplicationUserId = userId },
//        //    new Product { ProductId = 2, ProductName = "Test Product 2", Price = 20, ApplicationUserId = userId }
//        //    }.AsQueryable();

//        //    var mockProductsDbSet = Products;
//        //    _mockDbContext.Setup(db => db.products).Returns(mockProductsDbSet.Object);

//        //    // Act
//        //    var result = await _productRepo.GetAllProductsAsync(userId);

//        //    // Assert
//        //    Assert.NotNull(result);
//        //    Assert.Equal(2, result.Count());
//        //}
       
//        [Fact]
//        public async Task AddProductAsync_ShouldAddProductAndReturnResponse()
//        {
//            // Arrange
//            var fileMock = new Mock<IFormFile>();
//            fileMock.Setup(f => f.FileName).Returns("fkklm.png");
//            fileMock.Setup(f => f.Length).Returns("sample image content".Length);
//            fileMock.Setup(f => f.ContentType).Returns("image/png");
//            var addProductRequest = new AddProductRequest
//            {
//                Photo = fileMock.Object,
//                LowStock = 5,
//                SubCategoryId = 1,
//                SupplierId = 1,
//                ProductName = "New Product",
//                Price = 30
//            };
//            var product = new Product { ProductId = 1, LowStock = 5, SubCategoryId = 1, SupplierId = 1, ProductName = "New Product", Price = 30, ApplicationUserId = "jfkcjhsdk-dcjasj-dakjcj" };

//            _mockMapper.Setup(m => m.Map<Product>(addProductRequest)).Returns(product);
//            _mockBaseRepo.Setup(repo => repo.AddAsync(It.IsAny<Product>())).ReturnsAsync(new GeneralResponse { Done = true });


//            // Act
//            var _productRepo = new ProductRepo(null, _mockMapper.Object, _mockBaseRepo.Object);
//            var result = await _productRepo.AddProductAsync(addProductRequest);

//            // Assert
//            Assert.True(result.Done);
//            //_mockBaseRepo.Verify(repo => repo.AddAsync(It.IsAny<Product>()), Moq.Times.Once);
//        }

//        [Fact]
//        public async Task GetProductByIdAsync_ShouldReturnProductDetails()
//        {
//            // Arrange
//            var productId = 1;
//            var product = new Product
//            {
//                Image = "lfkgj.png",
//                ApplicationUserId ="lkjgdk41fdl",
//                LowStock = 5,
//                SubCategoryId = 1,
//                SupplierId = 1,
//                ProductName = "New Product",
//                Price = 30
//            };

//            _mockSet.As(Product).Setup(m => m.Provider).Returns(product.Provider);

//            // Act
//            var result = await _productRepo.GetProductByIdAsync(productId);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(productId, result.ProductId);
//        }

//        //[Fact]
//        //public async Task UpdateProductAsync_ShouldUpdateProductAndReturnResponse()
//        //{
//        //    // Arrange
//        //    var updateRequest = new UpdateProductRequest
//        //    {
//        //        ProductId = 1,
//        //        ProductName = "Updated Product",
//        //        Price = 40,
//        //        LowStock = 5
//        //    };

//        //    _mockBaseRepo.Setup(repo => repo.UpdateAsync(It.IsAny<Product>())).ReturnsAsync(new GeneralResponse { Success = true });

//        //    // Act
//        //    var result = await _productRepo.UpdateProductAsync(updateRequest);

//        //    // Assert
//        //    Assert.True(result.Success);
//        //    _mockBaseRepo.Verify(repo => repo.UpdateAsync(It.IsAny<Product>()), Times.Once);
//        //}

//        //[Fact]
//        //public async Task DeleteProductAsync_ShouldDeleteProductAndReturnResponse()
//        //{
//        //    // Arrange
//        //    var productId = 1;
//        //    _mockBaseRepo.Setup(repo => repo.DeleteAsync(productId)).ReturnsAsync(new GeneralResponse { Success = true });

//        //    // Act
//        //    var result = await _productRepo.DeleteProductAsync(productId);

//        //    // Assert
//        //    Assert.True(result.Success);
//        //    _mockBaseRepo.Verify(repo => repo.DeleteAsync(productId), Times.Once);
//        //}
//        [Fact]
//        public void Method_Scenario_Outcome()
//        {
//            // arrange    is input

//            // act        is operations

//            // Assert     is  Equalation

//        }
//    }
//}
