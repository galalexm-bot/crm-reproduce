using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

internal sealed class ServerComponentCodeEditorExtension : AbstractComponentCodeEditorExtension
{
	private static ServerComponentCodeEditorExtension CuRCAmWdK3jfLoG3wKWd;

	protected override Guid ModuleTypeUid => ComponentScriptModuleType.TypeUid;

	protected override CodeType CodeType => CodeType.Server;

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0153, IL_018c, IL_01ba, IL_01c9
		int num = 9;
		ScriptModule scriptModule = default(ScriptModule);
		IList<IScriptSource> list = default(IList<IScriptSource>);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		MetadataSourcesProviderArgs args = default(MetadataSourcesProviderArgs);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					return null;
				case 12:
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, aDe5bDWdkIafQLWnLTHF(this));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					return new ScriptData(list, assemblies);
				case 2:
				{
					MetadataSourcesProviderArgs metadataSourcesProviderArgs = new MetadataSourcesProviderArgs();
					UXonTJWdnOA30hx6hfuP(metadataSourcesProviderArgs, ClassSerializationHelper.CloneObjectByXml(componentMetadata));
					metadataSourcesProviderArgs.ScriptModule = scriptModule;
					metadataSourcesProviderArgs.GenerationMode = GenerationMode.CodeEditor;
					args = metadataSourcesProviderArgs;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 6:
					goto end_IL_0012;
				case 10:
					list.Add(GenerateProjectFile(projectHelper, list, assemblies));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					if (componentMetadata != null)
					{
						num2 = 12;
						continue;
					}
					goto case 5;
				case 3:
					projectHelper = new WorkspaceProjectHelper(scriptModule);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					if (request != null)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 7:
					list.AddRange(GenerateWebReferencesSources(scriptModule));
					num2 = 6;
					continue;
				case 1:
					obj = null;
					break;
				default:
					list = GenerateSources(args);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					obj = request.Metadata;
					break;
				}
				componentMetadata = obj as ComponentMetadata;
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			assemblies = GetAssemblies(scriptModule);
			num = 3;
		}
	}

	private IList<IScriptSource> GenerateSources(MetadataSourcesProviderArgs args)
	{
		using (MetadataServiceContext.Extend(GetExtendMetadata((ComponentMetadata)args.Metadata)))
		{
			return base.ComponentMetadataSourcesService.GetServerSources(args).ToList();
		}
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234164768), (string s) => (string)_003C_003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(_003C_003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(_003C_003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(_003C_003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(s, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638761553), _003C_003Ec__DisplayClass6_0.xTkS2MQUlb0pUi4J2uSV(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(-643786247 ^ -643492825), _003C_003Ec__DisplayClass6_0.CcVo4pQU5uxQ3lwfvRas(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(0xD3DEF7E ^ 0xD38617E), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references)), _003C_003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(0x48A7E34A ^ 0x48A26D56), AbstractCodeEditorExtension.GenerateSourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	public ServerComponentCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wLdZCHWdOSOB9I6m4wsf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid aDe5bDWdkIafQLWnLTHF(object P_0)
	{
		return ((AbstractComponentCodeEditorExtension)P_0).ModuleTypeUid;
	}

	internal static void UXonTJWdnOA30hx6hfuP(object P_0, object P_1)
	{
		((MetadataSourcesProviderArgs)P_0).Metadata = (IMetadata)P_1;
	}

	internal static bool R6l1LnWdX5pSFFWJFuEW()
	{
		return CuRCAmWdK3jfLoG3wKWd == null;
	}

	internal static ServerComponentCodeEditorExtension PKKWS1WdTrbUnaWK48m0()
	{
		return CuRCAmWdK3jfLoG3wKWd;
	}

	internal static void wLdZCHWdOSOB9I6m4wsf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
