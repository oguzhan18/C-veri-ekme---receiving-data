using System;
using System.IO;

namespace veri_cekme
{

    class Program
    {
        static void Main(string[] args)
        {
            string okunan;
            StreamReader st = File.OpenText(@"C:\Program Files (x86)\yazi.txt");
            while ((okunan = st.ReadLine()) != null)
            {
                Console.WriteLine(okunan);
            }
            Console.ReadLine();
        }
    }
}
