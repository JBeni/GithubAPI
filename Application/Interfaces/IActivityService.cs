using Application.Handlers.Activities.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IActivityService
    {
        Task<List<EventResponse>> GetEvents(GetEventsQuery query);
    }
}
