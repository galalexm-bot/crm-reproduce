using System;
using System.Collections;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Util;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

public abstract class BaseSkipEntityImportResolver : ISkipEntityImportResolver
{
	private static BaseSkipEntityImportResolver lZbXWgElMUkYL6j40RyK;

	public abstract bool IsSupported(Guid typeGuid);

	public abstract bool IsSkip(Dictionary<string, object> propValues, Dictionary<string, string> serviceData);

	protected virtual Guid GetId(Dictionary<string, object> propValues, string key)
	{
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(key) && propValues[key] != null)
		{
			if (propValues[key] is IDictionary dictionary && dictionary.Values.Count > 0 && Guid.TryParse(EnumerableExtensions.First((IEnumerable)dictionary.Values).ToString(), out result))
			{
				return result;
			}
			Guid.TryParse(propValues[key].ToString(), out result);
		}
		return result;
	}

	protected BaseSkipEntityImportResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FTWC1BElJf2LxfXHlAuC()
	{
		return lZbXWgElMUkYL6j40RyK == null;
	}

	internal static BaseSkipEntityImportResolver cqC8d6El9xJRcUbCyIe4()
	{
		return lZbXWgElMUkYL6j40RyK;
	}
}
