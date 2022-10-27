using System;
using System.Linq;
class program1{
    public static void Main(){
        int numbers1={9,7,10,11,60,5,8};
        var cube=
                from number in numbers1
                where (number*number*number)>100
                where (number*number*number)<1000
                select number;
        
        foreach(int i in cube){
            Console.Write(i+" ");
        }
    }
}
