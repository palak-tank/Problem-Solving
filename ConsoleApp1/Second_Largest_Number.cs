//5. Find Second Largest Number
// Input: [10,5,8,20,15]
// Output: 15


int FindSecondLarget(int[] numbers)
{
  int largest = int.MinValue;
  int secondLargest = int.MinValue;

  foreach(int num in numbers)
    {
        if(num > largest)
        {
            secondLargest = largest;
            largest = num;
        }

        else if(num > secondLargest && num < largest)
        {
            secondLargest = num;
        }
    }
return secondLargest;
    
}

var data = FindSecondLarget( [10,5,1,20,15,16]);

Console.WriteLine(data);