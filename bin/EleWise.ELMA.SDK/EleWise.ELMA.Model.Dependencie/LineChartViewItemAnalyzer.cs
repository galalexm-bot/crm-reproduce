using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Charts;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal sealed class LineChartViewItemAnalyzer : DynamicViewItemsAnalyzer
{
	internal static LineChartViewItemAnalyzer TfJRgvhRtv1FTtPoBV32;

	protected override bool CheckViewItem(ViewItem viewItem)
	{
		return viewItem is LineChartViewItem;
	}

	protected override void AdditionalProcess(IDynamicViewItem dynamicViewItem, Guid currentModuleUid, ClassMetadata metadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		LineChartViewItem lineChartViewItem = (LineChartViewItem)dynamicViewItem;
		CS_0024_003C_003E8__locals0.lineUid = lineChartViewItem.LinePropertyUid;
		if (CS_0024_003C_003E8__locals0.lineUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass1_0.D1PGcmvoIvlTDdhcIddm(a) == CS_0024_003C_003E8__locals0.lineUid);
			if (propertyMetadata != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata);
			}
		}
		CS_0024_003C_003E8__locals0.valueUid = lineChartViewItem.ValueUid;
		if (CS_0024_003C_003E8__locals0.valueUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass1_0.w9w31hvoVkgTquHeV0EG(a.Uid, CS_0024_003C_003E8__locals0.valueUid));
			if (propertyMetadata2 != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata2);
			}
		}
		CS_0024_003C_003E8__locals0.nameUid = lineChartViewItem.NameUid;
		if (CS_0024_003C_003E8__locals0.nameUid != Guid.Empty)
		{
			PropertyMetadata propertyMetadata3 = metadata.Properties.FirstOrDefault((PropertyMetadata a) => _003C_003Ec__DisplayClass1_0.w9w31hvoVkgTquHeV0EG(_003C_003Ec__DisplayClass1_0.D1PGcmvoIvlTDdhcIddm(a), CS_0024_003C_003E8__locals0.nameUid));
			if (propertyMetadata3 != null)
			{
				DependencyServiceHelper.ProcessMetadata(currentModuleUid, metadata, options, enumDependencies, entityDependencies, dataClassDependencies, propertyMetadata3);
			}
		}
	}

	public LineChartViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GA2m8hhR66GYhSiWuWWe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nUAjlyhRwFgBrehHhNYb()
	{
		return TfJRgvhRtv1FTtPoBV32 == null;
	}

	internal static LineChartViewItemAnalyzer whI4UuhR4B9bE0UmfoV8()
	{
		return TfJRgvhRtv1FTtPoBV32;
	}

	internal static void GA2m8hhR66GYhSiWuWWe()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
