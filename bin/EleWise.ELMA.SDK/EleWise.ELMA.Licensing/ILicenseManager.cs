using System;
using System.Collections.Generic;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.Licensing;

public interface ILicenseManager
{
	string GetRegistrationKey();

	string GetRegistrationKey(ILicensedUnit unit);

	void ApplyAllActivationKeys();

	Guid AddActivationKey(string key);

	Guid AddActivationKey(string key, out IEnumerable<IStoreComponentInfo> newActivatedComponents);

	void RemoveActivationKey(Guid keyUid);

	Dictionary<Guid, string> GetActivationKeys();

	bool CanAddActivationKey();

	string GetActivationToken();
}
