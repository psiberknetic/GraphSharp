namespace GraphSharp
{
    public class Edge
    {
        internal Edge() { }
        private readonly Guid _id;
        public Guid Id => _id;
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
