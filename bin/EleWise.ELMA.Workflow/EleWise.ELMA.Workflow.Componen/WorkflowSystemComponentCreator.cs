using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using EleWise.ELMA.Workflow.Constants;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class WorkflowSystemComponentCreator : ISystemComponentCreator
{
	private readonly UserManager userManager;

	private readonly ScriptModuleManager scriptModuleManager;

	private readonly IComponentAssemblyBuilderService componentAssemblyBuilderService;

	internal static WorkflowSystemComponentCreator CBSJC3OthfcI2Y5IUl9c;

	public WorkflowSystemComponentCreator(UserManager userManager, ScriptModuleManager scriptModuleManager, IComponentAssemblyBuilderService componentAssemblyBuilderService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		qbnGnFOt4ZyHvHSIXVSb();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.userManager = userManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
				{
					num = 1;
				}
				break;
			default:
				this.componentAssemblyBuilderService = componentAssemblyBuilderService;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.scriptModuleManager = scriptModuleManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public ComponentMetadataItem Create()
	{
		int num = 21;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		ComponentBuildAssemblyModel model = default(ComponentBuildAssemblyModel);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 8:
					goto end_IL_0012;
				default:
					qnm7T2ObO0Pe2gZtlEEe(componentMetadata, dQghbkObKtbkdSR6mxpU(0x1AF6F1F2 ^ 0x1AF74D50));
					num2 = 3;
					continue;
				case 18:
					componentAssemblyBuilderService.Build(model);
					num2 = 17;
					continue;
				case 1:
					((ComponentContentMetadata)evb5eaObY7V0oSVv4axj(componentMetadata)).Context.Properties.Add((PropertyMetadata)fboGOZOb8kKVkaV3Xhfw());
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					((ComponentContentMetadata)evb5eaObY7V0oSVv4axj(componentMetadata)).View.Items.Add((ViewItem)KukrF7ObldQRjiZlhrFe());
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 5;
					}
					continue;
				case 14:
				{
					object obj3 = qiEDk0ObcxjtWmyfn3iA(scriptModuleManager, ComponentClientScriptModuleTypeConstants.TypeUid);
					if (obj3 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj = ((IScriptModuleType)obj3).GenerateSourceCode((object)componentMetadata);
					goto IL_054b;
				}
				case 3:
					rrPOjcObvqGMr9XWj3w3(componentMetadata, eT6NsoObZXV2pfa88fQR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716431083)));
					num2 = 7;
					continue;
				case 9:
				{
					ComponentMetadataItemHeader componentMetadataItemHeader2 = new ComponentMetadataItemHeader();
					hUbiieObHjtwIwX0Slep(componentMetadataItemHeader2, sa9A4wObn7Tgoi9k3YhB(componentMetadata));
					zDxGyVObLPqsrhBOdnhc(componentMetadataItemHeader2, componentMetadata.Name);
					TIi2rWOb9glOgYG3E9Sb(componentMetadataItemHeader2, mHHaMBObf1FK91S4Y4ZN(componentMetadata));
					componentMetadataItemHeader2.Description = (string)WnErttObWUFJ39ufm7PC(componentMetadata);
					UBJLwXObRGQnSVHhA9go(componentMetadataItemHeader2, uKES3nObjDycarD5eufp(componentMetadata));
					componentMetadataItemHeader2.CreationAuthorId = componentMetadataItem.CreationAuthorId;
					oY6IsROb6hmvF1TNqgwV(componentMetadataItemHeader2, componentMetadataItem.CreationDate);
					nEbZkHObqRfrwt9nMp1I(componentMetadataItemHeader2, componentMetadataItem);
					v57IiEOb30Ityqgu0E4F(componentMetadataItemHeader2, componentMetadataItem);
					componentMetadataItemHeader2.MetadataTypeUid = bQ9fRnObT7F8wdKbBV24(componentMetadata);
					componentMetadataItemHeader = componentMetadataItemHeader2;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 12:
					((ClassMetadata)DogTUDObsSSednuiUvmq(evb5eaObY7V0oSVv4axj(componentMetadata))).Properties.Add((PropertyMetadata)YsvhSaObJZyxbuuSQZIh());
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 4;
					}
					continue;
				case 21:
					componentMetadata = new ComponentMetadata(Guid.Empty);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
					{
						num2 = 20;
					}
					continue;
				case 19:
					model = new ComponentBuildAssemblyModel(componentMetadataItem, Enumerable.Empty<byte[]>(), Enumerable.Empty<byte[]>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 18;
					}
					continue;
				case 11:
					user = userManager.Load(SecurityConstants.SystemUserUid);
					num2 = 10;
					continue;
				case 6:
					componentMetadata.Uid = WorkflowSystemComponentConstants.WorkflowTaskUid;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					((ClassMetadata)DogTUDObsSSednuiUvmq(evb5eaObY7V0oSVv4axj(componentMetadata))).Properties.Add(CreateFormUidProperty());
					num2 = 8;
					continue;
				case 10:
				{
					ComponentMetadataItem componentMetadataItem2 = new ComponentMetadataItem();
					T6ZUCfObPfAUVyVxqE9w(componentMetadataItem2, new Guid((string)dQghbkObKtbkdSR6mxpU(0x56F860D7 ^ 0x56F9DE09)));
					b1A2kOObXtBJcXQT86OG(componentMetadataItem2, componentMetadata);
					componentMetadataItem2.CreationAuthorId = user.Id;
					componentMetadataItem2.CreationDate = DateTime.Now;
					componentMetadataItem2.AssemblyVersion = (string)dQghbkObKtbkdSR6mxpU(-1430645277 ^ -1430541619);
					nYfIB7ObdWA2qWSyPwyX(componentMetadataItem2, ComponentMetadataHelper.ServerAssemblyName(componentMetadata));
					componentMetadataItem2.VersionNumber = 1L;
					RS8JcEObD0DWfhWIo5GE(componentMetadataItem2, B3Wgx1ObuOVQEqjZImqy(componentMetadata, text));
					componentMetadataItem = componentMetadataItem2;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				case 13:
					QCFdq0ObQXfTtm3Al3xy(componentMetadataItem, componentMetadataItemHeader);
					num2 = 19;
					continue;
				case 5:
				{
					List<FunctionDependency> functionDependencies = componentMetadata.FunctionDependencies;
					FunctionDependency functionDependency = new FunctionDependency();
					H1TcnJOb0GQFLWPZNlmA(functionDependency, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077869144));
					RjcCKFObyxFhCjf1Pd8c(functionDependency, dQghbkObKtbkdSR6mxpU(0x63D6C913 ^ 0x63D77423));
					aoif91ObmX1EaijjON7Q(functionDependency, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EEBD01)));
					VqVpL3ObtFLjpG96V7g3(functionDependency, new Guid((string)dQghbkObKtbkdSR6mxpU(0x2F44D93A ^ 0x2F456494)));
					TypeSignature typeSignature = new TypeSignature();
					OH3CWHObbaG7OLea2mh6(typeSignature, new Guid((string)dQghbkObKtbkdSR6mxpU(-1108877388 ^ -1108975026)));
					bgiPVKOb5uF2P9J01WYD(typeSignature, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45802505)));
					kfn5wAObgCsdGBJ588tJ(functionDependency, typeSignature);
					TypeSignature obj2 = new TypeSignature
					{
						TypeUid = new Guid((string)dQghbkObKtbkdSR6mxpU(0x4FD00585 ^ 0x4FD1B87F))
					};
					bgiPVKOb5uF2P9J01WYD(obj2, new Guid((string)dQghbkObKtbkdSR6mxpU(-29981480 ^ -29935030)));
					b7J10vObBymqZrm8SQyD(functionDependency, obj2);
					functionDependencies.Add(functionDependency);
					num2 = 14;
					continue;
				}
				case 17:
					return componentMetadataItem;
				case 20:
					Cjq3BUOtzitkqIfnwLR9(componentMetadata);
					num2 = 6;
					continue;
				case 7:
					((ComponentContentMetadata)evb5eaObY7V0oSVv4axj(componentMetadata)).Context.Properties.Add(CreateWorkflowTaskIdProperty());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					obj = null;
					goto IL_054b;
				case 15:
					{
						obj = string.Empty;
						break;
					}
					IL_054b:
					if (obj == null)
					{
						num2 = 15;
						continue;
					}
					break;
				}
				text = (string)obj;
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			((ClassMetadata)DogTUDObsSSednuiUvmq(componentMetadata.Content)).Properties.Add(CreateHideModeProperty());
			num = 12;
		}
	}

	private static ViewModelPropertyMetadata CreateWorkflowTaskIdProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		SyeRGjObpVx1HJFU3fRy(viewModelPropertyMetadata, new Guid((string)dQghbkObKtbkdSR6mxpU(-2111219045 ^ -2111248933)));
		viewModelPropertyMetadata.Name = (string)dQghbkObKtbkdSR6mxpU(0x6A69C5CD ^ 0x6A687A5D);
		viewModelPropertyMetadata.DisplayName = (string)eT6NsoObZXV2pfa88fQR(dQghbkObKtbkdSR6mxpU(0x213F6477 ^ 0x213EDBC7));
		tTFUT0ObCZs91sHqBqnk(viewModelPropertyMetadata, Int64Descriptor.UID);
		viewModelPropertyMetadata.SubTypeUid = Guid.Empty;
		uBbNdfObMQt3NcM4q4hr(viewModelPropertyMetadata, true);
		cFRbStObkBg3WMR2khXE(viewModelPropertyMetadata, false);
		vBjxB2ObUYrNbM2S20YR(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateWorkflowTaskTypeUidProperty()
	{
		ViewModelPropertyMetadata obj = new ViewModelPropertyMetadata
		{
			Uid = new Guid((string)dQghbkObKtbkdSR6mxpU(-1498811449 ^ -1498919885))
		};
		qnm7T2ObO0Pe2gZtlEEe(obj, dQghbkObKtbkdSR6mxpU(-2057730233 ^ -2057812221));
		rrPOjcObvqGMr9XWj3w3(obj, eT6NsoObZXV2pfa88fQR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130082632)));
		tTFUT0ObCZs91sHqBqnk(obj, GuidDescriptor.UID);
		obj.SubTypeUid = Guid.Empty;
		uBbNdfObMQt3NcM4q4hr(obj, true);
		obj.IsSystem = true;
		obj.Nullable = false;
		return obj;
	}

	private static ViewModelPropertyMetadata CreateFormUidProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		SyeRGjObpVx1HJFU3fRy(viewModelPropertyMetadata, new Guid((string)dQghbkObKtbkdSR6mxpU(0x6C7F14 ^ 0x6DBFC6)));
		qnm7T2ObO0Pe2gZtlEEe(viewModelPropertyMetadata, dQghbkObKtbkdSR6mxpU(-2002063381 ^ -2002047287));
		rrPOjcObvqGMr9XWj3w3(viewModelPropertyMetadata, eT6NsoObZXV2pfa88fQR(dQghbkObKtbkdSR6mxpU(-1386448964 ^ -1386367352)));
		tTFUT0ObCZs91sHqBqnk(viewModelPropertyMetadata, GuidDescriptor.UID);
		ntBBRBObVCTmTncNMrTe(viewModelPropertyMetadata, Guid.Empty);
		uBbNdfObMQt3NcM4q4hr(viewModelPropertyMetadata, true);
		cFRbStObkBg3WMR2khXE(viewModelPropertyMetadata, false);
		viewModelPropertyMetadata.IsSystem = true;
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateHideModeProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		SyeRGjObpVx1HJFU3fRy(viewModelPropertyMetadata, new Guid((string)dQghbkObKtbkdSR6mxpU(0x75872B6 ^ 0x759B3C2)));
		qnm7T2ObO0Pe2gZtlEEe(viewModelPropertyMetadata, dQghbkObKtbkdSR6mxpU(0x595C500A ^ 0x595D91CE));
		rrPOjcObvqGMr9XWj3w3(viewModelPropertyMetadata, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4941B7E3)));
		tTFUT0ObCZs91sHqBqnk(viewModelPropertyMetadata, Int32Descriptor.UID);
		viewModelPropertyMetadata.SubTypeUid = Guid.Empty;
		uBbNdfObMQt3NcM4q4hr(viewModelPropertyMetadata, true);
		cFRbStObkBg3WMR2khXE(viewModelPropertyMetadata, false);
		vBjxB2ObUYrNbM2S20YR(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateEntityProperty()
	{
		ViewModelPropertyMetadata obj = new ViewModelPropertyMetadata
		{
			Uid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125946780))
		};
		qnm7T2ObO0Pe2gZtlEEe(obj, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949635489));
		rrPOjcObvqGMr9XWj3w3(obj, eT6NsoObZXV2pfa88fQR(dQghbkObKtbkdSR6mxpU(0x3C1FFB55 ^ 0x3C1E3929)));
		tTFUT0ObCZs91sHqBqnk(obj, StringDescriptor.UID);
		ntBBRBObVCTmTncNMrTe(obj, Guid.Empty);
		obj.Input = true;
		cFRbStObkBg3WMR2khXE(obj, false);
		vBjxB2ObUYrNbM2S20YR(obj, true);
		return obj;
	}

	private static WorkflowTaskViewItem CreateWorkflowTaskViewItem()
	{
		WorkflowTaskViewItem workflowTaskViewItem = new WorkflowTaskViewItem();
		G2rQkbObArLP8UZoOjXN(workflowTaskViewItem, new Guid((string)dQghbkObKtbkdSR6mxpU(0x1134D2C0 ^ 0x1135104C)));
		JfpNaYObGeY0GMjLd2Qj(workflowTaskViewItem, dQghbkObKtbkdSR6mxpU(0x614274E3 ^ 0x6143B63F));
		return workflowTaskViewItem;
	}

	private static ScriptModule CreateScriptModule(object metadata, object sourceCode)
	{
		ScriptModule scriptModule = new ScriptModule();
		oxI2WfOb2GkVsmopV1cX(scriptModule, eRktNyOb74tyKuEcQwjB(metadata));
		pOrtNpObo6EvE67vMWBE(scriptModule, eRktNyOb74tyKuEcQwjB(metadata));
		dhP6gVObFEjRi67DlApw(scriptModule, ComponentMetadataHelper.ClientAssemblyName((ComponentMetadata)metadata, (string)dQghbkObKtbkdSR6mxpU(-1386448964 ^ -1386362734)));
		L3EtMVObioKeNvrlSwHN(scriptModule, ComponentClientScriptModuleTypeConstants.TypeUid);
		Ber5I9ObIPpldtG3HWY1(scriptModule, sourceCode);
		scriptModule.References = string.Empty;
		FI5uFdObrGhnExeV0sHi(scriptModule, Vi4dyAObaMGHljaJ6LoM(metadata));
		return scriptModule;
	}

	internal static void qbnGnFOt4ZyHvHSIXVSb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Eq0aTMOtEJsuXMi2SPLA()
	{
		return CBSJC3OthfcI2Y5IUl9c == null;
	}

	internal static WorkflowSystemComponentCreator uCbj1SOtwQRFTstXU5HT()
	{
		return CBSJC3OthfcI2Y5IUl9c;
	}

	internal static void Cjq3BUOtzitkqIfnwLR9(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static object dQghbkObKtbkdSR6mxpU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qnm7T2ObO0Pe2gZtlEEe(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object eT6NsoObZXV2pfa88fQR(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void rrPOjcObvqGMr9XWj3w3(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object evb5eaObY7V0oSVv4axj(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object fboGOZOb8kKVkaV3Xhfw()
	{
		return CreateWorkflowTaskTypeUidProperty();
	}

	internal static object DogTUDObsSSednuiUvmq(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object YsvhSaObJZyxbuuSQZIh()
	{
		return CreateEntityProperty();
	}

	internal static object KukrF7ObldQRjiZlhrFe()
	{
		return CreateWorkflowTaskViewItem();
	}

	internal static void H1TcnJOb0GQFLWPZNlmA(object P_0, object P_1)
	{
		((Dependency)P_0).Name = (string)P_1;
	}

	internal static void RjcCKFObyxFhCjf1Pd8c(object P_0, object P_1)
	{
		((Dependency)P_0).DisplayName = (string)P_1;
	}

	internal static void aoif91ObmX1EaijjON7Q(object P_0, Guid P_1)
	{
		((Dependency)P_0).HeaderUid = P_1;
	}

	internal static void VqVpL3ObtFLjpG96V7g3(object P_0, Guid P_1)
	{
		((Dependency)P_0).ModuleUid = P_1;
	}

	internal static void OH3CWHObbaG7OLea2mh6(object P_0, Guid P_1)
	{
		((TypeSignature)P_0).TypeUid = P_1;
	}

	internal static void bgiPVKOb5uF2P9J01WYD(object P_0, Guid P_1)
	{
		((TypeSignature)P_0).SubTypeUid = P_1;
	}

	internal static void kfn5wAObgCsdGBJ588tJ(object P_0, object P_1)
	{
		((FunctionDependency)P_0).ParameterType = (TypeSignature)P_1;
	}

	internal static void b7J10vObBymqZrm8SQyD(object P_0, object P_1)
	{
		((FunctionDependency)P_0).ReturnType = (TypeSignature)P_1;
	}

	internal static object qiEDk0ObcxjtWmyfn3iA(object P_0, Guid P_1)
	{
		return ((ScriptModuleManager)P_0).GetScriptModuleType(P_1);
	}

	internal static void T6ZUCfObPfAUVyVxqE9w(object P_0, Guid P_1)
	{
		((ComponentMetadataItem)P_0).Uid = P_1;
	}

	internal static void b1A2kOObXtBJcXQT86OG(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Metadata = P_1;
	}

	internal static void nYfIB7ObdWA2qWSyPwyX(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).AssemblyName = (string)P_1;
	}

	internal static object B3Wgx1ObuOVQEqjZImqy(object P_0, object P_1)
	{
		return CreateScriptModule(P_0, P_1);
	}

	internal static void RS8JcEObD0DWfhWIo5GE(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ClientScriptModule = (ScriptModule)P_1;
	}

	internal static Guid sa9A4wObn7Tgoi9k3YhB(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void hUbiieObHjtwIwX0Slep(object P_0, Guid P_1)
	{
		((ComponentMetadataItemHeader)P_0).Uid = P_1;
	}

	internal static void zDxGyVObLPqsrhBOdnhc(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object mHHaMBObf1FK91S4Y4ZN(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void TIi2rWOb9glOgYG3E9Sb(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object WnErttObWUFJ39ufm7PC(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static Guid uKES3nObjDycarD5eufp(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void UBJLwXObRGQnSVHhA9go(object P_0, Guid P_1)
	{
		((ComponentMetadataItemHeader)P_0).ModuleUid = P_1;
	}

	internal static void oY6IsROb6hmvF1TNqgwV(object P_0, DateTime P_1)
	{
		((ComponentMetadataItemHeader)P_0).CreationDate = P_1;
	}

	internal static void nEbZkHObqRfrwt9nMp1I(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Draft = (ComponentMetadataItem)P_1;
	}

	internal static void v57IiEOb30Ityqgu0E4F(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Published = (ComponentMetadataItem)P_1;
	}

	internal static Guid bQ9fRnObT7F8wdKbBV24(object P_0)
	{
		return ((ComponentMetadata)P_0).GetMetadataTypeUid();
	}

	internal static void QCFdq0ObQXfTtm3Al3xy(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Header = (ComponentMetadataItemHeader)P_1;
	}

	internal static void SyeRGjObpVx1HJFU3fRy(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static void tTFUT0ObCZs91sHqBqnk(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static void uBbNdfObMQt3NcM4q4hr(object P_0, bool P_1)
	{
		((ViewModelPropertyMetadata)P_0).Input = P_1;
	}

	internal static void cFRbStObkBg3WMR2khXE(object P_0, bool P_1)
	{
		((PropertyMetadata)P_0).Nullable = P_1;
	}

	internal static void vBjxB2ObUYrNbM2S20YR(object P_0, bool P_1)
	{
		((PropertyMetadata)P_0).IsSystem = P_1;
	}

	internal static void ntBBRBObVCTmTncNMrTe(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static void G2rQkbObArLP8UZoOjXN(object P_0, Guid P_1)
	{
		((ViewItem)P_0).Uid = P_1;
	}

	internal static void JfpNaYObGeY0GMjLd2Qj(object P_0, object P_1)
	{
		((ViewItem)P_0).Name = (string)P_1;
	}

	internal static object eRktNyOb74tyKuEcQwjB(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void oxI2WfOb2GkVsmopV1cX(object P_0, object P_1)
	{
		((ScriptModule)P_0).ClassName = (string)P_1;
	}

	internal static void pOrtNpObo6EvE67vMWBE(object P_0, object P_1)
	{
		((ScriptModule)P_0).ModuleName = (string)P_1;
	}

	internal static void dhP6gVObFEjRi67DlApw(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static void L3EtMVObioKeNvrlSwHN(object P_0, Guid P_1)
	{
		((ScriptModule)P_0).ModuleTypeUid = P_1;
	}

	internal static void Ber5I9ObIPpldtG3HWY1(object P_0, object P_1)
	{
		((ScriptModule)P_0).SourceCode = (string)P_1;
	}

	internal static object Vi4dyAObaMGHljaJ6LoM(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static void FI5uFdObrGhnExeV0sHi(object P_0, object P_1)
	{
		((ScriptModule)P_0).Namespace = (string)P_1;
	}
}
