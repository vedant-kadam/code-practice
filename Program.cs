using System;

namespace code_practice
{
    class Program
    {
        static void Main(string[] args)
        {
           //array  rotation
           ///1- make a new aray and srtore the  result space complexity n and time complexity n
           //2 - use two for loop  time complexity n2 and space ccplexity 1
           //3 juggle time complexity n ans space 1;

             int[] _arr = { 1, 2, 3, 4, 5, 6, 7 };
             int _rounds=2;
             int _arrSize=_arr.Length;
             int _gcd = gcd(_rounds,_arrSize);

             //storage var
             int currEl,currIndex,temp;

             for(int i = 0 ;i<_gcd;i++)
             {
                 currEl = _arr[i];
                 currIndex = i;
                 while(true)
                 {
                    int _swapIndex= currIndex+_rounds;  
                    if(_swapIndex>= _arrSize)
                    {
                        _swapIndex-= _arrSize;
                    }
                    if(_swapIndex==i)
                    {
                        break;
                    }

                    _arr[currIndex]=_arr[_swapIndex];
                    currIndex = _swapIndex;
                 }
                 _arr[currIndex] = currEl;
             }

            for(int i=0;i<_arr.Length;i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public static int gcd(int a ,int b)
        {
            if(b==0)
            {
                return a;
            }else{
                return gcd(b,a%b);
            }
        }
    }
}
