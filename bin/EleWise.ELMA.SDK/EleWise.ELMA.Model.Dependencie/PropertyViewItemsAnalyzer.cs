using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal sealed class PropertyViewItemsAnalyzer : BaseViewItemAnalyzer<PropertyViewItem>
{
	internal static PropertyViewItemsAnalyzer GcxvVFhqEAMj39lKpxlS;

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<PropertyViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		foreach (PropertyViewItem viewItem in viewItems)
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			CS_0024_003C_003E8__locals0.propertyUid = viewItem.PropertyUid;
			if (!(metadata is ComponentMetadata componentMetadata) || componentMetadata.UserDefinedListInfos == null || !componentMetadata.UserDefinedListInfos.Any(delegate(UserDefinedListInfo udl)
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (!_003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(_003C_003Ec__DisplayClass0_0.mj2UunvbCxxmnepq2tKj(udl), CS_0024_003C_003E8__locals0.propertyUid))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 2:
						if (!udl.IncludedProperties.Any(delegate(IncludedProperty ip)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								case 1:
									if (_003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(_003C_003Ec__DisplayClass0_0.uMcgHLvb8PVVcPlbfs9B(ip), CS_0024_003C_003E8__locals0.propertyUid))
									{
										return true;
									}
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
									{
										num6 = 0;
									}
									break;
								default:
									return _003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(ip.OriginalPropertyUid, CS_0024_003C_003E8__locals0.propertyUid);
								}
							}
						}))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					default:
						if (!udl.GroupingProperties.Any(delegate(GroupingProperty gp)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return _003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(_003C_003Ec__DisplayClass0_0.aUf2DsvbZu0pftbVLq3A(gp), CS_0024_003C_003E8__locals0.propertyUid);
								case 1:
									if (_003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(_003C_003Ec__DisplayClass0_0.uMcgHLvb8PVVcPlbfs9B(gp), CS_0024_003C_003E8__locals0.propertyUid))
									{
										return true;
									}
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 1:
						return udl.AggregationProperties.Any(delegate(AggregationProperty ap)
						{
							//Discarded unreachable code: IL_002d, IL_003c
							int num7 = 2;
							int num8 = num7;
							while (true)
							{
								switch (num8)
								{
								case 2:
									if (_003C_003Ec__DisplayClass0_0.nAQiexvbvh1qIl4AkeTX(ap.Uid, CS_0024_003C_003E8__locals0.propertyUid))
									{
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
										{
											num8 = 1;
										}
										break;
									}
									goto default;
								default:
									return ap.OriginalPropertyUid == CS_0024_003C_003E8__locals0.propertyUid;
								case 1:
									return true;
								}
							}
						});
					}
					break;
				}
				return true;
			}))
			{
				ProcessPropertyViewItem(viewItem, contextMetadata, options, dictionary, dictionary2, dictionary3);
			}
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList()
		};
	}

	private static void ProcessPropertyViewItem(object propertyViewItem, object rootMetadata, object options, Dictionary<Guid, EnumDependency> enumDependencies, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies)
	{
		switch (((PropertyViewItem)propertyViewItem).PropertyParents.Count)
		{
		case 0:
			ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((PropertyViewItem)propertyViewItem).PropertyUid, (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies);
			break;
		case 1:
			ViewItemsAnalyzerHelper.CaseOnePropertyParents(((PropertyViewItem)propertyViewItem).PropertyUid, ((PropertyViewItem)propertyViewItem).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies);
			break;
		default:
			ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((PropertyViewItem)propertyViewItem).PropertyUid, ((PropertyViewItem)propertyViewItem).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies);
			break;
		}
	}

	public PropertyViewItemsAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CkRmhmhqCsgGjUwIOjaB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void CkRmhmhqCsgGjUwIOjaB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EagopvhqfYJYJFFS8eZu()
	{
		return GcxvVFhqEAMj39lKpxlS == null;
	}

	internal static PropertyViewItemsAnalyzer th6iJ6hqQK87OpeNGB3a()
	{
		return GcxvVFhqEAMj39lKpxlS;
	}
}
