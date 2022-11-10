namespace BootcampApplication.model
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public String Feedback { get; set; }
        public SubscriptionResult Result { get; set; }
        public int BootcampId { get; set; }
        public virtual Bootcamp Bootcamp { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

    public enum SubscriptionResult
    {
        Passed,
        Failed,
        Pending,
        WaitList
    }
}