using System;

namespace WebApp.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int AgedCareCenterId { get; set; }
        public int AssessorId { get; set; }
        public DateTime ReportDate { get; set; }
        public double CompletionStatus { get; set; }
        public string Notes { get; set; }
        public QuestionReply[] QuestionReply { get; set; }

    }
}
