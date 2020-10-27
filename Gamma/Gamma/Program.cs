using System;
using System.Collections.Generic;
namespace Gamma
{
    class Program
    {
        public char[] alphabet = new char[]{'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я',' ','0','1','2','3','4','5','6','7','8','9'};
        public int mod = 0;
        
        public string Converter(int key)
        {
            string strkey = Convert.ToString(key);
            return strkey;
        }
        public string LengtEqual(string key,string text) 
        {
            while (key.Length < text.Length) 
            {
                key += key;
                if (key.Length > text.Length) 
                {
                    key = key.Remove(text.Length);
                }
            }
            string newkey = key;
            return newkey;
        }
        public string Encrypt(string text, string key)
        {
            mod = alphabet.Length;
            text = text.ToUpper();
            int z = 0;
            int k = 0;
            int x = 0;
            string str = "";
            for (int i = 0; i < text.Length; i++) 
            {
                for (int a = 0; a < alphabet.Length; a++) 
                {
                    if (key[i] == alphabet[a])
                    {
                        k = a;
                    }
                    if (text[i] == alphabet[a])
                    {
                        x = a;
                    } 
                    z = (x + k) % alphabet.Length;
                }
                str += alphabet[z];
            }
            return str;
        }
        public string Decrypt(string encrypt,string key)
        {
            mod = alphabet.Length;
            int z = 0;
            int k = 0;
            int x = 0;
            string str = "";
            for (int i = 0; i < encrypt.Length; i++) 
            {
                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (key[i] == alphabet[a])
                    {
                        k = a;
                    }
                    if (encrypt[i] == alphabet[a])
                    {
                        x = a;
                    } 
                    z = ((x - k) + alphabet.Length) % alphabet.Length;
                }
                str += alphabet[z];
            }
            return str;
        }
        static void Main(string[] args)
        {
            Program InstanceProgram = new Program();
            string str = "мама мыла раму";
            var a = InstanceProgram.LengtEqual(InstanceProgram.Converter(243), str);
            Console.WriteLine(a);
            var t = InstanceProgram.Encrypt(str, a);
            Console.WriteLine(t);
            var y = InstanceProgram.Decrypt(t, a);
            Console.WriteLine(y.ToLower());
        }
    }
}
