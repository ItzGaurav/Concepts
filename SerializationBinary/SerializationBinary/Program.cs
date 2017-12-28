using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add('1', "A");
            ht.Add('2', "B");
            ht.Add('3', "C");
            ht.Add('4', "D");
            ht.Add('5', "E");
            string pth = @"E:\Test.txt";  // Change Location According to your choice.

            Serialize(ht, pth);
            deserialize();
        }

        public static void Serialize(Hashtable hh, string path)
        {

            using (FileStream FS = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter binaryf = new BinaryFormatter();
                try
                {
                    binaryf.Serialize(FS, hh);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            Console.WriteLine("The Serialized text file is saved in your given location, Enter any key to Deserialize and get output");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void deserialize()
        {
            Hashtable ht = null;
            string pth = @"E:\Test.txt";  // Change Location According to your choice.
            FileStream fs = new FileStream(pth, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                ht = (Hashtable)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (DictionaryEntry kvp in ht)
            {
                Console.WriteLine("Key={0}, Value={1}", kvp.Key, kvp.Value);
                Console.WriteLine("--------------------------");

            }
            Console.Read();

        }
    }
}
