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
using System.Collections.Generic;
using System.Text;

public class WordFinder
{
  private readonly Node _root;

  public WordFinder(string[] words)
  {
    _root = new Node();

    foreach(var word in words)
      Add(word);
  }

  public IEnumerable<string> Find(string pattern)
  {
    var word = new StringBuilder();

    for(var i = 0; i < pattern.Length; i++)
    {
      var current = _root;
    
      for(var pos = i; pos < pattern.Length; pos++)
      {
        current = current.Children[IndexOf(pattern[pos])];

        if(current == default(Node))
          break;

        word.Append(pattern[pos]);

        if(current.IsWord)
          yield return word.ToString();
      }        

      word.Clear();
    }
  }

  private void Add(string word)
  {
    var current = _root;

    foreach(var letter in word)
    {
      var index = IndexOf(letter);

      if(current.Children[index] == default(Node))
        current.Children[index] = new Node();

      current = current.Children[index];
    }

    current.IsWord = true;
  }

  private static int IndexOf(char letter) => letter - 'a';

  private class Node
  {
    public const int AlphabetSize = 26;      
    public Node[] Children { get; set; } = new Node[AlphabetSize];
    public bool IsWord { get; set; }
  }
}