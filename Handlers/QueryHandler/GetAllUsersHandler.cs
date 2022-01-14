using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;

namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserView>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersHandler(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<List<UserView>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserView>>(users);
        }
    }
}
