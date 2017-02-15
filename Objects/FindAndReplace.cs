using System;
using System.Collections.Generic;

namespace FindAndReplaceApp.Objects

{
  public class Find
  {

    public string _originalString;
    public string _wordToReplace;
    public string _replaceWith;
    // public stringArray _originalString.Split(" ");

    public Find(string originalString, string wordToReplace, string replaceWith)
    {
      _originalString = originalString;
      _wordToReplace = wordToReplace;
      _replaceWith = replaceWith;
    }

    public bool seeIfWordMatches()
    {
      if(_originalString.Contains(_wordToReplace))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string FindAndReplace()
    {
      string newString = _originalString.Replace("hello", "goodbye");
      return newString;
    }
  }
}
