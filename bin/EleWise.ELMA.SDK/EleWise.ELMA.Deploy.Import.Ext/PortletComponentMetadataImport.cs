using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component(Order = 10)]
internal class PortletComponentMetadataImportExtension : ComponentMetadataImportExtension<PortletComponentMetadata>
{
	private static PortletComponentMetadataImportExtension KS4Y3HElHUHvmCh0lCnG;

	public PortletComponentMetadataImportExtension(IComponentMetadataItemManager componentMetadataItemManager, IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IMetadataItemGroupUIManager metadataItemGroupUIManager, DataClassMetadataImportExtension dataClassMetadataImportExtension, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_0033, IL_0038
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(componentMetadataItemManager, componentMetadataItemHeaderManager, metadataItemGroupUIManager, dataClassMetadataImportExtension, actorContextService, featureFlagService);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void MergeMetadata(PortletComponentMetadata mdImported, PortletComponentMetadata mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0081, IL_0090
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				mdDraft.PersonalizationContext = (PortletPersonalizationMetadata)Pby09tElxyhewElH48fR(mdImported);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 4:
				return;
			default:
				if (isTestRead)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	internal static bool aD3KqYElAKNT1hhHRQxX()
	{
		return KS4Y3HElHUHvmCh0lCnG == null;
	}

	internal static PortletComponentMetadataImportExtension rlc3hUEl7noYOccP6m1u()
	{
		return KS4Y3HElHUHvmCh0lCnG;
	}

	internal static object Pby09tElxyhewElH48fR(object P_0)
	{
		return ((PortletComponentMetadata)P_0).PersonalizationContext;
	}
}
