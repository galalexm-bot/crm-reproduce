using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IPasswordResolver
{
	Guid Uid { get; }

	string DisplayName { get; }

	string GenerateSalt();

	string Encrypt(string password, string salt);

	string Decrypt(string password, string salt);

	bool Check(string encryptedPassword, string salt, string password);
}
