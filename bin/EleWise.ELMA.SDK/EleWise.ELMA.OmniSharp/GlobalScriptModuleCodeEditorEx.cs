using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

[Component]
internal sealed class GlobalScriptModuleCodeEditorExtension : AbstractCodeEditorExtension
{
	private class FindProjectItemResult
	{
		private static object kis3i3QLg7bMPuLYW1YF;

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return _003CPath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CPath_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ProjectItem ProjectItem
		{
			[CompilerGenerated]
			get
			{
				return _003CProjectItem_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CProjectItem_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public FindProjectItemResult()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HwTq21QLYviUV6lFAg7M();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool b6EytBQL5IjKuJTSiCNo()
		{
			return kis3i3QLg7bMPuLYW1YF == null;
		}

		internal static FindProjectItemResult kZ8uFEQLjINRsd2EG0hk()
		{
			return (FindProjectItemResult)kis3i3QLg7bMPuLYW1YF;
		}

		internal static void HwTq21QLYviUV6lFAg7M()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static GlobalScriptModuleCodeEditorExtension Qh2WXtW9TQoF3L4v6COH;

	protected override CodeType CodeType => CodeType.Server;

	public override bool Check(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 1;
		int num2 = num;
		GlobalScriptModuleInitWorkspaceRequest globalScriptModuleInitWorkspaceRequest = default(GlobalScriptModuleInitWorkspaceRequest);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return hh9dNeW9OiVCm8Wf5EVL(globalScriptModuleInitWorkspaceRequest) == zXRDCtW92IL8nfXprTpZ(this);
			default:
				return false;
			case 1:
				if ((globalScriptModuleInitWorkspaceRequest = request as GlobalScriptModuleInitWorkspaceRequest) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0143, IL_0152
		int num = 6;
		List<IScriptSource> list = default(List<IScriptSource>);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		GlobalScriptModuleInitWorkspaceRequest globalScriptModuleInitWorkspaceRequest = default(GlobalScriptModuleInitWorkspaceRequest);
		ScriptModule scriptModule = default(ScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					list.Add(GenerateProjectFile(projectHelper, list, assemblies));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					break;
				case 5:
					if (globalScriptModuleInitWorkspaceRequest != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				default:
					throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F324968), tEGSkcW9eXpvmVAyTsP4(-281842504 ^ -281977186), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE3ECE)));
				case 4:
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, GlobalScriptModuleType.UID);
					num2 = 9;
					continue;
				case 2:
					return new ScriptData(list, assemblies);
				case 1:
					list.AddRange(GenerateWebReferencesSources(scriptModule));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					globalScriptModuleInitWorkspaceRequest = request as GlobalScriptModuleInitWorkspaceRequest;
					num2 = 5;
					continue;
				case 3:
					assemblies = GetAssemblies(scriptModule);
					num2 = 8;
					continue;
				case 9:
					list = GenerateSources(globalScriptModuleInitWorkspaceRequest);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			projectHelper = GetProjectHelper(scriptModule);
			num = 7;
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_01ac
		int num = 5;
		int num2 = num;
		ScriptModule scriptModule = default(ScriptModule);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		GlobalScriptModuleInitWorkspaceRequest globalScriptModuleInitWorkspaceRequest = default(GlobalScriptModuleInitWorkspaceRequest);
		FindProjectItemResult findProjectItemResult = default(FindProjectItemResult);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new ArgumentException(SR.T((string)tEGSkcW9eXpvmVAyTsP4(-1867198571 ^ -1867055541), tEGSkcW9eXpvmVAyTsP4(-1426094279 ^ -1426213601), tEGSkcW9eXpvmVAyTsP4(-1334993905 ^ -1334858119)));
			case 2:
				throw new Exception((string)p3LapPW93QSC5MoA5cJT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A7E767)));
			case 6:
				scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, GlobalScriptModuleType.UID);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				projectHelper = GetProjectHelper(scriptModule);
				num2 = 7;
				break;
			case 4:
				if (globalScriptModuleInitWorkspaceRequest != null)
				{
					findProjectItemResult = FindProjectItem(PBfiANW91ne9yIkXIBqt(GliNPhW9P4ruATWhDF35(globalScriptModuleInitWorkspaceRequest)) as ProjectInfo, evXtvmW9NO52MxfmGru1(globalScriptModuleInitWorkspaceRequest));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 1:
				if (findProjectItemResult != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 7:
			{
				CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
				t3afscW9pg1rJ4g0sWIq(codeEditorInitData, findProjectItemResult.Path);
				x3Ms2bW9DT3PrDgy1XpY(codeEditorInitData, ((ProjectItem)XrnUrtW9aqY7btttPC8e(findProjectItemResult)).Code);
				codeEditorInitData.ProjectName = (string)a900wbW9tjVOJodfjuwM(projectHelper);
				return codeEditorInitData;
			}
			case 5:
				globalScriptModuleInitWorkspaceRequest = request as GlobalScriptModuleInitWorkspaceRequest;
				num2 = 4;
				break;
			}
		}
	}

	private WorkspaceProjectHelper GetProjectHelper(ScriptModule scriptModule)
	{
		return new WorkspaceProjectHelper(scriptModule, ((string)ATiFNFW9ws844ddAooGK(scriptModule)).ToTranslit());
	}

	private FindProjectItemResult FindProjectItem(ProjectInfo projectInfo, Guid projectItemUid)
	{
		return FindProjectItem(projectInfo, projectItemUid, string.Empty);
	}

	private FindProjectItemResult FindProjectItem(ProjectFolderItem projectFolder, Guid projectItemUid, string currentPath)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0113, IL_01bc, IL_01cb, IL_021d, IL_0251, IL_0291, IL_02a0, IL_02ac
		int num = 5;
		int num2 = num;
		ProjectItem projectItem = default(ProjectItem);
		IEnumerator<ProjectFolderItem> enumerator = default(IEnumerator<ProjectFolderItem>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		ProjectFolderItem current = default(ProjectFolderItem);
		FindProjectItemResult result = default(FindProjectItemResult);
		FindProjectItemResult findProjectItemResult = default(FindProjectItemResult);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (projectItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					enumerator = projectFolder.Items.OfType<ProjectFolderItem>().GetEnumerator();
					num2 = 2;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass8_.projectItemUid = projectItemUid;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				projectItem = projectFolder.Items.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CFindProjectItem_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 3;
				}
				break;
			default:
			{
				FindProjectItemResult findProjectItemResult2 = new FindProjectItemResult();
				jDr9k7W9HBhBgI6Zifmh(findProjectItemResult2, XJSJygW96iquAuqKVqe0(currentPath, ((string)J2S5wcW94YsJEsypPy0j(projectItem)).ToTranslitIdent()));
				YWNR4eW9AkV7A2kCjQHg(findProjectItemResult2, projectItem);
				return findProjectItemResult2;
			}
			case 2:
				try
				{
					while (true)
					{
						IL_01d6:
						int num3;
						if (!FwWRrFW97QwG01Xpqk1i(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num3 = 0;
							}
							goto IL_0117;
						}
						goto IL_0194;
						IL_0194:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num3 = 0;
						}
						goto IL_0117;
						IL_0117:
						while (true)
						{
							switch (num3)
							{
							case 3:
								result = findProjectItemResult;
								num3 = 6;
								continue;
							case 8:
								if (findProjectItemResult == null)
								{
									num3 = 4;
									continue;
								}
								goto case 3;
							case 5:
								currentPath = (string)XJSJygW96iquAuqKVqe0(currentPath, ((string)J2S5wcW94YsJEsypPy0j(current)).ToTranslitIdent());
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num3 = 0;
								}
								continue;
							case 7:
								break;
							default:
								goto IL_01d6;
							case 1:
								findProjectItemResult = FindProjectItem(current, _003C_003Ec__DisplayClass8_.projectItemUid, currentPath);
								num3 = 8;
								continue;
							case 2:
								goto end_IL_01d6;
							case 6:
								return result;
							}
							break;
						}
						goto IL_0194;
						continue;
						end_IL_01d6:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num4 = 1;
						}
						goto IL_0255;
					}
					goto IL_026b;
					IL_026b:
					IRhfqEW9xeHIi5VZgmGT(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num4 = 0;
					}
					goto IL_0255;
					IL_0255:
					switch (num4)
					{
					default:
						goto end_IL_0230;
					case 2:
						break;
					case 1:
						goto end_IL_0230;
					case 0:
						goto end_IL_0230;
					}
					goto IL_026b;
					end_IL_0230:;
				}
				goto case 6;
			case 6:
				return null;
			case 5:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private static List<IScriptSource> GenerateSources(object gsmRequest)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.gsmRequest = (GlobalScriptModuleInitWorkspaceRequest)gsmRequest;
		return ((IEnumerable<IScriptSource>)(from item in EnumerateProjectItems(CS_0024_003C_003E8__locals0.gsmRequest.GlobalScriptModule.Items as ProjectInfo)
			select new ScriptSource((string)_003C_003Ec__DisplayClass9_0.E7nOAkQUhF19CW6VEcTN(item), item.ProjectItem.Code, (!(_003C_003Ec__DisplayClass9_0.f0TFV2QUEmfIrvp2CRE5(_003C_003Ec__DisplayClass9_0.UZOjpnQUGYlRRTcDNLkc(item)) == CS_0024_003C_003E8__locals0.gsmRequest.ProjectItemUid)) ? ScriptSourceType.Additional : ScriptSourceType.Edit))).ToList();
	}

	[IteratorStateMachine(typeof(_003CEnumerateProjectItems_003Ed__10))]
	private static IEnumerable<FindProjectItemResult> EnumerateProjectItems(object projectInfo)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CEnumerateProjectItems_003Ed__10(-2)
		{
			_003C_003E3__projectInfo = (ProjectInfo)projectInfo
		};
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<GlobalScriptModuleCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AFFE28), (string s) => (string)_003C_003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH(_003C_003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH(((string)_003C_003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH(s, _003C_003Ec__DisplayClass11_0.ICNwBsQUk8P0AlPRa5Of(0x7EC153F ^ 0x7E99881), _003C_003Ec__DisplayClass11_0.H0WUEpQUnPvGCpOLuQJ2(CS_0024_003C_003E8__locals0.projectHelper))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97739384), (string)_003C_003Ec__DisplayClass11_0.pRFmUNQU2iCYaT1lMoPI(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass11_0.ICNwBsQUk8P0AlPRa5Of(-289714582 ^ -289488790), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A64BBA2), AbstractCodeEditorExtension.GenerateSourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	public GlobalScriptModuleCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W5sjJmW90Ghh76GiH7mq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static CodeType hh9dNeW9OiVCm8Wf5EVL(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).CodeType;
	}

	internal static CodeType zXRDCtW92IL8nfXprTpZ(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static bool vehHoWW9kdlRjrkvnuOR()
	{
		return Qh2WXtW9TQoF3L4v6COH == null;
	}

	internal static GlobalScriptModuleCodeEditorExtension TUUQKUW9nDTQuBlC5ZX8()
	{
		return Qh2WXtW9TQoF3L4v6COH;
	}

	internal static object tEGSkcW9eXpvmVAyTsP4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GliNPhW9P4ruATWhDF35(object P_0)
	{
		return ((GlobalScriptModuleInitWorkspaceRequest)P_0).GlobalScriptModule;
	}

	internal static object PBfiANW91ne9yIkXIBqt(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Items;
	}

	internal static Guid evXtvmW9NO52MxfmGru1(object P_0)
	{
		return ((GlobalScriptModuleInitWorkspaceRequest)P_0).ProjectItemUid;
	}

	internal static object p3LapPW93QSC5MoA5cJT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void t3afscW9pg1rJ4g0sWIq(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static object XrnUrtW9aqY7btttPC8e(object P_0)
	{
		return ((FindProjectItemResult)P_0).ProjectItem;
	}

	internal static void x3Ms2bW9DT3PrDgy1XpY(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object a900wbW9tjVOJodfjuwM(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static object ATiFNFW9ws844ddAooGK(object P_0)
	{
		return ((ScriptModule)P_0).Namespace;
	}

	internal static object J2S5wcW94YsJEsypPy0j(object P_0)
	{
		return ((ProjectItem)P_0).Name;
	}

	internal static object XJSJygW96iquAuqKVqe0(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void jDr9k7W9HBhBgI6Zifmh(object P_0, object P_1)
	{
		((FindProjectItemResult)P_0).Path = (string)P_1;
	}

	internal static void YWNR4eW9AkV7A2kCjQHg(object P_0, object P_1)
	{
		((FindProjectItemResult)P_0).ProjectItem = (ProjectItem)P_1;
	}

	internal static bool FwWRrFW97QwG01Xpqk1i(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void IRhfqEW9xeHIi5VZgmGT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void W5sjJmW90Ghh76GiH7mq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
