using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

[Component]
internal sealed class ComponentScriptExecutionHandler : IScriptExecutionHandler
{
	private readonly IComponentMetadataItemManager componentMetadataItemManager;

	private readonly IExecutionScopeFactory executionScopeFactory;

	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly IEqlPropertiesService eqlPropertiesService;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModuleAssemblyLoader moduleAssemblyLoader;

	private readonly ISecurityService securityService;

	private readonly ILockService lockService;

	internal static ComponentScriptExecutionHandler uodop251pxJkF6rYRBE;

	public ComponentScriptExecutionHandler(IComponentMetadataItemManager componentMetadataItemManager, IExecutionScopeFactory executionScopeFactory, IModuleReferenceManager moduleReferenceManager, IEqlPropertiesService eqlPropertiesService, IModuleMetadataLoader moduleMetadataLoader, IModuleAssemblyLoader moduleAssemblyLoader, ISecurityService securityService, ILockService lockService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rsCQUV5pxWJXuYndE8W();
		base._002Ector();
		int num = 8;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 6:
				this.eqlPropertiesService = eqlPropertiesService;
				num = 7;
				break;
			default:
				this.executionScopeFactory = executionScopeFactory;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 3;
				}
				break;
			case 1:
				this.securityService = securityService;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 0;
				}
				break;
			case 8:
				this.componentMetadataItemManager = componentMetadataItemManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.moduleAssemblyLoader = moduleAssemblyLoader;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				this.moduleReferenceManager = moduleReferenceManager;
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 5;
				}
				break;
			case 7:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 2;
				break;
			case 4:
				this.lockService = lockService;
				num = 5;
				break;
			}
		}
	}

	public bool Check(ScriptExecutionParams parameters)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return r2bi835th7Der31KAei(((ModelInfo)eKNIue5aI5bIqHxL9eR(parameters)).TypeUid, PortletComponentMetadata.TypeUid);
			default:
				return true;
			case 1:
				if (r2bi835th7Der31KAei(K1RHod5DMDdjYTWEIRg(eKNIue5aI5bIqHxL9eR(parameters)), ComponentMetadata.TypeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				if (!r2bi835th7Der31KAei(K1RHod5DMDdjYTWEIRg(eKNIue5aI5bIqHxL9eR(parameters)), PageComponentMetadata.TypeUid))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
	{
		//Discarded unreachable code: IL_01c2, IL_0206, IL_0413, IL_0508, IL_0517, IL_0587, IL_0591, IL_0674, IL_06ac, IL_06bb, IL_06cb, IL_0788, IL_096d, IL_097c, IL_098c, IL_0a1c, IL_0c63, IL_0cc2, IL_0cd1, IL_0e92, IL_0ea1, IL_0f43, IL_0f8d, IL_0f9c, IL_0fd4, IL_0fe3, IL_101c, IL_1048, IL_1057, IL_1096, IL_1125, IL_1144, IL_1153, IL_11a1, IL_11d9, IL_11e8, IL_12fa
		int num = 52;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		string text6 = default(string);
		Assembly assembly = default(Assembly);
		string text3 = default(string);
		ModuleInfoMetadata moduleInfoMetadata = default(ModuleInfoMetadata);
		ModuleVersion moduleVersion = default(ModuleVersion);
		List<IMetadata> list = default(List<IMetadata>);
		UIRuntimeModel orDefault = default(UIRuntimeModel);
		byte[] debugRaw = default(byte[]);
		ServerBuildResult serverBuildResult = default(ServerBuildResult);
		string text5 = default(string);
		ItemRuntimeModel itemRuntimeModel = default(ItemRuntimeModel);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		byte[] array = default(byte[]);
		PropertyViewInfoContainer propertyViewInfoContainer = default(PropertyViewInfoContainer);
		string text2 = default(string);
		string text7 = default(string);
		string text4 = default(string);
		byte[] assemblyRaw = default(byte[]);
		byte[] assemblyRaw2 = default(byte[]);
		IEnumerator<ItemRuntimeModel> enumerator = default(IEnumerator<ItemRuntimeModel>);
		ModuleInfoMetadata moduleInfoMetadata2 = default(ModuleInfoMetadata);
		ItemRuntimeModel current = default(ItemRuntimeModel);
		string text = default(string);
		Type type = default(Type);
		IExecutionScope executionScope = default(IExecutionScope);
		_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals0;
		_003C_003Ec__DisplayClass10_2 _003C_003Ec__DisplayClass10_2 = default(_003C_003Ec__DisplayClass10_2);
		PortletComponentMetadata _003CportletMetadata_003E5__ = default(PortletComponentMetadata);
		_003C_003Ec__DisplayClass10_3 _003C_003Ec__DisplayClass10_3 = default(_003C_003Ec__DisplayClass10_3);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		_003C_003Ec__DisplayClass10_4 _003C_003Ec__DisplayClass10_4 = default(_003C_003Ec__DisplayClass10_4);
		string text8 = default(string);
		PageComponentMetadata pageComponentMetadata = default(PageComponentMetadata);
		Type type2 = default(Type);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		Type type3 = default(Type);
		PageComponentMetadata pageComponentMetadata2 = default(PageComponentMetadata);
		string message = default(string);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		SerializedModel serializedModel = default(SerializedModel);
		string text9 = default(string);
		RedirectToPageResult redirectToPageResult2 = default(RedirectToPageResult);
		object obj2 = default(object);
		RedirectToPageResult redirectToPageResult = default(RedirectToPageResult);
		FieldInfo field = default(FieldInfo);
		object obj = default(object);
		RedirectToUrlResult redirectToUrlResult = default(RedirectToUrlResult);
		ModuleReference moduleReference = default(ModuleReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					_003C_003Ec__DisplayClass10_.contextInstance = null;
					num2 = 35;
					continue;
				case 35:
					Hm8uyijWxSC1bFTsfCd(securityService, new Action(_003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__0));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 24;
					}
					continue;
				default:
					dA4fyY5JS23LYTDyQeF(tBYBHl5M4FlbtqblhOT(), text6);
					num2 = 54;
					continue;
				case 17:
					assembly = (Assembly)hZwqWK5xVhNtupJdmVq(text3, true);
					num2 = 6;
					continue;
				case 2:
					moduleInfoMetadata = (ModuleInfoMetadata)WuEetR5rm9hbpPLttki(moduleVersion);
					num = 21;
					break;
				case 1:
				case 53:
					list.Add(_003C_003Ec__DisplayClass10_.componentMetadata);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 11;
					}
					continue;
				case 32:
				case 36:
					orDefault = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146527525));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 12;
					}
					continue;
				case 21:
					_003C_003Ec__DisplayClass10_.componentMetadata = moduleInfoMetadata.Components.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__3);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					debugRaw = (byte[])UjfaLM5YYto9YTHIF69(serverBuildResult);
					num = 34;
					break;
				case 51:
					_003C_003Ec__DisplayClass10_.parameters = parameters;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 16;
					}
					continue;
				case 12:
					throw new Exception(text5);
				case 7:
					moduleVersion = (ModuleVersion)N6YJLS5dj2nhIK042ow(moduleMetadataLoader, _003C_003Ec__DisplayClass10_.moduleUid, m6uYvW59GIOU3sU38Wt(itemRuntimeModel));
					num2 = 43;
					continue;
				case 37:
					text3 = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string)Yhjlmi5HHTvNN3uRxtS(componentMetadataItem), (string)kWeThG5AW07L37M2gvk(componentMetadataItem), (string)XBlKfn57G1U4arKqa3a(-1886646897 ^ -1886599063), (string)XBlKfn57G1U4arKqa3a(-812025778 ^ -812029784));
					num2 = 50;
					continue;
				case 38:
				case 39:
					if (_003C_003Ec__DisplayClass10_.componentMetadata != null)
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 13;
				case 25:
					array = (byte[])EuU0C35moCMCNgfZGlE(GkF2eP50Mp8DOwq8P79(componentMetadataItem));
					num2 = 15;
					continue;
				case 33:
					componentMetadataItem = componentMetadataItemManager.Load(F1oDhX5waIoBEK8Z1p4(_003C_003Ec__DisplayClass10_.parameters.ModelInfo));
					num2 = 45;
					continue;
				case 6:
					if (!JAhWUB55vr6aMCx0FEj(assembly, null))
					{
						num2 = 46;
						continue;
					}
					goto case 23;
				case 3:
				case 42:
				{
					ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
					ofp4Stj2LdJce6hUalh(scriptExecutionResult, _003C_003Ec__DisplayClass10_.contextInstance);
					scriptExecutionResult.PropertyContainer = propertyViewInfoContainer;
					ONKRsojeTFNOZ8LKxnk(scriptExecutionResult, text2);
					return scriptExecutionResult;
				}
				case 43:
					serverBuildResult = (ServerBuildResult)FlKlx85lReDuRc1yfJI(moduleAssemblyLoader, _003C_003Ec__DisplayClass10_.moduleUid, m6uYvW59GIOU3sU38Wt(itemRuntimeModel));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					text6 = SR.T((string)XBlKfn57G1U4arKqa3a(0x103FE975 ^ 0x103F2FF1), qRC8XB5cTAsllqL0gRv(typeof(ComponentMetadata).TypeHandle).FullName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				case 55:
					if (!aHdW1ejELLpWqGQrGCp(RJasUrjGFFjZpf3UroI(_003C_003Ec__DisplayClass10_.parameters), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E9870)))
					{
						num2 = 42;
						continue;
					}
					goto case 58;
				case 8:
					if (!(assembly == null))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 53;
						}
						continue;
					}
					goto case 60;
				case 20:
					throw new Exception(text7);
				case 52:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 51;
					continue;
				case 54:
					throw new Exception(text6);
				case 49:
					text4 = (string)edD2B35zbwbnINRk4CG(_003C_003Ec__DisplayClass10_.componentMetadata);
					num2 = 48;
					continue;
				case 34:
					assembly = ComponentManager.LoadAssemblyWithLock(lockService, text3, isFullName: true, assemblyRaw, debugRaw);
					num2 = 26;
					continue;
				case 40:
					_003C_003Ec__DisplayClass10_.contextExpando = new EntityJsonSerializer().DeserializeJson((string)G0Im9FjBt4PphH0HwFu(_003C_003Ec__DisplayClass10_.parameters));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 28;
					}
					continue;
				case 60:
					assemblyRaw2 = ((ScriptModule)GkF2eP50Mp8DOwq8P79(componentMetadataItem)).AssemblyRaw;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 25;
					}
					continue;
				case 10:
					try
					{
						while (true)
						{
							IL_0638:
							int num10;
							if (!vK5Tqj5UiWE3tlQqI7X(enumerator))
							{
								num10 = 2;
								goto IL_0595;
							}
							goto IL_05b3;
							IL_0595:
							while (true)
							{
								switch (num10)
								{
								case 3:
									break;
								case 1:
									list.AddRange(moduleInfoMetadata2.GetMetadataToRegister());
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num10 = 0;
									}
									continue;
								case 4:
									moduleInfoMetadata2 = (ModuleInfoMetadata)WuEetR5rm9hbpPLttki(moduleMetadataLoader.GetSpecificModuleVersion(iHP6aT5LmpMwJs09UaY(current), m6uYvW59GIOU3sU38Wt(current)));
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num10 = 1;
									}
									continue;
								default:
									goto IL_0638;
								case 2:
									goto end_IL_0638;
								}
								break;
							}
							goto IL_05b3;
							IL_05b3:
							current = enumerator.Current;
							num10 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num10 = 2;
							}
							goto IL_0595;
							continue;
							end_IL_0638:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num11 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num11 = 1;
							}
							while (true)
							{
								switch (num11)
								{
								case 1:
									Yp8WST5s6FAgBmATf6e(enumerator);
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num11 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 38;
				case 30:
					text3 = ScriptExecutionHandlerHelper.CreateFullAssemblyName(serverBuildResult.AssemblyName, ((ModuleVersionHeader)LIvrF55g9WGbLwiNgYJ(moduleVersion)).Version.ToString(), (string)XBlKfn57G1U4arKqa3a(-87337865 ^ -87322223), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411200693));
					num2 = 17;
					continue;
				case 23:
					assemblyRaw = (byte[])xZnT3h5jatvIfHRgOWf(serverBuildResult);
					num2 = 19;
					continue;
				case 58:
					text = ComponentMetadataHelperInternal.ControllerTypeName(_003C_003Ec__DisplayClass10_.componentMetadata);
					num2 = 47;
					continue;
				case 45:
					_003C_003Ec__DisplayClass10_.componentMetadata = (ComponentMetadata)ERKo9M56MBytU0kERWm(componentMetadataItem);
					num2 = 37;
					continue;
				case 29:
					if (!kpZVYOjfRcVM2phL9YL(type, null))
					{
						executionScope = (IExecutionScope)KlddaIjQkbMZ5y9N2S3(executionScopeFactory.CreateScope().AddRegistration(type));
						num2 = 56;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 57;
					}
					continue;
				case 26:
				case 46:
					list.AddRange(moduleInfoMetadata.GetMetadataToRegister());
					num2 = 31;
					continue;
				case 59:
					if (itemRuntimeModel != null)
					{
						num2 = 7;
						continue;
					}
					goto case 18;
				case 57:
					text7 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108635712), text);
					num = 4;
					break;
				case 56:
					try
					{
						CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_1();
						int num3 = 16;
						while (true)
						{
							int num8;
							switch (num3)
							{
							case 22:
							case 26:
								_003C_003Ec__DisplayClass10_2._003CportletMetadata_003E5__2 = _003CportletMetadata_003E5__;
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num3 = 21;
								}
								continue;
							case 11:
								_003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_2();
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num3 = 28;
								}
								continue;
							case 25:
								propertyViewInfoContainer = new PropertyViewInfoContainer((ClassMetadata)VgctibjbyLVxlcRHrGU(wp49s0joIQkxFerGCTu(_003C_003Ec__DisplayClass10_3.CS_0024_003C_003E8__locals2._003CportletMetadata_003E5__2)));
								num3 = 17;
								continue;
							case 24:
								if (componentMetadata != null)
								{
									num3 = 6;
									continue;
								}
								goto case 32;
							case 36:
								_003C_003Ec__DisplayClass10_4 = new _003C_003Ec__DisplayClass10_4();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num3 = 1;
								}
								continue;
							case 9:
								if (CS_0024_003C_003E8__locals0.controllerInstance != null)
								{
									num3 = 37;
									continue;
								}
								goto case 13;
							case 38:
								dA4fyY5JS23LYTDyQeF(tBYBHl5M4FlbtqblhOT(), text8);
								num3 = 31;
								continue;
							case 5:
								_003C_003Ec__DisplayClass10_3.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass10_2;
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 2;
								}
								continue;
							case 21:
								_003C_003Ec__DisplayClass10_3 = new _003C_003Ec__DisplayClass10_3();
								num8 = 5;
								goto IL_0807;
							case 12:
								CS_0024_003C_003E8__locals0.viewModel = iTbDIGjRsaWQqdHGmbl(pageComponentMetadata, type2, _003C_003Ec__DisplayClass10_.contextInstance, propertyViewInfoContainer);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								metadataServiceContext = MetadataServiceContext.Extend(list);
								num3 = 35;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 1;
								}
								continue;
							case 18:
								_003C_003Ec__DisplayClass10_3.personalizationInstance = Activator.CreateInstance(type3);
								num3 = 19;
								continue;
							case 20:
								if ((pageComponentMetadata2 = componentMetadata as PageComponentMetadata) != null)
								{
									num3 = 34;
									continue;
								}
								goto case 32;
							case 14:
							case 34:
								pageComponentMetadata = pageComponentMetadata2;
								num8 = 2;
								goto IL_0807;
							case 32:
								CS_0024_003C_003E8__locals0.viewModel = zdeJMHjqcQvXCXtZ3TC(type2, _003C_003Ec__DisplayClass10_.contextInstance);
								num3 = 27;
								continue;
							case 4:
								((ILogger)tBYBHl5M4FlbtqblhOT()).Error(message);
								num3 = 29;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num3 = 28;
								}
								continue;
							case 23:
								CS_0024_003C_003E8__locals0.method = (MethodInfo)CFNkWPjvISWLSPCBnZn(type, scriptMethodInfo.Name);
								num3 = 3;
								continue;
							case 39:
								_003C_003Ec__DisplayClass10_4.personalizationModelExpando = new EntityJsonSerializer().DeserializeJson((string)c1GBUYjSCAiN8AP0Dth(serializedModel));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num3 = 7;
								}
								continue;
							case 8:
								message = SR.T((string)XBlKfn57G1U4arKqa3a(0x10E41EDB ^ 0x10E4D6AF), scriptMethodInfo.Name);
								num3 = 4;
								continue;
							case 2:
								propertyViewInfoContainer = new PropertyViewInfoContainer((ClassMetadata)VgctibjbyLVxlcRHrGU(wp49s0joIQkxFerGCTu(pageComponentMetadata)));
								num3 = 12;
								continue;
							case 1:
								_003C_003Ec__DisplayClass10_4.CS_0024_003C_003E8__locals3 = _003C_003Ec__DisplayClass10_3;
								num8 = 39;
								goto IL_0807;
							case 17:
								CS_0024_003C_003E8__locals0.viewModel = EeBmw7jiTy95UvwSaSY(_003C_003Ec__DisplayClass10_3.CS_0024_003C_003E8__locals2._003CportletMetadata_003E5__2, type2, _003C_003Ec__DisplayClass10_.contextInstance, _003C_003Ec__DisplayClass10_3.personalizationInstance, propertyViewInfoContainer);
								num3 = 30;
								continue;
							case 28:
								componentMetadata = _003C_003Ec__DisplayClass10_.componentMetadata;
								num3 = 24;
								continue;
							case 3:
								if (AWSv2jj8cudwTOsEFCm(CS_0024_003C_003E8__locals0.method, null))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num3 = 8;
									}
									continue;
								}
								type2 = QteoG2jufIIP541RfyK(((object[])HWA9UnjZguqvcbgFdMI(CS_0024_003C_003E8__locals0.method))[0]);
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
								{
									num3 = 5;
								}
								continue;
							case 15:
								text9 = (string)ewFQnujVWwgeEwlGKy4(_003C_003Ec__DisplayClass10_3.CS_0024_003C_003E8__locals2._003CportletMetadata_003E5__2.FullTypeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281861274), qwecQ5jI8GQiQA8wSof(_003C_003Ec__DisplayClass10_3.CS_0024_003C_003E8__locals2._003CportletMetadata_003E5__2.PersonalizationContext));
								num3 = 33;
								continue;
							case 19:
								if (serializedModel != null)
								{
									num8 = 36;
									goto IL_0807;
								}
								goto case 25;
							case 29:
								throw new Exception(message);
							case 6:
								if ((_003CportletMetadata_003E5__ = componentMetadata as PortletComponentMetadata) != null)
								{
									num3 = 26;
									continue;
								}
								goto case 20;
							case 13:
								text8 = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BB7D10), text);
								num3 = 38;
								continue;
							case 7:
								securityService.RunWithElevatedPrivilegiesAndWithDeleted(_003C_003Ec__DisplayClass10_4._003CExecuteScript_003Eb__6);
								num3 = 25;
								continue;
							case 33:
								type3 = E8lcTvjF2i786R7bPHb(assembly, text9);
								num3 = 18;
								continue;
							case 16:
								CS_0024_003C_003E8__locals0.controllerInstance = executionScope.Resolve(type);
								num3 = 9;
								continue;
							case 31:
								throw new Exception(text8);
							case 37:
								scriptMethodInfo = (ScriptMethodInfo)XHX4EXjCmuOkr2DvgQK(_003C_003Ec__DisplayClass10_.parameters.ScriptName);
								num8 = 23;
								goto IL_0807;
							case 10:
								serializedModel = ((IEnumerable<SerializedModel>)Nl8JOZjhe3YKS5MVv1R(_003C_003Ec__DisplayClass10_.parameters)).FirstOrDefault((SerializedModel model) => (string)_003C_003Ec.peBOoPfYVtjGrHKcsf6H(model) == (string)_003C_003Ec.J65IErfYiGkCx1Akbh7U(-1751176224 ^ -1751498056));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num3 = 15;
								}
								continue;
							case 35:
								{
									try
									{
										QU1btjjKypxqjfCZylc((Action)delegate
										{
											int num12 = 1;
											int num13 = num12;
											while (true)
											{
												switch (num13)
												{
												default:
													return;
												case 1:
													_003C_003Ec__DisplayClass10_1.zoNR05fjsBGU33kBE2qj(CS_0024_003C_003E8__locals0.method, CS_0024_003C_003E8__locals0.controllerInstance, new object[1] { CS_0024_003C_003E8__locals0.viewModel });
													num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
													{
														num13 = 0;
													}
													break;
												case 0:
													return;
												}
											}
										}, "");
										int num4 = 18;
										while (true)
										{
											switch (num4)
											{
											case 4:
												text2 = (string)A8J8e8jkmaSiy2vLrwM(XBlKfn57G1U4arKqa3a(0x12441CA4 ^ 0x1244D448), rbnojcjTVfm58Kty8R2(redirectToPageResult2));
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
												{
													num4 = 2;
												}
												continue;
											case 13:
												goto end_IL_0dfe;
											case 5:
												if (obj2 == null)
												{
													num4 = 16;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
													{
														num4 = 17;
													}
													continue;
												}
												goto case 3;
											case 14:
											case 16:
												redirectToPageResult2 = redirectToPageResult;
												num4 = 4;
												continue;
											case 12:
												if (!(field != null))
												{
													num4 = 8;
													continue;
												}
												goto case 10;
											case 11:
												if (obj != null)
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
													{
														num4 = 6;
													}
													continue;
												}
												goto end_IL_0dfe;
											case 18:
												if (_003C_003Ec__DisplayClass10_.componentMetadata is PageComponentMetadata)
												{
													num4 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
													{
														num4 = 7;
													}
													continue;
												}
												goto end_IL_0dfe;
											case 17:
												goto end_IL_0dfe;
											case 7:
												field = type2.GetField((string)XBlKfn57G1U4arKqa3a(-1979251663 ^ -1979200283), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
												num4 = 12;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
												{
													num4 = 1;
												}
												continue;
											case 10:
												obj2 = pXn9BajX5soEEjsVH3q(field, CS_0024_003C_003E8__locals0.viewModel);
												num4 = 5;
												continue;
											case 3:
												obj = obj2;
												num4 = 11;
												continue;
											case 8:
												goto end_IL_0dfe;
											case 1:
												if ((redirectToUrlResult = obj as RedirectToUrlResult) == null)
												{
													num4 = 13;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
													{
														num4 = 4;
													}
													continue;
												}
												break;
											case 6:
												if ((redirectToPageResult = obj as RedirectToPageResult) != null)
												{
													int num5 = 16;
													num4 = num5;
													continue;
												}
												goto case 1;
											case 2:
												goto end_IL_0dfe;
											case 15:
												goto end_IL_0dfe;
											}
											text2 = redirectToUrlResult.Url;
											num4 = 15;
											continue;
											end_IL_0dfe:
											break;
										}
									}
									catch (Exception ex)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
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
											ILs57OjOisYNL1bTQcK(tBYBHl5M4FlbtqblhOT(), SR.T((string)XBlKfn57G1U4arKqa3a(-521266112 ^ -521218748), WGl8lwjn4eJomexVijx(scriptMethodInfo), type), ex);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
											{
												num6 = 1;
											}
										}
									}
									finally
									{
										int num7;
										if (metadataServiceContext == null)
										{
											num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
											{
												num7 = 1;
											}
											goto IL_1129;
										}
										goto IL_115e;
										IL_115e:
										((IDisposable)metadataServiceContext).Dispose();
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
										{
											num7 = 0;
										}
										goto IL_1129;
										IL_1129:
										switch (num7)
										{
										default:
											goto end_IL_1104;
										case 1:
											goto end_IL_1104;
										case 2:
											break;
										case 0:
											goto end_IL_1104;
										}
										goto IL_115e;
										end_IL_1104:;
									}
									break;
								}
								IL_0807:
								num3 = num8;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (executionScope != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									Yp8WST5s6FAgBmATf6e(executionScope);
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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
				case 27:
					text2 = string.Empty;
					num2 = 44;
					continue;
				case 18:
					text5 = SR.T((string)XBlKfn57G1U4arKqa3a(0x307E9FD1 ^ 0x307E59CD), _003C_003Ec__DisplayClass10_.moduleUid);
					num2 = 14;
					continue;
				case 4:
					dA4fyY5JS23LYTDyQeF(tBYBHl5M4FlbtqblhOT(), text7);
					num2 = 20;
					continue;
				case 47:
					type = E8lcTvjF2i786R7bPHb(assembly, text);
					num2 = 29;
					continue;
				case 9:
					moduleReference = (ModuleReference)MSqdnn54sQxURcykj1L(moduleReferenceManager, F1oDhX5waIoBEK8Z1p4(eKNIue5aI5bIqHxL9eR(_003C_003Ec__DisplayClass10_.parameters)));
					num2 = 41;
					continue;
				case 15:
					assembly = (Assembly)ogWam35ycGSVi6m9KiC(lockService, text3, true, assemblyRaw2, array);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					continue;
				case 44:
					propertyViewInfoContainer = null;
					num2 = 55;
					continue;
				case 11:
					list.AddRange(_003C_003Ec__DisplayClass10_.componentMetadata.GetMetadataToRegister());
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 12;
					}
					continue;
				case 22:
					itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__2);
					num2 = 59;
					continue;
				case 16:
					list = new List<IMetadata>();
					num2 = 9;
					continue;
				case 14:
					dA4fyY5JS23LYTDyQeF(tBYBHl5M4FlbtqblhOT(), text5);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 12;
					}
					continue;
				case 48:
					_003C_003Ec__DisplayClass10_.contextType = E8lcTvjF2i786R7bPHb(assembly, text4);
					num2 = 40;
					continue;
				case 5:
					if (!(_003C_003Ec__DisplayClass10_.moduleUid == Guid.Empty))
					{
						num2 = 32;
						continue;
					}
					goto case 33;
				case 50:
					assembly = (Assembly)hZwqWK5xVhNtupJdmVq(text3, true);
					num2 = 8;
					continue;
				case 41:
					_003C_003Ec__DisplayClass10_.moduleUid = moduleReference?.ModuleUid ?? Guid.Empty;
					num2 = 5;
					continue;
				case 31:
					enumerator = orDefault.RuntimeModules.Where(_003C_003Ec__DisplayClass10_._003CExecuteScript_003Eb__4).GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 10;
					}
					continue;
				case 24:
					eqlPropertiesService.SetEqlComputedProperties(_003C_003Ec__DisplayClass10_.contextInstance, _003C_003Ec__DisplayClass10_.contextType, ((ClassMetadata)VgctibjbyLVxlcRHrGU(wp49s0joIQkxFerGCTu(_003C_003Ec__DisplayClass10_.componentMetadata))).Properties, ((IEnumerable<SerializedModel>)Nl8JOZjhe3YKS5MVv1R(_003C_003Ec__DisplayClass10_.parameters)).Select(delegate(SerializedModel s)
					{
						SerializedModel obj3 = new SerializedModel
						{
							Model = (string)_003C_003Ec.K44CW9fYIHfC6VpUtZC6(s)
						};
						_003C_003Ec.xhaX92fYSyapm9CnBhp8(obj3, _003C_003Ec.peBOoPfYVtjGrHKcsf6H(s));
						return obj3;
					}).ToList());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 27;
					}
					continue;
				}
				break;
			}
		}
	}

	private static object ProcessPortletComponentMetadata(object portletMetadata, Type viewModelType, object contextInstance, object personalizationInstance, object propertyContainer)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 2;
		int num2 = num;
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!KrgnDYj1rR1Qs3E1pWB(constructorInfo, null))
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				return dY70EUjN31HNbs03mEI(constructorInfo, new object[5]
				{
					contextInstance,
					personalizationInstance,
					null,
					VgctibjbyLVxlcRHrGU(wp49s0joIQkxFerGCTu(portletMetadata)),
					propertyContainer
				});
			case 4:
				constructorInfo = (ConstructorInfo)MBxxtRjP745NuQF5a8j(viewModelType, 2);
				num2 = 3;
				break;
			case 3:
				return constructorInfo.Invoke(new object[2] { contextInstance, personalizationInstance });
			case 2:
				constructorInfo = (ConstructorInfo)MBxxtRjP745NuQF5a8j(viewModelType, 5);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static object ProcessPageComponentMetadata(object pageMetadata, Type viewModelType, object contextInstance, object propertyContainer)
	{
		int num = 2;
		int num2 = num;
		ConstructorInfo ctor = default(ConstructorInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				ctor = GetCtor(viewModelType, 4);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (KrgnDYj1rR1Qs3E1pWB(ctor, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return zdeJMHjqcQvXCXtZ3TC(viewModelType, contextInstance);
			default:
				return dY70EUjN31HNbs03mEI(ctor, new object[4]
				{
					contextInstance,
					null,
					VgctibjbyLVxlcRHrGU(wp49s0joIQkxFerGCTu(pageMetadata)),
					propertyContainer
				});
			}
		}
	}

	private static object ProcessComponentMetadata(Type viewModelType, object contextInstance)
	{
		return dY70EUjN31HNbs03mEI(GetCtor(viewModelType, 1), new object[1] { contextInstance });
	}

	private static ConstructorInfo GetCtor(Type viewModelType, int paramCount)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass14_.paramCount = paramCount;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Array.Find(viewModelType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), _003C_003Ec__DisplayClass14_._003CGetCtor_003Eb__0);
			}
		}
	}

	internal static void rsCQUV5pxWJXuYndE8W()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool unMLpy5NEVPow1QjFrp()
	{
		return uodop251pxJkF6rYRBE == null;
	}

	internal static ComponentScriptExecutionHandler XShNo953BH0MEtNelPK()
	{
		return uodop251pxJkF6rYRBE;
	}

	internal static object eKNIue5aI5bIqHxL9eR(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ModelInfo;
	}

	internal static Guid K1RHod5DMDdjYTWEIRg(object P_0)
	{
		return ((ModelInfo)P_0).TypeUid;
	}

	internal static bool r2bi835th7Der31KAei(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid F1oDhX5waIoBEK8Z1p4(object P_0)
	{
		return ((ModelInfo)P_0).SubTypeUid;
	}

	internal static object MSqdnn54sQxURcykj1L(object P_0, Guid metadataUid)
	{
		return ((IModuleReferenceManager)P_0).LoadOrNull(metadataUid);
	}

	internal static object ERKo9M56MBytU0kERWm(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static object Yhjlmi5HHTvNN3uRxtS(object P_0)
	{
		return ((ComponentMetadataItem)P_0).AssemblyName;
	}

	internal static object kWeThG5AW07L37M2gvk(object P_0)
	{
		return ((ComponentMetadataItem)P_0).AssemblyVersion;
	}

	internal static object XBlKfn57G1U4arKqa3a(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hZwqWK5xVhNtupJdmVq(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object GkF2eP50Mp8DOwq8P79(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ScriptModule;
	}

	internal static object EuU0C35moCMCNgfZGlE(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object ogWam35ycGSVi6m9KiC(object P_0, object P_1, bool isFullName, object P_3, object P_4)
	{
		return ComponentManager.LoadAssemblyWithLock((ILockService)P_0, (string)P_1, isFullName, (byte[])P_3, (byte[])P_4);
	}

	internal static object tBYBHl5M4FlbtqblhOT()
	{
		return Logger.Log;
	}

	internal static void dA4fyY5JS23LYTDyQeF(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static Guid m6uYvW59GIOU3sU38Wt(object P_0)
	{
		return ((ItemRuntimeModel)P_0).ItemUid;
	}

	internal static object N6YJLS5dj2nhIK042ow(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleMetadataLoader)P_0).GetSpecificModuleVersion(moduleUid, versionUid);
	}

	internal static object FlKlx85lReDuRc1yfJI(object P_0, Guid moduleUid, Guid versionUid)
	{
		return ((IModuleAssemblyLoader)P_0).GetServerAssembly(moduleUid, versionUid);
	}

	internal static object WuEetR5rm9hbpPLttki(object P_0)
	{
		return ((ModuleVersion)P_0).Metadata;
	}

	internal static object LIvrF55g9WGbLwiNgYJ(object P_0)
	{
		return ((ModuleVersion)P_0).Header;
	}

	internal static bool JAhWUB55vr6aMCx0FEj(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object xZnT3h5jatvIfHRgOWf(object P_0)
	{
		return ((ServerBuildResult)P_0).AssemblyRaw;
	}

	internal static object UjfaLM5YYto9YTHIF69(object P_0)
	{
		return ((ServerBuildResult)P_0).DebugRaw;
	}

	internal static Guid iHP6aT5LmpMwJs09UaY(object P_0)
	{
		return ((ItemRuntimeModel)P_0).HeaderUid;
	}

	internal static bool vK5Tqj5UiWE3tlQqI7X(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Yp8WST5s6FAgBmATf6e(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type qRC8XB5cTAsllqL0gRv(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object edD2B35zbwbnINRk4CG(object P_0)
	{
		return ComponentMetadataHelperInternal.ContextTypeName((ComponentMetadata)P_0);
	}

	internal static Type E8lcTvjF2i786R7bPHb(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static object G0Im9FjBt4PphH0HwFu(object P_0)
	{
		return ((ScriptExecutionParams)P_0).Model;
	}

	internal static void Hm8uyijWxSC1bFTsfCd(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegiesAndWithDeleted((Action)P_1);
	}

	internal static object wp49s0joIQkxFerGCTu(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object VgctibjbyLVxlcRHrGU(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object Nl8JOZjhe3YKS5MVv1R(object P_0)
	{
		return ((ScriptExecutionParams)P_0).AdditionalModels;
	}

	internal static object RJasUrjGFFjZpf3UroI(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ScriptName;
	}

	internal static bool aHdW1ejELLpWqGQrGCp(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool kpZVYOjfRcVM2phL9YL(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object KlddaIjQkbMZ5y9N2S3(object P_0)
	{
		return ((IExecutionScopeBuilder)P_0).StartScope();
	}

	internal static object XHX4EXjCmuOkr2DvgQK(object P_0)
	{
		return ScriptMethodInfoHelper.Deserialize((string)P_0);
	}

	internal static object CFNkWPjvISWLSPCBnZn(Type type, object P_1)
	{
		return ScriptHelper.GetMethodInfo(type, (string)P_1);
	}

	internal static bool AWSv2jj8cudwTOsEFCm(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object HWA9UnjZguqvcbgFdMI(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type QteoG2jufIIP541RfyK(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static object qwecQ5jI8GQiQA8wSof(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object ewFQnujVWwgeEwlGKy4(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object c1GBUYjSCAiN8AP0Dth(object P_0)
	{
		return ((SerializedModel)P_0).Model;
	}

	internal static object EeBmw7jiTy95UvwSaSY(object P_0, Type viewModelType, object P_2, object P_3, object P_4)
	{
		return ProcessPortletComponentMetadata(P_0, viewModelType, P_2, P_3, P_4);
	}

	internal static object iTbDIGjRsaWQqdHGmbl(object P_0, Type viewModelType, object P_2, object P_3)
	{
		return ProcessPageComponentMetadata(P_0, viewModelType, P_2, P_3);
	}

	internal static object zdeJMHjqcQvXCXtZ3TC(Type viewModelType, object P_1)
	{
		return ProcessComponentMetadata(viewModelType, P_1);
	}

	internal static void QU1btjjKypxqjfCZylc(object P_0, object P_1)
	{
		ScriptExecutionService.ScriptExecution((Action)P_0, (string)P_1);
	}

	internal static object pXn9BajX5soEEjsVH3q(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object rbnojcjTVfm58Kty8R2(object P_0)
	{
		return ((RedirectToPageResult)P_0).PageId;
	}

	internal static object A8J8e8jkmaSiy2vLrwM(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object WGl8lwjn4eJomexVijx(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static void ILs57OjOisYNL1bTQcK(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void ofp4Stj2LdJce6hUalh(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).Model = P_1;
	}

	internal static void ONKRsojeTFNOZ8LKxnk(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).RedirectUrl = (string)P_1;
	}

	internal static object MBxxtRjP745NuQF5a8j(Type viewModelType, int paramCount)
	{
		return GetCtor(viewModelType, paramCount);
	}

	internal static bool KrgnDYj1rR1Qs3E1pWB(object P_0, object P_1)
	{
		return (ConstructorInfo)P_0 != (ConstructorInfo)P_1;
	}

	internal static object dY70EUjN31HNbs03mEI(object P_0, object P_1)
	{
		return ((ConstructorInfo)P_0).Invoke((object[])P_1);
	}
}
