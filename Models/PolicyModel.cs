
namespace PolicyApp.Models
{
    public class PolicyModel
    {
        public int PolicyId { get; set; }
        public string PolicyType { get; set; }
        public string  PolicyTitle { get; set; }
        public int SumAssured { get; set; }
        public int PremiumAmount { get; set; }
        public DateTime PolicyTerm { get; set; }
    }
}
