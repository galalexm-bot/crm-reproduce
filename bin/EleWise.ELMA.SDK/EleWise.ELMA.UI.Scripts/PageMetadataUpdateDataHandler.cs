using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Scripts;

internal sealed class PageMetadataUpdateDataHandler : FormMetadataUpdateDataHandler
{
	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	internal static PageMetadataUpdateDataHandler GtyRfwgCv9VmGDntkf6;

	public PageMetadataUpdateDataHandler(FormMetadataItemHeaderManager formMetadataItemHeaderManager, IComponentMetadataItemManager componentMetadataItemManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		Jtf11FgZwqXaBU35Pjh();
		base._002Ector(formMetadataItemHeaderManager);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is PageMetadata;
	}

	public override IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult)
	{
		return new Guid[1] { ((PageMetadata)updateResult.Metadata).Content.View.Uid };
	}

	protected override void CreateComponent(IMetadataUpdateResult updateResult)
	{
		int num = 1;
		int num2 = num;
		PageMetadata pageMetadata = default(PageMetadata);
		ComponentMetadataItem item = default(ComponentMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				pageMetadata = (PageMetadata)updateResult.Metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				item = (ComponentMetadataItem)saHMJwgIpZFyWIsMTnF(componentMetadataItemManager, PageComponentMetadata.TypeUid, Guid.Empty, Guid.Empty, HRwN7oguoY3k0J9k9Bs(pageMetadata));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				updateResult.Entities.Add(item);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void Jtf11FgZwqXaBU35Pjh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool mvVxDvgv2bdd822hXUv()
	{
		return GtyRfwgCv9VmGDntkf6 == null;
	}

	internal static PageMetadataUpdateDataHandler xtrV6mg8sSbQJCoyQOJ()
	{
		return GtyRfwgCv9VmGDntkf6;
	}

	internal static object HRwN7oguoY3k0J9k9Bs(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object saHMJwgIpZFyWIsMTnF(object P_0, Guid typeUid, Guid moduleUid, Guid groupUid, object P_4)
	{
		return ((IComponentMetadataItemManager)P_0).Create(typeUid, moduleUid, groupUid, (string)P_4);
	}
}
