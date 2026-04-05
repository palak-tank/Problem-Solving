//1. Move All Zeros to End

//Input:  [1,0,2,0,3,4]
//Output: [1,2,3,4,0,0]

int[] MoveZeroToEnd(int[] numbers)
{
    var updatedNumber = new List<int>();
    var countZero = 0;

    for(int i=0; i<numbers.Length/2 ; i++)
    {
        if(numbers[i]== 0)
        {
            countZero++;
        }
        else
        {
            updatedNumber.Add(numbers[i]);

        }
         if(numbers[numbers.Length -i-1] == 0)
        {
            countZero++;
        }
        else
        {
            updatedNumber.Add(numbers[numbers.Length -i-1]);
        }
    }

    for(int j =0; j<countZero; j++)
    {
        updatedNumber.Add(0);
    }
    return updatedNumber.ToArray();
}

var data = MoveZeroToEnd([1,0,2,0,3,4]);

Console.WriteLine(string.Join(", ", data));