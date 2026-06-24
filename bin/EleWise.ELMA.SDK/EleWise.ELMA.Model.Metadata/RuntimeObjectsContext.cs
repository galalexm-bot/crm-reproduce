using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class RuntimeObjectsContext
{
	internal static RuntimeObjectsContext Ibv2FIbNQYOo9sw4ySR1;

	public IDictionary<Guid, IMetadata> LoadedMetadata { get; }

	public IDictionary<Guid, object> LoadedData { get; }

	public IDictionary<string, object> LoadedWithStringKey { get; }

	public ICollection<ILinkedObject> CheckedObjects { get; }

	public RuntimeObjectsContext()
	{
		//Discarded unreachable code: IL_001a
		gHPgE4bN8H00BfSye3OM();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				LoadedData = new Dictionary<Guid, object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num = 0;
				}
				break;
			default:
			{
				LoadedWithStringKey = new Dictionary<string, object>();
				int num2 = 3;
				num = num2;
				break;
			}
			case 1:
				LoadedMetadata = new Dictionary<Guid, IMetadata>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				CheckedObjects = new List<ILinkedObject>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void gHPgE4bN8H00BfSye3OM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FR2mMkbNC75r6JSXOD57()
	{
		return Ibv2FIbNQYOo9sw4ySR1 == null;
	}

	internal static RuntimeObjectsContext asyVeZbNvdY3OD5ZKEoN()
	{
		return Ibv2FIbNQYOo9sw4ySR1;
	}
}
