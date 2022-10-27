using System;
using System.Linq;
class program{
    public static void Main(){
        int[] numbers={9,7,10,11,60,5,8};

        var even=
                from number in numbers
                where (number%2)==0
                select number;
        
        foreach(int i in even){
            Console.Write(i+" ");
        }
    }
}