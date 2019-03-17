using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.readcsvlib;

namespace csvreader
{
    public class corefunction
    {
        public static void Main(string[] args)
        {
            var read = File.ReadAllLines(@"C:\100 Records.csv");

            var List = from data in read
                       let newdata = data.Split(',')
                       select new
                       {
                       
                           Name = newdata[2],
                           DOB = newdata[10],
                           Designation = newdata[1],
                           Location = newdata[32]

                       };
        }
        public static void location_based_users()
            {
                Console.WriteLine("Enter the location");
                string location = Console.ReadLine();
                var record = List.Where(e => e.Location == location);
                foreach (var loc in record)
            {
                
                Console.WriteLine("\tName : " + loc.Name);
                Console.WriteLine("\tDOB : " + loc.DOB);
                Console.WriteLine("\tLocation: " + loc.Location);
                Console.WriteLine("\tDesignation: " + loc.Designation);
            }

                
            }
            
        
        public static void designation_based_users()
        {
            Console.WriteLine("Enter the designation");
            String designation = Console.ReadLine();
            var record = List.Where(e => e.Designation == designation);
            foreach (var des in record)
                {
                    Console.WriteLine("\tName : " + des.Name);
                    Console.WriteLine("\tDOB : " + des.DOB);
                    Console.WriteLine("\tLocation: " + des.Location);
                    Console.WriteLine("\tDesignation: " + des.Designation);
                }


            }



          
       
        public static void DOB_based_users()
        {
            

            Console.WriteLine("Enter the dob(dd-mm-yyyy)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            String doj = String.Format("{0:MM/dd/yyyy}", date);
            var record = List.Where(e => e.DOB <= doj);
            foreach (var d in record)
            {
               
                Console.WriteLine("Name : " + d.Name);
                Console.WriteLine("DOB : " + d.DOB);
                Console.WriteLine("Location: " + d.Location);
                Console.WriteLine("\tDesignation: " + d.Designation);
            }
          
        }

    }

}