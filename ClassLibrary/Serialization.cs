using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Serialization
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(SmthAboutPlayer));
        public static void WriteToFile(string fileName, SmthAboutPlayer data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static SmthAboutPlayer LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (SmthAboutPlayer)Xs.Deserialize(fileStream);
            }
        }
        public static SmthAboutPlayer LoadFromStream(Stream file)
        {
            return (SmthAboutPlayer)Xs.Deserialize(file);
        }
    }
}


