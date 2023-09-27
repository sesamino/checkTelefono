using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        int i;
        string num;

        for(i=0;i<input.Length;i++){
            num = input[i];
            if(num[0]=='+' && num[1]=='3' && num[2]=='9'){
                return num;
            };
         if(num[0]=='0' && num[1]=='0' && num[2]=='3' && num[1]=='9'){
                return num;
            };
         if(num[0]=='3' ){
                return num;
            };

        };
            
        return "";
    }
}