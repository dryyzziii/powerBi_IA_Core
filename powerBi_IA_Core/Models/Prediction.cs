namespace powerBi_IA_Core.Models
{
    public class Prediction
    {
        public int PredictionID { get; set; }
        public int DatasetID { get; set; }
        public int UserID { get; set; }
        public string PredictionResult { get; set; }  // Assuming JSON is stored as a string
        public DateTime CreatedAt { get; set; }

        public Prediction(int predictionID, int datasetID, int userID, string predictionResult)
        {
            PredictionID = predictionID;
            DatasetID = datasetID;
            UserID = userID;
            PredictionResult = predictionResult;
            CreatedAt = DateTime.Now;
        }

        public string FormatPrediction()
        {
            // Simple string formatting example
            return $"Prediction Result: {PredictionResult}";
        }

        public void AddResultField(string fieldName, string value)
        {
            // Add a new field to the JSON result (you'd use a JSON library for this).
        }
    }
}
