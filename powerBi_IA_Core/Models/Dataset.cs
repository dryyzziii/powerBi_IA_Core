namespace powerBi_IA_Core.Models
{
    public class Dataset
    {
        public int DatasetID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceType { get; set; }  // CSV, API, Manual, etc.
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; }  // en cours, traité, erreur

        public Dataset(int datasetID, int userID, string name, string description, string sourceType, string status)
        {
            DatasetID = datasetID;
            UserID = userID;
            Name = name;
            Description = description;
            SourceType = sourceType;
            Status = status;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }

        public bool IsProcessed()
        {
            return Status == "traité";
        }
    }
}
