namespace powerBi_IA_Core.Models
{
    public class DataRecord
    {
        public int RecordID { get; set; }
        public int DatasetID { get; set; }
        public string Data { get; set; }  // Assuming JSON is stored as a string
        public DateTime CreatedAt { get; set; }

        public DataRecord(int recordID, int datasetID, string data)
        {
            RecordID = recordID;
            DatasetID = datasetID;
            Data = data;
            CreatedAt = DateTime.Now;
        }

        public string GetFieldValue(string fieldName)
        {
            // Assuming Data is a JSON string, you could deserialize it and retrieve the field value.
            // This is a simple example; in a real project, you'd likely use JSON deserialization.
            return $"Field value for {fieldName}";
        }

        public void AddField(string fieldName, string value)
        {
            // Add a new field to the JSON data (again, you would use a JSON library to achieve this).
        }
    }
}
