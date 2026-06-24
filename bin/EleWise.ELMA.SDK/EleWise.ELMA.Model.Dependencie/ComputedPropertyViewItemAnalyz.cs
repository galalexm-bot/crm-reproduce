using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal class ComputedPropertyViewItemAnalyzer : BaseViewItemAnalyzer<ViewItem>
{
	private static ComputedPropertyViewItemAnalyzer FrOZhZhR3L1YcdBvuepf;

	protected override bool CheckViewItem(ViewItem viewItem)
	{
		return viewItem.DynamicProperties.Any((ComputedValue d) => _003C_003Ec.NGM9lcvoCvHJcbDMoYOT(d) == ComputedValueType.Property);
	}

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<ViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		_ = contextMetadata.ModuleUid;
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		foreach (ViewItem viewItem in viewItems)
		{
			foreach (ComputedValue dynamicProperty in viewItem.DynamicProperties)
			{
				if (dynamicProperty.ComputedValueType == ComputedValueType.Property && !(dynamicProperty.PropertyUid == Guid.Empty))
				{
					ComputedPropertyViewItem(dynamicProperty, contextMetadata, options, dictionary, dictionary2, dictionary3);
				}
			}
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList()
		};
	}

	private static (ClassMetadata, IPropertyMetadata) ComputedPropertyViewItem(object computedValue, object rootMetadata, object options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		return ((ComputedValue)computedValue).PropertyParents.Count switch
		{
			0 => ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((ComputedValue)computedValue).PropertyUid, (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			1 => ViewItemsAnalyzerHelper.CaseOnePropertyParents(((ComputedValue)computedValue).PropertyUid, ((ComputedValue)computedValue).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			_ => ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((ComputedValue)computedValue).PropertyUid, ((ComputedValue)computedValue).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
		};
	}

	public ComputedPropertyViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LhZP0khRDnxMP9rg2xE8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Eawp8mhRpPuHmkDq7AGC()
	{
		return FrOZhZhR3L1YcdBvuepf == null;
	}

	internal static ComputedPropertyViewItemAnalyzer oINBs4hRarn0ek0K55Kb()
	{
		return FrOZhZhR3L1YcdBvuepf;
	}

	internal static void LhZP0khRDnxMP9rg2xE8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
