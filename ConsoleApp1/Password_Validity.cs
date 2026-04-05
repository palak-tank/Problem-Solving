 static int minimumNumber(int n, string password)
    {

        if(n < 6)
    {
        return 6-n;
    }
    // Return the minimum number of characters to make the password strong
        var numbers = "0123456789";
        var lower_case = "abcdefghijklmnopqrstuvwxyz";
        var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var special_characters = "!@#$%^&*()-+";
        var validity =0;
        var numberCheck = numbers.Intersect(password);
        var upper_caseCheck = upper_case.Intersect(password);
        var lower_caseCheck = lower_case.Intersect(password);
        var special_charactersCheck = special_characters.Intersect(password);

    if (numberCheck.Count() == 0)
    {
        validity =validity+1;
    }
    if (upper_caseCheck.Count() == 0)
    {
       validity= validity+1;
    }
    if (lower_caseCheck.Count() == 0)
    {
       validity= validity+1;
    }
    if (special_charactersCheck.Count() == 0)
    {
        validity=validity+1;
    }
    return validity;

    }


var data = minimumNumber(3, "Ah1");
Console.WriteLine(data);