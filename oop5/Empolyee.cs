using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    internal class Empolyee
    {
        public int Id;
        public string name;
        public static int numberofempolyees;
        public static string FilePath;
        public Empolyee()
        {

        } 
        public void Display()
        {
            Test();
            numberofempolyees = 10;
            Console.WriteLine($"(ID is:{Id}\t Name is:{name} ");
        }
        public static void Test() {
            numberofempolyees = 10; 
        
        }
        
    }
}
