using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csvreader;

namespace searchandgetdata
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Select from the given optios");
            Console.WriteLine("location");
            Console.WriteLine("dob");
            Console.WriteLine("designation");
            Console.WriteLine(" ");
            String str = Console.ReadLine();

            switch (str)
            {

                case "location":

                    corefunction.location_based_users();
                    break;
                case "dob":

                    corefunction.DOB_based_users();
                    break;
                case "designation":
                    corefunction.designation_based_users();
                    break;
                default:
                    Console.WriteLine("input is wrong,re enter");
                    break;
            }

                    Console.ReadKey(true);
            
            
                    
            

        }


    }
}

