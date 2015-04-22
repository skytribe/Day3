using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "this si a test ";
            var en = new Enigma();
            var y = en.Encrypt(x);

            Console.WriteLine("Original String:{0}", x);
            Console.WriteLine("Encrypted String:{0}", y);

            var y1 = en.Decrypt(y);
            Console.WriteLine("Decrypted String:{0}", y1);

            Debug.Assert(en.Encrypt("aaa") != en.Decrypt("aaaa"), "Encryption should result in different value");
            Debug.Assert( "aaa"  == en.Decrypt(en.Encrypt("aaa")), "Encryption should result in same value");

            Console.ReadLine();
        }

    }

    class Enigma
    {
        System.Collections.Hashtable encryptKeys;
        System.Collections.Hashtable decryptKeys;

        public Enigma()
        {

            encryptKeys = new System.Collections.Hashtable();
            encryptKeys.Add('a', "b");
            encryptKeys.Add('b', "c");
            encryptKeys.Add('c', "d");
            encryptKeys.Add('d', "e");
            encryptKeys.Add('e', "f");
            encryptKeys.Add('f', "g");
            encryptKeys.Add('g', "h");
            encryptKeys.Add('h', "i");
            encryptKeys.Add('i', "j");
            encryptKeys.Add('j', "k");
            encryptKeys.Add('k', "l");
            encryptKeys.Add('l', "m");
            encryptKeys.Add('m', "n");
            encryptKeys.Add('n', "o");
            encryptKeys.Add('o', "p");
            encryptKeys.Add('p', "q");
            encryptKeys.Add('q', "r");
            encryptKeys.Add('r', "s");
            encryptKeys.Add('s', "t");
            encryptKeys.Add('t', "u");
            encryptKeys.Add('u', "v");
            encryptKeys.Add('v', "w");
            encryptKeys.Add('w', "x");
            encryptKeys.Add('x', "y");
            encryptKeys.Add('y', "z");
            encryptKeys.Add('z', "a");

            decryptKeys = new System.Collections.Hashtable();
            decryptKeys.Add('b', 'a');
            decryptKeys.Add('c', 'b');
            decryptKeys.Add('d', 'c');
            decryptKeys.Add('e', 'd');
            decryptKeys.Add('f', 'e');
            decryptKeys.Add('g', 'f');
            decryptKeys.Add('h', 'g');
            decryptKeys.Add('i', 'h');
            decryptKeys.Add('j', 'i');
            decryptKeys.Add('k', 'j');
            decryptKeys.Add('l', 'k');
            decryptKeys.Add('m', 'l');
            decryptKeys.Add('n', 'm');
            decryptKeys.Add('o', 'n');
            decryptKeys.Add('p', 'o');
            decryptKeys.Add('q', 'p');
            decryptKeys.Add('r', 'q');
            decryptKeys.Add('s', 'r');
            decryptKeys.Add('t', 's');
            decryptKeys.Add('u', 't');
            decryptKeys.Add('v', 'u');
            decryptKeys.Add('w', 'v');
            decryptKeys.Add('x', 'w');
            decryptKeys.Add('y', 'x');
            decryptKeys.Add('z', 'y');
            decryptKeys.Add('a', 'z');
        }

        //Will encrypt with the encrypt key
        public string Encrypt(string s)
        {
            return encryptstring(s, encryptKeys);
        }

        //Will encrypt with the decrypt key
        public string Decrypt(string s)
        {            
            return encryptstring(s, decryptKeys);
        }

        private string encryptstring(string s, System.Collections.Hashtable key)
        {
            var sb = new StringBuilder();
            foreach (char item in s)
            {
                if (key.ContainsKey(item))
                {
                    sb.Append(key[item]);
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }

    }
}
