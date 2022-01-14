using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetAllVehiclesHandler : IRequestHandler<GetAllVehiclesQuery, List<VehicleView>>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public GetAllVehiclesHandler(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _mapper = mapper;
            _vehicleRepository = vehicleRepository;
        }
        public async Task<List<VehicleView>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return _mapper.Map<List<VehicleView>>(vehicles);
        }
    }
}
