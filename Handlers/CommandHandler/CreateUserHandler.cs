using AutoMapper;
using MediatR;
using VehicleTracking.Commands;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.CommandHandler
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserView>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserView> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _userRepository.AddAsync(request.User);
            return  _mapper.Map<UserView>(request.User);
        }
    }
}
