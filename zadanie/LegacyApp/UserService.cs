using System;

namespace LegacyApp
{
    public class UserService
    {
        private readonly ClientRepository _clientRepository;
        private readonly UserCreditService _userCreditService;

        public UserService() : this(new ClientRepository(), new UserCreditService())
        {
        }

        public UserService(ClientRepository clientRepository, UserCreditService userCreditService)
        {
            _clientRepository = clientRepository;
            _userCreditService = userCreditService;
        }

        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            var userCreationService = new UserCreationService(_clientRepository, _userCreditService);
            return userCreationService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        }
    }
}