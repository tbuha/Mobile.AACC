namespace WebApp.Models
{
    public class AccreditationStandart
    {
        public int AccreditationStandartId { get; set; }
        public Question[] Questions { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public StandartType StandartType { get; set; }
    }
}
