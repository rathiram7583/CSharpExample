

using System;

namespace C_Example
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //MyMethod(); 
            Console.WriteLine("Enter Your Name");
            string myname=Console.ReadLine();
            Console.WriteLine("Thankyou"+myname+"Your Array is ");
            int[] myarray= new int[5]{3,4,5,6,7};
            myarray[0]=2;
            int i;
            for(i=0;i<5;i++)
            {
            Console.WriteLine(myarray[i]);
            }

            int j=0;
            while(j<5)
            {
                Console.WriteLine("Array Index:"+j+"Array Value:"+myarray[j]);
                //j=j+2;
                j+=2;

            }
            foreach(int e in myarray)
            {
                Console.WriteLine("Current foreach Value is:"+e);
            }

           


        }
        static void MyMethod()
        {
            int x=23;
            Console.WriteLine("Hello World!"+x);
            if (x<30)
            {
                Console.WriteLine("X is less than thirty");
            }else if(x==30)
            {Console.WriteLine("X is Thirty");
            }
            else{
                Console.WriteLine("x is greater than Thirty");
            }


            int a=3;
            switch(a){
                case 1:
                Console.WriteLine("The Value is 1");
                break;
                case 2:
                Console.WriteLine("The Value is 2");
                break;
                case 3:
                Console.WriteLine("The Value is 3");
                break;
                default :
                
                break;
            }
        }

    }
}
