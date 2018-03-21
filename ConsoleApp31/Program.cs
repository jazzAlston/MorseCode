using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
       {
    {' ', "/"},
    {'A', ".-"},
    {'B', "-..."},
    {'C', "-.-."},
    {'D', "-.."},
    {'E', "."},
    {'F', "..-."},
    {'G', "--."},
    {'H', "...."},
    {'I', ".."},
    {'J', ".---"},
    {'K', "-.-"},
    {'L', ".-.."},
    {'M', "--"},
    {'N', "-."},
    {'O', "---"},
    {'P', ".--."},
    {'Q', "--.-"},
    {'R', ".-."},
    {'S', "..."},
    {'T', "-"},
    {'U', "..-"},
    {'V', "...-"},
    {'W', ".--"},
    {'X', "-..-"},
    {'Y', "-.--"},
    {'Z', "--.."},
    {'1', ".----"},
    {'2', "..---"},
    {'3', "...--"},
    {'4', "....-"},
    {'5', "....."},
    {'6', "-...."},
    {'7', "--..."},
    {'8', "---.."},
    {'9', "----."},
    {'0', "-----"},
    {',', "--..--"},
    {'.', ".-.-.-"},
    {'?', "..--.."},
    {';', "-.-.-."},
    {':', "---..."},
    {'/', "-..-."},
    {'-', "-....-"},
    {'\'', ".----."},
    {'"', ".-..-."},
    {'(', "-.--."},
    {')', "-.--.-"},
    {'=', "-...-"},
    {'+', ".-.-."},
    {'@', ".--.-."},
    {'!', "-.-.--"},
    {'Á', ".--.-"},
    {'É', "..-.."},
    {'Ö', "---."},
    {'Ä', ".-.-"},
    {'Ñ', "--.--"},
    {'Ü', "..--"}
};

        public static void ToMorse(string input)
        {


            foreach (char c in input)
            {

                Console.WriteLine(_textToMorse[c]);
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter message to translate to Morse Code");
            string input = Console.ReadLine().ToUpper();
            ToMorse(input);
        }

    }

}
