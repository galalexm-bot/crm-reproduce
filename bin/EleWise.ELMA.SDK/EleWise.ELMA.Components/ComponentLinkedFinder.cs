using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class ComponentLinkedFinder : LinkedFinderBase
{
	private readonly IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager;

	internal static ComponentLinkedFinder zvIKwEfGTlWpPYrxQlWP;

	public ComponentLinkedFinder(IEntityManager<ComponentMetadataItemHeader, long> componentMetadataItemManager)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.componentMetadataItemManager = componentMetadataItemManager;
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult findLinkedObjectsResult = new FindLinkedObjectsResult();
		foreach (ILinkedObject item in objectsToSearch)
		{
			IMetadata metadata = GetMetadata(item.Uid, context, findLinkedObjectsResult);
			if (metadata != null && metadata is ComponentMetadata)
			{
				FillDependencies(item.Uid, context, findLinkedObjectsResult);
			}
		}
		return findLinkedObjectsResult;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0076
		int num = 1;
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				default:
					if (componentMetadataItemHeader != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 3:
					obj = null;
					break;
				case 4:
					return ((ComponentMetadataItem)peiCEdfGOq5TKBhfoqN2(componentMetadataItemHeader)).Metadata as ComponentMetadata;
				case 1:
					componentMetadataItemHeader = componentMetadataItemManager.LoadOrNull(metadataId);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = peiCEdfGOq5TKBhfoqN2(componentMetadataItemHeader);
					break;
				}
				break;
			}
			if (obj == null)
			{
				break;
			}
			num = 4;
		}
		return null;
	}

	internal static object peiCEdfGOq5TKBhfoqN2(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Draft;
	}

	internal static bool G8t7rifGkuwsBR31baw6()
	{
		return zvIKwEfGTlWpPYrxQlWP == null;
	}

	internal static ComponentLinkedFinder Bk1sDYfGnuu4UTxKc8vt()
	{
		return zvIKwEfGTlWpPYrxQlWP;
	}
}
