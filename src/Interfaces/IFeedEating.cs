namespace Trestlebridge.Interfaces
{
    public interface IFeedEating : IResource
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}