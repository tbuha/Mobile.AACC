namespace WebApp.Models
{
    public class QuestionReply
    {
        public int QuestionReplyId { get; set; }
        public int QuestionId { get; set; }
        public bool Response { get; set; }
        public string Notes { get; set; }
        public int ReportId { get; set; }
    }
}
