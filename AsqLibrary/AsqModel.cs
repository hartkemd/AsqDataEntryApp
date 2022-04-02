
namespace AsqLibrary
{
    public class AsqModel
    {
        public string Id { get; set; }
        public DateTime DateAsqCompleted { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string CommunicationScore { get; set; }
        public string CommunicationRecommendation { get; set; }
        public string GrossMotorScore { get; set; }
        public string GrossMotorRecommendation { get; set; }
        public string FineMotorScore { get; set; }
        public string FineMotorRecommendation { get; set; }
        public string ProblemSolvingScore { get; set; }
        public string ProblemSolvingRecommendation { get; set; }
        public string PersonalSocialScore { get; set; }
        public string PersonalSocialRecommendation { get; set; }
    }
}
