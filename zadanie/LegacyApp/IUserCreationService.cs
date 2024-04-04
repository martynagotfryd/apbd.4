using System;

namespace LegacyApp;

public interface IUserCreationService
{
    bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId);

}