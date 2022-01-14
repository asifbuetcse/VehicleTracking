using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetTrackingCurrentByIdHandler : IRequestHandler<GetTrackingCurrentByIdQuery, TrackingCurrentView>
    {
        private readonly ITrackingCurrentRepository _trackingCurrentRepository;
        private readonly IMapper _mapper;

        public GetTrackingCurrentByIdHandler(ITrackingCurrentRepository trackingCurrentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _trackingCurrentRepository = trackingCurrentRepository;
            
        }

        public async Task<TrackingCurrentView> Handle(GetTrackingCurrentByIdQuery request, CancellationToken cancellationToken)
        {
            var trackingCurrent = await _trackingCurrentRepository.GetByIdAsync(request.Id);
            return trackingCurrent == null ? null : _mapper.Map<TrackingCurrentView>(trackingCurrent);
        }
    }
}
