/**
* 10 SEP 2023
* CSC 253
* Daniel Parks
* File Encryption and Decryption
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDictionary
{
    public static class Dictionary
    {
        public static Dictionary<char, char> encryptionDict = new Dictionary<char, char>()
        {
            {'A', '!'}, {'a', '1'},
            {'B', '@'}, {'b', '2'},
            {'C', '#'}, {'c', '3'},
            {'D', '$'}, {'d', '4'},
            {'E', '%'}, {'e', '5'},
            {'F', '^'}, {'f', '6'},
            {'G', '&'}, {'g', '7'},
            {'H', '*'}, {'h', '8'},
            {'I', '('}, {'i', '9'},
            {'J', ')'}, {'j', '0'},
            {'K', 'z'}, {'k', 'Z'},
            {'L', 'y'}, {'l', 'Y'},
            {'M', 'x'}, {'m', 'X'},
            {'N', 'w'}, {'n', 'W'},
            {'O', 'v'}, {'o', 'V'},
            {'P', 'u'}, {'p', 'U'},
            {'Q', 't'}, {'q', 'T'},
            {'R', 's'}, {'r', 'S'},
            {'S', 'r'}, {'s', 'R'},
            {'T', 'q'}, {'t', 'Q'},
            {'U', 'p'}, {'u', 'P'},
            {'V', 'o'}, {'v', 'O'},
            {'W', 'n'}, {'w', 'N'},
            {'X', 'm'}, {'x', 'M'},
            {'Y', 'l'}, {'y', 'L'},
            {'Z', 'k'}, {'z', 'K'},
            {'1', 'j'}, {'!', 'J'},
            {'2', 'i'}, {'@', 'I'},
            {'3', 'h'}, {'#', 'H'},
            {'4', 'g'}, {'$', 'G'},
            {'5', 'f'}, {'%', 'F'},
            {'6', 'e'}, {'^', 'E'},
            {'7', 'd'}, {'&', 'D'},
            {'8', 'c'}, {'*', 'C'},
            {'9', 'b'}, {'(', 'B'},
            {'0', 'a'}, {')', 'A'},

        };

        public static Dictionary<char, char> decryptionDict = new Dictionary<char, char>();

        static Dictionary()
        {
            // Populate decryption dictionary by reversing the encryption dictionary
            foreach (var entry in encryptionDict)
            {
                decryptionDict[entry.Value] = entry.Key;
            }
        }
    }
}