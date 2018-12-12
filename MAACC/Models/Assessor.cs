namespace WebApp.Models
{
    public class Assessor
    {
        public int AssessorId { get; set; }
        public bool IsAdmin { get; set; }
        public int TeamId { get; set; }
        //public Team Team { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
    }
}
