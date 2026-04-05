//4. Count Occurrences of Characters

// Input: "hello"
// Output:
// h:1
// e:1
// l:2
// o:1



Dictionary<char, int> GetOccurence(string word)
{
    //Solution 1
    // var countOccurenece = new Dictionary<char, int>();
    // foreach(var c in word)
    // {
    //     if (countOccurenece.ContainsKey(c))
    //     {
    //         ++countOccurenece[c];
    //     }
    //     else
    //     {
    //         countOccurenece.Add(c, 1);
    //     }
    // }
    // return countOccurenece;

    //Solution 2

    var data = word.GroupBy(x=>x).ToDictionary(x=>x.Key, x=>x.Count());
    return data;

}

var data = GetOccurence("helpmeplease");

foreach(var item in data)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}