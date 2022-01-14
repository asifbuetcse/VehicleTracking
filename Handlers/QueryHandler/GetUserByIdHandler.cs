using AutoMapper;
using MediatR;
using VehicleTracking.Queries;
using VehicleTracking.Repositories.Interfaces;
using VehicleTracking.ViewModels;
namespace VehicleTracking.Handlers.QueryHandler
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserView>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserView> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);
            return user == null ? null : _mapper.Map<UserView>(user);
        }
    }
}
