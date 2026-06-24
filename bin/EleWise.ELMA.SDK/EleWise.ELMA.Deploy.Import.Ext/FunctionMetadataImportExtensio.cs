using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
internal class FunctionMetadataImportExtension : NamedMetadataImportExtension<FunctionMetadata>
{
	[Component(Order = 2300)]
	private sealed class FunctionConfigImportExtension : ConfigImportExtension
	{
		private readonly object functionMetadataItemHeaderManager;

		private readonly object functionMetadataItemManager;

		private readonly object securityService;

		private readonly object actorContextService;

		internal static object TpFonX8Hu1uQ1GivblVK;

		private ICollection<DeployLogMessage> DeployLogMessages
		{
			get
			{
				if (!((IActorContextService)actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811630888), out object value))
				{
					((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3BE9E8), value = new List<DeployLogMessage>());
				}
				return (ICollection<DeployLogMessage>)value;
			}
		}

		public FunctionConfigImportExtension(IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager, IFunctionMetadataItemManager functionMetadataItemManager, ISecurityService securityService, IActorContextService actorContextService)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			R9pFj88HS2bXgFaXmk4a();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 2:
					this.functionMetadataItemManager = functionMetadataItemManager;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				case 4:
					this.actorContextService = actorContextService;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num = 1;
					}
					break;
				default:
					this.securityService = securityService;
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num = 4;
					}
					break;
				case 3:
					this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
					num = 2;
					break;
				}
			}
		}

		public override void OnPostReadPackets(PostReadPacketsParameters parameters)
		{
			//Discarded unreachable code: IL_0170, IL_017f, IL_01d6
			int num = 2;
			ICollection<Guid> importHeaders = default(ICollection<Guid>);
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
			List<KeyValuePair<string, string>> list = default(List<KeyValuePair<string, string>>);
			Guid[] array = default(Guid[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 11:
						if (PcZ8wm8HRF5JjQ7c3nVW(importHeaders) <= 0)
						{
							num = 7;
							break;
						}
						goto case 5;
					case 13:
						if (_003C_003Ec__DisplayClass5_.parameters.HeaderIds.Count == 0)
						{
							num2 = 10;
							continue;
						}
						goto case 4;
					case 10:
						importHeaders = GetImportHeaders(actorContextService);
						num = 11;
						break;
					case 15:
						list.ForEach(_003C_003Ec__DisplayClass5_._003COnPostReadPackets_003Eb__2);
						num2 = 6;
						continue;
					case 1:
						_003C_003Ec__DisplayClass5_.parameters = parameters;
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 14;
						}
						continue;
					default:
						if (array.Length == 0)
						{
							num2 = 8;
							continue;
						}
						goto case 9;
					case 2:
						_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
					case 7:
						if (ueZX5N8HiMPZeKIHNi9s(_003C_003Ec__DisplayClass5_.parameters) == 2)
						{
							num2 = 12;
							continue;
						}
						return;
					case 5:
						Publish(importHeaders, _003C_003Ec__DisplayClass5_.parameters.Messages, (string)lDo5qi8HqCcGfIvPap0t(_003C_003Ec__DisplayClass5_.parameters));
						num2 = 4;
						continue;
					case 9:
						Publish(array, _003C_003Ec__DisplayClass5_.parameters.Messages, (string)lDo5qi8HqCcGfIvPap0t(_003C_003Ec__DisplayClass5_.parameters));
						num2 = 15;
						continue;
					case 6:
						return;
					case 8:
						return;
					case 14:
						if (ueZX5N8HiMPZeKIHNi9s(_003C_003Ec__DisplayClass5_.parameters) == 1)
						{
							num2 = 13;
							continue;
						}
						goto case 4;
					case 12:
						list = _003C_003Ec__DisplayClass5_.parameters.ServiceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E22B79))).ToList();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 3;
						}
						continue;
					case 3:
						array = list.Select((KeyValuePair<string, string> record) => new Guid(record.Value)).ToArray();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}

		public void Publish(IEnumerable<Guid> headerUids, ICollection<DeployLogMessage> messages = null, string treeUid = null)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.headerUids = headerUids;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.messages = messages;
			CS_0024_003C_003E8__locals0.treeUid = treeUid;
			CS_0024_003C_003E8__locals0.messages = CS_0024_003C_003E8__locals0.messages ?? DeployLogMessages;
			((ISecurityService)securityService).RunWithElevatedPrivilegies((Action)delegate
			{
				//Discarded unreachable code: IL_002f, IL_0039, IL_00df, IL_02aa, IL_02da, IL_031a, IL_0329, IL_0335, IL_0344
				int num = 1;
				int num2 = num;
				IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
				Guid current = default(Guid);
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					default:
						try
						{
							while (true)
							{
								int num3;
								if (!_003C_003Ec__DisplayClass6_0.GnJY3oZP3p9onigd9MVd(enumerator))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num3 = 1;
									}
									goto IL_003d;
								}
								goto IL_0057;
								IL_0057:
								current = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num3 = 0;
								}
								goto IL_003d;
								IL_003d:
								switch (num3)
								{
								case 1:
									return;
								case 2:
									break;
								case 3:
									continue;
								default:
									try
									{
										((IFunctionMetadataItemManager)CS_0024_003C_003E8__locals0._003C_003E4__this.functionMetadataItemManager).Publish(current, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489011707));
										int num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
										{
											num4 = 1;
										}
										while (true)
										{
											switch (num4)
											{
											case 3:
												ImportLog.Info(text);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
												{
													num4 = 0;
												}
												continue;
											default:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text, endProcess: false));
												num4 = 2;
												continue;
											case 1:
												text = SR.T((string)_003C_003Ec__DisplayClass6_0.PapsvbZPe5X9EXyHdulJ(0x3B36AB09 ^ 0x3B309EC3), current);
												num4 = 3;
												continue;
											case 2:
												break;
											}
											break;
										}
									}
									catch (Exception ex)
									{
										int num5 = 3;
										int num6 = num5;
										while (true)
										{
											switch (num6)
											{
											case 3:
												_003C_003Ec__DisplayClass6_0.nmIY3VZPPK5AftC9BP1G(ImportLog, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A1D576), current, ex));
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
												{
													num6 = 0;
												}
												continue;
											default:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, current, CS_0024_003C_003E8__locals0.treeUid));
												num6 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
												{
													num6 = 2;
												}
												continue;
											case 1:
												CS_0024_003C_003E8__locals0.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T((string)_003C_003Ec__DisplayClass6_0.PapsvbZPe5X9EXyHdulJ(-29254301 ^ -28857505), current, _003C_003Ec__DisplayClass6_0.Tyrx5uZP1TmZRqEwYiUV(ex)), endProcess: false));
												num6 = 4;
												continue;
											case 4:
												if (!_003C_003Ec__DisplayClass6_0.bEOyoMZPNZ9JqJd12vKl(CS_0024_003C_003E8__locals0.treeUid))
												{
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
													{
														num6 = 0;
													}
													continue;
												}
												break;
											case 2:
												break;
											}
											break;
										}
									}
									continue;
								}
								goto IL_0057;
							}
						}
						finally
						{
							int num7;
							if (enumerator == null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num7 = 1;
								}
								goto IL_02de;
							}
							goto IL_02f4;
							IL_02f4:
							_003C_003Ec__DisplayClass6_0.lu0DLOZPpbeNntTc8OTC(enumerator);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num7 = 2;
							}
							goto IL_02de;
							IL_02de:
							switch (num7)
							{
							case 1:
								goto end_IL_02b9;
							case 2:
								goto end_IL_02b9;
							}
							goto IL_02f4;
							end_IL_02b9:;
						}
					case 1:
						enumerator = CS_0024_003C_003E8__locals0.headerUids.GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 0;
						}
						break;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void SetPromisedDependenciesKey(IDictionary<string, string> serviceData)
		{
			foreach (KeyValuePair<string, string> item in serviceData.Where((KeyValuePair<string, string> m) => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459167613))).ToList())
			{
				if (Guid.TryParse(item.Value, out var result))
				{
					string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138904566), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8327CE8), item.Value);
					((IActorContextService)actorContextService).Set(key, (object)result);
					((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16718813), (object)string.Empty);
					serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538549550)] = string.Empty;
				}
			}
		}

		internal static void R9pFj88HS2bXgFaXmk4a()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool XLDYDv8HIeyGXAH79qC2()
		{
			return TpFonX8Hu1uQ1GivblVK == null;
		}

		internal static FunctionConfigImportExtension n381wq8HViWuWpLn9b3h()
		{
			return (FunctionConfigImportExtension)TpFonX8Hu1uQ1GivblVK;
		}

		internal static int ueZX5N8HiMPZeKIHNi9s(object P_0)
		{
			return ((ImportExtensionParameters)P_0).ImportStep;
		}

		internal static int PcZ8wm8HRF5JjQ7c3nVW(object P_0)
		{
			return ((ICollection<Guid>)P_0).Count;
		}

		internal static object lDo5qi8HqCcGfIvPap0t(object P_0)
		{
			return ((ImportExtensionParameters)P_0).TreeUid;
		}
	}

	[Component(Order = -80)]
	private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
	{
		private readonly object actorContextService;

		private readonly ILazy<FunctionConfigImportExtension> functionConfigImportExtension;

		public ModelAssemblyBuilderHandler(IActorContextService actorContextService, ILazy<FunctionConfigImportExtension> functionConfigImportExtension)
		{
			SingletonReader.PushGlobal();
			base._002Ector();
			this.actorContextService = actorContextService;
			this.functionConfigImportExtension = functionConfigImportExtension;
		}

		public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
		{
			ICollection<Guid> importHeaders = GetImportHeaders(actorContextService);
			if (importHeaders.Count > 0)
			{
				functionConfigImportExtension.Value.Publish(importHeaders);
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
	internal class FunctionMetadataImport : MetadataImport
	{
		internal static FunctionMetadataImport RYFoHB8HkbrPyjFWQ7g3;

		public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
		{
			//Discarded unreachable code: IL_0039, IL_0048, IL_0097, IL_00a6
			int num = 1;
			int num2 = num;
			FunctionMetadata functionMetadata = default(FunctionMetadata);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 5:
					fakeManifest.GetOrCreateChapterByUid(FunctionExportConsts.ExportExtensionUid).GetOrCreateItemByUid(VZK9yt8H2M9fG9qnbYDP(functionMetadata), (string)aJobil8He48YblCMivd6(functionMetadata));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 4:
					return;
				case 3:
					if ((functionMetadata = namedMd as FunctionMetadata) == null)
					{
						num2 = 4;
						break;
					}
					goto case 5;
				case 1:
					if (fakeManifest == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}

		public FunctionMetadataImport()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			hWOCtR8HP6KOnlGLOICT();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Guid VZK9yt8H2M9fG9qnbYDP(object P_0)
		{
			return ((AbstractMetadata)P_0).Uid;
		}

		internal static object aJobil8He48YblCMivd6(object P_0)
		{
			return ((NamedMetadata)P_0).DisplayName;
		}

		internal static bool lcQ36f8HnwARwZW6Na3b()
		{
			return RYFoHB8HkbrPyjFWQ7g3 == null;
		}

		internal static FunctionMetadataImport JRLgmA8HOfwPiFh18Bbe()
		{
			return RYFoHB8HkbrPyjFWQ7g3;
		}

		internal static void hWOCtR8HP6KOnlGLOICT()
		{
			SingletonReader.PushGlobal();
		}
	}

	private static readonly ILogger ImportLog;

	private readonly IFunctionMetadataItemManager functionMetadataItemManager;

	private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;

	private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;

	private readonly IActorContextService actorContextService;

	private readonly IFeatureFlagService featureFlagService;

	private static FunctionMetadataImportExtension ldwAEZEdb7WQ6l9lGVSL;

	private bool SecondRuntimeEnabled => dLYlr9EdwsKFmlFeW06D(featureFlagService, OHWPRAEdCPvCkCi9QOGF(0x3630F361 ^ 0x36305D6B), false);

	public FunctionMetadataImportExtension(IFunctionMetadataItemManager functionMetadataItemManager, IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager, IMetadataItemGroupUIManager metadataItemGroupUIManager, IActorContextService actorContextService, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		m8fsciEdEeKnAYIlyPnb();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.metadataItemGroupUIManager = metadataItemGroupUIManager;
				num = 4;
				break;
			case 4:
				this.actorContextService = actorContextService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.featureFlagService = featureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			case 5:
				this.functionMetadataItemManager = functionMetadataItemManager;
				num = 3;
				break;
			}
		}
	}

	protected override bool TestMetadata(FunctionMetadata mdMerged, ReadMetadataParameters parameters, bool isTestRead)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!SecondRuntimeEnabled)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				}
				return base.TestMetadata(mdMerged, parameters, isTestRead);
			case 1:
				fCbs8UEdQyEhEGTJ7T3p(parameters, new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335280539), Ce4txZEdfSnFOW1ESNOh(mdMerged))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return false;
			}
		}
	}

	protected override bool CheckMetadata(FunctionMetadata mdImported, FunctionMetadata mdDraft, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			default:
				return base.CheckMetadata(mdImported, mdDraft, parameters);
			case 2:
				parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)OHWPRAEdCPvCkCi9QOGF(-1459557599 ^ -1459336373), Ce4txZEdfSnFOW1ESNOh(mdImported))));
				num2 = 3;
				break;
			case 1:
				if (SecondRuntimeEnabled)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override void CheckNewMetadata(FunctionMetadata mdImported, bool isTestRead, ReadMetadataParameters parameters)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!isTestRead)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 4;
					}
					break;
				}
				return;
			case 4:
				px81SwEdu18e2Wvx0R9a(Lske4VEdvs27KL03YrJ5(mdImported), oB8UHqEdZ5cFxSMTLGSv(parameters.MergeReplace, M9CudCEd8q8dgWqYAUeg(Lske4VEdvs27KL03YrJ5(mdImported))));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				base.CheckNewMetadata(mdImported, isTestRead, parameters);
				num2 = 2;
				break;
			case 1:
				((TypeSignature)rVGQaCEdIsmUusiV0ZoC(mdImported)).SubTypeUid = oB8UHqEdZ5cFxSMTLGSv(bVem78EdV7e8yUhAfplC(parameters), M9CudCEd8q8dgWqYAUeg(rVGQaCEdIsmUusiV0ZoC(mdImported)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void MergeMetadata(FunctionMetadata mdImported, FunctionMetadata mdDraft, bool isTestRead, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_009d, IL_00ac
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 7:
				return;
			case 4:
				if (isTestRead)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				mdDraft.ReturnType = (TypeSignature)Lske4VEdvs27KL03YrJ5(mdImported);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				px81SwEdu18e2Wvx0R9a(rVGQaCEdIsmUusiV0ZoC(mdDraft), oB8UHqEdZ5cFxSMTLGSv(parameters.MergeReplace, M9CudCEd8q8dgWqYAUeg(rVGQaCEdIsmUusiV0ZoC(mdDraft))));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				mdDraft.ParameterType = (TypeSignature)rVGQaCEdIsmUusiV0ZoC(mdImported);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				px81SwEdu18e2Wvx0R9a(Lske4VEdvs27KL03YrJ5(mdDraft), parameters.MergeReplace.GetUidReplaceMD(M9CudCEd8q8dgWqYAUeg(Lske4VEdvs27KL03YrJ5(mdDraft))));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	protected override void SaveMetadata(FunctionMetadata mdMerged, ReadMetadataParameters parameters)
	{
		//Discarded unreachable code: IL_024a
		int num = 19;
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		Guid result = default(Guid);
		FunctionMetadataItem functionMetadataItem = default(FunctionMetadataItem);
		string key = default(string);
		string value = default(string);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 24:
					metadataItemGroupUI = metadataItemGroupUIManager.LoadOrNull(result);
					num2 = 4;
					continue;
				case 8:
					omj4j8EdOh1i6dDyFbpZ(oN4sR5EdnC45JLlK5895(functionMetadataItem));
					num2 = 16;
					continue;
				default:
					nhoct7EdpvpJVLKqEEKO(GcM0wjEdTtOYQss3Uktb(functionMetadataItem), metadataItemGroupUI);
					num2 = 14;
					continue;
				case 10:
					if (functionMetadataItem == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 21;
				case 17:
					jBYs0QEdqsnRI19JxJwB(functionMetadataItem.Header, QyIj43EdRBCVhiGgH7hC(mdMerged));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 9;
					}
					continue;
				case 22:
					key = (string)b59VkWEd3VguqrxgWl40(OHWPRAEdCPvCkCi9QOGF(-867826612 ^ -868038440), xa1LINEdNDWe2dTHL2gc(mdMerged));
					num2 = 25;
					continue;
				case 2:
					sbe2MmEdkRtg4j9EwXL6(GcM0wjEdTtOYQss3Uktb(functionMetadataItem), mdMerged.Uid);
					num2 = 8;
					continue;
				case 9:
					v9od59EdXphV3ySLFe6S(functionMetadataItem.Header, PXseL8EdKKXcWR5pSL78(mdMerged));
					num2 = 2;
					continue;
				case 5:
					if (Guid.TryParse(value, out result))
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 14;
				case 25:
					if (parameters.ServiceData.TryGetValue(key, out value))
					{
						num2 = 5;
						continue;
					}
					goto case 14;
				case 21:
					GcsajsEd23Wnannrxr2M(functionMetadataItem, mdMerged);
					num = 23;
					break;
				case 3:
					ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243CF80), type.Name, Gd0fObEdDX0QbOTBStLb(functionMetadataItem));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					if (!ImportLog.IsInfoEnabled())
					{
						num2 = 11;
						continue;
					}
					obj2 = mdMerged.GetType();
					goto IL_0484;
				case 11:
					obj2 = null;
					goto IL_0484;
				case 20:
					GetImportHeaders(actorContextService).Add(X6xJB5EdtgvMCavatuNA(functionMetadataItem.Header));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
					parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463EC6E4), xa1LINEdNDWe2dTHL2gc(mdMerged), Ce4txZEdfSnFOW1ESNOh(mdMerged), QyIj43EdRBCVhiGgH7hC(mdMerged)), endProcess: false));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					functionMetadataItem = (FunctionMetadataItem)xmkXjAEdiYGnDQE7KwYK(functionMetadataItemManager, mdMerged.ModuleUid, Guid.Empty, Ce4txZEdfSnFOW1ESNOh(mdMerged));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 11;
					}
					continue;
				case 15:
					EntityMetadataDependencyService.GetPromisedMetadataDependencies(actorContextService).Add(mdMerged);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					functionMetadataItem.Save();
					num2 = 3;
					continue;
				case 23:
				{
					FunctionMetadataItem metadataItem = functionMetadataItem;
					ParameterExpression parameterExpression = (ParameterExpression)owhoMHEdPHaxHeYrfMoG(yncGLZEdepJEH1F4QC0I(typeof(FunctionMetadataItem).TypeHandle), OHWPRAEdCPvCkCi9QOGF(0x42643203 ^ 0x4264C793));
					SetScriptModule(metadataItem, Expression.Lambda<Func<FunctionMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)oqFM6XEd1lZjp30Krux1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), parameters);
					num2 = 22;
					continue;
				}
				case 4:
					if (metadataItemGroupUI != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 7:
					ImportLog.InfoFormat((string)OHWPRAEdCPvCkCi9QOGF(0x2A7797B7 ^ 0x2A735B77), VBTIfbEdaRQmO9vAmios(type), Gd0fObEdDX0QbOTBStLb(functionMetadataItem));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 13;
					}
					continue;
				case 16:
					functionMetadataItem.ScriptModule = null;
					num = 21;
					break;
				case 19:
				{
					FunctionMetadataItemHeader functionMetadataItemHeader = functionMetadataItemHeaderManager.LoadOrNull(mdMerged.Uid);
					if (functionMetadataItemHeader == null)
					{
						num2 = 18;
						continue;
					}
					obj = R77Xb4EdS8sx0lxhc1LO(functionMetadataItemHeader);
					goto IL_0472;
				}
				case 12:
					return;
				case 18:
					{
						obj = null;
						goto IL_0472;
					}
					IL_0472:
					functionMetadataItem = (FunctionMetadataItem)obj;
					num2 = 10;
					continue;
					IL_0484:
					type = (Type)obj2;
					num = 7;
					break;
				}
				break;
			}
		}
	}

	private static ICollection<Guid> GetImportHeaders(object actorContextService)
	{
		if (!((IActorContextService)actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998292318), out object value))
		{
			((IActorContextService)actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112456434), value = new List<Guid>());
		}
		return (ICollection<Guid>)value;
	}

	static FunctionMetadataImportExtension()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				m8fsciEdEeKnAYIlyPnb();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ImportLog = Logger.GetLogger((string)OHWPRAEdCPvCkCi9QOGF(0x12A5FAC7 ^ 0x12A17919));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void m8fsciEdEeKnAYIlyPnb()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool SR2NF3EdhUf3aNcVGGc6()
	{
		return ldwAEZEdb7WQ6l9lGVSL == null;
	}

	internal static FunctionMetadataImportExtension x9d0vsEdGDeYhkkYxlvl()
	{
		return ldwAEZEdb7WQ6l9lGVSL;
	}

	internal static object Ce4txZEdfSnFOW1ESNOh(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void fCbs8UEdQyEhEGTJ7T3p(object P_0, object P_1)
	{
		((ReadMetadataParameters)P_0).TestMessagesAdd((TestImportMessages)P_1);
	}

	internal static object OHWPRAEdCPvCkCi9QOGF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Lske4VEdvs27KL03YrJ5(object P_0)
	{
		return ((FunctionMetadata)P_0).ReturnType;
	}

	internal static Guid M9CudCEd8q8dgWqYAUeg(object P_0)
	{
		return ((TypeSignature)P_0).SubTypeUid;
	}

	internal static Guid oB8UHqEdZ5cFxSMTLGSv(object P_0, Guid uidFrom)
	{
		return ((MergeReplace)P_0).GetUidReplaceMD(uidFrom);
	}

	internal static void px81SwEdu18e2Wvx0R9a(object P_0, Guid value)
	{
		((TypeSignature)P_0).SubTypeUid = value;
	}

	internal static object rVGQaCEdIsmUusiV0ZoC(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static object bVem78EdV7e8yUhAfplC(object P_0)
	{
		return ((ReadMetadataParameters)P_0).MergeReplace;
	}

	internal static object R77Xb4EdS8sx0lxhc1LO(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Draft;
	}

	internal static object xmkXjAEdiYGnDQE7KwYK(object P_0, Guid moduleUid, Guid group, object P_3)
	{
		return ((IFunctionMetadataItemManager)P_0).Create(moduleUid, group, (string)P_3);
	}

	internal static object QyIj43EdRBCVhiGgH7hC(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void jBYs0QEdqsnRI19JxJwB(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object PXseL8EdKKXcWR5pSL78(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void v9od59EdXphV3ySLFe6S(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Description = (string)P_1;
	}

	internal static object GcM0wjEdTtOYQss3Uktb(object P_0)
	{
		return ((FunctionMetadataItem)P_0).Header;
	}

	internal static void sbe2MmEdkRtg4j9EwXL6(object P_0, Guid value)
	{
		((FunctionMetadataItemHeader)P_0).Uid = value;
	}

	internal static object oN4sR5EdnC45JLlK5895(object P_0)
	{
		return ((FunctionMetadataItem)P_0).ScriptModule;
	}

	internal static void omj4j8EdOh1i6dDyFbpZ(object P_0)
	{
		((Entity<long>)P_0).Delete();
	}

	internal static void GcsajsEd23Wnannrxr2M(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).Metadata = P_1;
	}

	internal static Type yncGLZEdepJEH1F4QC0I(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object owhoMHEdPHaxHeYrfMoG(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object oqFM6XEd1lZjp30Krux1(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static Guid xa1LINEdNDWe2dTHL2gc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object b59VkWEd3VguqrxgWl40(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void nhoct7EdpvpJVLKqEEKO(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static object VBTIfbEdaRQmO9vAmios(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Guid Gd0fObEdDX0QbOTBStLb(object P_0)
	{
		return ((FunctionMetadataItem)P_0).Uid;
	}

	internal static Guid X6xJB5EdtgvMCavatuNA(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Uid;
	}

	internal static bool dLYlr9EdwsKFmlFeW06D(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}
}
