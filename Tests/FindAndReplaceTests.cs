using Xunit;
using FindAndReplace.Objects;

namespace FindAndReplace

{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplace_ReplaceOneWord_Word()
    {
      //Arrange
      Find obj = new Find();
      //Act
      string output = obj.FindAndReplace("hello world", "hello", "goodbye");
      //Assert
      Assert.Equal("goodbye world", output);
    }
  }
}
