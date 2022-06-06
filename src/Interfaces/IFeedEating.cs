namespace Trestlebridge.Interfaces
{
    public interface IFeedEating
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}