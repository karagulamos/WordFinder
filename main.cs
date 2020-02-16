// Author: Alexander Karagulamos
//   Date: February 16, 2020
// Remark: Given a list of words and a pattern, WordFinder is able to
//         efficiently generate all words in the pattern. Time complexity
//         of the Find() operation is O(M * M), where M is the size of the 
//         pattern. Note that the algorithm does not handle duplicates, but
//         can be modified to do a check when we find a word. We only have 
//         to add a Found property to the Node class and set it to true when 
//         we find a word.

using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var words = new[]{ "we", "enter", "enterance", "ran", "an"};
    var finder = new WordFinder(words);

    var pattern = "wenterance";
    foreach(var word in finder.Find(pattern))
      Console.WriteLine(word);
  }
}