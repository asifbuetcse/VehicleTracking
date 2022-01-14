using AutoMapper;
using MediatR;
using VehicleTracking.Commands;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.CommandHandler
{
    public class CreateVehicleHandler : IRequestHandler<CreateVehicleCommand, VehicleView>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public CreateVehicleHandler(IVehicleRepository VehicleRepository, IMapper mapper)
        {
            _mapper = mapper;
            _vehicleRepository = VehicleRepository;
        }
        public async Task<VehicleView> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            await _vehicleRepository.AddAsync(request.Vehicle);
            return  _mapper.Map<VehicleView>(request.Vehicle);
        }
    }
}
