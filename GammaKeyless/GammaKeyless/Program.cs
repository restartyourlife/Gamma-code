using System;

namespace GammaKeyless
{
    class Program
    {
        public char[] alphabet = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public int mod = 0;

        public string Encrypt(string text)
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
                    k = i;
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
        public string Decrypt(string encrypt)
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
                    k = i;
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
            var t = InstanceProgram.Encrypt(str);
            Console.WriteLine(t);
            var y = InstanceProgram.Decrypt(t);
            Console.WriteLine(y.ToLower());
        }
    }
}
