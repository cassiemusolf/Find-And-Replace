using Xunit;
using FindAndReplaceApp.Objects;

namespace FindAndReplaceApp
{

  public class FindAndReplaceTest
  {

    [Fact]
    public void Test_SeeIfWordMatches_Word()
    {
      //Arrange
      string _originalString = "hello";
      string _wordToReplace = "hello";
      string _replaceWith = "goodbye";
      //Act
      Find obj = new Find(_originalString, _wordToReplace, _replaceWith);
      // string output = obj.FindAndReplace("hello world", "hello", "goodbye");
      //Assert
      Assert.Equal(true, obj.seeIfWordMatches());
    }

    [Fact]
    public void FindAndReplace_ReplaceOneWord_Word()
    {
      //Arrange
      string originalString = "hello";
      string wordToReplace = "hello";
      string replaceWith = "goodbye";
      //Act
      Find obj = new Find(originalString, wordToReplace, replaceWith);
      // string output = obj.FindAndReplace("hello world", "hello", "goodbye");
      //Assert
      Assert.Equal("goodbye", obj.FindAndReplace());
    }

    [Fact]
    public void FindAndReplace_ReplaceOneWordInSentence_Word()
    {
      //Arrange
      string originalString = "hello world";
      string wordToReplace = "hello";
      string replaceWith = "goodbye";
      //Act
      Find obj = new Find(originalString, wordToReplace, replaceWith);
      // string output = obj.FindAndReplace("hello world", "hello", "goodbye");
      //Assert
      Assert.Equal("goodbye world", obj.FindAndReplace());
    }

  }
}
