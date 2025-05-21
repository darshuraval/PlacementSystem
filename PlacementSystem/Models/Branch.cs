namespace PlacementSystem.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string Batch { get; set; } = string.Empty;
    }
}
