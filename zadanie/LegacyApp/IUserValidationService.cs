using System;

namespace LegacyApp;

public interface IUserValidationService
{
    bool ValidateBasicInfo(string firstName, string lastName, string email);
    bool ValidateAge(DateTime dateOfBirth);
    bool ValidateClientType(int clientId, out Client client);
}