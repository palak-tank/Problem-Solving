//2. Reverse Words in a Sentence

// Input: "hello world from csharp"
// Output: "csharp from world hello"

string ReverseMe(string setense)
{
    //Solution 1
//     var words = setense.Split(" ");

//     for(int i = 0; i< words.Length/2; i++)
//     {
//         var temp =words[i];
//         words[i] = words[words.Length-i-1];
//         words[words.Length-i-1] = temp;

//     }

//    // words.Join(" ");
//     return string.Join(" ",words);

    //Solution 2

    var data = string.Join(" ", setense.Split(" ").Reverse());
    return data;
}

var data = ReverseMe("hello world from csharp");
Console.WriteLine(data);