using SmartStock.BLL.Mappers;
using Xunit;

namespace SmartStock.Tests.BllTests
{
    public class Source
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }
    }

    public class Destination
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }
    }

    public class MapperTests
    {
        [Fact]
        public void TestMap_ValidSource_ReturnValidDestination()
        {
            // Arrange
            var source = new Source
            {
                Id = 1,
                Name = "John",
                Address = "1234 Main st.",
            };

            // Act
            var result = Mapper<Source, Destination>.Map(source);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Destination>(result);
            Assert.Equal(source.Id, result.Id);
            Assert.Equal(source.Name, result.Name);
            Assert.Equal(source.Address, result.Address);
        }

        [Fact]
        public void TestMap_InvalidDestinationProperty_DoesNotCopy()
        {
            // Arrange
            var source = new Source
            {
                Id = 1,
                Name = "Test",
                Address = "1234 Main St.",
            };

            // Act
            var result = Mapper<Source, Destination>.Map(source);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Destination>(result);
            Assert.Null(result.GetType().GetProperty("InvalidProperty"));
        }
    }
}