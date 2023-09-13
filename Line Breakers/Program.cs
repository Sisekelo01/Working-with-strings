using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Breakers
{
    internal class Program
    {
        static void Main(string[] args)
        {//introduction to line breakers;
            Console.WriteLine("This shows on one line");
            Console.WriteLine("This will be on two line because of \n check console ");
            Console.WriteLine("To have the quotation marks put a \"Sisekelo\" ");
            
            //declaration;
            string firstname = "Khaya";
            string lastname = "Mthembu";

            //concatinate
            Console.WriteLine(firstname + " " + lastname);
            
            //function used on strings to the length or number  of characters
            Console.WriteLine("The length of the of the name is " + firstname.Length);

            //change name to uppercase and change lastname to lowercase

            Console.WriteLine("firstname as upperrcase " + firstname.ToUpper());
            Console.WriteLine("lastname as lowercase " + lastname.ToLower());
            Console.WriteLine("To find if firstname contain Kh "+firstname.Contains("kh"));

            Console.WriteLine("first letter of first name is" + firstname[0]);

            Console.WriteLine("The index of k is " + firstname.IndexOf("k"));
            Console.WriteLine("The suubstring from 1 " + lastname.Substring(0,3));


    




            //freeze console
            Console.ReadLine();
        }
    }
}
