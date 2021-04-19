using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mad_libs_lab
{
    class Program
    {
        static void Main(string[] args)
        {

            string adjective1 = "frightful";
            string noun1 = "monkey";
            string verbpasttense = "jumped";
            string adverb1 = "rapidly";
            string adjective2 = "fruity";
            string noun2 = "mango";
            string noun3 = "feeding";
            string adjective3 = "giant";
            string verb1 = "run";
            string adverb2 = "carefully";
            string verbpasttense2 = "hugged";
            string adjective4 = "good";

            Console.WriteLine($"Today I went to the zoo. I saw a {adjective1} {noun1} jumping up and down in its tree. He {verbpasttense} {adverb1} through the large tunnel that led to its {adjective2} {noun2}. I got some peanuts and passed them through the cage to a gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adjective3} scoop of ice cream. It filled my stomach. Afterwards I had to {verb1} {adverb2} to catch our bus. When I got home I {verbpasttense2} my mom for a {adjective4} day at the zoo.");

            Console.ReadLine();
        }
    }
}
