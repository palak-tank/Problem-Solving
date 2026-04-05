//3. Remove Duplicates from List

// Input: [1,2,2,3,4,4,5]
// Output: [1,2,3,4,5]


int[] RemoveDuplicates(int[] numbers)
{
    //Solution 1
    // var hashSetNumbers = new HashSet<int>();

    // for(int i=0; i< numbers.Length; i++)
    // {
    //     hashSetNumbers.Add(numbers[i]);
    // }
    // return hashSetNumbers.ToArray();

    //Solution 2
    return numbers.Distinct().ToArray();
}

var data = RemoveDuplicates( [1,2,2,3,4,4,5]);
Console.WriteLine(string.Join(", ", data));