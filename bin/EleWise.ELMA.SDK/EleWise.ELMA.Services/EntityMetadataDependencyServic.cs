using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class EntityMetadataDependencyService : IEntityMetadataDependencyService
{
	internal const string PromisedDependenciesKey = "HasPromisedDependencies";

	internal const string PromisedKeyTemplate = "Promised{0}_{1}";

	private readonly IDependencyService dependencyService;

	private readonly ISearchMetadataService searchMetadataService;

	internal static EntityMetadataDependencyService BYeIZXBDtjf03038l55y;

	public EntityMetadataDependencyService(IDependencyService dependencyService, ISearchMetadataService searchMetadataService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		up0JBgBD6lSY4YJGLWIa();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.searchMetadataService = searchMetadataService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.dependencyService = dependencyService;
				num = 2;
				break;
			}
		}
	}

	public void CollectDependencies(EntityMetadata metadata, IMetadataItem metadataItem)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0140, IL_0183, IL_018d, IL_0313, IL_03b9, IL_03c8, IL_03ff, IL_0412, IL_0421, IL_04ce, IL_0502, IL_053a, IL_0549
		int num = 5;
		int num2 = num;
		MetadataDependencyContainer classMetadataDependencies = default(MetadataDependencyContainer);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		List<FormViewItemTransformation>.Enumerator enumerator = default(List<FormViewItemTransformation>.Enumerator);
		FormViewItemDependencyContainer formViewItemDependencyContainer = default(FormViewItemDependencyContainer);
		DependencyAnalysisResult dependencyAnalysisResult = default(DependencyAnalysisResult);
		FormViewItem formViewItem = default(FormViewItem);
		List<ViewItemTransformation>.Enumerator enumerator2 = default(List<ViewItemTransformation>.Enumerator);
		FormViewItemTransformation current = default(FormViewItemTransformation);
		ViewItemTransformationAdd viewItemTransformationAdd = default(ViewItemTransformationAdd);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				WvkH2tBDmqhEtBqdYKbH(metadataItem, classMetadataDependencies);
				num2 = 2;
				break;
			case 5:
				if (C1UUcTBDHO3Xbpd8n71U(metadata) != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				return;
			case 4:
				metadataServiceContext = MetadataServiceContext.Extend(((IEnumerable<IMetadata>)searchMetadataService.GetPublishedDataClasses().ToList()).Concat((IMetadata)metadata).Concat(searchMetadataService.GetPublishedFunctions()).Concat(searchMetadataService.GetPublishedComponents()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					classMetadataDependencies = dependencyService.GetClassMetadataDependencies((ClassMetadata)C1UUcTBDHO3Xbpd8n71U(metadata), metadata, metadata.Forms.Where((FormViewItem f) => _003C_003Ec.taV3FpQXRWtbsOxdlcjB(f) == RuntimeVersion.Version2));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							enumerator = metadata.FormTransformations.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num3 = 0;
							}
							continue;
						default:
							try
							{
								while (true)
								{
									IL_02cf:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 9;
										goto IL_0191;
									}
									goto IL_022a;
									IL_0191:
									while (true)
									{
										switch (num4)
										{
										case 1:
											formViewItemDependencyContainer.EntityDependencies.AddRange(dependencyAnalysisResult.EntityDependencies);
											num4 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
											{
												num4 = 11;
											}
											continue;
										case 6:
											formViewItem = new FormViewItem();
											num4 = 7;
											continue;
										case 3:
											formViewItemDependencyContainer.ComponentDependencies.AddRange(dependencyAnalysisResult.ComponentDependencies);
											num4 = 4;
											continue;
										case 2:
											break;
										default:
											formViewItemDependencyContainer.EnumDependencies.AddRange(dependencyAnalysisResult.EnumDependencies);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
											{
												num4 = 0;
											}
											continue;
										case 4:
											classMetadataDependencies.FormDependencies.Add(formViewItemDependencyContainer);
											num4 = 12;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
											{
												num4 = 10;
											}
											continue;
										case 11:
											formViewItemDependencyContainer.DataClassDependencies.AddRange(dependencyAnalysisResult.DataClassDependencies);
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
											{
												num4 = 1;
											}
											continue;
										case 12:
											goto IL_02cf;
										case 7:
											enumerator2 = current.Items.GetEnumerator();
											num4 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
											{
												num4 = 2;
											}
											continue;
										case 10:
											try
											{
												while (true)
												{
													int num6;
													if (!enumerator2.MoveNext())
													{
														int num5 = 2;
														num6 = num5;
														goto IL_0321;
													}
													goto IL_033f;
													IL_0321:
													switch (num6)
													{
													case 4:
														break;
													case 1:
														goto IL_036d;
													default:
														continue;
													case 2:
														goto end_IL_039a;
													}
													goto IL_033f;
													IL_033f:
													if ((viewItemTransformationAdd = enumerator2.Current as ViewItemTransformationAdd) == null)
													{
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
														{
															num6 = 0;
														}
														goto IL_0321;
													}
													goto IL_036d;
													IL_036d:
													((EventedList<ViewItem>)e3Bpi1BDA3eb1kwt2g6m(formViewItem)).Add((ViewItem)s0wv1FBD74q0fFXgLPZ6(viewItemTransformationAdd));
													num6 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
													{
														num6 = 3;
													}
													goto IL_0321;
													continue;
													end_IL_039a:
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator2).Dispose();
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
												{
													num7 = 0;
												}
												switch (num7)
												{
												case 0:
													break;
												}
											}
											goto case 5;
										case 5:
											dependencyAnalysisResult = dependencyService.SimpleFormDependencyAnalysis(metadata.ViewModelMetadata, metadata, formViewItem);
											num4 = 8;
											continue;
										case 8:
											formViewItemDependencyContainer = new FormViewItemDependencyContainer
											{
												FormUid = ((KveWtbBDxrJpQi2Djj6a(current) != Guid.Empty) ? KveWtbBDxrJpQi2Djj6a(current) : current.Uid)
											};
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num4 = 0;
											}
											continue;
										case 9:
											goto end_IL_02cf;
										}
										break;
									}
									goto IL_022a;
									IL_022a:
									current = enumerator.Current;
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num4 = 4;
									}
									goto IL_0191;
									continue;
									end_IL_02cf:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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
						}
						break;
					}
				}
				finally
				{
					if (metadataServiceContext != null)
					{
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								nsJ3AWBD0xScwK06BxBL(metadataServiceContext);
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
								{
									num9 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			}
		}
	}

	internal static ICollection<IMetadata> GetPromisedMetadataDependencies(IActorContextService actorContextService)
	{
		if (!actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F1FB1), out var value))
		{
			actorContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123549756), value = new List<IMetadata>());
		}
		return (ICollection<IMetadata>)value;
	}

	internal static void up0JBgBD6lSY4YJGLWIa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XEDrvdBDwvFyr5iYQYpE()
	{
		return BYeIZXBDtjf03038l55y == null;
	}

	internal static EntityMetadataDependencyService bGOCJbBD4m45H1VC0vZ8()
	{
		return BYeIZXBDtjf03038l55y;
	}

	internal static object C1UUcTBDHO3Xbpd8n71U(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object e3Bpi1BDA3eb1kwt2g6m(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static object s0wv1FBD74q0fFXgLPZ6(object P_0)
	{
		return ((ViewItemTransformationAdd)P_0).Item;
	}

	internal static Guid KveWtbBDxrJpQi2Djj6a(object P_0)
	{
		return ((FormViewItemTransformation)P_0).NewFormUid;
	}

	internal static void nsJ3AWBD0xScwK06BxBL(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void WvkH2tBDmqhEtBqdYKbH(object P_0, object P_1)
	{
		((IMetadataItem)P_0).Dependencies = P_1;
	}
}
