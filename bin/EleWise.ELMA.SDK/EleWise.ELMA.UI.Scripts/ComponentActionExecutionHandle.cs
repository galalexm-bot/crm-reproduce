using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

internal sealed class ComponentActionExecutionHandler : AbstractActionExecutionHandler
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModuleAssemblyLoader moduleAssemblyLoader;

	private readonly ILockService lockService;

	private static ComponentActionExecutionHandler uk2XLGggmufxWTOlYIC;

	public ComponentActionExecutionHandler(IExecutionScopeFactory executionScopeFactory, IModuleReferenceManager moduleReferenceManager, IComponentMetadataItemManager componentMetadataItemManager, IModuleMetadataLoader moduleMetadataLoader, IModuleAssemblyLoader moduleAssemblyLoader, ILockService lockService)
	{
		//Discarded unreachable code: IL_002b
		K13kmQgYcaFI1hkH9Qf();
		base._002Ector(executionScopeFactory);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.moduleAssemblyLoader = moduleAssemblyLoader;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 2;
				}
				break;
			case 1:
				this.moduleReferenceManager = moduleReferenceManager;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 4;
				}
				break;
			case 3:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.lockService = lockService;
				num = 5;
				break;
			case 4:
			{
				this.componentMetadataItemManager = componentMetadataItemManager;
				int num2 = 3;
				num = num2;
				break;
			}
			case 5:
				return;
			}
		}
	}

	public override bool Check(ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_0044, IL_0053
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return XQkE9UgUFmFECwRRZTR(parameters) == PortletComponentMetadata.TypeUid;
			case 3:
				return true;
			case 1:
				if (!oM9qwUgLoVGe1ST6WEv(parameters.TypeUid, ComponentMetadata.TypeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				if (oM9qwUgLoVGe1ST6WEv(XQkE9UgUFmFECwRRZTR(parameters), PageComponentMetadata.TypeUid))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public override ActionExecutionResult Execute(ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_01c9, IL_01d8, IL_01fb, IL_02a7, IL_02df, IL_0317, IL_0357, IL_0366, IL_038e, IL_03ce, IL_051d, IL_052c, IL_0537, IL_060a, IL_0629, IL_0638, IL_0655, IL_0664, IL_06e0, IL_094e
		int num = 31;
		Assembly assembly = default(Assembly);
		string text4 = default(string);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		List<IMetadata> list = default(List<IMetadata>);
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		string text6 = default(string);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		ItemRuntimeModel itemRuntimeModel = default(ItemRuntimeModel);
		UIRuntimeModel orDefault = default(UIRuntimeModel);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		string text = default(string);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		ModuleReference moduleReference = default(ModuleReference);
		ActionExecutionResult actionExecutionResult = default(ActionExecutionResult);
		Type type = default(Type);
		ModuleVersion moduleVersion = default(ModuleVersion);
		Guid itemUid = default(Guid);
		string text3 = default(string);
		string text5 = default(string);
		string text2 = default(string);
		IEnumerator<ItemRuntimeModel> enumerator = default(IEnumerator<ItemRuntimeModel>);
		ItemRuntimeModel current = default(ItemRuntimeModel);
		ModuleInfoMetadata metadata = default(ModuleInfoMetadata);
		ServerBuildResult serverBuildResult = default(ServerBuildResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					if (!TkgpBJ5ocUTBkrCbCTU(assembly, null))
					{
						num = 5;
						break;
					}
					goto default;
				case 14:
					text4 = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string)JigWTWgzhJCqHU4R20D(componentMetadataItem), (string)stMS6q5F09naGrUo7kD(componentMetadataItem), (string)t0un5g5B6xcpujZoI3c(-1998538950 ^ -1998556452), (string)t0un5g5B6xcpujZoI3c(0xE1229CF ^ 0xE123929));
					num2 = 35;
					continue;
				case 1:
					assembly = (Assembly)H76YNI5WTtybiE2oJ1H(text4, true);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 19;
					}
					continue;
				case 25:
					return actionExecutionResult;
				case 5:
				case 47:
					list.AddRange(moduleInfoMetadata.GetMetadataToRegister());
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 33;
					}
					continue;
				case 20:
					RL53HP5f0MZBVXopC2H(Logger.Log, text6);
					num2 = 32;
					continue;
				case 8:
					list.AddRange(componentMetadata.GetMetadataToRegister());
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 17;
					}
					continue;
				case 44:
					list.Add(componentMetadata);
					num2 = 8;
					continue;
				case 6:
					itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CExecute_003Eb__0);
					num2 = 42;
					continue;
				case 46:
					text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876080051), exVjyc5TrK05P0QWAOZ(scriptMethodInfo), syVwjE5khpvhmpKhAXR(componentMetadata));
					num2 = 38;
					continue;
				case 28:
					moduleReference = moduleReferenceManager.LoadOrNull(_003C_003Ec__DisplayClass7_.instanceUid);
					num2 = 29;
					continue;
				case 18:
					try
					{
						MetadataServiceContext metadataServiceContext = MetadataServiceContext.Extend(list);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								actionExecutionResult = Execute(type, parameters);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num4 = 0;
								}
								return num4 switch
								{
									0 => actionExecutionResult, 
									_ => actionExecutionResult, 
								};
							}
							finally
							{
								int num5;
								if (metadataServiceContext == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num5 = 1;
									}
									goto IL_031b;
								}
								goto IL_0331;
								IL_0331:
								Qyp7jk5RkS6xvReKTZN(metadataServiceContext);
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num5 = 0;
								}
								goto IL_031b;
								IL_031b:
								switch (num5)
								{
								case 1:
									goto end_IL_02f6;
								case 2:
									goto end_IL_02f6;
								}
								goto IL_0331;
								end_IL_02f6:;
							}
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								NkGlRD5PJuGihNRpfLq(Logger.Log, text, ex);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num6 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
				case 16:
					moduleVersion = (ModuleVersion)rCDE0p5QDAi3p1Q2D2J(moduleMetadataLoader, _003C_003Ec__DisplayClass7_.moduleUid, itemUid);
					num2 = 17;
					continue;
				case 23:
					RL53HP5f0MZBVXopC2H(Logger.Log, text3);
					num2 = 27;
					continue;
				case 24:
					assembly = (Assembly)qYgBdO5ERNIST6ZhgW6(lockService, text4, true, Mp5D8v5b6wICAYguJLO(componentMetadataItem.ScriptModule), Wq1Ss05GKj5w49AWwgH(EdWVsw5hLPoAXmOyrmB(componentMetadataItem)));
					num2 = 44;
					continue;
				case 11:
					text5 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426112067), by9K1v5qsIbByWB3maL(typeof(ComponentMetadata).TypeHandle).FullName);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 41;
					}
					continue;
				case 12:
					text3 = (string)tJVeim5emRwUVGVD1UG(text, SR.T((string)t0un5g5B6xcpujZoI3c(-812025778 ^ -812007650), text2));
					num2 = 23;
					continue;
				case 30:
					list = new List<IMetadata>();
					num2 = 15;
					continue;
				case 45:
					componentMetadataItem = componentMetadataItemManager.Load(_003C_003Ec__DisplayClass7_.instanceUid);
					num2 = 21;
					continue;
				case 10:
					componentMetadata = moduleInfoMetadata.Components.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CExecute_003Eb__1);
					num2 = 9;
					continue;
				case 39:
					try
					{
						while (true)
						{
							IL_05be:
							int num7;
							if (!s9cjs25in82RV3m0lMm(enumerator))
							{
								num7 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num7 = 3;
								}
								goto IL_053b;
							}
							goto IL_059b;
							IL_059b:
							current = enumerator.Current;
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num7 = 1;
							}
							goto IL_053b;
							IL_053b:
							while (true)
							{
								switch (num7)
								{
								case 1:
									metadata = ((ModuleVersion)rCDE0p5QDAi3p1Q2D2J(moduleMetadataLoader, TqAvDy5V1g5dR8eqKW6(current), EIpOBe5SXGs5sh91hK2(current))).Metadata;
									num7 = 2;
									continue;
								case 2:
									list.AddRange(metadata.GetMetadataToRegister());
									num7 = 4;
									continue;
								case 4:
									goto IL_05be;
								case 3:
									goto end_IL_05be;
								}
								break;
							}
							goto IL_059b;
							continue;
							end_IL_05be:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator == null)
						{
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num8 = 0;
							}
							goto IL_060e;
						}
						goto IL_0643;
						IL_0643:
						Qyp7jk5RkS6xvReKTZN(enumerator);
						num8 = 2;
						goto IL_060e;
						IL_060e:
						switch (num8)
						{
						case 1:
							goto end_IL_05e9;
						case 2:
							goto end_IL_05e9;
						}
						goto IL_0643;
						end_IL_05e9:;
					}
					goto case 34;
				case 22:
					text6 = SR.T((string)t0un5g5B6xcpujZoI3c(0x4EA5403C ^ 0x4EA58620), _003C_003Ec__DisplayClass7_.moduleUid);
					num2 = 20;
					continue;
				case 26:
					orDefault = ContextVars.GetOrDefault<UIRuntimeModel>((string)t0un5g5B6xcpujZoI3c(-420743386 ^ -420793634));
					num2 = 6;
					continue;
				case 37:
					type = gBWF0w5Ou3viDsoeyXX(assembly, text2);
					num2 = 7;
					continue;
				case 17:
					serverBuildResult = (ServerBuildResult)A2BeYB5CAg3KVbIYbJy(moduleAssemblyLoader, _003C_003Ec__DisplayClass7_.moduleUid, itemUid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 36;
					}
					continue;
				case 35:
					assembly = (Assembly)H76YNI5WTtybiE2oJ1H(text4, true);
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 27;
					}
					continue;
				case 15:
					_003C_003Ec__DisplayClass7_.instanceUid = sopgp4gsqi6NWVM6tRi(parameters);
					num2 = 28;
					continue;
				case 36:
					moduleInfoMetadata = (ModuleInfoMetadata)txqxu55v7CVdUoIDn2f(moduleVersion);
					num2 = 10;
					continue;
				case 42:
					if (itemRuntimeModel == null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 22;
						}
						continue;
					}
					itemUid = itemRuntimeModel.ItemUid;
					num = 16;
					break;
				default:
					assembly = ComponentManager.LoadAssemblyWithLock(lockService, text4, isFullName: true, serverBuildResult.AssemblyRaw, (byte[])VnEcir5IijnEfhfTSb0(serverBuildResult));
					num2 = 47;
					continue;
				case 31:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 30;
					continue;
				case 34:
				case 40:
					if (componentMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 11;
				case 3:
					throw new Exception(text5);
				case 2:
					scriptMethodInfo = (ScriptMethodInfo)TdGdd95XQgXA1Ki9U4V(aga0p55KdyaAYglwPvd(parameters));
					num = 46;
					break;
				case 7:
					if (!u5FvIB52PVskxVyD9VW(type, null))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 12;
				case 41:
					RL53HP5f0MZBVXopC2H(Logger.Log, text5);
					num2 = 3;
					continue;
				case 4:
					if (oM9qwUgLoVGe1ST6WEv(_003C_003Ec__DisplayClass7_.moduleUid, Guid.Empty))
					{
						num = 45;
						break;
					}
					goto case 26;
				case 21:
					componentMetadata = (ComponentMetadata)rFeWeJgc40XDcJx3r32(componentMetadataItem);
					num2 = 14;
					continue;
				case 32:
					throw new Exception(text6);
				case 38:
					text2 = (string)brJmIk5nQSYb1BJMDOS(componentMetadata);
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 37;
					}
					continue;
				case 9:
					text4 = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string)D9G1IW58lM98Ja5Muuu(serverBuildResult), hH7BKC5ubNoOx5EZJB8(QL0SMc5ZHiLx1MUCBrT(moduleVersion)).ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FF7F4), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A778751));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
					continue;
				case 43:
					if (TkgpBJ5ocUTBkrCbCTU(assembly, null))
					{
						num2 = 24;
						continue;
					}
					goto case 44;
				case 27:
					throw new Exception(text3);
				case 13:
					num = 18;
					break;
				case 29:
					_003C_003Ec__DisplayClass7_.moduleUid = moduleReference?.ModuleUid ?? Guid.Empty;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 4;
					}
					continue;
				case 33:
					enumerator = orDefault.RuntimeModules.Where(_003C_003Ec__DisplayClass7_._003CExecute_003Eb__2).GetEnumerator();
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 39;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void K13kmQgYcaFI1hkH9Qf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cZP668g51Cj6BHkDeDj()
	{
		return uk2XLGggmufxWTOlYIC == null;
	}

	internal static ComponentActionExecutionHandler EJhwVygjGY1yI1vK85X()
	{
		return uk2XLGggmufxWTOlYIC;
	}

	internal static bool oM9qwUgLoVGe1ST6WEv(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid XQkE9UgUFmFECwRRZTR(object P_0)
	{
		return ((ActionExecutionParams)P_0).TypeUid;
	}

	internal static Guid sopgp4gsqi6NWVM6tRi(object P_0)
	{
		return ((ActionExecutionParams)P_0).InstanceUid;
	}

	internal static object rFeWeJgc40XDcJx3r32(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static object JigWTWgzhJCqHU4R20D(object P_0)
	{
		return ((ComponentMetadataItem)P_0).AssemblyName;
	}

	internal static object stMS6q5F09naGrUo7kD(object P_0)
	{
		return ((ComponentMetadataItem)P_0).AssemblyVersion;
	}

	internal static object t0un5g5B6xcpujZoI3c(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object H76YNI5WTtybiE2oJ1H(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static bool TkgpBJ5ocUTBkrCbCTU(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object Mp5D8v5b6wICAYguJLO(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object EdWVsw5hLPoAXmOyrmB(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ScriptModule;
	}

	internal static object Wq1Ss05GKj5w49AWwgH(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object qYgBdO5ERNIST6ZhgW6(object P_0, object P_1, bool isFullName, object P_3, object P_4)
	{
		return ComponentManager.LoadAssemblyWithLock((ILockService)P_0, (string)P_1, isFullName, (byte[])P_3, (byte[])P_4);
	}

	internal static void RL53HP5f0MZBVXopC2H(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object rCDE0p5QDAi3p1Q2D2J(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleMetadataLoader)P_0).GetSpecificModuleVersion(moduleUid, versionUid);
	}

	internal static object A2BeYB5CAg3KVbIYbJy(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleAssemblyLoader)P_0).GetServerAssembly(moduleUid, versionUid);
	}

	internal static object txqxu55v7CVdUoIDn2f(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object D9G1IW58lM98Ja5Muuu(object P_0)
	{
		return ((ServerBuildResult)P_0).AssemblyName;
	}

	internal static object QL0SMc5ZHiLx1MUCBrT(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static object hH7BKC5ubNoOx5EZJB8(object P_0)
	{
		return ((ModuleVersionHeader)P_0).Version;
	}

	internal static object VnEcir5IijnEfhfTSb0(object P_0)
	{
		return ((ServerBuildResult)P_0).DebugRaw;
	}

	internal static Guid TqAvDy5V1g5dR8eqKW6(object P_0)
	{
		return ((ItemRuntimeModel)P_0).HeaderUid;
	}

	internal static Guid EIpOBe5SXGs5sh91hK2(object P_0)
	{
		return ((ItemRuntimeModel)P_0).ItemUid;
	}

	internal static bool s9cjs25in82RV3m0lMm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Qyp7jk5RkS6xvReKTZN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type by9K1v5qsIbByWB3maL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object aga0p55KdyaAYglwPvd(object P_0)
	{
		return ((ActionExecutionParams)P_0).ScriptName;
	}

	internal static object TdGdd95XQgXA1Ki9U4V(object P_0)
	{
		return ScriptMethodInfoHelper.Deserialize((string)P_0);
	}

	internal static object exVjyc5TrK05P0QWAOZ(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static object syVwjE5khpvhmpKhAXR(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object brJmIk5nQSYb1BJMDOS(object P_0)
	{
		return ComponentMetadataHelperInternal.ControllerTypeName((ComponentMetadata)P_0);
	}

	internal static Type gBWF0w5Ou3viDsoeyXX(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool u5FvIB52PVskxVyD9VW(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object tJVeim5emRwUVGVD1UG(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void NkGlRD5PJuGihNRpfLq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
