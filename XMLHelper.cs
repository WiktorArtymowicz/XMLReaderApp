using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace XMLReaderApp
{
    public static class XMLHelper
    {
        public static List<Person> GetPeople(string sorce)
        {
            XDocument document = XDocument.Load(sorce);

            var xmlData = from p in document.Descendants("Person")
                          select new
                          {
                              Name = (string)p.Attribute("Name"),
                              Surname = (string)p.Attribute("Surname"),
                              Age = (int)p.Attribute("Age")
                          };

            return ConvertToPersonList(xmlData);
        }

        private static List<Person> ConvertToPersonList(dynamic personList)
        {
            List<Person> people = new List<Person>();
            foreach (var item in personList)
            {
                people.Add(new Person() { Age = item.Age, Name = item.Name, Surname = item.Surname });
            }

            return people;
        }
    }
}
