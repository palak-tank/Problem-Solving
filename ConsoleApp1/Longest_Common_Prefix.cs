  string LongestCommonPrefix(string[] strs) {
    var totalWords = strs.Length;
        var wLength = strs[0].Count();
                 var commonLetters = new List<char>();

        if(wLength == 0)
    {
        return "";
    }
    else if(strs.Length == 1)
    {
        return strs[0].ToString();
    }
  
        for(int i=0; i<wLength; i++)
        {
            var initLetter = strs[0][i];
            for(int j=1; j<totalWords; j++)
            {
            if(i >= strs[j].Length || initLetter != strs[j][i])
            {
                if(commonLetters.Count >= 1)
                {
                    return new string(commonLetters.ToArray());

                }
                else
                {
                    return "";
                }

            }    
            else
            {
                if(j == totalWords-1)
                {
                    commonLetters.Add(strs[0][i]);
                }
            }
            }
            
    }
                    return new string(commonLetters.ToArray());

    }

    var commonLetters = LongestCommonPrefix(["a","b"]);
    Console.WriteLine(commonLetters);