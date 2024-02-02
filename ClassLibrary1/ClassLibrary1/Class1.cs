namespace ClassLibrary1
{
    public class Class1
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Class1(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}, {Description}";
        }
    }
}
