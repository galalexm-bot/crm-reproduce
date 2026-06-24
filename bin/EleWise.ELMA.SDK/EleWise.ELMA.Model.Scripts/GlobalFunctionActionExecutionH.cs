using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

internal sealed class GlobalFunctionActionExecutionHandler : AbstractActionExecutionHandler
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly IFunctionMetadataItemManager functionMetadataItemManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModuleAssemblyLoader moduleAssemblyLoader;

	private static GlobalFunctionActionExecutionHandler OjPw3bbINKbu8iAPJbv0;

	public GlobalFunctionActionExecutionHandler(IExecutionScopeFactory executionScopeFactory, IModuleReferenceManager moduleReferenceManager, IFunctionMetadataItemManager functionMetadataItemManager, IModuleMetadataLoader moduleMetadataLoader, IModuleAssemblyLoader moduleAssemblyLoader)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		yOymjRbIagHbQxO7anhK();
		base._002Ector(executionScopeFactory);
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.functionMetadataItemManager = functionMetadataItemManager;
				num = 3;
				break;
			case 3:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.moduleAssemblyLoader = moduleAssemblyLoader;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				this.moduleReferenceManager = moduleReferenceManager;
				num = 2;
				break;
			}
		}
	}

	public override bool Check(ActionExecutionParams parameters)
	{
		return MYmQe8bItrg67018rDE3(ObU9RobIDKqUa8F0sxxL(parameters), FunctionMetadata.UID);
	}

	public override ActionExecutionResult Execute(ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_022a, IL_0239, IL_028b, IL_029a, IL_0349, IL_0377, IL_03af, IL_03e7, IL_0406, IL_0415, IL_044e, IL_048e, IL_0630, IL_0711, IL_0730, IL_073f, IL_076c, IL_0883
		int num = 10;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		ItemRuntimeModel itemRuntimeModel = default(ItemRuntimeModel);
		string text3 = default(string);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		Assembly assembly = default(Assembly);
		ServerBuildResult serverBuildResult = default(ServerBuildResult);
		ModuleVersion moduleVersion = default(ModuleVersion);
		UIRuntimeModel orDefault = default(UIRuntimeModel);
		string text4 = default(string);
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		FunctionMetadataItem functionMetadataItem = default(FunctionMetadataItem);
		List<IMetadata> list = default(List<IMetadata>);
		ActionExecutionResult actionExecutionResult = default(ActionExecutionResult);
		Type type = default(Type);
		string text2 = default(string);
		string text = default(string);
		Guid versionUid = default(Guid);
		IEnumerator<ItemRuntimeModel> enumerator = default(IEnumerator<ItemRuntimeModel>);
		ModuleInfoMetadata metadata = default(ModuleInfoMetadata);
		ItemRuntimeModel current = default(ItemRuntimeModel);
		ModuleReference moduleReference = default(ModuleReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 6;
					}
					continue;
				case 15:
					if (itemRuntimeModel != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 32;
				case 6:
					text3 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87321963), FTTkQbbI5eLtPWafIFR9(scriptMethodInfo), i8NqSZbIjmAQSEjWa29n(functionMetadata));
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 18;
					}
					continue;
				case 37:
					assembly = (Assembly)cjKj2DbI6tFGjO9W2HYQ(ScriptExecutionHandlerHelper.CreateFullAssemblyName((string)LCxUBGbIMywGTtcNBRYT(serverBuildResult), s6mJqxbI9CE5UCTopoIf(huwIpEbIJFW9UdJSfdY1(moduleVersion)).ToString(), (string)oRDpn5bI46Buy5Y16PJH(-672123589 ^ -672075555), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C0E02)), true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					parameters.ParameterType = (TypeSignature)X5BuJZbIc5KLFgPgeSZw(functionMetadata);
					num2 = 43;
					continue;
				case 31:
					itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CExecute_003Eb__0);
					num2 = 15;
					continue;
				case 5:
				case 11:
					break;
				case 29:
					return actionExecutionResult;
				case 40:
					text4 = SR.T((string)oRDpn5bI46Buy5Y16PJH(-29254301 ^ -29271065), typeof(FunctionMetadata).FullName);
					num2 = 42;
					continue;
				case 14:
					moduleInfoMetadata = (ModuleInfoMetadata)el4OvJbIyV0N2D3rVKqw(moduleVersion);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
				case 22:
					if (functionMetadata != null)
					{
						num2 = 39;
						continue;
					}
					goto case 40;
				case 18:
					assembly = (Assembly)wl6wosbIAhe9pp8JFSN0(functionMetadataItem.AssemblyRaw, uV9YY7bIHEZrXH1H8sus(functionMetadataItem));
					num2 = 22;
					continue;
				case 26:
					_003C_003Ec__DisplayClass6_.instanceUid = dLCXRjbIwTxDAEIRP9fM(parameters);
					num2 = 12;
					continue;
				default:
					functionMetadata = moduleInfoMetadata.Functions.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CExecute_003Eb__1);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 21;
					}
					continue;
				case 23:
					try
					{
						MetadataServiceContext metadataServiceContext = MetadataServiceContext.Extend(list);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num5 = 0;
									}
									goto IL_03eb;
								}
								goto IL_0420;
								IL_0420:
								nsMynwbIgjQed7eoNqfo(metadataServiceContext);
								num5 = 2;
								goto IL_03eb;
								IL_03eb:
								switch (num5)
								{
								default:
									goto end_IL_03c6;
								case 0:
									goto end_IL_03c6;
								case 1:
									break;
								case 2:
									goto end_IL_03c6;
								}
								goto IL_0420;
								end_IL_03c6:;
							}
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								throw;
							}
							Dp5bHbbVBgbRN4xPVjsF(DJS2ZjbVFd8Ej6hZ3dcI(), text3, ex);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num6 = 1;
							}
						}
					}
				case 30:
					H1D9flbI7xmf8m4Dn2OO(Logger.Log, text2);
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 38;
					}
					continue;
				case 9:
					list = new List<IMetadata>();
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 20;
					}
					continue;
				case 16:
					throw new Exception(SR.T((string)oRDpn5bI46Buy5Y16PJH(-1123633026 ^ -1123810702), text));
				case 41:
					if (!GnWk0gbIUQ3lkD3imTGn(type, null))
					{
						uVaCABbIsDFqq5QP4NJp(parameters, oRDpn5bI46Buy5Y16PJH(-787452571 ^ -787294443));
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 16;
						}
					}
					continue;
				case 19:
					functionMetadata = functionMetadataItem.Metadata as FunctionMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 7;
					}
					continue;
				case 13:
					serverBuildResult = (ServerBuildResult)dbWwL6bImHOsla5G9PeO(moduleAssemblyLoader, _003C_003Ec__DisplayClass6_.moduleUid, versionUid);
					num2 = 14;
					continue;
				case 28:
					functionMetadataItem = functionMetadataItemManager.Load(_003C_003Ec__DisplayClass6_.instanceUid);
					num2 = 19;
					continue;
				case 42:
					H1D9flbI7xmf8m4Dn2OO(Logger.Log, text4);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 34;
					}
					continue;
				case 32:
					text2 = SR.T((string)oRDpn5bI46Buy5Y16PJH(0x7C1EE318 ^ 0x7C1E2504), _003C_003Ec__DisplayClass6_.moduleUid);
					num2 = 30;
					continue;
				case 25:
					try
					{
						while (true)
						{
							int num7;
							if (!HZmbVGbIrSwAqTSQhWAZ(enumerator))
							{
								num7 = 3;
								goto IL_063e;
							}
							goto IL_069a;
							IL_063e:
							while (true)
							{
								switch (num7)
								{
								case 1:
									break;
								default:
									list.AddRange(metadata.GetMetadataToRegister());
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num7 = 1;
									}
									continue;
								case 2:
									goto IL_069a;
								case 4:
									metadata = ((ModuleVersion)OsdKmCbI0aIntKvpUY6p(moduleMetadataLoader, current.HeaderUid, Gq1EOVbIxWoqS38hu15N(current))).Metadata;
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
									{
										num7 = 0;
									}
									continue;
								case 3:
									goto end_IL_065c;
								}
								break;
							}
							continue;
							IL_069a:
							current = enumerator.Current;
							int num8 = 4;
							num7 = num8;
							goto IL_063e;
							continue;
							end_IL_065c:
							break;
						}
					}
					finally
					{
						int num9;
						if (enumerator == null)
						{
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num9 = 1;
							}
							goto IL_0715;
						}
						goto IL_074a;
						IL_074a:
						nsMynwbIgjQed7eoNqfo(enumerator);
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num9 = 0;
						}
						goto IL_0715;
						IL_0715:
						switch (num9)
						{
						default:
							goto end_IL_06f0;
						case 1:
							goto end_IL_06f0;
						case 2:
							break;
						case 0:
							goto end_IL_06f0;
						}
						goto IL_074a;
						end_IL_06f0:;
					}
					goto case 17;
				case 27:
					if (assembly == null)
					{
						num2 = 18;
						continue;
					}
					goto case 17;
				case 7:
					assembly = (Assembly)cjKj2DbI6tFGjO9W2HYQ(ScriptExecutionHandlerHelper.CreateFullAssemblyName(functionMetadataItem.AssemblyName, functionMetadataItem.AssemblyVersion, (string)oRDpn5bI46Buy5Y16PJH(-1108654032 ^ -1108636202), (string)oRDpn5bI46Buy5Y16PJH(-29254301 ^ -29258363)), true);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 27;
					}
					continue;
				case 38:
					throw new Exception(text2);
				case 3:
					versionUid = Gq1EOVbIxWoqS38hu15N(itemRuntimeModel);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (C7ZBBrbIdNCW80cwfRh1(assembly, null))
					{
						num2 = 8;
						continue;
					}
					goto case 21;
				case 4:
					if (!MYmQe8bItrg67018rDE3(_003C_003Ec__DisplayClass6_.moduleUid, Guid.Empty))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 28;
				case 12:
					moduleReference = moduleReferenceManager.LoadOrNull(_003C_003Ec__DisplayClass6_.instanceUid);
					num2 = 20;
					continue;
				case 43:
					parameters.ReturnType = (TypeSignature)xQEecKbIzYGXS5beBJE2(functionMetadata);
					num2 = 23;
					continue;
				case 8:
					assembly = (Assembly)wl6wosbIAhe9pp8JFSN0(U2cQ0XbIl019JQtWlZXv(serverBuildResult), serverBuildResult.DebugRaw);
					num2 = 21;
					continue;
				case 2:
					moduleVersion = (ModuleVersion)OsdKmCbI0aIntKvpUY6p(moduleMetadataLoader, _003C_003Ec__DisplayClass6_.moduleUid, versionUid);
					num2 = 13;
					continue;
				case 36:
					type = NqN12KbILLMRO03A1pXp(assembly, text);
					num2 = 41;
					continue;
				case 21:
					list.AddRange(moduleInfoMetadata.GetMetadataToRegister());
					num2 = 34;
					continue;
				case 35:
					throw new Exception(text4);
				case 39:
					scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(parameters.ScriptName);
					num2 = 6;
					continue;
				case 33:
					text = (string)amnbFxbIY8u34JQ3iW1m(functionMetadata);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 36;
					}
					continue;
				case 20:
					_003C_003Ec__DisplayClass6_.moduleUid = moduleReference?.ModuleUid ?? Guid.Empty;
					num2 = 4;
					continue;
				case 34:
					enumerator = orDefault.RuntimeModules.Where(_003C_003Ec__DisplayClass6_._003CExecute_003Eb__2).GetEnumerator();
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 25;
					}
					continue;
				}
				break;
			}
			orDefault = ContextVars.GetOrDefault<UIRuntimeModel>((string)oRDpn5bI46Buy5Y16PJH(-2138958856 ^ -2138909184));
			num = 31;
		}
	}

	internal static void yOymjRbIagHbQxO7anhK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JfHdyGbI3BGj8fwsjGii()
	{
		return OjPw3bbINKbu8iAPJbv0 == null;
	}

	internal static GlobalFunctionActionExecutionHandler aQgsO3bIpq8DLGmhyg01()
	{
		return OjPw3bbINKbu8iAPJbv0;
	}

	internal static Guid ObU9RobIDKqUa8F0sxxL(object P_0)
	{
		return ((ActionExecutionParams)P_0).TypeUid;
	}

	internal static bool MYmQe8bItrg67018rDE3(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid dLCXRjbIwTxDAEIRP9fM(object P_0)
	{
		return ((ActionExecutionParams)P_0).InstanceUid;
	}

	internal static object oRDpn5bI46Buy5Y16PJH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cjKj2DbI6tFGjO9W2HYQ(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object uV9YY7bIHEZrXH1H8sus(object P_0)
	{
		return ((FunctionMetadataItem)P_0).DebugRaw;
	}

	internal static object wl6wosbIAhe9pp8JFSN0(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static void H1D9flbI7xmf8m4Dn2OO(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static Guid Gq1EOVbIxWoqS38hu15N(object P_0)
	{
		return ((ItemRuntimeModel)P_0).ItemUid;
	}

	internal static object OsdKmCbI0aIntKvpUY6p(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleMetadataLoader)P_0).GetSpecificModuleVersion(moduleUid, versionUid);
	}

	internal static object dbWwL6bImHOsla5G9PeO(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleAssemblyLoader)P_0).GetServerAssembly(moduleUid, versionUid);
	}

	internal static object el4OvJbIyV0N2D3rVKqw(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object LCxUBGbIMywGTtcNBRYT(object P_0)
	{
		return ((ServerBuildResult)P_0).AssemblyName;
	}

	internal static object huwIpEbIJFW9UdJSfdY1(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static object s6mJqxbI9CE5UCTopoIf(object P_0)
	{
		return ((ModuleVersionHeader)P_0).Version;
	}

	internal static bool C7ZBBrbIdNCW80cwfRh1(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object U2cQ0XbIl019JQtWlZXv(object P_0)
	{
		return ((ServerBuildResult)P_0).AssemblyRaw;
	}

	internal static bool HZmbVGbIrSwAqTSQhWAZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void nsMynwbIgjQed7eoNqfo(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object FTTkQbbI5eLtPWafIFR9(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static object i8NqSZbIjmAQSEjWa29n(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object amnbFxbIY8u34JQ3iW1m(object P_0)
	{
		return FunctionMetadataHelper.ExecutorTypeName((FunctionMetadata)P_0);
	}

	internal static Type NqN12KbILLMRO03A1pXp(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool GnWk0gbIUQ3lkD3imTGn(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void uVaCABbIsDFqq5QP4NJp(object P_0, object P_1)
	{
		((ActionExecutionParams)P_0).ScriptName = (string)P_1;
	}

	internal static object X5BuJZbIc5KLFgPgeSZw(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static object xQEecKbIzYGXS5beBJE2(object P_0)
	{
		return ((FunctionMetadata)P_0).ReturnType;
	}

	internal static object DJS2ZjbVFd8Ej6hZ3dcI()
	{
		return Logger.Log;
	}

	internal static void Dp5bHbbVBgbRN4xPVjsF(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
