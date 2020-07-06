using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Insectia
{
    interface IFileWorkable
    {
        void New();
        void Load(Item item);
        void Save(Item item);
    }

    class Item
    {
        private List<Seznam> items = null;
        public Item()
        {
            items = new List<Seznam>();
        }

        public void AddItem(string name, string category, string content)
        {
            items.Add(new Seznam(name, category, content));
        }
        public void AddItem(Seznam item)
        {
            items.Add(item);
        }
        public string[] GetItemsNames(string category)
        {
            var query = from l in items where l.Kategorie == category select l.Nazev;
            List<string> names = new List<string>();
            foreach (var name in query)
            {
                names.Add(name);
            }
            return names.ToArray();
        }
        public string GetItemContent(string category, int index)
        {
            string[] it = items.Where(i => i.Kategorie == category).Select(i => i.Obsah).ToArray();
            return it[index];
        }
        public string[] GetCategories()
        {
            var query = from l in items group l by l.Kategorie;
            List<string> cats = new List<string>();
            foreach (var category in query)
            {
                cats.Add(category.Key);
            }
            return cats.ToArray();
        }
        public Seznam GetItem(int index)
        {
            return items[index];
        }
        public void Clear()
        {
            items.Clear();
        }
        public List<Seznam> GetItemsList()
        {
            return items;
        }

        public string[] GetItemList()
        {
            List<string> itemList = new List<string>();
            foreach (Seznam item in items)
            {
                itemList.Add($"{item.Nazev} v {item.Kategorie}");
            }
            return itemList.ToArray();
        }

        public void SetItemsList(List<Seznam> items)
        {
            this.items = items;
        }
        public void DeleteItems(string categoryName, string itemName)
        {
            int index = 0;
            while (index < items.Count)
            {
                if (!itemName.Equals(String.Empty) && items[index].Kategorie.Equals(categoryName) && items[index].Nazev.Equals(itemName))
                {
                    items.RemoveAt(index);
                    index--;
                }
                else if (itemName.Equals(String.Empty) && items[index].Kategorie.Equals(categoryName))
                {
                    items.RemoveAt(index);
                    index--;
                }
                index++;
            }
        }
        public void UpdateItem(int index, string name, string category, string content)
        {
            items[index] = new Seznam(name, category, content);
        }

        public void UpdateCategory(string oldCategory, string newCategory)
        {
            var query = from l in items where l.Kategorie == oldCategory select l;
            foreach (Seznam cat in query)
            {
                cat.SetKategorie(newCategory);
            }
        }
    }

    class CSV : IFileWorkable
    {
        public string filename { get; private set; }
        private readonly string CSVHead = "Nazev;Kategorie;Obsah";

        public CSV(string filename)
        {
            this.filename = filename;
        }

        public void SetFilename(string filename)
        {
            this.filename = filename;
        }

        public void New()
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            StreamWriter fileWriter = new StreamWriter(filename, false, Encoding.Default);
            fileWriter.WriteLine(CSVHead);
            fileWriter.Close();
        }

        public void Load(Item item)
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            item.Clear();
            StreamReader fileReader = new StreamReader(filename, Encoding.Default);
            string row = fileReader.ReadLine();
            while ((row = fileReader.ReadLine()) != null)
            {
                string[] vals = row.Split(';');
                item.AddItem(vals[0], vals[1], vals[2]);
            }
            fileReader.Close();
        }

        public void Save(Item item)
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            StreamWriter fileWriter = new StreamWriter(filename, false, Encoding.Default);
            fileWriter.WriteLine(CSVHead);
            foreach (Seznam seznam in item.GetItemsList())
            {
                fileWriter.WriteLine($"{seznam.Nazev};{seznam.Kategorie};{seznam.Obsah}");
            }
            fileWriter.Close();
        }
    }

    class XML : IFileWorkable
    {
        public string filename { get; private set; }

        public XML(string filename)
        {
            this.filename = filename;
        }

        public void SetFilename(string filename)
        {
            this.filename = filename;
        }

        public void New()
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            XmlTextWriter writer = new XmlTextWriter(filename, Encoding.Default);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("data");
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
        }

        public void Load(Item item)
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            item.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodes = doc.SelectNodes("/data/item");
            foreach (XmlNode node in nodes)
            {
                item.AddItem(node.SelectSingleNode("name").InnerText, node.SelectSingleNode("category").InnerText, node.SelectSingleNode("content").InnerText);
            }
        }

        public void Save(Item item)
        {
            if (filename.Equals(String.Empty))
                throw new Exception("Filename is not set!");
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlElement root = doc.DocumentElement;
            root.RemoveAll();
            foreach (Seznam seznam in item.GetItemsList())
            {
                XmlElement itemelem = doc.CreateElement("item");
                XmlElement nazev = doc.CreateElement("name");
                nazev.InnerText = seznam.Nazev;
                itemelem.AppendChild(nazev);
                XmlElement kategorie = doc.CreateElement("category");
                kategorie.InnerText = seznam.Kategorie;
                itemelem.AppendChild(kategorie);
                XmlElement obsah = doc.CreateElement("content");
                obsah.InnerText = seznam.Obsah;
                itemelem.AppendChild(obsah);
                root.AppendChild(itemelem);
            }
            doc.Save(filename);
        }
    }

    class Database
    {
        private dbInsectiaSet dbInsectiaSet;
        private dbInsectiaSetTableAdapters.itemTableAdapter itemTableAdapter;
        private dbInsectiaSetTableAdapters.categoryTableAdapter categoryTableAdapter;

        private string connectionString;
        private dbInsectiaSet.itemDataTable itemTable;
        private dbInsectiaSet.categoryDataTable categoryTable;
        public Database()
        {
            Init();
            InitTables();
        }

        public Database(string connectionString)
        {
            Init();
            itemTableAdapter.Connection.ConnectionString = categoryTableAdapter.Connection.ConnectionString = connectionString;
            InitTables();
        }

        private void Init()
        {
            dbInsectiaSet = new dbInsectiaSet();
            itemTableAdapter = new dbInsectiaSetTableAdapters.itemTableAdapter();
            categoryTableAdapter = new dbInsectiaSetTableAdapters.categoryTableAdapter();
        }

        private void InitTables()
        {
            itemTable = dbInsectiaSet.item;
            categoryTable = dbInsectiaSet.category;
        }

        public void SetConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
            itemTableAdapter.Connection.ConnectionString = categoryTableAdapter.Connection.ConnectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public void FillTables()
        {
            itemTableAdapter.Fill(itemTable);
            categoryTableAdapter.Fill(categoryTable);
        }

        public Seznam[] SelectData()
        {
            FillTables();
            List<Seznam> localList = new List<Seznam>();
            var queryitem = from _item in itemTable select _item;
            foreach (dbInsectiaSet.itemRow row in queryitem)
            {
                localList.Add(new Seznam(row.name, row.categoryRow.category, row.content));
            }
            return localList.ToArray();
        }

        public void Load(Item item)
        {
            FillTables();
            var queryItem = from _item in itemTable select _item;
            foreach (dbInsectiaSet.itemRow row in queryItem)
            {
                item.AddItem(new Seznam(row.name, row.categoryRow.category, row.content));
            }
        }

        public string[] SelectCategories()
        {
            var queryCategory = from _category in categoryTable select _category;
            List<string> cats = new List<string>();
            foreach (dbInsectiaSet.categoryRow row in queryCategory)
            {
                cats.Add(row.category);
            }
            return cats.ToArray();
        }

        public void AddRecord(string name, string category, string content)
        {
            dbInsectiaSet.itemRow NewRow = itemTable.NewitemRow();
            NewRow.name = name;
            NewRow.content = content;
            dbInsectiaSet.categoryRow categoryRow = null;
            foreach (dbInsectiaSet.categoryRow row in categoryTable)
            {
                if (row.category == category)
                    categoryRow = row;
            }
            if (categoryRow == null)
            {
                categoryRow = categoryTable.NewcategoryRow();
                categoryRow.category = category;
                categoryTable.AddcategoryRow(categoryRow);
                Save(true);
                categoryTableAdapter.Fill(categoryTable);
                var q = from _category in categoryTable where _category.category == category select _category;
                foreach (dbInsectiaSet.categoryRow row in q)
                {
                    categoryRow = row;
                }
            }
            NewRow.idCategory = categoryRow.id;
            itemTable.AdditemRow(NewRow);
        }

        public void AddCategory(string Category)
        {
            dbInsectiaSet.categoryRow NewRow = categoryTable.NewcategoryRow();
            NewRow.category = Category;
            categoryTable.AddcategoryRow(NewRow);
            Save(true);
            categoryTableAdapter.Fill(categoryTable);
        }

        public void UpdateRecord(string OldName, string OldCategory, string NewName, string NewCategory, string Content)
        {
            dbInsectiaSet.itemRow itemRow = null;
            var queryItem = from _item in itemTable where _item.name == OldName && _item.categoryRow.category == OldCategory select _item;
            foreach (dbInsectiaSet.itemRow row in queryItem)
            {
                itemRow = row;
            }
            if (!string.IsNullOrEmpty(NewName))
            {
                itemRow.name = NewName;
            }
            dbInsectiaSet.categoryRow categoryRow = null;
            if (!string.IsNullOrEmpty(NewCategory))
            {
                var queryCategory = from _category in categoryTable where _category.category == NewCategory select _category;
                foreach (dbInsectiaSet.categoryRow row in queryCategory)
                {
                    categoryRow = row;
                }
                if (categoryRow == null)
                {
                    categoryRow = categoryTable.NewcategoryRow();
                    categoryRow.category = NewCategory;
                    categoryTable.AddcategoryRow(categoryRow);
                    Save(true);
                    categoryTableAdapter.Fill(categoryTable);
                    var q = from _category in categoryTable where _category.category == NewCategory select _category;
                    foreach (dbInsectiaSet.categoryRow row in q)
                    {
                        categoryRow = row;
                    }
                }
                itemRow.idCategory = categoryRow.id;
            }
            if (!string.IsNullOrEmpty(Content))
            {
                itemRow.content = Content;
            }
        }

        public void UpdateCategories(string OldCategory, string NewCategory)
        {
            var queryCategory = from _category in categoryTable where _category.category == OldCategory select _category;
            foreach (dbInsectiaSet.categoryRow row in queryCategory)
            {
                row.category = NewCategory;
            }
            Save(true);
            categoryTableAdapter.Fill(categoryTable);
        }

        public void DeleteRecord(string Name, string Category)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                var queryItem = from _item in itemTable where _item.name == Name && _item.categoryRow.category == Category select _item;
                foreach (dbInsectiaSet.itemRow row in queryItem)
                {
                    row.Delete();
                }
            }
            else
            {
                var queryItem = from _item in itemTable where _item.categoryRow.category == Category select _item;
                var queryCategory = from _category in categoryTable where _category.category == Category select _category;
                foreach (dbInsectiaSet.itemRow row in queryItem)
                {
                    row.Delete();
                }
                foreach (dbInsectiaSet.categoryRow row in queryCategory)
                {
                    row.Delete();
                }
            }
        }
        public void Save(bool categoryOnly = false)
        {
            if (categoryOnly)
            {
                categoryTableAdapter.Update(categoryTable);
            }
            else
            {
                itemTableAdapter.Update(itemTable);
                categoryTableAdapter.Update(categoryTable);
            }
        }
    }
}
