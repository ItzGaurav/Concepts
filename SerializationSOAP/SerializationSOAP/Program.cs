using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationSOAP
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
            Serializee(ht);
            Console.WriteLine("The Serialized text file is saved in your given location, Enter any key to Deserialize and get output");
            Console.ReadKey();
            Deserializee();
        }

        public static void Serializee(Hashtable collection)
        {
            using (FileStream fs = new FileStream(@"E:\SOAP.txt", FileMode.Create))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, collection);
            }
        }

        public static void Deserializee()
        {
            FileStream fss = new FileStream(@"E:\SOAP.txt", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();
            Hashtable H = (Hashtable)sf.Deserialize(fss);

            foreach (DictionaryEntry kvp in H)
            {
                Console.WriteLine("Key={0}, value={1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }

    }
}
