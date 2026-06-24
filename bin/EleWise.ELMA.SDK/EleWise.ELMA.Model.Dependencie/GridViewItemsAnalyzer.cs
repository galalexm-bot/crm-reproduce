using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal class GridViewItemsAnalyzer : BaseViewItemAnalyzer<GridViewItem>
{
	private static GridViewItemsAnalyzer hX05cAhqFwZ423Uh93ue;

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<GridViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		Guid moduleUid = contextMetadata.ModuleUid;
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		foreach (GridViewItem viewItem in viewItems)
		{
			Guid entityUid = viewItem.EntityUid;
			if (!(entityUid == Guid.Empty) && MetadataServiceContext.Service.GetMetadata(entityUid) is ClassMetadata metadata2)
			{
				DependencyServiceHelper.ProcessMetadata(moduleUid, metadata2, options, dictionary, dictionary2, dictionary3);
			}
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList()
		};
	}

	public GridViewItemsAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cn8cW2hqo14PMQbwrxW6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void cn8cW2hqo14PMQbwrxW6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool KlceflhqBm9xSCMAS0eg()
	{
		return hX05cAhqFwZ423Uh93ue == null;
	}

	internal static GridViewItemsAnalyzer JfCyB3hqWh1EyPhDE5bj()
	{
		return hX05cAhqFwZ423Uh93ue;
	}
}
