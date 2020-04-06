using System.Xml;

namespace OverwatchLibrary
{
    public class XmlParser
    {
        /// <summary>
        /// Method which creates xml element.
        /// </summary>
        /// <param name="unit1">unit which should be write in file</param>
        /// <returns></returns>
        private XmlDocument Serialize(Unit unit1)
        {
            var xml = new XmlDocument();
            var unitElement = xml.CreateElement("Unit");

            unitElement.AppendChild(CreateXmlNode(xml, "Heroes", unit1.Heroes));
            unitElement.AppendChild(CreateXmlNode(xml, "DamagePS", unit1.DamagePS.ToString()));
            unitElement.AppendChild(CreateXmlNode(xml, "HeadDPS", unit1.HeadDPS.ToString()));
            unitElement.AppendChild(CreateXmlNode(xml, "SingleShot", unit1.SingleShot.ToString()));
            unitElement.AppendChild(CreateXmlNode(xml, "Health", unit1.Health.ToString()));
            unitElement.AppendChild(CreateXmlNode(xml, "Reload", unit1.Reload.ToString()));
            unitElement.AppendChild(CreateXmlNode(xml, "MaxHealth", unit1.MaxHealth.ToString()));

            xml.AppendChild(unitElement);
            return xml;
        }
        /// <summary>
        /// Method which save unit in xml file.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="path"></param>
        public void SaveToXml(Unit unit, string path)
        {
            var xml = Serialize(unit);
            xml.Save(path);
        }
        /// <summary>
        /// Method which creates new xml node.
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private XmlNode CreateXmlNode(XmlDocument xml, string name, string data)
        {
            var element = xml.CreateElement(name);
            var xmlData = xml.CreateTextNode(name);
            xmlData.Value = data;
            element.AppendChild(xmlData.Clone());
            return element.Clone();
        }
        /// <summary>
        /// Method which creates new unit from xml file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Unit Deserialize(string path)
        {
            var xml = new XmlDocument();
            xml.Load(path);
            var unit = new Unit(xml.GetElementsByTagName("Heroes")[0].InnerText,
                double.Parse(xml.GetElementsByTagName("DamagePS")[0].InnerText),
                double.Parse(xml.GetElementsByTagName("HeadDPS")[0].InnerText),
                double.Parse(xml.GetElementsByTagName("SingleShot")[0].InnerText),
                double.Parse(xml.GetElementsByTagName("Health")[0].InnerText),
                xml.GetElementsByTagName("Reload")[0].InnerText);
            unit.MaxHealth = double.Parse(xml.GetElementsByTagName("MaxHealth")[0].InnerText);
            return unit;
        }
    }
}
