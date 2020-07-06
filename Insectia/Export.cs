using System.Linq;

namespace Insectia
{
    static class Export
    {
        public enum filetype { CSV, XML, MySQL };
        public static void Proceed(filetype filetype, string filenameOrConnectionString, Item source, string[] categories = null)
        {
            switch (filetype)
            {
                case filetype.CSV:
                    {
                        CSV csvFile = new CSV(filenameOrConnectionString);
                        csvFile.New();
                        csvFile.Save(source);
                    }
                    break;
                case filetype.XML:
                    {
                        XML xmlFile = new XML(filenameOrConnectionString);
                        xmlFile.New();
                        xmlFile.Save(source);
                    }
                    break;
                case filetype.MySQL:
                    {
                        Database db = new Database(filenameOrConnectionString);
                        db.FillTables();
                        foreach (Seznam item in source.GetItemsList())
                        {
                            db.AddRecord(item.Nazev, item.Kategorie, item.Obsah);
                        }
                        db.Save();
                    }
                    break;
            }
        }
    }
}
