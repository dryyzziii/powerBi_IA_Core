namespace powerBi_IA_Core.Models
{
    public class Visualization
    {
        public int VisualizationID { get; set; }
        public int UserID { get; set; }
        public int DatasetID { get; set; }
        public string ChartType { get; set; }  // Bar, Line, Pie, etc.
        public string ChartData { get; set; }  // Assuming JSON is stored as a string
        public DateTime CreatedAt { get; set; }

        public Visualization(int visualizationID, int userID, int datasetID, string chartType, string chartData)
        {
            VisualizationID = visualizationID;
            UserID = userID;
            DatasetID = datasetID;
            ChartType = chartType;
            ChartData = chartData;
            CreatedAt = DateTime.Now;
        }

        public void UpdateChartType(string newType)
        {
            ChartType = newType;
        }

        public string PreviewChartData()
        {
            return ChartData;  // This would preview the chart data (JSON format).
        }
    }
}
