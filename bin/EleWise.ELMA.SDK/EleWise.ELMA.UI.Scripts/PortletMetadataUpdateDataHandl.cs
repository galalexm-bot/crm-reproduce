using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Scripts;

internal sealed class PortletMetadataUpdateDataHandler : FormMetadataUpdateDataHandler
{
	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	internal static PortletMetadataUpdateDataHandler RPdcWsgkcBSZmJ4IGdx;

	public PortletMetadataUpdateDataHandler(FormMetadataItemHeaderManager formMetadataItemHeaderManager, IComponentMetadataItemManager componentMetadataItemManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		YtJ39Xg2DWiyjOaDaCS();
		base._002Ector(formMetadataItemHeaderManager);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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
			this.componentMetadataItemManager = componentMetadataItemManager;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is PortletMetadata;
	}

	public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
	{
		return new Guid[1] { ((PortletMetadata)updateResult.Metadata).Content.View.Uid };
	}

	protected override void CreateComponent(IMetadataUpdateResult updateResult)
	{
		int num = 1;
		int num2 = num;
		ComponentMetadataItem item = default(ComponentMetadataItem);
		PortletMetadata portletMetadata = default(PortletMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				item = componentMetadataItemManager.Create(PortletComponentMetadata.TypeUid, Guid.Empty, Guid.Empty, (string)VCP2bcge2XXyD45KbxV(portletMetadata));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				updateResult.Entities.Add(item);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				portletMetadata = (PortletMetadata)updateResult.Metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void YtJ39Xg2DWiyjOaDaCS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dJcy6ngnZYHtbn1f8xL()
	{
		return RPdcWsgkcBSZmJ4IGdx == null;
	}

	internal static PortletMetadataUpdateDataHandler tyCV1dgOJgY2p5cuW1V()
	{
		return RPdcWsgkcBSZmJ4IGdx;
	}

	internal static object VCP2bcge2XXyD45KbxV(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
