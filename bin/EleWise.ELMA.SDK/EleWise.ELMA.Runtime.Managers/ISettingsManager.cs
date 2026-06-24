using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Managers;

public interface ISettingsManager
{
	void SetString(Guid uid, string key, string value);

	void SetStrings(Guid uid, IDictionary<string, string> strings);

	string GetString(Guid uid, string key);

	IDictionary<string, string> GetAllStrings(Guid uid);

	void RemoveString(Guid uid, string key);

	void RemoveAllStrings(Guid uid);
}
