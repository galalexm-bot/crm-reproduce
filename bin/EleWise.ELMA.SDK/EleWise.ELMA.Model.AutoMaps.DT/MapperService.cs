using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

[Service(Type = ComponentType.Server)]
internal sealed class MapperService : AbstractMapperService, IModuleMapperService, IMapperService
{
	[Component]
	private class EntityPublishRefreshMappersHandler : IPublicationEventHandler, IEventHandler
	{
		private readonly object mapperService;

		internal static object fc1Oylv47XVUuvjZanap;

		public EntityPublishRefreshMappersHandler(MapperService mapperService)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			N5rtQ3v4mitvxVEeO451();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.mapperService = mapperService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 1;
				}
			}
		}

		public void Complete(Guid publicationToken)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((MapperService)mapperService).moduleMappers = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Error(Guid publicationToken, Exception exception)
		{
		}

		internal static void N5rtQ3v4mitvxVEeO451()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool zh2NF5v4xxUj961wITkv()
		{
			return fc1Oylv47XVUuvjZanap == null;
		}

		internal static EntityPublishRefreshMappersHandler ihVug1v40Ow1UvESiQSg()
		{
			return (EntityPublishRefreshMappersHandler)fc1Oylv47XVUuvjZanap;
		}
	}

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private IEnumerable<IInternalMapperConfiguration> moduleMappers;

	private static MapperService vGQ6puh0StQrbiHBLvSP;

	IEnumerable<IInternalMapperConfiguration> IModuleMapperService.ModuleMappers
	{
		get
		{
			return moduleMappers;
		}
		set
		{
			moduleMappers = value;
		}
	}

	public MapperService(IModuleMetadataLoader moduleMetadataLoader)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		NuT0xch0qCEpVTDqQ4U3();
		base._002Ector(moduleMetadataLoader);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.moduleMetadataLoader = moduleMetadataLoader;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Init()
	{
		//Discarded unreachable code: IL_026e, IL_0360, IL_036f, IL_03b7, IL_041d, IL_0492, IL_04a1, IL_04f8, IL_0530, IL_053f, IL_054e, IL_059f, IL_05be, IL_05cd, IL_05fa, IL_0688, IL_06a7, IL_06b6, IL_06e3
		int num = 2;
		int num2 = num;
		MapperService obj = default(MapperService);
		bool lockTaken = default(bool);
		ISearchMetadataService service = default(ISearchMetadataService);
		List<IInternalMapperConfiguration> list = default(List<IInternalMapperConfiguration>);
		MetadataMapperConfigurator metadataMapperConfigurator = default(MetadataMapperConfigurator);
		List<IInternalMapperConfiguration> moduleMapperConfigurations = default(List<IInternalMapperConfiguration>);
		TypeSettingsMapperConfigurator typeSettingsMapperConfigurator = default(TypeSettingsMapperConfigurator);
		int num5 = default(int);
		ModuleVersion[] orAdd = default(ModuleVersion[]);
		ModuleMetadataItem moduleMetadataItem3 = default(ModuleMetadataItem);
		ModuleVersion moduleVersion = default(ModuleVersion);
		ModuleMetadataItem moduleMetadataItem2 = default(ModuleMetadataItem);
		ModuleMetadataItemHeader moduleMetadataItemHeader = default(ModuleMetadataItemHeader);
		Guid current = default(Guid);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (moduleMappers == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				lockTaken = false;
				num2 = 3;
				break;
			case 4:
				return;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 14:
							R5otNMh0ewZI2IbO3hwp(mappersByUidCache);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num3 = 9;
							}
							break;
						case 11:
							service = Locator.GetService<ISearchMetadataService>();
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num3 = 12;
							}
							break;
						case 16:
							list.AddRange(metadataMapperConfigurator.Init());
							num3 = 4;
							break;
						case 5:
							if (moduleMappers != null)
							{
								return;
							}
							num3 = 8;
							break;
						case 6:
							rDmNvoh01aBy9lkVYklp(PublishedModules);
							num3 = 17;
							break;
						case 17:
							moduleMappers = moduleMapperConfigurations;
							num3 = 2;
							break;
						default:
							mappersByTypeRef.Clear();
							num3 = 6;
							break;
						case 15:
						{
							mappers = new MappersCollection(moduleMapperConfigurations, list);
							int num11 = 14;
							num3 = num11;
							break;
						}
						case 12:
							if (service == null)
							{
								num3 = 7;
								break;
							}
							goto case 13;
						case 4:
							typeSettingsMapperConfigurator = new TypeSettingsMapperConfigurator(service);
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num3 = 18;
							}
							break;
						case 3:
							metadataMapperConfigurator = new MetadataMapperConfigurator(service);
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num3 = 11;
							}
							break;
						case 8:
							moduleMapperConfigurations = new List<IInternalMapperConfiguration>();
							num3 = 11;
							break;
						case 18:
							list.AddRange(typeSettingsMapperConfigurator.Init());
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num3 = 15;
							}
							break;
						case 1:
							try
							{
								IEnumerator<Guid> enumerator = ModuleMetadataItemHeaderManager.DesignerModules.GetEnumerator();
								int num4 = 3;
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 >= orAdd.Length)
										{
											num4 = 11;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
											{
												num4 = 4;
											}
											continue;
										}
										goto case 5;
									case 2:
										num5 = 0;
										num4 = 7;
										continue;
									case 1:
										LoadMapper(moduleMetadataItem3);
										num4 = 6;
										continue;
									case 4:
										orAdd = PublishedModules.GetOrAdd(Guid.Empty, (Guid g) => moduleMetadataLoader.GetAllDefaultVersions(ModuleMetadataItemHeaderManager.DesignerModules).ToArray());
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num4 = 1;
										}
										continue;
									case 5:
										moduleVersion = orAdd[num5];
										num4 = 9;
										continue;
									case 9:
									{
										moduleMetadataItem3 = ((AbstractNHEntityManager<ModuleMetadataItem, long>)JF2lSqh0naxOHvUWo4Wv()).LoadOrNull(yr7R7Vh02Ngdn5x3xYQa(yp226wh0OlsQghG75GsR(moduleVersion)));
										int num9 = 8;
										num4 = num9;
										continue;
									}
									case 8:
										if (moduleMetadataItem3 == null)
										{
											num4 = 10;
											continue;
										}
										goto case 1;
									case 3:
										try
										{
											while (true)
											{
												IL_0473:
												int num7;
												if (!gFec9Kh0ThsxoKkVxMsu(enumerator))
												{
													int num6 = 4;
													num7 = num6;
													goto IL_03c5;
												}
												goto IL_0460;
												IL_03c5:
												while (true)
												{
													switch (num7)
													{
													case 7:
														if (moduleMetadataItem2 == null)
														{
															num7 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
															{
																num7 = 2;
															}
															continue;
														}
														goto case 9;
													case 3:
														moduleMetadataItemHeader = ((AbstractNHEntityManager<ModuleMetadataItemHeader, long>)L1N7Uph0KHlnrSeL894C()).LoadOrNull(current);
														num7 = 5;
														continue;
													case 5:
														if (moduleMetadataItemHeader == null)
														{
															num7 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
															{
																num7 = 0;
															}
															continue;
														}
														goto case 1;
													case 6:
														break;
													default:
														goto IL_0473;
													case 9:
														LoadMapper(moduleMetadataItem2);
														num7 = 8;
														continue;
													case 1:
														moduleMetadataItem2 = (ModuleMetadataItem)BdpCbqh0X0FO9B3lnRlb(moduleMetadataItemHeader);
														num7 = 7;
														continue;
													case 4:
														goto end_IL_0473;
													}
													break;
												}
												goto IL_0460;
												IL_0460:
												current = enumerator.Current;
												num7 = 3;
												goto IL_03c5;
												continue;
												end_IL_0473:
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
												{
													num8 = 0;
												}
												while (true)
												{
													switch (num8)
													{
													default:
														XCkf6oh0kOYjyn0JwDOr(enumerator);
														num8 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
														{
															num8 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 4;
									case 6:
									case 10:
										num5++;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num4 = 0;
										}
										continue;
									case 11:
										break;
									}
									break;
								}
							}
							finally
							{
								int num10;
								if (metadataServiceContext == null)
								{
									num10 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
									{
										num10 = 2;
									}
									goto IL_05a3;
								}
								goto IL_05d8;
								IL_05d8:
								XCkf6oh0kOYjyn0JwDOr(metadataServiceContext);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num10 = 0;
								}
								goto IL_05a3;
								IL_05a3:
								switch (num10)
								{
								default:
									goto end_IL_057e;
								case 2:
									goto end_IL_057e;
								case 1:
									break;
								case 0:
									goto end_IL_057e;
								}
								goto IL_05d8;
								end_IL_057e:;
							}
							goto case 7;
						case 7:
						case 10:
							list = new List<IInternalMapperConfiguration>();
							num3 = 3;
							break;
						case 13:
							metadataServiceContext = MetadataServiceContext.Extend(service.GetPublishedDataClasses());
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num3 = 1;
							}
							break;
						case 9:
							pj8687h0PO9HBDiO4QSc(mappersByTypeAndUidCache);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num12;
					if (!lockTaken)
					{
						num12 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num12 = 0;
						}
						goto IL_068c;
					}
					goto IL_06c1;
					IL_06c1:
					Monitor.Exit(obj);
					num12 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num12 = 0;
					}
					goto IL_068c;
					IL_068c:
					switch (num12)
					{
					case 2:
						goto end_IL_0667;
					case 1:
						goto end_IL_0667;
					}
					goto IL_06c1;
					end_IL_0667:;
				}
			}
		}
	}

	internal static void NuT0xch0qCEpVTDqQ4U3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sk9xEbh0ibVclc4duuqg()
	{
		return vGQ6puh0StQrbiHBLvSP == null;
	}

	internal static MapperService YIliVdh0R4jxh9OdyRor()
	{
		return vGQ6puh0StQrbiHBLvSP;
	}

	internal static object L1N7Uph0KHlnrSeL894C()
	{
		return ModuleMetadataItemHeaderManager.Instance;
	}

	internal static object BdpCbqh0X0FO9B3lnRlb(object P_0)
	{
		return ((ModuleMetadataItemHeader)P_0).Published;
	}

	internal static bool gFec9Kh0ThsxoKkVxMsu(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void XCkf6oh0kOYjyn0JwDOr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object JF2lSqh0naxOHvUWo4Wv()
	{
		return ModuleMetadataItemManager.Instance;
	}

	internal static object yp226wh0OlsQghG75GsR(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static Guid yr7R7Vh02Ngdn5x3xYQa(object P_0)
	{
		return ((ModuleVersionHeader)P_0).VersionUid;
	}

	internal static void R5otNMh0ewZI2IbO3hwp(object P_0)
	{
		((ConcurrentDictionary<Guid, IInternalMapperConfiguration>)P_0).Clear();
	}

	internal static void pj8687h0PO9HBDiO4QSc(object P_0)
	{
		((ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>>)P_0).Clear();
	}

	internal static void rDmNvoh01aBy9lkVYklp(object P_0)
	{
		((ConcurrentDictionary<Guid, ModuleVersion[]>)P_0).Clear();
	}

	internal static object oP4RNXh0N2giDif6aSeV(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Version;
	}

	internal static object ll0IZMh03EUWPNsLasTl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sedid3h0pCLtm8aYY7LJ(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static bool G5KEhXh0aJISfCKq4eMJ(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object C5h50hh0D6wD04h6lOWC(object P_0)
	{
		return ((ModuleMetadataItem)P_0).DebugRaw;
	}

	internal static object CqK2D0h0tIms1nbIQNNX(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object HrEIWwh0wZw73otfnkSl(object P_0)
	{
		return ((Assembly)P_0).GetTypes();
	}

	internal static object XuyNkuh04fNLDA2Yw7gW(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object gLjHjmh060ZrZ6VTspP4(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object C3Mm83h0HT39yMTRCoW0(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object o4IuJih0A6x9jpLVcfaA()
	{
		return Logger.Log;
	}

	internal static void oBO5boh07dMbbmsTdLf0(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
