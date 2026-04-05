//2. Check if String is Palindrome

// Input: "madam"
// Output: true


bool IsPalindrome(string word)
{
    var isPali = false;
    for(int i=0; i<word.Length/2; i++)
    {
        if (!word[i].Equals(word[word.Length - i - 1]))
        {
            return isPali;
        }
        else if(word[i].Equals(word[word.Length - i - 1]))
        {
            isPali = true;
        }
        else
        {
            isPali = false;
        }
    }
    return isPali;
}

Console.WriteLine(IsPalindrome("huh"));