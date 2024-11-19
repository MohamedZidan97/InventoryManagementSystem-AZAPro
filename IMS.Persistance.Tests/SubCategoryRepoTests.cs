using IMS.Application.Interfaces;
using IMS.Domain.Entites;
using IMS.Persistance.Repositories.EntitiesRepo;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Persistance.Tests
{
    public class SubCategoryRepoTests
    {
        private readonly Mock<IBaseRepo<SubCategory>> _mockBaseRepo;
        private readonly SubCategoryRepo _subCategoryRepo;

        public SubCategoryRepoTests()
        {
            _mockBaseRepo = new Mock<IBaseRepo<SubCategory>>();
            _subCategoryRepo = new SubCategoryRepo(_mockBaseRepo.Object);
        }

        [Fact]
        public async Task GetSubCategoriesRepo_ShouldReturnSubCategories()
        {
            // Arrange
            var subCategories = new List<SubCategory>
                {
            new SubCategory { SubCategoryId = 1, Name = "Electronics" },
            new SubCategory { SubCategoryId = 2, Name = "Clothing" }
            };

            // إعداد النتيجة المتوقعة من `GetAllAsync`
            _mockBaseRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(subCategories);

            // Act
            var result = await _subCategoryRepo.GetSubCategoriesRepo();


            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, r => r.SubCategoryName == "Electronics" && r.SubCategoryId == 1);
            Assert.Contains(result, r => r.SubCategoryName == "Clothing" && r.SubCategoryId == 2);
        }
    }
}
