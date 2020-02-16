// Author: Alexander Karagulamos
//   Date: February 16, 2020
// Remark: Given a list of words and a pattern, WordFinder is able to
//         efficiently generate all words in the pattern. Time complexity
//         of the Find() operation is O(M * M), where M is the size of the 
//         pattern. Note that the algorithm does not handle duplicates, but
//         can be modified to do a check when a word is found. We only have 
//         to add a 'Processed' field to the Node class and set it to true 
//         when we find a word. However, an unobtrusive approach will be to
//         store the node where a word is found (i.e. where IsWord == true) 
//         in a hash table to check if we have processed that node already.

using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var words = new[]{ "we", "wet", "enter", "enterance", "ran", "an", "rat"};
    var finder = new WordFinder(words);

    var pattern = "wenterancewet";    
    foreach(var word in finder.Find(pattern))
      Console.WriteLine(word);
  }
}