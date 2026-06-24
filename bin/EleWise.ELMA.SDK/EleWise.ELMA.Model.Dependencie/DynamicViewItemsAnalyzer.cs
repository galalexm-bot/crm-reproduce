using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal class DynamicViewItemsAnalyzer : BaseViewItemAnalyzer<IDynamicViewItem>
{
	internal static DynamicViewItemsAnalyzer uJhsAOhRYATLL4uiniVe;

	protected override bool CheckViewItem(ViewItem viewItem)
	{
		int num = 1;
		int num2 = num;
		IDynamicViewItem dynamicViewItem = default(IDynamicViewItem);
		while (true)
		{
			switch (num2)
			{
			default:
				return z4vV5chRcKlwDnH7f0Cq(yEigMnhRsGbsx1ljVI8l(dynamicViewItem), Guid.Empty);
			case 1:
				if ((dynamicViewItem = viewItem as IDynamicViewItem) == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<IDynamicViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		Guid moduleUid = contextMetadata.ModuleUid;
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		foreach (IDynamicViewItem viewItem in viewItems)
		{
			var (classMetadata, propertyMetadata) = ProcessDynamicViewItem(viewItem, contextMetadata, options, dictionary, dictionary2, dictionary3);
			if (classMetadata != null && propertyMetadata != null)
			{
				AdditionalProcess(viewItem, moduleUid, classMetadata, options, dictionary, dictionary2, dictionary3);
			}
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList()
		};
	}

	protected virtual void AdditionalProcess(IDynamicViewItem dynamicViewItem, Guid currentModuleUid, ClassMetadata metadata, DependencyServiceOptions options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
	}

	private static (ClassMetadata, IPropertyMetadata) ProcessDynamicViewItem(object dynamicViewItem, object rootMetadata, object options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		return ((IViewItemWithPropertyParents)dynamicViewItem).PropertyParents.Count switch
		{
			0 => ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((IDynamicViewItem)dynamicViewItem).PropertyUid, (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			1 => ViewItemsAnalyzerHelper.CaseOnePropertyParents(((IDynamicViewItem)dynamicViewItem).PropertyUid, ((IViewItemWithPropertyParents)dynamicViewItem).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			_ => ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((IDynamicViewItem)dynamicViewItem).PropertyUid, ((IViewItemWithPropertyParents)dynamicViewItem).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
		};
	}

	public DynamicViewItemsAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HwsRXDhRz6en2PSOmMsD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid yEigMnhRsGbsx1ljVI8l(object P_0)
	{
		return ((IDynamicViewItem)P_0).PropertyUid;
	}

	internal static bool z4vV5chRcKlwDnH7f0Cq(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool oUa3SkhRLphvnDcGQF5J()
	{
		return uJhsAOhRYATLL4uiniVe == null;
	}

	internal static DynamicViewItemsAnalyzer Wy1y97hRUFQgPn8dISEU()
	{
		return uJhsAOhRYATLL4uiniVe;
	}

	internal static void HwsRXDhRz6en2PSOmMsD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
