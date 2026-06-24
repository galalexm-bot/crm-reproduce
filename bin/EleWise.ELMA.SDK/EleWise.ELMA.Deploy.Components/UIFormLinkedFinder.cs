using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Components;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Components;

[Component]
internal sealed class UIFormLinkedFinder : LinkedFinderBase
{
	private readonly FormMetadataItemHeaderManager formMetadataManager;

	private static UIFormLinkedFinder SavG2iEsSjwkDVeCLuAU;

	public UIFormLinkedFinder(FormMetadataItemHeaderManager formMetadataManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tW5P8rEsqZUrD28KG7GZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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
			this.formMetadataManager = formMetadataManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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
			if (metadata == null || !(metadata is FormMetadata formMetadata))
			{
				continue;
			}
			EntityMetadata entityMetadata = null;
			if (formMetadata.GetTypeUid() == PortletMetadata.TypeUid)
			{
				PortletMetadata portletMetadata = formMetadata as PortletMetadata;
				if (portletMetadata?.Content != null)
				{
					entityMetadata = portletMetadata.Content.Context;
				}
			}
			if (formMetadata.GetTypeUid() == PageMetadata.TypeUid)
			{
				PageMetadata pageMetadata = formMetadata as PageMetadata;
				if (pageMetadata?.Content != null)
				{
					entityMetadata = pageMetadata.Content.Context;
				}
			}
			if (entityMetadata != null)
			{
				FillProperties(entityMetadata, context, findLinkedObjectsResult);
			}
		}
		return findLinkedObjectsResult;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_004e, IL_0058, IL_0067, IL_00c0
		int num = 5;
		int num2 = num;
		IFormMetadataItemHeader formMetadataItemHeader = default(IFormMetadataItemHeader);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				return S52jqDEsXlhd0M41MP3U(JcKjxhEsK8Ux7HeVnU3C(formMetadataItemHeader)) as FormMetadata;
			case 1:
				return null;
			default:
				obj = null;
				goto IL_00d1;
			case 5:
				formMetadataItemHeader = formMetadataManager.LoadOrNull(metadataId);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (formMetadataItemHeader != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 2:
				{
					obj = JcKjxhEsK8Ux7HeVnU3C(formMetadataItemHeader);
					goto IL_00d1;
				}
				IL_00d1:
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void tW5P8rEsqZUrD28KG7GZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool h2sNoXEsiKFbQJZ9mX45()
	{
		return SavG2iEsSjwkDVeCLuAU == null;
	}

	internal static UIFormLinkedFinder PMwxc6EsRJLW2l4M9gCD()
	{
		return SavG2iEsSjwkDVeCLuAU;
	}

	internal static object JcKjxhEsK8Ux7HeVnU3C(object P_0)
	{
		return ((IFormMetadataItemHeader)P_0).Draft;
	}

	internal static object S52jqDEsXlhd0M41MP3U(object P_0)
	{
		return ((IFormMetadataItem)P_0).Metadata;
	}
}
