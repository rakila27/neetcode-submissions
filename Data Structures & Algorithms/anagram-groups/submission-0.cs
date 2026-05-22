public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

foreach(var str in strs)
  {
      char[] charArray = str.ToCharArray();
      Array.Sort(charArray);
      string sortedString = new string(charArray);
      if (!result.ContainsKey(sortedString))
      {
          result[sortedString] = new List<string>();
      }
      result[sortedString].Add(str);
  }

  return result.Values.ToList<List<string>>();
    }
}
