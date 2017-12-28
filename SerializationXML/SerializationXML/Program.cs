using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationXML
{
    public class addressDetails
    {
        public string HouseNo { get; set; }
        public string city { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            addressDetails details = new addressDetails();
            details.HouseNo = "MIG-28";
            details.city = "Noida";
            serialization(details);
            deserialization();
            Console.ReadKey();
        }

        public static void serialization(addressDetails detail)
        {
            XmlSerializer s = new XmlSerializer(typeof(addressDetails));
            TextWriter tw = new StreamWriter(@"E:\A.xml");
            s.Serialize(tw, detail);
            tw.Close();
        }

        public static void deserialization()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(addressDetails));
            TextReader tr = new StreamReader(@"E:\A.xml");
            addressDetails xmldata = (addressDetails)deserializer.Deserialize(tr);
            tr.Close();
        }
    }
}
