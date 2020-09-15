namespace MadLibs.Models
{
    public class LibVariable
    {
        public string Name { get; set; }
        public string Verb1 { get; set; }
        public string Verb2 { get; set; }
        public string Verb3 { get; set; }
        public string Noun1 { get; set; }
        public string Noun2 { get; set; }
        public string Noun3 { get; set; }
        public string Adj1 { get; set; }
        public string Adj2 { get; set; }
        public string Adj3 { get; set; }

        public LibVariable(string name, string verb1, string verb2, string verb3, string noun1, string noun2, string noun3, string adj1, string adj2, string adj3)
        {
            Name = name;
            Verb1 = verb1;
            Verb2 = verb2;
            Verb3 = verb3;
            Noun1 = noun1;
            Noun2 = noun2;
            Noun3 = noun3;
            Adj1 = adj1;
            Adj2 = adj2;
            Adj3 = adj3;
        }
    }
}