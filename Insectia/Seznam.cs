namespace Insectia
{
    class Seznam
    {
        public string Nazev { get; private set; }
        public string Kategorie { get; private set; }
        public string Obsah { get; private set; }

        public Seznam(string nazev, string kategorie, string obsah)
        {
            this.Nazev = nazev;
            this.Kategorie = kategorie;
            this.Obsah = obsah;
        }
        public void SetKategorie(string category)
        {
            this.Kategorie = category;
        }
    }
}
