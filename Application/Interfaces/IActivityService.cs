namespace Application.Interfaces
{
    public interface IActivityService
    {
        Task<List<EventResponse>> GetEvents(GetEventsQuery query);
        Task<List<EventResponse>> GetNetworkPublicEvents(GetNetworkPublicEventsQuery query);
        Task<List<EventResponse>> GetOrganizationPublicEvents(GetOrganizationPublicEventsQuery query);
        Task<List<EventResponse>> GetRepositoryEvents(GetRepositoryEventsQuery query);
        Task<List<EventResponse>> GetUserPublicEvents(GetUserPublicEventsQuery query);
        Task<List<EventResponse>> GetUserReceivedPublicEvents(GetUserReceivedPublicEventsQuery query);
    }
}
