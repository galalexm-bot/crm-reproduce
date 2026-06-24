using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Charts;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal sealed class ChartViewItemAnalyzer : DynamicViewItemsAnalyzer
{
	internal static ChartViewItemAnalyzer wiBBUHhRHnhtvjkwou6W;

	protected override bool CheckViewItem(ViewItem viewItem)
	{
		return viewItem is ChartViewItem;
	}

	protected override void AdditionalProcess(IDynamicViewItem dynamicViewItem, Guid currentModuleUid, ClassMetadata metadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		ChartViewItem chartViewItem = (ChartViewItem)dynamicViewItem;
		CS_0024_003C_003E8__locals0.valueUid = chartViewItem.ValueUid;
		if (CS_0024_003C_003E8__locals0.valueUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass1_0.oHPZ8MvoK94f4JcHjoZP(a.Uid, CS_0024_003C_003E8__locals0.valueUid));
			if (propertyMetadata != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata);
			}
		}
		CS_0024_003C_003E8__locals0.nameUid = chartViewItem.NameUid;
		if (CS_0024_003C_003E8__locals0.nameUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == CS_0024_003C_003E8__locals0.nameUid);
			if (propertyMetadata2 != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata2);
			}
		}
	}

	public ChartViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ISLt5yhRxIF6d6Zb7RlH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SHNBfNhRABa49M8jKMS8()
	{
		return wiBBUHhRHnhtvjkwou6W == null;
	}

	internal static ChartViewItemAnalyzer dYVBubhR7P4hqmQft4mi()
	{
		return wiBBUHhRHnhtvjkwou6W;
	}

	internal static void ISLt5yhRxIF6d6Zb7RlH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
