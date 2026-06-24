using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Dependencies.Analyzers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

[Service]
internal sealed class DependencyService : IDependencyService
{
	private readonly IEnumerable<IViewItemAnalyzer> viewItemAnalyzers;

	internal static DependencyService sp0IUXbvK8bdSDlJQl18;

	public DependencyService(IEnumerable<IViewItemAnalyzer> viewItemAnalyzers)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.viewItemAnalyzers = viewItemAnalyzers;
	}

	public MetadataDependencyContainer GetClassMetadataDependencies(ClassMetadata contextMetadata, IMetadata metadata, IEnumerable<FormViewItem> forms, DependencyServiceOptions options = null)
	{
		Contract.ArgumentNotNull(contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643803557));
		DependencyAnalysisResult dependencyAnalysisResult = AnalyzeMetadata(contextMetadata, options);
		MetadataDependencyContainer metadataDependencyContainer = new MetadataDependencyContainer();
		metadataDependencyContainer.EntityDependencies.AddRange(dependencyAnalysisResult.EntityDependencies);
		metadataDependencyContainer.EnumDependencies.AddRange(dependencyAnalysisResult.EnumDependencies);
		metadataDependencyContainer.FunctionDependencies.AddRange(dependencyAnalysisResult.FunctionDependencies);
		metadataDependencyContainer.DataClassDependencies.AddRange(dependencyAnalysisResult.DataClassDependencies);
		foreach (FormViewItem form in forms)
		{
			DependencyAnalysisResult dependencyAnalysisResult2 = SimpleFormDependencyAnalysis(contextMetadata, metadata, form);
			FormViewItemDependencyContainer formViewItemDependencyContainer = new FormViewItemDependencyContainer
			{
				FormUid = form.Uid
			};
			formViewItemDependencyContainer.EnumDependencies.AddRange(dependencyAnalysisResult2.EnumDependencies);
			formViewItemDependencyContainer.EntityDependencies.AddRange(dependencyAnalysisResult2.EntityDependencies);
			formViewItemDependencyContainer.DataClassDependencies.AddRange(dependencyAnalysisResult2.DataClassDependencies);
			formViewItemDependencyContainer.ComponentDependencies.AddRange(dependencyAnalysisResult2.ComponentDependencies);
			metadataDependencyContainer.FormDependencies.Add(formViewItemDependencyContainer);
		}
		return metadataDependencyContainer;
	}

	public DependencyAnalysisResult SimpleFormDependencyAnalysis(ClassMetadata contextMetadata, IMetadata metadata, FormViewItem form, DependencyServiceOptions options = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				F9eHGZbvnkXa4Mk1Y2ru(contextMetadata, c2gICTbvk65apcXGfW2n(-576149596 ^ -576165882));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return AnalyzeForm(contextMetadata, metadata, form, options);
			default:
				F9eHGZbvnkXa4Mk1Y2ru(form, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70011450));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public DependencyAnalysisResult SimpleFunctionDependencyAnalysis(FunctionMetadata metadata, DependencyServiceOptions options)
	{
		int num = 2;
		Dictionary<Guid, DataClassDependency> dictionary3 = default(Dictionary<Guid, DataClassDependency>);
		Dictionary<Guid, EnumDependency> dictionary = default(Dictionary<Guid, EnumDependency>);
		Dictionary<Guid, EntityDependency> dictionary2 = default(Dictionary<Guid, EntityDependency>);
		Guid currentModuleUid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					dictionary3 = new Dictionary<Guid, DataClassDependency>();
					num2 = 5;
					continue;
				case 6:
					return new DependencyAnalysisResult
					{
						EnumDependencies = dictionary.Values.ToList(),
						EntityDependencies = dictionary2.Values.ToList(),
						DataClassDependencies = dictionary3.Values.ToList()
					};
				case 5:
					DependencyServiceHelper.AnalyseTypeSignature((TypeSignature)n0YRSObv2XAxpoX0UQlM(metadata), dictionary3, dictionary2, dictionary, currentModuleUid, options);
					num2 = 4;
					continue;
				case 1:
					break;
				case 4:
					DependencyServiceHelper.AnalyseTypeSignature((TypeSignature)jlmiATbve17BFPFXcRrv(metadata), dictionary3, dictionary2, dictionary, currentModuleUid, options);
					num2 = 6;
					continue;
				case 3:
					dictionary2 = new Dictionary<Guid, EntityDependency>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					currentModuleUid = HEKy63bvOApmSq91eyFs(metadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			dictionary = new Dictionary<Guid, EnumDependency>();
			num = 3;
		}
	}

	public CompatibilityResult CheckFunctionCompatibility(FunctionDependency current, FunctionDependency candidate)
	{
		//Discarded unreachable code: IL_0035, IL_004b
		int num = 1;
		int num2 = num;
		int success;
		CompatibilityResult compatibilityResult2 = default(CompatibilityResult);
		CompatibilityResult compatibilityResult = default(CompatibilityResult);
		while (true)
		{
			switch (num2)
			{
			case 4:
				success = (orUEiNbvNLsroV3H7Pjg(compatibilityResult2) ? 1 : 0);
				break;
			default:
				compatibilityResult2 = (CompatibilityResult)kgbPeabvPAtDlQBNfhBw(axXn7dbv1ladSSjMWnDj(current), axXn7dbv1ladSSjMWnDj(candidate));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (!orUEiNbvNLsroV3H7Pjg(compatibilityResult))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 4;
			case 1:
				compatibilityResult = (CompatibilityResult)kgbPeabvPAtDlQBNfhBw(current.ParameterType, candidate.ParameterType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				success = 0;
				break;
			}
			break;
		}
		return new CompatibilityResult((byte)success != 0, ((IEnumerable<string>)iiPPVpbv3BQSSI4Ofp5X(compatibilityResult)).Concat((IEnumerable<string>)iiPPVpbv3BQSSI4Ofp5X(compatibilityResult2)));
	}

	public CompatibilityResult CheckDataClassCompatibility(DataClassDependency current, DataClassDependency candidate)
	{
		return (CompatibilityResult)sjZe6YbvpKOvBcW3EKPb(current, candidate);
	}

	public static DependencyAnalysisResult CombineAnalysis(params DependencyAnalysisResult[] results)
	{
		return new DependencyAnalysisResult
		{
			FunctionDependencies = DependencyHelper.CombineDependencies(results.SelectMany((DependencyAnalysisResult r) => r.FunctionDependencies)).ToList(),
			EnumDependencies = DependencyHelper.CombineDependencies(results.SelectMany((DependencyAnalysisResult r) => r.EnumDependencies)).ToList(),
			EntityDependencies = DependencyHelper.CombineClassDependencies(results.SelectMany((DependencyAnalysisResult r) => r.EntityDependencies)).ToList(),
			DataClassDependencies = DependencyHelper.CombineClassDependencies(results.SelectMany((DependencyAnalysisResult r) => r.DataClassDependencies)).ToList(),
			ComponentDependencies = results.SelectMany((DependencyAnalysisResult a) => a.ComponentDependencies).ToList()
		};
	}

	public void FillDependencies(ComponentMetadata componentMetadata, IEnumerable<Guid> ignoredMetadata, DependencyServiceOptions options = null)
	{
		HashSet<Guid> hashSet = ignoredMetadata.ToHashSet();
		using (MetadataServiceContext.Extend(componentMetadata.GetMetadataToRegister().ToList()))
		{
			DependencyAnalysisResult dependencyAnalysisResult = SimpleDependencyAnalysis(componentMetadata, options);
			componentMetadata.EnumDependencies = Filter(dependencyAnalysisResult.EnumDependencies, hashSet).ToList();
			componentMetadata.EntityDependencies = Filter(dependencyAnalysisResult.EntityDependencies, hashSet).ToList();
			componentMetadata.DataClassDependencies = Filter(dependencyAnalysisResult.DataClassDependencies, hashSet).ToList();
			componentMetadata.FunctionDependencies = Filter(dependencyAnalysisResult.FunctionDependencies, hashSet).ToList();
			hashSet.Add(componentMetadata.Uid);
			componentMetadata.ComponentDependencies = Filter(dependencyAnalysisResult.ComponentDependencies, hashSet).ToList();
		}
	}

	public ModuleDependency CalculateDependencies(ModuleInfoMetadata module, IEnumerable<Guid> ignoredMetadata)
	{
		Contract.ArgumentNotNull(module, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740399860));
		DependencyAnalysisResult dependencyAnalysisResult = new DependencyAnalysisResult();
		DependencyAnalysisResult dependencyAnalysisResult2 = new DependencyAnalysisResult();
		HashSet<Guid> ignoredMetadata2 = ignoredMetadata.ToHashSet();
		foreach (ComponentMetadata component in module.Components)
		{
			using (MetadataServiceContext.Extend(component.DataClasses))
			{
				DependencyAnalysisResult dependencyAnalysisResult3 = SimpleDependencyAnalysis(component, null);
				dependencyAnalysisResult3.DataClassDependencies = Filter(dependencyAnalysisResult3.DataClassDependencies, ignoredMetadata2).ToList();
				dependencyAnalysisResult2 = CombineAnalysis(dependencyAnalysisResult2, dependencyAnalysisResult3);
			}
		}
		dependencyAnalysisResult = CombineAnalysis(dependencyAnalysisResult, dependencyAnalysisResult2);
		DependencyAnalysisResult dependencyAnalysisResult4 = module.Functions.Select((FunctionMetadata function) => SimpleFunctionDependencyAnalysis(function, null)).Aggregate(new DependencyAnalysisResult(), (DependencyAnalysisResult current, DependencyAnalysisResult functionDependencyAnalysis) => CombineAnalysis(current, functionDependencyAnalysis));
		dependencyAnalysisResult = CombineAnalysis(dependencyAnalysisResult, dependencyAnalysisResult4);
		ModuleDependency moduleDependency = new ModuleDependency();
		moduleDependency.DataClasses.AddRange(dependencyAnalysisResult.DataClassDependencies);
		moduleDependency.Functions.AddRange(dependencyAnalysisResult.FunctionDependencies);
		moduleDependency.Components.AddRange(dependencyAnalysisResult.ComponentDependencies);
		moduleDependency.EntityDependencies.AddRange(dependencyAnalysisResult.EntityDependencies);
		moduleDependency.EnumDependencies.AddRange(dependencyAnalysisResult.EnumDependencies);
		return moduleDependency;
	}

	private DependencyAnalysisResult SimpleDependencyAnalysis(ComponentMetadata componentMetadata, DependencyServiceOptions options)
	{
		int num = 5;
		int num2 = num;
		DependencyAnalysisResult dependencyAnalysisResult = default(DependencyAnalysisResult);
		DependencyAnalysisResult dependencyAnalysisResult2 = default(DependencyAnalysisResult);
		DependencyAnalysisResult dependencyAnalysisResult4 = default(DependencyAnalysisResult);
		DependencyAnalysisResult dependencyAnalysisResult3 = default(DependencyAnalysisResult);
		while (true)
		{
			switch (num2)
			{
			case 5:
				F9eHGZbvnkXa4Mk1Y2ru(componentMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29152965));
				num2 = 4;
				break;
			case 4:
				dependencyAnalysisResult = AnalyzeMetadata((ClassMetadata)KrDA0TbvDVGKQFEBT9RN(QTI2A7bvaRJF5HHavBNU(componentMetadata)), options);
				num2 = 2;
				break;
			case 2:
				dependencyAnalysisResult2 = AnalyzeForm(componentMetadata, options);
				num2 = 3;
				break;
			default:
				dependencyAnalysisResult4 = AnalyzeUserDefinedListInfos(componentMetadata, options);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				dependencyAnalysisResult3 = AnalyzeImplementations(componentMetadata, options);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return CombineAnalysis(dependencyAnalysisResult, dependencyAnalysisResult2, dependencyAnalysisResult3, dependencyAnalysisResult4);
			}
		}
	}

	private DependencyAnalysisResult AnalyzeUserDefinedListInfos(ComponentMetadata componentMetadata, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_00fb, IL_010a, IL_014b, IL_015a, IL_018e, IL_019d, IL_0222, IL_0231, IL_02a1, IL_02b4, IL_030a, IL_0319, IL_0329, IL_03b8, IL_03e7, IL_03f6, IL_04c0, IL_04d3
		int num = 2;
		List<UserDefinedListInfo>.Enumerator enumerator = default(List<UserDefinedListInfo>.Enumerator);
		UserDefinedListInfo current = default(UserDefinedListInfo);
		IMetadata metadata = default(IMetadata);
		Dictionary<Guid, EnumDependency> dictionary3 = default(Dictionary<Guid, EnumDependency>);
		EnumMetadata metadata2 = default(EnumMetadata);
		List<IncludedProperty>.Enumerator enumerator2 = default(List<IncludedProperty>.Enumerator);
		IncludedProperty current2 = default(IncludedProperty);
		ClassMetadata rootMetadata = default(ClassMetadata);
		Dictionary<Guid, EntityDependency> dictionary = default(Dictionary<Guid, EntityDependency>);
		Dictionary<Guid, DataClassDependency> dictionary2 = default(Dictionary<Guid, DataClassDependency>);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		EntityMetadata metadata3 = default(EntityMetadata);
		Guid currentModuleUid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto end_IL_0012;
				case 6:
					enumerator = componentMetadata.UserDefinedListInfos.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_02df:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num3 = 2;
								}
								goto IL_0098;
							}
							goto IL_0133;
							IL_0133:
							current = enumerator.Current;
							num3 = 3;
							goto IL_0098;
							IL_0098:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 3:
									metadata = ((IMetadataService)olYCngbvtaEyOhjAnm8M()).GetMetadata(fpnHsdbvwQcMsY9OeIVr(current), loadImplementation: true);
									num3 = 16;
									continue;
								case 17:
									DependencyServiceHelper.AddEnumDependency(dictionary3, metadata2);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num3 = 0;
									}
									continue;
								case 14:
									try
									{
										while (true)
										{
											IL_025f:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 2;
												goto IL_01ac;
											}
											goto IL_023c;
											IL_01ac:
											while (true)
											{
												switch (num5)
												{
												case 1:
													if (CrNTHAbvHLlWCoWxKx2A(rolJUebv6FAPa9koNeXH(current2), Guid.Empty))
													{
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
														{
															num5 = 0;
														}
														continue;
													}
													goto case 3;
												case 3:
												{
													ProcessDynamicViewItem(current2, rootMetadata, options, dictionary, dictionary2, dictionary3);
													int num6 = 5;
													num5 = num6;
													continue;
												}
												case 4:
													break;
												default:
													goto IL_025f;
												case 2:
													goto end_IL_025f;
												}
												break;
											}
											goto IL_023c;
											IL_023c:
											current2 = enumerator2.Current;
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num5 = 1;
											}
											goto IL_01ac;
											continue;
											end_IL_025f:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto case 8;
								case 8:
								case 10:
								case 15:
									if ((dataClassMetadata = metadata as DataClassMetadata) == null)
									{
										num4 = 9;
										goto IL_0094;
									}
									goto case 13;
								case 1:
								case 11:
								case 20:
									goto IL_02df;
								case 2:
								case 9:
									if ((metadata3 = metadata as EntityMetadata) == null)
									{
										num4 = 4;
										goto IL_0094;
									}
									goto case 6;
								case 13:
									if (!HObJU3bvAJYhwU8jRwrx(dataClassMetadata, currentModuleUid, options))
									{
										num3 = 19;
										continue;
									}
									goto IL_02df;
								case 4:
								case 18:
									if ((metadata2 = metadata as EnumMetadata) != null)
									{
										num3 = 17;
										continue;
									}
									goto IL_02df;
								case 7:
									enumerator2 = current.IncludedProperties.GetEnumerator();
									num3 = 14;
									continue;
								case 12:
									if ((rootMetadata = metadata as ClassMetadata) == null)
									{
										num3 = 15;
										continue;
									}
									goto case 7;
								case 16:
									if (!odEwB2bv4pc624v6UdPE(fpnHsdbvwQcMsY9OeIVr(current), Guid.Empty))
									{
										num3 = 10;
										continue;
									}
									goto case 12;
								case 19:
									DependencyServiceHelper.AddClassDependency(dictionary2, gFoZYTbv71f0MyEiORob(dataClassMetadata), dataClassMetadata, (DataClassMetadata m) => m.GetSignature(simple: true));
									num4 = 11;
									goto IL_0094;
								case 6:
									DependencyServiceHelper.AddClassDependency(dictionary, fpnHsdbvwQcMsY9OeIVr(current), metadata3, (EntityMetadata m) => m.GetSignature(simple: true));
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num3 = 2;
									}
									continue;
								case 5:
									goto end_IL_02df;
									IL_0094:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0133;
							continue;
							end_IL_02df:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					break;
				case 5:
					dictionary2 = new Dictionary<Guid, DataClassDependency>();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
				{
					object obj = KrDA0TbvDVGKQFEBT9RN(QTI2A7bvaRJF5HHavBNU(componentMetadata));
					new List<PropertyMetadata>();
					currentModuleUid = HEKy63bvOApmSq91eyFs(obj);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 3:
					dictionary = new Dictionary<Guid, EntityDependency>();
					num2 = 5;
					continue;
				case 4:
					break;
				}
				return new DependencyAnalysisResult
				{
					EntityDependencies = dictionary.Values.ToList(),
					DataClassDependencies = dictionary2.Values.ToList(),
					EnumDependencies = dictionary3.Values.ToList()
				};
				continue;
				end_IL_0012:
				break;
			}
			dictionary3 = new Dictionary<Guid, EnumDependency>();
			num = 3;
		}
	}

	private static (ClassMetadata, IPropertyMetadata) ProcessDynamicViewItem(object includedProperty, object rootMetadata, object options, Dictionary<Guid, EntityDependency> entityDependencies, Dictionary<Guid, DataClassDependency> dataClassDependencies, Dictionary<Guid, EnumDependency> enumDependencies)
	{
		return ((IncludedProperty)includedProperty).PropertyParents.Count switch
		{
			0 => ViewItemsAnalyzerHelper.CaseZeroPropertyParents(((UserDefinedListPropertyBase)includedProperty).OriginalPropertyUid, (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			1 => ViewItemsAnalyzerHelper.CaseOnePropertyParents(((UserDefinedListPropertyBase)includedProperty).OriginalPropertyUid, ((IncludedProperty)includedProperty).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
			_ => ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(((UserDefinedListPropertyBase)includedProperty).OriginalPropertyUid, ((IncludedProperty)includedProperty).PropertyParents.ToArray(), (ClassMetadata)rootMetadata, (DependencyServiceOptions)options, enumDependencies, entityDependencies, dataClassDependencies), 
		};
	}

	private DependencyAnalysisResult AnalyzeMetadata(ClassMetadata metadata, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_0059, IL_0063, IL_00fa, IL_0109, IL_0156, IL_0165, IL_0175, IL_01a8, IL_01b7, IL_0211, IL_0220, IL_0230, IL_0389, IL_0398, IL_04d6, IL_063a, IL_064d, IL_065c
		int num = 3;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		ActionSettings actionSettings = default(ActionSettings);
		Dictionary<Guid, DataClassDependency> dictionary = default(Dictionary<Guid, DataClassDependency>);
		Dictionary<Guid, EntityDependency> dictionary2 = default(Dictionary<Guid, EntityDependency>);
		Dictionary<Guid, EnumDependency> dictionary3 = default(Dictionary<Guid, EnumDependency>);
		Guid moduleUid = default(Guid);
		EnumMetadata metadata2 = default(EnumMetadata);
		Guid functionHeaderUid = default(Guid);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		Dictionary<Guid, FunctionDependency> dictionary4 = default(Dictionary<Guid, FunctionDependency>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				enumerator = metadata.Properties.GetEnumerator();
				num2 = 4;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num3 = 12;
							}
							goto IL_0067;
						}
						goto IL_051e;
						IL_051e:
						current = enumerator.Current;
						num3 = 7;
						goto IL_0067;
						IL_0067:
						while (true)
						{
							switch (num3)
							{
							case 11:
							case 23:
								if (!XUJ2ZtbvyskaFTLMXgaN(bb7abGbvxNe4cAO6Upw4(current)))
								{
									num3 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num3 = 22;
									}
									continue;
								}
								goto case 16;
							case 21:
								break;
							case 19:
								goto IL_017f;
							case 31:
								DependencyServiceHelper.AnalyseTypeSignature((TypeSignature)ejriZ4bv9QGhOis83FfM(actionSettings), dictionary, dictionary2, dictionary3, moduleUid, options);
								num3 = 2;
								continue;
							case 8:
								if (!JkB6hRbvmTGcZLBeFDWM(bb7abGbvxNe4cAO6Upw4(current)))
								{
									num3 = 21;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
									{
										num3 = 23;
									}
									continue;
								}
								goto IL_0498;
							case 12:
								goto IL_023a;
							case 15:
								throw new MetadataLoadException(SR.T((string)c2gICTbvk65apcXGfW2n(0x17ADCCD8 ^ 0x17AF7F56), CAXCMsbv08Jb2SVw8DtR(current)));
							case 16:
								if ((metadata2 = MetadataServiceContext.Service.GetMetadata(CAXCMsbv08Jb2SVw8DtR(current)) as EnumMetadata) != null)
								{
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num3 = 10;
									}
									continue;
								}
								goto case 29;
							case 22:
							case 24:
								if (!M8wDM1bvMoEWJXaNkqmY(bb7abGbvxNe4cAO6Upw4(current)))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 29:
								throw new MetadataLoadException(SR.T((string)c2gICTbvk65apcXGfW2n(0x2A7797B7 ^ 0x2A75246B), current.SubTypeUid));
							case 20:
								DependencyServiceHelper.AddEnumDependency(dictionary3, metadata2);
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num3 = 32;
								}
								continue;
							case 7:
								if (DependencyServiceHelper.IsDataClass(bb7abGbvxNe4cAO6Upw4(current), CAXCMsbv08Jb2SVw8DtR(current)))
								{
									num3 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								goto case 8;
							case 2:
							{
								object obj = xFRfskbvdMR3v6c6ytRF(actionSettings);
								if (obj == null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num3 = 28;
									}
									continue;
								}
								if (((ActionValue)obj).CodeType == CodeType.GlobalFunction)
								{
									goto case 14;
								}
								goto case 28;
							}
							case 10:
								DependencyServiceHelper.AnalyseTypeSignature(actionSettings.ReturnType, dictionary, dictionary2, dictionary3, moduleUid, options);
								num3 = 31;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num3 = 3;
								}
								continue;
							case 18:
								throw new MetadataLoadException(SR.T((string)c2gICTbvk65apcXGfW2n(-281842504 ^ -281945914), functionHeaderUid));
							case 4:
								actionSettings = (ActionSettings)Rlr339bvJo5JYX4pe2h4(current);
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								goto IL_0498;
							default:
								goto end_IL_0067;
							case 14:
								functionHeaderUid = actionSettings.DefaultValue.FunctionHeaderUid;
								num3 = 19;
								continue;
							case 25:
								goto IL_051e;
							case 17:
								goto IL_0531;
							case 27:
								throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5117B1C1), CAXCMsbv08Jb2SVw8DtR(current)));
							case 28:
								num3 = 5;
								continue;
							case 13:
								goto end_IL_04e0;
							}
							goto IL_013e;
							IL_023a:
							if ((dataClassMetadata = ((IMetadataService)olYCngbvtaEyOhjAnm8M()).GetMetadata(CAXCMsbv08Jb2SVw8DtR(current), loadImplementation: true) as DataClassMetadata) == null)
							{
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num3 = 15;
								}
								continue;
							}
							if (HObJU3bvAJYhwU8jRwrx(dataClassMetadata, moduleUid, options))
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num3 = 9;
								}
								continue;
							}
							goto IL_0531;
							IL_0498:
							if (!(((IMetadataService)olYCngbvtaEyOhjAnm8M()).GetMetadata(CAXCMsbv08Jb2SVw8DtR(current), loadImplementation: true) is EntityMetadata metadata3))
							{
								num3 = 26;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num3 = 27;
								}
							}
							else
							{
								DependencyServiceHelper.AddClassDependency(dictionary2, current.SubTypeUid, metadata3, (EntityMetadata m) => m.GetSignature(simple: true));
								num3 = 3;
							}
							continue;
							IL_017f:
							if ((functionMetadata = ((IMetadataService)olYCngbvtaEyOhjAnm8M()).GetMetadata(functionHeaderUid, loadImplementation: true) as FunctionMetadata) == null)
							{
								num3 = 18;
								continue;
							}
							if (HObJU3bvAJYhwU8jRwrx(functionMetadata, moduleUid, options))
							{
								num3 = 26;
								continue;
							}
							goto IL_013e;
							IL_013e:
							DependencyServiceHelper.AddFunctionDependency(dictionary4, functionMetadata);
							num3 = 6;
							continue;
							IL_0531:
							DependencyServiceHelper.AddClassDependency(dictionary, gFoZYTbv71f0MyEiORob(dataClassMetadata), dataClassMetadata, (DataClassMetadata m) => m.GetSignature(simple: true));
							num3 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num3 = 30;
							}
							continue;
							end_IL_0067:
							break;
						}
						continue;
						end_IL_04e0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 1:
				dictionary4 = new Dictionary<Guid, FunctionDependency>();
				num2 = 5;
				break;
			case 2:
				dictionary3 = new Dictionary<Guid, EnumDependency>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return new DependencyAnalysisResult
				{
					EnumDependencies = dictionary3.Values.ToList(),
					EntityDependencies = dictionary2.Values.ToList(),
					DataClassDependencies = dictionary.Values.ToList(),
					FunctionDependencies = dictionary4.Values.ToList()
				};
			case 3:
				moduleUid = metadata.ModuleUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 2;
				}
				break;
			default:
				dictionary2 = new Dictionary<Guid, EntityDependency>();
				num2 = 6;
				break;
			case 6:
				dictionary = new Dictionary<Guid, DataClassDependency>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private DependencyAnalysisResult AnalyzeForm(ClassMetadata contextMetadata, IMetadata metadata, FormViewItem form, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00f8, IL_0107
		int num = 7;
		int num2 = num;
		DependencyAnalysisResult[] array2 = default(DependencyAnalysisResult[]);
		int num3 = default(int);
		IViewItemAnalyzer[] array = default(IViewItemAnalyzer[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return CombineAnalysis(array2);
			case 3:
			case 4:
				array2[num3] = array[num3].Analyse(contextMetadata, metadata, form, options);
				num2 = 8;
				break;
			case 5:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				array2 = new DependencyAnalysisResult[array.Length];
				num2 = 5;
				break;
			case 7:
				array = viewItemAnalyzers.ToArray();
				num2 = 6;
				break;
			default:
				if (num3 < array.Length)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 8:
				num3++;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private DependencyAnalysisResult AnalyzeForm(ComponentMetadata componentMetadata, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_00fe
		int num = 7;
		int num3 = default(int);
		ComponentContextMetadata componentContextMetadata = default(ComponentContextMetadata);
		DependencyAnalysisResult[] array = default(DependencyAnalysisResult[]);
		IViewItemAnalyzer[] array2 = default(IViewItemAnalyzer[]);
		FormViewItem formViewItem = default(FormViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3++;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					componentContextMetadata = (ComponentContextMetadata)KrDA0TbvDVGKQFEBT9RN(QTI2A7bvaRJF5HHavBNU(componentMetadata));
					num2 = 6;
					continue;
				case 8:
					array = new DependencyAnalysisResult[array2.Length];
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					formViewItem = (FormViewItem)HwxbX1bvlQB1GbYN41JP(QTI2A7bvaRJF5HHavBNU(componentMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					num3 = 0;
					num2 = 3;
					continue;
				case 3:
				case 5:
					if (num3 >= array2.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return CombineAnalysis(array);
				case 1:
					goto end_IL_0012;
				case 4:
					break;
				}
				array[num3] = (DependencyAnalysisResult)iT5YvjbvrywIxwEQ2hRj(array2[num3], componentContextMetadata, componentMetadata, formViewItem, options);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			array2 = viewItemAnalyzers.ToArray();
			num = 8;
		}
	}

	private DependencyAnalysisResult AnalyzeImplementations(ComponentMetadata componentMetadata, DependencyServiceOptions options)
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_0058, IL_0093, IL_00a2, IL_00b2, IL_00c1, IL_015c, IL_01d9, IL_01f8, IL_0207, IL_0224, IL_0234, IL_023e, IL_0279, IL_0288, IL_02f6, IL_03e5, IL_03f8
		int num = 2;
		int num2 = num;
		IEnumerator<ExtensionPointViewItem> enumerator2 = default(IEnumerator<ExtensionPointViewItem>);
		ExtensionPointViewItem current2 = default(ExtensionPointViewItem);
		DataClassMetadata dataClassMetadata2 = default(DataClassMetadata);
		Guid currentModuleUid = default(Guid);
		Dictionary<Guid, DataClassDependency> dictionary = default(Dictionary<Guid, DataClassDependency>);
		List<Implementation>.Enumerator enumerator = default(List<Implementation>.Enumerator);
		Implementation current = default(Implementation);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		FormViewItem view = default(FormViewItem);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					while (true)
					{
						IL_0118:
						int num5;
						if (!CtD8R8bvjvsysUiKoAGE(enumerator2))
						{
							num5 = 9;
							goto IL_005c;
						}
						goto IL_0105;
						IL_005c:
						while (true)
						{
							switch (num5)
							{
							case 5:
								break;
							case 1:
								break;
							case 3:
								if (odEwB2bv4pc624v6UdPE(TEVRFFbv5AbnJcG0tVVQ(current2), Guid.Empty))
								{
									num5 = 2;
									continue;
								}
								goto IL_0118;
							case 7:
								if (HObJU3bvAJYhwU8jRwrx(dataClassMetadata2, currentModuleUid, options))
								{
									num5 = 5;
									continue;
								}
								goto case 8;
							default:
								goto IL_0105;
							case 4:
							case 6:
								goto IL_0118;
							case 2:
								if ((dataClassMetadata2 = ((IMetadataService)olYCngbvtaEyOhjAnm8M()).GetMetadata(current2.TypeUid, loadImplementation: true) as DataClassMetadata) == null)
								{
									num5 = 4;
									continue;
								}
								goto case 7;
							case 8:
								DependencyServiceHelper.AddClassDependency(dictionary, gFoZYTbv71f0MyEiORob(dataClassMetadata2), dataClassMetadata2, (DataClassMetadata m) => m.GetSignature(simple: true));
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num5 = 1;
								}
								continue;
							case 9:
								break;
							}
							break;
						}
						break;
						IL_0105:
						current2 = enumerator2.Current;
						num5 = 3;
						goto IL_005c;
					}
				}
				finally
				{
					int num6;
					if (enumerator2 == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num6 = 0;
						}
						goto IL_01dd;
					}
					goto IL_0212;
					IL_0212:
					enumerator2.Dispose();
					num6 = 2;
					goto IL_01dd;
					IL_01dd:
					switch (num6)
					{
					case 1:
						goto end_IL_01b8;
					case 2:
						goto end_IL_01b8;
					}
					goto IL_0212;
					end_IL_01b8:;
				}
				goto case 4;
			default:
				try
				{
					while (true)
					{
						IL_0292:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 3;
							}
							goto IL_0242;
						}
						goto IL_0300;
						IL_0300:
						current = enumerator.Current;
						num3 = 4;
						goto IL_0242;
						IL_0242:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto IL_0292;
							case 3:
								if ((dataClassMetadata = MetadataServiceContext.Service.GetMetadata(current.TypeUid) as DataClassMetadata) == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 9;
							case 7:
								break;
							case 5:
								goto IL_0300;
							case 9:
								if (HObJU3bvAJYhwU8jRwrx(dataClassMetadata, currentModuleUid, options))
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto case 2;
							case 4:
								if (odEwB2bv4pc624v6UdPE(owrdj0bvgVGy22qc8tGv(current), Guid.Empty))
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_0292;
							case 2:
								DependencyServiceHelper.AddClassDependency(dictionary, dataClassMetadata.Uid, dataClassMetadata, (DataClassMetadata m) => m.GetSignature(simple: true));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num3 = 1;
								}
								continue;
							case 8:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 4:
				return new DependencyAnalysisResult
				{
					DataClassDependencies = dictionary.Values.ToList()
				};
			case 2:
			{
				object obj = KrDA0TbvDVGKQFEBT9RN(QTI2A7bvaRJF5HHavBNU(componentMetadata));
				view = ((ComponentContentMetadata)QTI2A7bvaRJF5HHavBNU(componentMetadata)).View;
				currentModuleUid = HEKy63bvOApmSq91eyFs(obj);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 1:
				dictionary = new Dictionary<Guid, DataClassDependency>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				enumerator = componentMetadata.Implementations.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				break;
			}
			enumerator2 = view.FindItems(ignoreHide: false, (ViewItem i) => i is ExtensionPointViewItem).OfType<ExtensionPointViewItem>().GetEnumerator();
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num2 = 5;
			}
		}
	}

	private static IEnumerable<T> Filter<T>(IEnumerable<T> dependencies, ISet<Guid> ignoredMetadata) where T : Dependency
	{
		_003C_003Ec__DisplayClass17_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0<T>();
		CS_0024_003C_003E8__locals0.ignoredMetadata = ignoredMetadata;
		return dependencies.Where((T d) => !CS_0024_003C_003E8__locals0.ignoredMetadata.Contains(d.HeaderUid));
	}

	internal static object c2gICTbvk65apcXGfW2n(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void F9eHGZbvnkXa4Mk1Y2ru(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool AjAjEVbvXTmbuTFqEG45()
	{
		return sp0IUXbvK8bdSDlJQl18 == null;
	}

	internal static DependencyService MWgt0hbvTvkPbmqdNIB1()
	{
		return sp0IUXbvK8bdSDlJQl18;
	}

	internal static Guid HEKy63bvOApmSq91eyFs(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static object n0YRSObv2XAxpoX0UQlM(object P_0)
	{
		return ((FunctionMetadata)P_0).ReturnType;
	}

	internal static object jlmiATbve17BFPFXcRrv(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static object kgbPeabvPAtDlQBNfhBw(object P_0, object P_1)
	{
		return CheckCompatibility((TypeSignature)P_0, (TypeSignature)P_1);
		static CompatibilityResult CheckCompatibility(TypeSignature currentTypeSignature, TypeSignature candidateTypeSignature)
		{
			//Discarded unreachable code: IL_0054
			int num = 2;
			int num2 = num;
			CompatibilityResult compatibilityResult = default(CompatibilityResult);
			while (true)
			{
				switch (num2)
				{
				case 2:
					compatibilityResult = (CompatibilityResult)hcFW6pbvYeGwmQdvUWYp(currentTypeSignature, candidateTypeSignature);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return new CompatibilityResult(true);
				default:
					return compatibilityResult;
				case 1:
					if (!orUEiNbvNLsroV3H7Pjg(compatibilityResult))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	internal static object axXn7dbv1ladSSjMWnDj(object P_0)
	{
		return ((FunctionDependency)P_0).ReturnType;
	}

	internal static bool orUEiNbvNLsroV3H7Pjg(object P_0)
	{
		return ((CompatibilityResult)P_0).IsValid;
	}

	internal static object iiPPVpbv3BQSSI4Ofp5X(object P_0)
	{
		return ((CompatibilityResult)P_0).Errors;
	}

	internal static object sjZe6YbvpKOvBcW3EKPb(object P_0, object P_1)
	{
		return ((DataClassDependency)P_0).Compatible((DataClassDependency)P_1);
	}

	internal static object QTI2A7bvaRJF5HHavBNU(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object KrDA0TbvDVGKQFEBT9RN(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object olYCngbvtaEyOhjAnm8M()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid fpnHsdbvwQcMsY9OeIVr(object P_0)
	{
		return ((UserDefinedListInfo)P_0).SubTypeUid;
	}

	internal static bool odEwB2bv4pc624v6UdPE(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid rolJUebv6FAPa9koNeXH(object P_0)
	{
		return ((UserDefinedListPropertyBase)P_0).OriginalPropertyUid;
	}

	internal static bool CrNTHAbvHLlWCoWxKx2A(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool HObJU3bvAJYhwU8jRwrx(object P_0, Guid currentModuleUid, object P_2)
	{
		return DependencyServiceHelper.SkipDependency((IMetadata)P_0, currentModuleUid, (DependencyServiceOptions)P_2);
	}

	internal static Guid gFoZYTbv71f0MyEiORob(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid bb7abGbvxNe4cAO6Upw4(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid CAXCMsbv08Jb2SVw8DtR(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool JkB6hRbvmTGcZLBeFDWM(Guid typeUid)
	{
		return DependencyServiceHelper.IsEntity(typeUid);
	}

	internal static bool XUJ2ZtbvyskaFTLMXgaN(Guid typeUid)
	{
		return DependencyServiceHelper.IsEnum(typeUid);
	}

	internal static bool M8wDM1bvMoEWJXaNkqmY(Guid typeUid)
	{
		return DependencyServiceHelper.IsAction(typeUid);
	}

	internal static object Rlr339bvJo5JYX4pe2h4(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object ejriZ4bv9QGhOis83FfM(object P_0)
	{
		return ((ActionSettings)P_0).ParameterType;
	}

	internal static object xFRfskbvdMR3v6c6ytRF(object P_0)
	{
		return ((ActionSettings)P_0).DefaultValue;
	}

	internal static object HwxbX1bvlQB1GbYN41JP(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}

	internal static object iT5YvjbvrywIxwEQ2hRj(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((IViewItemAnalyzer)P_0).Analyse((ClassMetadata)P_1, (IMetadata)P_2, (FormViewItem)P_3, (DependencyServiceOptions)P_4);
	}

	internal static Guid owrdj0bvgVGy22qc8tGv(object P_0)
	{
		return ((Implementation)P_0).TypeUid;
	}

	internal static Guid TEVRFFbv5AbnJcG0tVVQ(object P_0)
	{
		return ((ExtensionPointViewItem)P_0).TypeUid;
	}

	internal static bool CtD8R8bvjvsysUiKoAGE(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object hcFW6pbvYeGwmQdvUWYp(object P_0, object P_1)
	{
		return ((TypeSignature)P_0).Compatible((TypeSignature)P_1);
	}
}
