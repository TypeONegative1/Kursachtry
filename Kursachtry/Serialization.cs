using System.IO;
using System.Xml.Serialization;

namespace samproject
{
    public static class HelperMine
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
    }
}
