namespace powerBi_IA_Core.Models
{
    public class DashboardWidget
    {
        public int WidgetID { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }  // Type de widget (bar, line, pie, etc.)
        public string Title { get; set; }  // Titre du widget
        public string DataSource { get; set; }  // URL ou identifiant de la source des données
        public string Options { get; set; }  // JSON stockant les options supplémentaires
        public int PositionX { get; set; }  // Position X dans la grille
        public int PositionY { get; set; }  // Position Y dans la grille
        public int SizeWidth { get; set; }  // Largeur du widget dans la grille
        public int SizeHeight { get; set; }  // Hauteur du widget dans la grille
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Constructeur
        public DashboardWidget(int widgetID, int userID, string type, string title, string dataSource, string options, int positionX, int positionY, int sizeWidth, int sizeHeight)
        {
            WidgetID = widgetID;
            UserID = userID;
            Type = type;
            Title = title;
            DataSource = dataSource;
            Options = options;
            PositionX = positionX;
            PositionY = positionY;
            SizeWidth = sizeWidth;
            SizeHeight = sizeHeight;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
