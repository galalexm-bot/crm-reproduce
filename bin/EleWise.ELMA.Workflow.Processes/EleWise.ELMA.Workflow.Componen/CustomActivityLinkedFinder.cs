using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Components;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class CustomActivityLinkedFinder : LinkedFinderBase
{
	private readonly CustomActivityHeaderManager customActivityManager;

	internal static CustomActivityLinkedFinder GQoGGeNPUZjg6LUFc3M;

	public CustomActivityLinkedFinder(CustomActivityHeaderManager customActivityManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.customActivityManager = customActivityManager;
			num = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
			{
				num = 1;
			}
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		FindLinkedObjectsResult findLinkedObjectsResult = new FindLinkedObjectsResult();
		foreach (ILinkedObject item in objectsToSearch)
		{
			IMetadata metadata = GetMetadata(item.Uid, context, findLinkedObjectsResult);
			if (metadata != null && metadata is CustomActivityParameters md)
			{
				FillProperties(md, context, findLinkedObjectsResult);
			}
		}
		return findLinkedObjectsResult;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_009d
		int num = 4;
		int num2 = num;
		ICustomActivityHeader customActivityHeader = default(ICustomActivityHeader);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (customActivityHeader == null)
				{
					num2 = 2;
					break;
				}
				obj = JKEyboNTSiGIUXvTIWH(customActivityHeader);
				goto IL_00a9;
			default:
				return (IMetadata)bEBcd4NctSi25e7KvxZ(JKEyboNTSiGIUXvTIWH(customActivityHeader));
			case 1:
				return null;
			case 4:
				customActivityHeader = customActivityManager.LoadOrNull(metadataId);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				{
					obj = null;
					goto IL_00a9;
				}
				IL_00a9:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static bool pixcC6N4douOq6YkpiU()
	{
		return GQoGGeNPUZjg6LUFc3M == null;
	}

	internal static CustomActivityLinkedFinder KhMTcWN96oWJpEaCYSV()
	{
		return GQoGGeNPUZjg6LUFc3M;
	}

	internal static object JKEyboNTSiGIUXvTIWH(object P_0)
	{
		return ((ICustomActivityHeader)P_0).Draft;
	}

	internal static object bEBcd4NctSi25e7KvxZ(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}
}
