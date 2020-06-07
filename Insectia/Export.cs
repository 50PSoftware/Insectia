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
                        source.GetItemsList();
                        if (categories != null)
                        {
                            foreach (string category in categories)
                            {
                                var query = from _category in source.GetCategories() where _category != category select _category;
                                foreach (string _category in query)
                                {
                                    db.AddCategory(category);
                                }
                            }
                            db.Save(true);
                        }
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
