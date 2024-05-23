namespace GraphSharp
{

    public class Node
    {
        internal Node() { }
        private readonly Guid _id = new();

        public Guid Id => _id;
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
