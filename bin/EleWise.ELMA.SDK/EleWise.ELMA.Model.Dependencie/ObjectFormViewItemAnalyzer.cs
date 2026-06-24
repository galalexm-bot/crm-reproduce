using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal class ObjectFormViewItemAnalyzer : BaseViewItemAnalyzer<ObjectFormViewItem>
{
	internal static ObjectFormViewItemAnalyzer ybUYvqhR0DY8KPCwwG9Y;

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<ObjectFormViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		_ = contextMetadata.ModuleUid;
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		foreach (ObjectFormViewItem viewItem in viewItems)
		{
			switch (viewItem.PropertyParents.Count)
			{
			case 0:
				ViewItemsAnalyzerHelper.CaseZeroPropertyParents(viewItem.ContextPropertyUid, contextMetadata, options, dictionary, dictionary2, dictionary3);
				break;
			case 1:
				ViewItemsAnalyzerHelper.CaseOnePropertyParents(viewItem.ContextPropertyUid, viewItem.PropertyParents.ToArray(), contextMetadata, options, dictionary, dictionary2, dictionary3);
				break;
			default:
				ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(viewItem.ContextPropertyUid, viewItem.PropertyParents.ToArray(), contextMetadata, options, dictionary, dictionary2, dictionary3);
				break;
			}
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList()
		};
	}

	public ObjectFormViewItemAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YlfSmGhRm5ewJsHBuX4X()
	{
		return ybUYvqhR0DY8KPCwwG9Y == null;
	}

	internal static ObjectFormViewItemAnalyzer t6SnYkhRy9LJ3xc8Ayrg()
	{
		return ybUYvqhR0DY8KPCwwG9Y;
	}
}
