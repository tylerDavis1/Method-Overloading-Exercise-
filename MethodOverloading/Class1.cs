using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Class1
    {
        public static int Add (int x, int y)
        {
            return x + y; 
        }

        public static decimal Add (decimal x , decimal y )
        {
            return x + y; 
        }

        public static string Add (int x , int y , bool withPesos)
        {
            if (withPesos)
            {
                return $"{x + y} pesos";
            }else if (withPesos && (x + y) == 1)
            {
                return $"{x + y} pesos";
            }
            else
            {
                return $"{x + y}";
            }
            
        }
       

        
    }
}
