namespace GraphSharp
{

    public class Node
    {
        internal Node(string category, string? name = null) 
        {
            if (String.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentException(nameof(category), "A Node must have a category");
            }

            Category = category;
            Name = name;
        }
        private readonly Guid _id = new();

        public Guid Id => _id;
        public string Category { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
