//1. First Non-Repeating Character
// Input:  "swiss"
// Output: 'w'

public class first_non_repeat_char
{
   public char NonRepeatC(string word)
{
    //Solution 1
    // var charArray = word.ToArray();
    // var charDic = new Dictionary<char, int>();

    // foreach(char c in charArray)
    // {
    //     if (charDic.ContainsKey(c))
    //     {
    //         charDic[c] += charDic[c];
    //     }
    //     else
    //     {
    //         charDic.Add(c, 1);
    //     }
    // }

    // var uniqueLetter = charDic.FirstOrDefault(x=>x.Value == 1);
    // return uniqueLetter.Key;

    //Solution 2
    var linq = word.GroupBy(x=>x).Where(c=>c.Count() ==1).Select(x=>x.Key).FirstOrDefault();
    return linq;
}
}


