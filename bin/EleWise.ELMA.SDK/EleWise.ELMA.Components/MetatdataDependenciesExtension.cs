using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal class MetatdataDependenciesExtension : IDependenciesExtension
{
	private MetadataItemHeaderManager metadataItemHeaderManager;

	internal static MetatdataDependenciesExtension ieY04rfGF7cljcvdPMP7;

	public MetatdataDependenciesExtension(MetadataItemHeaderManager metadataItemHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JRY8LmfGoWn9oLqCnOWY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.metadataItemHeaderManager = metadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid)
	{
		List<IDependencyContainer> list = new List<IDependencyContainer>();
		IMetadataItem metadataItem = metadataItemHeaderManager.LoadOrNull(uid)?.Published;
		if (metadataItem != null)
		{
			if (metadataItem.Dependencies is MetadataDependencyContainer item)
			{
				list.Add(item);
			}
			if (metadataItem.ClientScriptModule?.Dependencies is ScriptModuleDependencyContainer item2)
			{
				list.Add(item2);
			}
		}
		return list;
	}

	internal static void JRY8LmfGoWn9oLqCnOWY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kGlmRZfGBekjXPVyq3ZG()
	{
		return ieY04rfGF7cljcvdPMP7 == null;
	}

	internal static MetatdataDependenciesExtension wwSt0YfGWcQnmDra1gJn()
	{
		return ieY04rfGF7cljcvdPMP7;
	}
}
