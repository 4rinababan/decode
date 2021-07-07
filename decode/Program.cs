using System;
using System.Text;

namespace decode
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] data = Convert.FromBase64String("password");
            //string decodedString = Encoding.Default.GetString(data);
            string base64Decoded = "password";
            string base64Encoded;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            base64Encoded = System.Convert.ToBase64String(data);
            Console.WriteLine(base64Encoded);
            Console.ReadKey();
        }
    }
}
