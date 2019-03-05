using System;
using System.Linq;
using System.Xml.Linq;

namespace Katas.Challenges
{
    public static class XmlFolderReader
    {
        private const string NAME_ATTRIBUTE = "name";

        public static void GetFolderNamesFromXml(string xml, char startingLetter)
        {
            var folders = XDocument.Parse(xml).Descendants()
                .Where(x =>
                    x.Attribute(NAME_ATTRIBUTE) != null &&
                    x.Attribute(NAME_ATTRIBUTE).Value.StartsWith(startingLetter))
                .Select(x => x.Attribute(NAME_ATTRIBUTE).Value);

            folders.ToList().ForEach(Console.WriteLine);
        }
    }
}
