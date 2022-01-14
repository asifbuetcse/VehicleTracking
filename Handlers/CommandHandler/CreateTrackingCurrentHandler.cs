using AutoMapper;
using MediatR;
using VehicleTracking.Commands;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.CommandHandler
{
    public class CreateTrackingCurrentHandler : IRequestHandler<CreateTrackingCurrentCommand, TrackingCurrentView>
    {
        private readonly ITrackingCurrentRepository _trackingCurrentRepository;
        private readonly IMapper _mapper;

        public CreateTrackingCurrentHandler(ITrackingCurrentRepository trackingCurrentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _trackingCurrentRepository = trackingCurrentRepository;    
        }
        public async Task<TrackingCurrentView> Handle(CreateTrackingCurrentCommand request, CancellationToken cancellationToken)
        {
            await _trackingCurrentRepository.AddAsync(request.TrackingCurrent);
            return  _mapper.Map<TrackingCurrentView>(request.TrackingCurrent);
        }
    }
}
