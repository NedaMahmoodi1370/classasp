using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //    1    
    //   121   
    //  12321  
    // 1234321 
    //123454321


    int row = 7;

    for(int index = 0; index < 7; index++)
    {
        row--;
        for(int sapce = 0; sapce < row; sapce++)
        {
            System.Console.Write(" ");
        }
        for( int counter = 0; counter < index; counter++)
        {
            System.Console.Write(counter+1);
        }
        for( int counter = index + 1; counter > 0; counter--)
        {
            System.Console.Write(counter);
        }
        for(int sapce = 0; sapce < row; sapce++)
        {
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }   
