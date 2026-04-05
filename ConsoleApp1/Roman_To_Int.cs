     int RomanToInt(string s) {
        var romanDic = new Dictionary<string, int>(){
            {"CD",400},
            {"CM",900},
            {"IV",4},
            {"IX",9},
            {"XL",40},
            {"XC",90},
           {"I",1},
           {"V",5},
           {"X",10},
           {"L", 50},
           {"C", 100},
           {"D", 500},
           {"M",1000}
        };

        var sum = 0;
        var counter = 0;
       while(counter < s.Length ){
            if(counter + 1< s.Length && romanDic.ContainsKey(s[counter].ToString()+s[counter+1].ToString())){
                Console.WriteLine($"{s[counter].ToString()+s[counter+1].ToString()} + {counter}");
                sum = sum + romanDic[s[counter].ToString()+s[counter+1].ToString()];
                counter += 2;
            }
           else if(romanDic.ContainsKey(s[counter].ToString())){
                sum = sum + romanDic[s[counter].ToString()];
                counter += 1;

            }
       }
         return sum;
    }


var data = RomanToInt("MCMXCIV");

Console.WriteLine(data);