using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
internal sealed class DataClassMetadataImportExtension : ClassMetadataImportExtension<DataClassMetadata>
{
	[Component(Order = 2200)]
	private class DataClassConfigImportExtension : ConfigImportExtension
	{
		private readonly object dataClassMetadataItemManager;

		private readonly object actorContextService;

		private readonly object securityService;

		private static object g8vwQn8HanyLrF8kFbmA;

		private ICollection<DeployLogMessage> DeployLogMessages
		{
			get
			{
				if (!((IActorContextService)actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ABCA28), out object value))
				{
					((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858754735), value = new List<DeployLogMessage>());
				}
				return (ICollection<DeployLogMessage>)value;
			}
		}

		public DataClassConfigImportExtension(IDataClassMetadataItemManager dataClassMetadataItemManager, IActorContextService actorContextService, ISecurityService securityService)
		{
			//Discarded unreachable code: IL_001e
			dJ3gri8HwxTiH2YAeHkr();
			base._002Ector();
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					this.dataClassMetadataItemManager = dataClassMetadataItemManager;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 1:
					this.securityService = securityService;
					num2 = 2;
					break;
				default:
					this.actorContextService = actorContextService;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override void OnPostReadPackets(PostReadPacketsParameters parameters)
		{
			//Discarded unreachable code: IL_0180
			int num = 7;
			List<KeyValuePair<string, string>> list = default(List<KeyValuePair<string, string>>);
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
			ICollection<Guid> importHeaders = default(ICollection<Guid>);
			Guid[] array = default(Guid[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 14:
						list.ForEach(_003C_003Ec__DisplayClass4_._003COnPostReadPackets_003Eb__2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						if (_003C_003Ec__DisplayClass4_.parameters.HeaderIds.Count == 0)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 3;
					case 3:
					case 13:
						if (jCjqhH8H4eWMumw0r1RH(_003C_003Ec__DisplayClass4_.parameters) == 2)
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						return;
					case 9:
						Publish(importHeaders, _003C_003Ec__DisplayClass4_.parameters.Messages, _003C_003Ec__DisplayClass4_.parameters.TreeUid);
						num2 = 3;
						continue;
					case 1:
						importHeaders = GetImportHeaders(actorContextService);
						num2 = 10;
						continue;
					case 2:
						return;
					case 4:
						Publish(array, _003C_003Ec__DisplayClass4_.parameters.Messages, (string)H7eYBC8H6MkgsNXS67jQ(_003C_003Ec__DisplayClass4_.parameters));
						num2 = 14;
						continue;
					case 10:
						if (importHeaders.Count <= 0)
						{
							num = 13;
							break;
						}
						goto case 9;
					case 6:
						_003C_003Ec__DisplayClass4_.parameters = parameters;
						num2 = 5;
						continue;
					default:
						if (array.Length == 0)
						{
							return;
						}
						num2 = 4;
						continue;
					case 5:
						if (jCjqhH8H4eWMumw0r1RH(_003C_003Ec__DisplayClass4_.parameters) == 1)
						{
							num = 8;
							break;
						}
						goto case 3;
					case 7:
						_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 5;
						}
						continue;
					case 11:
						list = _003C_003Ec__DisplayClass4_.parameters.ServiceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345015432))).ToList();
						num = 12;
						break;
					case 12:
						array = list.Select((KeyValuePair<string, string> record) => new Guid(record.Value)).ToArray();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}

		public override void OnPostPublish(PostPublishParameters parameters)
		{
			//Discarded unreachable code: IL_006f
			int num = 4;
			int num2 = num;
			ICollection<DeployLogMessage> deployLogMessages = default(ICollection<DeployLogMessage>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					deployLogMessages = DeployLogMessages;
					num2 = 3;
					break;
				case 0:
					return;
				case 1:
					return;
				case 2:
					parameters.Messages.AddRange(deployLogMessages);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (bPjYMn8HHJ2toEtJPCwl(deployLogMessages) <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		public void Publish(IEnumerable<Guid> headerUids, ICollection<DeployLogMessage> messages = null, string treeUid = null)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.headerUids = headerUids;
			CS_0024_003C_003E8__locals0.messages = messages;
			CS_0024_003C_003E8__locals0.treeUid = treeUid;
			CS_0024_003C_003E8__locals0.messages = CS_0024_003C_003E8__locals0.messages ?? DeployLogMessages;
			((ISecurityService)securityService).RunWithElevatedPrivilegies((Action)delegate
			{
				//Discarded unreachable code: IL_005d, IL_015c, IL_016b, IL_01da, IL_01e4, IL_02d4, IL_02e7, IL_02f6, IL_033d, IL_042f, IL_043e
				switch (1)
				{
				case 0:
					break;
				case 1:
					try
					{
						UIMetadataPublishResult uIMetadataPublishResult = ((IDataClassMetadataItemManager)CS_0024_003C_003E8__locals0._003C_003E4__this.dataClassMetadataItemManager).Publish(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740732902), CS_0024_003C_003E8__locals0.headerUids.ToArray());
						int num = 6;
						string text2 = default(string);
						List<ValidationError>.Enumerator enumerator = default(List<ValidationError>.Enumerator);
						string text = default(string);
						ValidationError current = default(ValidationError);
						while (true)
						{
							switch (num)
							{
							case 2:
								return;
							case 1:
								_003C_003Ec__DisplayClass6_0.FcT3KXZP97klOJbvmUU4(ImportLog, text2);
								num = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
								{
									num = 4;
								}
								break;
							case 10:
								enumerator = uIMetadataPublishResult.Errors.GetEnumerator();
								num = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num = 0;
								}
								break;
							case 9:
								CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text, endProcess: false));
								num = 2;
								break;
							case 5:
								ImportLog.Info(text);
								num = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num = 9;
								}
								break;
							case 4:
								CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text2, endProcess: false));
								num = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num = 9;
								}
								break;
							case 3:
							case 8:
								text = (string)_003C_003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(_003C_003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(0x6DC147B0 ^ 0x6DC770F4));
								num = 5;
								break;
							case 7:
								text2 = (string)_003C_003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(_003C_003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(0x4D1C1EE4 ^ 0x4D1A2802));
								num = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num = 1;
								}
								break;
							default:
								try
								{
									while (true)
									{
										IL_0282:
										int num2;
										if (!enumerator.MoveNext())
										{
											num2 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
											{
												num2 = 4;
											}
											goto IL_01e8;
										}
										goto IL_022c;
										IL_022c:
										current = enumerator.Current;
										num2 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
										{
											num2 = 0;
										}
										goto IL_01e8;
										IL_01e8:
										while (true)
										{
											switch (num2)
											{
											case 4:
												return;
											default:
												_003C_003Ec__DisplayClass6_0.FcT3KXZP97klOJbvmUU4(ImportLog, current);
												num2 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
												{
													num2 = 3;
												}
												continue;
											case 2:
												break;
											case 3:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, current.Message, endProcess: false));
												num2 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
												{
													num2 = 1;
												}
												continue;
											case 1:
												goto IL_0282;
											}
											break;
										}
										goto IL_022c;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 0;
									}
									switch (num3)
									{
									case 0:
										break;
									}
								}
							case 6:
								if (_003C_003Ec__DisplayClass6_0.yegcU5ZPy1NKDk9E5l4B(uIMetadataPublishResult.Errors) == 0)
								{
									num = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
									{
										num = 3;
									}
									break;
								}
								goto case 7;
							}
						}
					}
					catch (Exception ex)
					{
						int num4 = 2;
						string text3 = default(string);
						while (true)
						{
							switch (num4)
							{
							case 4:
								return;
							case 2:
								text3 = (string)_003C_003Ec__DisplayClass6_0.G9jqT2ZPJ3uYRMyqJe03(_003C_003Ec__DisplayClass6_0.h7hFUyZPMC5EWm5WfvSb(-1876063057 ^ -1876182455));
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num4 = 1;
								}
								break;
							case 5:
								_003C_003Ec__DisplayClass6_0.lDt7grZPdaoVUtwel9o3(ImportLog, text3, ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num4 = 0;
								}
								break;
							case 1:
								CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text3, endProcess: false));
								num4 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
								{
									num4 = 5;
								}
								break;
							default:
								if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.treeUid))
								{
									return;
								}
								num4 = 3;
								break;
							case 3:
								CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, ObjectsExportConsts.ExportExtensionUidDataClass, CS_0024_003C_003E8__locals0.treeUid));
								num4 = 4;
								break;
							}
						}
					}
				}
			});
		}

		public override void OnPreStartTest(PreStartTestImportParameters parameters)
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
					SetPromisedDependenciesKey(parameters.ServiceData);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override void OnPrePublish(PrePublishParameters parameters)
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
					SetPromisedDependenciesKey(parameters.ServiceData);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void SetPromisedDependenciesKey(IDictionary<string, string> serviceData)
		{
			foreach (KeyValuePair<string, string> item in serviceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A35C88A))).ToList())
			{
				if (Guid.TryParse(item.Value, out var result))
				{
					string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8318FC0), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106453838), item.Value);
					((IActorContextService)actorContextService).Set(key, (object)result);
					((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477112546), (object)string.Empty);
					serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A772D73)] = string.Empty;
				}
			}
		}

		internal static void dJ3gri8HwxTiH2YAeHkr()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool vywxm28HDPmn3ButOX8f()
		{
			return g8vwQn8HanyLrF8kFbmA == null;
		}

		internal static DataClassConfigImportExtension AKMhxE8HtI4gVxXX8bD2()
		{
			return (DataClassConfigImportExtension)g8vwQn8HanyLrF8kFbmA;
		}

		internal static int jCjqhH8H4eWMumw0r1RH(object P_0)
		{
			return ((ImportExtensionParameters)P_0).ImportStep;
		}

		internal static object H7eYBC8H6MkgsNXS67jQ(object P_0)
		{
			return ((ImportExtensionParameters)P_0).TreeUid;
		}

		internal static int bPjYMn8HHJ2toEtJPCwl(object P_0)
		{
			return ((ICollection<DeployLogMessage>)P_0).Count;
		}
	}

	[Component(Order = -90)]
	private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
	{
		private readonly object actorContextService;

		private readonly ILazy<DataClassConfigImportExtension> dataClassConfigImportExtension;

		public ModelAssemblyBuilderHandler(IActorContextService actorContextService, ILazy<DataClassConfigImportExtension> dataClassConfigImportExtension)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.actorContextService = actorContextService;
			this.dataClassConfigImportExtension = dataClassConfigImportExtension;
		}

		public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
		{
			ICollection<Guid> importHeaders = GetImportHeaders(actorContextService);
			if (importHeaders.Count > 0)
			{
				dataClassConfigImportExtension.Value.Publish(importHeaders);
			}
		}

		public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
		{
		}

		public void AfterAll(IEnumerable<AbstractMetadata> publishMetadataList, IEnumerable<ScriptModule> scriptModules, IEnumerable<ScriptModule> clientScriptModules)
		{
		}
	}

	[Component]
	private sealed class DataClassMetadataImport : MetadataImport
	{
		private static object aweRS28H0PAtmy1QgFxV;

		public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
		{
			int num = 2;
			int num2 = num;
			DataClassMetadata dataClassMetadata = default(DataClassMetadata);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if ((dataClassMetadata = namedMd as DataClassMetadata) != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 2;
						}
						break;
					}
					return;
				case 3:
					fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidDataClass).GetOrCreateItemByUid(dataClassMetadata.Uid, (string)sic9gd8HMrV6tKkOcUjD(dataClassMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (fakeManifest != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 0:
					return;
				}
			}
		}

		public DataClassMetadataImport()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			UM29fF8HJaNXIiClDF7e();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object sic9gd8HMrV6tKkOcUjD(object P_0)
		{
			return ((NamedMetadata)P_0).DisplayName;
		}

		internal static bool j4sdSI8HmheNcO45kQyR()
		{
			return aweRS28H0PAtmy1QgFxV == null;
		}

		internal static DataClassMetadataImport rHGgUB8HyuRoUpOOIjVH()
		{
			return (DataClassMetadataImport)aweRS28H0PAtmy1QgFxV;
		}

		internal static void UM29fF8HJaNXIiClDF7e()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly ILogger ImportLog;

	private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;

	private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;

	private readonly IActorContextService actorContextService;

	private readonly IFeatureFlagService featureFlagService;

	private static DataClassMetadataImportExtension ra4BaVEd4xEgUXt6ERd4;

	private bool SecondRuntimeEnabled => dNW02eElotqVaml2RpDJ(featureFlagService, YgrfKQEdALiALRcpi62N(0x35C0467B ^ 0x35C0E871), false);

	public DataClassMetadataImportExtension(IDataClassMetadataItemManager dataClassMetadataItemManager, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, IMetadataItemGroupUIManager metadataItemGroupUIManager, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
				this.metadataItemGroupUIManager = metadataItemGroupUIManager;
				num = 3;
				break;
			default:
				this.featureFlagService = featureFlagService;
				num = 2;
				break;
			case 4:
				this.dataClassMetadataItemManager = dataClassMetadataItemManager;
				num = 5;
				break;
			case 2:
				return;
			case 3:
				this.actorContextService = actorContextService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 0;
				}
				break;
			case 5:
				this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal void CheckNewMetadata(DataClassMetadata mdImported, ReadMetadataParameters parameters, bool isTestRead)
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
				CheckNewMetadata(mdImported, isTestRead, parameters);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void MergeMetadata(DataClassMetadata mdImported, DataClassMetadata mdDraft, ReadMetadataParameters parameters, bool isTestRead)
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
				MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override bool TestMetadata(DataClassMetadata mdMerged, ReadMetadataParameters parameters, bool isTestRead)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				p7l9FsEdxdUqRdUuf6oF(parameters, new TestImportMessages(TestImportMessagesType.Error, SR.T((string)YgrfKQEdALiALRcpi62N(0x5DD55050 ^ 0x5DD19D8E), i7p97VEd7UX8YnCnFkHa(mdMerged))));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return false;
			default:
				return base.TestMetadata(mdMerged, parameters, isTestRead);
			case 1:
				if (SecondRuntimeEnabled)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	protected override bool CheckMetadata(DataClassMetadata mdImported, DataClassMetadata mdDraft, ReadMetadataParameters parameters)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)YgrfKQEdALiALRcpi62N(0x49E27B8A ^ 0x49E6B490), i7p97VEd7UX8YnCnFkHa(mdImported))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!SecondRuntimeEnabled)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return base.CheckMetadata(mdImported, mdDraft, parameters);
			default:
				return false;
			}
		}
	}

	protected override void CheckNewMetadata(DataClassMetadata mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0036, IL_0040, IL_0106, IL_0119
		int num = 2;
		int num2 = num;
		List<DataClassDependency>.Enumerator enumerator = default(List<DataClassDependency>.Enumerator);
		DataClassDependency current = default(DataClassDependency);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!isTestRead)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 3:
				return;
			case 4:
				enumerator = mdImported.IncludeList.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				base.CheckNewMetadata(mdImported, isTestRead, parameters);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0081:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num3 = 0;
						}
						goto IL_0044;
					}
					goto IL_005e;
					IL_005e:
					current = enumerator.Current;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num3 = 1;
					}
					goto IL_0044;
					IL_0044:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 3:
							break;
						case 2:
							goto IL_0081;
						case 1:
							s8UtuREdyilThtB5lHjq(current, ((MergeReplace)jdb8pREd0Wvu18GeTxWo(parameters)).GetUidReplaceMD(tBk7SuEdmKDqL3C6g8Dy(current)));
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
					goto IL_005e;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected override void MergeMetadata(DataClassMetadata mdImported, DataClassMetadata mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_007a, IL_01c0, IL_01d3, IL_01e2
		int num = 4;
		List<DataClassDependency>.Enumerator enumerator = default(List<DataClassDependency>.Enumerator);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!isTestRead)
					{
						num2 = 2;
						continue;
					}
					return;
				default:
					XXgXcZEd929ioGMsQIa8(mdImported, BsqgTlEdJ8FUw9nnlYTX(mdDraft));
					num2 = 5;
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_007e;
							}
							goto IL_0157;
							IL_007e:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 1:
									_003C_003Ec__DisplayClass12_.dependency.HeaderUid = JuxotnEdMQahuPKokN6F(jdb8pREd0Wvu18GeTxWo(parameters), tBk7SuEdmKDqL3C6g8Dy(_003C_003Ec__DisplayClass12_.dependency));
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
									{
										num3 = 4;
									}
									continue;
								case 6:
									_003C_003Ec__DisplayClass12_.dependency = enumerator.Current;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num3 = 1;
									}
									continue;
								case 4:
									if (mdDraft.IncludeList.All(_003C_003Ec__DisplayClass12_._003CMergeMetadata_003Eb__0))
									{
										num3 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
										{
											num3 = 5;
										}
										continue;
									}
									break;
								default:
									goto IL_0157;
								case 5:
									mdDraft.IncludeList.Add(_003C_003Ec__DisplayClass12_.dependency);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto end_IL_00a4;
								}
								break;
							}
							continue;
							IL_0157:
							_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
							num3 = 6;
							goto IL_007e;
							continue;
							end_IL_00a4:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 4:
					break;
				case 5:
					return;
				case 2:
					enumerator = mdImported.IncludeList.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
			num = 3;
		}
	}

	protected override void SaveMetadata(DataClassMetadata mdMerged, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_022e, IL_027b, IL_028a, IL_031a, IL_032a, IL_0339, IL_0362, IL_037d
		int num = 14;
		DataClassMetadataItem dataClassMetadataItem = default(DataClassMetadataItem);
		Type type = default(Type);
		string key = default(string);
		string value = default(string);
		Guid result = default(Guid);
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 3:
					if (dataClassMetadataItem != null)
					{
						num2 = 25;
						continue;
					}
					goto case 24;
				case 9:
					zxRKLEEdYW7YcBRD12yE(dataClassMetadataItem.Header, QPvR8BEdd0oQQS0L9MNT(mdMerged));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					l5CmguEdjRDOqBNv2lVf(CDtisxEdglv6lfFHS6ju(dataClassMetadataItem), k1qLpOEd5IeZKB270key(mdMerged));
					num2 = 9;
					continue;
				case 20:
					parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487107650), QPvR8BEdd0oQQS0L9MNT(mdMerged), i7p97VEd7UX8YnCnFkHa(mdMerged), k1qLpOEd5IeZKB270key(mdMerged)), endProcess: false));
					num2 = 18;
					continue;
				case 5:
					ImportLog.InfoFormat((string)YgrfKQEdALiALRcpi62N(0x571EA399 ^ 0x571A6F59), Dk8logEdzAbHRa7Ig8CY(type), NpKNi4ElFCcx83YJ5Qja(dataClassMetadataItem));
					num2 = 10;
					continue;
				case 15:
					ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138228491), Dk8logEdzAbHRa7Ig8CY(type), NpKNi4ElFCcx83YJ5Qja(dataClassMetadataItem));
					num2 = 20;
					continue;
				case 4:
				case 11:
				case 12:
				case 26:
					if (jcHleDEdcFGu03gaEmhC(ImportLog))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 16;
				case 23:
					key = (string)MImc0lEdUIWDAJR8eq90(YgrfKQEdALiALRcpi62N(-521266112 ^ -521482028), QPvR8BEdd0oQQS0L9MNT(mdMerged));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					hIol6rEdLRqjM86dfbqB(dataClassMetadataItem, mdMerged);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 23;
					}
					continue;
				case 8:
					if (!Guid.TryParse(value, out result))
					{
						num = 12;
						break;
					}
					goto case 6;
				case 21:
					EntityMetadataDependencyService.GetPromisedMetadataDependencies(actorContextService).Add(mdMerged);
					num = 7;
					break;
				case 2:
					if (!parameters.ServiceData.TryGetValue(key, out value))
					{
						num2 = 26;
						continue;
					}
					goto case 8;
				case 6:
					metadataItemGroupUI = metadataItemGroupUIManager.LoadOrNull(result);
					num = 19;
					break;
				case 18:
					GetImportHeaders(actorContextService).Add(DdjwH3ElW5WVouIcEnHc(CDtisxEdglv6lfFHS6ju(dataClassMetadataItem)));
					num2 = 21;
					continue;
				case 7:
					return;
				case 22:
					twJ3ErEds3PHBoiLCjUX(dataClassMetadataItem.Header, metadataItemGroupUI);
					num2 = 11;
					continue;
				case 16:
					obj = null;
					goto IL_0428;
				case 19:
					if (metadataItemGroupUI == null)
					{
						num2 = 4;
						continue;
					}
					goto case 22;
				case 10:
					OBf6BkElBNpRk5U3V0Da(dataClassMetadataItem);
					num = 15;
					break;
				case 24:
					dataClassMetadataItem = dataClassMetadataItemManager.Create(tey8hmEdr4knoT8DqtNy(mdMerged), Guid.Empty, (string)i7p97VEd7UX8YnCnFkHa(mdMerged));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
				{
					DataClassMetadataItemHeader dataClassMetadataItemHeader = dataClassMetadataItemHeaderManager.LoadOrNull(QPvR8BEdd0oQQS0L9MNT(mdMerged));
					if (dataClassMetadataItemHeader == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj2 = ES2TJkEdlMTnR3vZQaUi(dataClassMetadataItemHeader);
					goto IL_0416;
				}
				case 13:
					obj2 = null;
					goto IL_0416;
				case 17:
					{
						obj = mdMerged.GetType();
						goto IL_0428;
					}
					IL_0416:
					dataClassMetadataItem = (DataClassMetadataItem)obj2;
					num2 = 3;
					continue;
					IL_0428:
					type = (Type)obj;
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	private static ICollection<Guid> GetImportHeaders(object actorContextService)
	{
		if (!((IActorContextService)actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE70D9D), out object value))
		{
			((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103B3961), value = new List<Guid>());
		}
		return (ICollection<Guid>)value;
	}

	static DataClassMetadataImportExtension()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				kS1YwaElbOgDcsZO0lUR();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				ImportLog = (ILogger)ejElsBElhaqSnQbpGpXb(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A853A6A));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool APg3QHEd6MhONclpl6CR()
	{
		return ra4BaVEd4xEgUXt6ERd4 == null;
	}

	internal static DataClassMetadataImportExtension g5sY62EdHlItTlHEskxD()
	{
		return ra4BaVEd4xEgUXt6ERd4;
	}

	internal static object YgrfKQEdALiALRcpi62N(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object i7p97VEd7UX8YnCnFkHa(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void p7l9FsEdxdUqRdUuf6oF(object P_0, object P_1)
	{
		((ReadMetadataParameters)P_0).TestMessagesAdd((TestImportMessages)P_1);
	}

	internal static object jdb8pREd0Wvu18GeTxWo(object P_0)
	{
		return ((ReadMetadataParameters)P_0).MergeReplace;
	}

	internal static Guid tBk7SuEdmKDqL3C6g8Dy(object P_0)
	{
		return ((Dependency)P_0).HeaderUid;
	}

	internal static void s8UtuREdyilThtB5lHjq(object P_0, Guid value)
	{
		((Dependency)P_0).HeaderUid = value;
	}

	internal static Guid JuxotnEdMQahuPKokN6F(object P_0, Guid uidFrom)
	{
		return ((MergeReplace)P_0).GetUidReplaceMD(uidFrom);
	}

	internal static object BsqgTlEdJ8FUw9nnlYTX(object P_0)
	{
		return ((DataClassMetadata)P_0).TypeToMap;
	}

	internal static void XXgXcZEd929ioGMsQIa8(object P_0, object P_1)
	{
		((DataClassMetadata)P_0).TypeToMap = (TypeToMap)P_1;
	}

	internal static Guid QPvR8BEdd0oQQS0L9MNT(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object ES2TJkEdlMTnR3vZQaUi(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Draft;
	}

	internal static Guid tey8hmEdr4knoT8DqtNy(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static object CDtisxEdglv6lfFHS6ju(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Header;
	}

	internal static object k1qLpOEd5IeZKB270key(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void l5CmguEdjRDOqBNv2lVf(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static void zxRKLEEdYW7YcBRD12yE(object P_0, Guid value)
	{
		((DataClassMetadataItemHeader)P_0).Uid = value;
	}

	internal static void hIol6rEdLRqjM86dfbqB(object P_0, object P_1)
	{
		((DataClassMetadataItem)P_0).Metadata = P_1;
	}

	internal static object MImc0lEdUIWDAJR8eq90(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void twJ3ErEds3PHBoiLCjUX(object P_0, object P_1)
	{
		((DataClassMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static bool jcHleDEdcFGu03gaEmhC(object P_0)
	{
		return ((ILogger)P_0).IsInfoEnabled();
	}

	internal static object Dk8logEdzAbHRa7Ig8CY(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Guid NpKNi4ElFCcx83YJ5Qja(object P_0)
	{
		return ((DataClassMetadataItem)P_0).Uid;
	}

	internal static void OBf6BkElBNpRk5U3V0Da(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static Guid DdjwH3ElW5WVouIcEnHc(object P_0)
	{
		return ((DataClassMetadataItemHeader)P_0).Uid;
	}

	internal static bool dNW02eElotqVaml2RpDJ(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static void kS1YwaElbOgDcsZO0lUR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ejElsBElhaqSnQbpGpXb(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
