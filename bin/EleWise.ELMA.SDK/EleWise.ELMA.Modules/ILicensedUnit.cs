using System;
using EleWise.ELMA.Licensing;

namespace EleWise.ELMA.Modules;

public interface ILicensedUnit
{
	Guid RegistrationKeyMethodUid { get; }

	string GetRegistrationKey();

	void ApplyActivationKey(string key);

	void CompleteLicensingInitialize();

	ILicenseInfo GetLicenseInfo();

	void UpdateLicenseInfo();

	byte[] GetActivationToken();
}
