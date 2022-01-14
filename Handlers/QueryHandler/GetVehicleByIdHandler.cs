using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetVehicleByIdHandler : IRequestHandler<GetVehicleByIdQuery, VehicleView>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public GetVehicleByIdHandler(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _mapper = mapper;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<VehicleView> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(request.Id);
            return vehicle == null ? null : _mapper.Map<VehicleView>(vehicle);
        }
    }
}
