namespace powerBi_IA_Core.Models
{
    public class Log
    {
        public int LogID { get; set; }
        public int DatasetID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public string LogType { get; set; }  // Info, Erreur, Avertissement
        public DateTime CreatedAt { get; set; }

        public Log(int logID, int datasetID, int userID, string message, string logType)
        {
            LogID = logID;
            DatasetID = datasetID;
            UserID = userID;
            Message = message;
            LogType = logType;
            CreatedAt = DateTime.Now;
        }

        public void ChangeLogType(string newType)
        {
            LogType = newType;
        }

        public string FormatLog()
        {
            return $"[{LogType.ToUpper()}] - {Message}";
        }
    }
}
