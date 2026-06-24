using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

[Component]
internal sealed class ServerFormCodeEditorExtension : AbstractCodeEditorExtension
{
	private static ServerFormCodeEditorExtension qc5ZbDWdbwDJcEepPppe;

	protected override CodeType CodeType => CodeType.Server;

	public override bool Check(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0086, IL_0095, IL_00c4, IL_00d3
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return aABKjFWdQjup1Vd0htOX(request) is PageMetadata;
				case 2:
					return true;
				case 3:
					return false;
				case 5:
					if (aABKjFWdQjup1Vd0htOX(request) is PortletMetadata)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					if (request == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 1;
				case 1:
					if (kW6m9uWdEeAGAv6IIwxZ(request) == RIArnZWdfDIyfRaJvTlq(this))
					{
						goto end_IL_0012;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_006b, IL_0075
		int num = 8;
		IList<IScriptSource> list = default(IList<IScriptSource>);
		ScriptModule scriptModule = default(ScriptModule);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		FormMetadata formMetadata = default(FormMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					list.AddRange(GenerateWebReferencesSources(scriptModule));
					num = 4;
					break;
				case 9:
					obj = null;
					goto IL_0166;
				case 6:
					projectHelper = new WorkspaceProjectHelper(scriptModule);
					num2 = 3;
					continue;
				case 4:
					assemblies = GetAssemblies(scriptModule);
					num2 = 6;
					continue;
				case 10:
					list = GenerateSources(formMetadata, scriptModule);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (request != null)
					{
						num = 7;
						break;
					}
					goto case 9;
				case 2:
					if (formMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, PageScriptModuleType.UID, PortletScriptModuleType.UID);
						num2 = 10;
					}
					continue;
				case 1:
					return null;
				case 5:
					return new ScriptData(list, assemblies);
				case 3:
					list.Add(GenerateProjectFile(projectHelper, list, assemblies));
					num2 = 5;
					continue;
				case 7:
					{
						obj = request.Metadata;
						goto IL_0166;
					}
					IL_0166:
					formMetadata = obj as FormMetadata;
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_006f
		int num = 5;
		int num2 = num;
		WorkspaceProjectHelper workspaceProjectHelper = default(WorkspaceProjectHelper);
		ScriptModule scriptModule = default(ScriptModule);
		FormMetadata formMetadata = default(FormMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
				num2 = 3;
				continue;
			default:
				if (formMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, PageScriptModuleType.UID, PortletScriptModuleType.UID);
					num2 = 2;
				}
				continue;
			case 4:
				obj = null;
				break;
			case 3:
			{
				CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
				c9a5k1Wdv5edmZ6tPhQJ(codeEditorInitData, mJV0LrWdCedDqGF32dhq(formMetadata));
				E27o5BWdZcWV3d8k0yFd(codeEditorInitData, formMetadata.Name + (string)iIhMq7Wd82UuSQdhp9Cq(0xD3DEF7E ^ 0xD3D4406));
				vDtmv6WdI4xuvsG92MgT(codeEditorInitData, u5qCeeWduB9MjUHWWnQH(request));
				mKIHtSWdSGCaAIjmtYVn(codeEditorInitData, W0aC8sWdVGmU3jUhobXo(scriptModule));
				IOJ7v1WdRXE5sbRi7I07(codeEditorInitData, swSAD5WdiB25y3yXPlVD(workspaceProjectHelper));
				return codeEditorInitData;
			}
			case 5:
				if (request == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				obj = request.Metadata;
				break;
			case 1:
				return null;
			}
			formMetadata = obj as FormMetadata;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num2 = 0;
			}
		}
	}

	private IList<IScriptSource> GenerateSources(FormMetadata metadata, ScriptModule scriptModule)
	{
		using (new MetadataServiceContext(new ExtendedMetadataService(base.MetadataRuntimeService, metadata.GetMetadataToRegister())))
		{
			List<IScriptSource> list = new List<IScriptSource>
			{
				new ScriptSource(GetControllerFileName(metadata), scriptModule.SourceCode, ScriptSourceType.Edit)
			};
			GeneratedFileInfo[] array = FormCodeCompiler.CreateGenerator(metadata).Generate();
			foreach (GeneratedFileInfo generatedFileInfo in array)
			{
				if (generatedFileInfo.Type == GeneratedFileType.CS)
				{
					string text = generatedFileInfo.Extension;
					if (text.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70101138)))
					{
						text = text.Substring(0, text.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488809851).Length);
					}
					list.Add(new ScriptSource(metadata.Name + text, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
				}
			}
			return list;
		}
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606796820), (string s) => (string)_003C_003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(_003C_003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(_003C_003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(_003C_003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(s, _003C_003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(-70037984 ^ -69811298), _003C_003Ec__DisplayClass6_0.WySPrcQUmMhAX5F0Uy08(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(0x463A0F3C ^ 0x463F82E2), CS_0024_003C_003E8__locals0.projectHelper.ProjectAssemblyName), _003C_003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(-1767720453 ^ -1767426053), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69842671), AbstractCodeEditorExtension.GenerateSourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	private static string GetControllerFileName(object metadata)
	{
		return string.Join((string)iIhMq7Wd82UuSQdhp9Cq(-1822890472 ^ -1822884644), (string)EiXJl7WdqpvB3EL1In7R(metadata), (string)iIhMq7Wd82UuSQdhp9Cq(-1858887263 ^ -1858925863));
	}

	public ServerFormCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	internal static CodeType kW6m9uWdEeAGAv6IIwxZ(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).CodeType;
	}

	internal static CodeType RIArnZWdfDIyfRaJvTlq(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static object aABKjFWdQjup1Vd0htOX(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool fcyKpBWdhxrUK3jJCokc()
	{
		return qc5ZbDWdbwDJcEepPppe == null;
	}

	internal static ServerFormCodeEditorExtension pN9oKmWdGQbxl3HWRwxH()
	{
		return qc5ZbDWdbwDJcEepPppe;
	}

	internal static object mJV0LrWdCedDqGF32dhq(object P_0)
	{
		return GetControllerFileName(P_0);
	}

	internal static void c9a5k1Wdv5edmZ6tPhQJ(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static object iIhMq7Wd82UuSQdhp9Cq(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void E27o5BWdZcWV3d8k0yFd(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ClassName = (string)P_1;
	}

	internal static object u5qCeeWduB9MjUHWWnQH(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).MethodName;
	}

	internal static void vDtmv6WdI4xuvsG92MgT(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).MethodName = (string)P_1;
	}

	internal static object W0aC8sWdVGmU3jUhobXo(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static void mKIHtSWdSGCaAIjmtYVn(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object swSAD5WdiB25y3yXPlVD(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static void IOJ7v1WdRXE5sbRi7I07(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ProjectName = (string)P_1;
	}

	internal static object EiXJl7WdqpvB3EL1In7R(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}
}
