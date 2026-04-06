//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     bool IsValid(string s) {
        var isValid = false;
        if(s.Length%2 != 0)
        {
            return false;
        }
        var stackParentheses = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                stackParentheses.Push(c);
            }
            else if(c == ')' || c == '}' || c == ']')
            {
                if(stackParentheses.Count > 0){
                var p = stackParentheses.Pop();
                if( (p == '(' && c == ')') ||  (p == '{' && c == '}') ||  (p == '[' && c == ']'))
                {
                    isValid = true;
                }
                else
                {
                    return  false;
                }
                }
                 else
                {
                    return false;
                }
            }
            else
        {
            return false;
        }

        }
        return isValid && (stackParentheses.Count ==0);

    }


var data = IsValid("[[[]");
Console.WriteLine(data);