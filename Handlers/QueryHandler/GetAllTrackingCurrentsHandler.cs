using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetAllTrackingCurrentsHandler : IRequestHandler<GetAllTrackingCurrentsQuery, List<TrackingCurrentView>>
    {
        private readonly ITrackingCurrentRepository _trackingCurrentRepository;
        private readonly IMapper _mapper;

        public GetAllTrackingCurrentsHandler(ITrackingCurrentRepository trackingCurrentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _trackingCurrentRepository = trackingCurrentRepository;
        }
        public async Task<List<TrackingCurrentView>> Handle(GetAllTrackingCurrentsQuery request, CancellationToken cancellationToken)
        {
            var trackingCurrents = await _trackingCurrentRepository.GetAllAsync();
            return _mapper.Map<List<TrackingCurrentView>>(trackingCurrents);
        }
    }
}
