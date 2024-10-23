namespace powerBi_IA_Core.Models
{
    public class PredictionModel
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public PredictionModel(int modelID, string modelName, string description)
        {
            ModelID = modelID;
            ModelName = modelName;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }
    }
}
