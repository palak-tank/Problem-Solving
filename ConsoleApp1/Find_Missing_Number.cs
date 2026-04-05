//3. Find Missing Number

//Input: [1,2,4,5]
//Output: 3


int MissingNumber(int[] numbers)
{
    var total = numbers.Length+1;

    var expectedSum = total *( total +1)/2;
    var currentSum = 0;
    for(int i=0; i< total-1 ; i++)
    {
       currentSum += numbers[i] ;
       
    }
     return expectedSum -currentSum;
}

Console.WriteLine(MissingNumber([1,2,5,4]));