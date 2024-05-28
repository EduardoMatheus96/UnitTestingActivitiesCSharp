using Xunit;

namespace Atividade09.Tests
{
    public class ItemCollectionTests
    {
        [Fact]
        public void AddItem_NullItem_ThrowsArgumentException()
        {
            // Arrange
            var collection = new ItemCollection();
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => collection.AddItem(null));
        }

        [Fact]
        public void RemoveItem_ItemNotInCollection_ThrowsArgumentException()
        {
            // Arrange
            var collection = new ItemCollection();
            var item = new Item("TestItem");
            collection.AddItem(item);
            
            // Act & Assert
            var newItem = new Item("NewItem");
            Assert.Throws<ArgumentException>(() => collection.RemoveItem(newItem));
        }

        [Fact]
        public void GetItems_ReturnsAllItems()
        {
            // Arrange
            var collection = new ItemCollection();
            var item1 = new Item("Item1");
            var item2 = new Item("Item2");
            collection.AddItem(item1);
            collection.AddItem(item2);
            
            // Act
            var items = collection.GetItems();
            
            // Assert
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
            Assert.Equal(2, items.Count);
        }
    }
}
