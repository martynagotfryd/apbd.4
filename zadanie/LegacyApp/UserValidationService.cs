using System;

namespace LegacyApp;

public class UserValidationService : IUserValidationService
{
    private readonly ClientRepository _clientRepository;

    public UserValidationService(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public bool ValidateBasicInfo(string firstName, string lastName, string email)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            return false;
        }

        if (!email.Contains("@") || !email.Contains("."))
        {
            return false;
        }

        return true;
    }

    public bool ValidateAge(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        int age = now.Year - dateOfBirth.Year;

        if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
        {
            age--;
        }

        return age >= 21;
    }

    public bool ValidateClientType(int clientId, out Client client)
    {
        client = _clientRepository.GetById(clientId);

        return client != null;
    }
}
