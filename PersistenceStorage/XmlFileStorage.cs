using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistedStorage
{
    public class XmlFileStorage : IStorage
    {
        string filePath = "xmlDict.xml";
        public string Get(string key)
        {
            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                XElement keyValueElement = doc.Descendants("KeyValuePair").FirstOrDefault(e => e.Element("Key").Value == key);

                if (keyValueElement != null)
                {
                    return keyValueElement.Element("Value").Value;
                }
            }

            return null;
        //throw new NotImplementedException();
        }

        public void Save(string key, string value)
        {
            XDocument doc;

            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
            }
            else
            {
                doc = new XDocument(new XElement("dict"));
            }

            XElement keyValueElement = new XElement("KeyValuePair",
                new XElement("Key", key),
                new XElement("Value", value));

            doc.Element("dict").Add(keyValueElement);
            doc.Save(filePath);
        //throw new NotImplementedException();
        }
    }
}
