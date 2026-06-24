using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Licensing.Storages;

public interface IActivationKeyStorage
{
	bool CanRead { get; }

	bool CanWrite { get; }

	Dictionary<Guid, string> GetActivationKeys();

	void AddActivationKey(Guid uid, string key);

	void RemoveActivationKey(Guid uid);
}
