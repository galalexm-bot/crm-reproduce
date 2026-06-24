using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.OmniSharp;

[Component(Order = -50)]
internal sealed class ServerWorkflowCodeEditorExtension : AbstractCodeEditorExtension
{
	private readonly WorkflowProcessManager workflowProcessManager;

	private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfo;

	internal static ServerWorkflowCodeEditorExtension vFuwLU50ynRnRqmvPu0;

	protected override CodeType CodeType => CodeType.Server;

	public ServerWorkflowCodeEditorExtension(WorkflowProcessManager workflowProcessManager, IEnumerable<IMetadataTypeInfo> metadataTypeInfo)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		this.workflowProcessManager = workflowProcessManager;
		this.metadataTypeInfo = metadataTypeInfo;
	}

	public override bool Check(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_007d, IL_008c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (request == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return NlWo9p5bhtfi56tDyoR(request) is ProcessContext;
			case 1:
				return false;
			default:
				if (request.CodeType == oqv1nZ5tVaTRvJndOYx(this))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_00a0, IL_00af, IL_0107, IL_014f, IL_015e, IL_016e, IL_01cc, IL_01fe, IL_020d, IL_0231, IL_0310, IL_032f, IL_033e, IL_036b
		int num = 5;
		int num2 = num;
		List<EntityMetadata> list = default(List<EntityMetadata>);
		ProcessContext processContext3 = default(ProcessContext);
		ProcessContext processContext = default(ProcessContext);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		ProcessContext processContext2 = default(ProcessContext);
		IScriptData result = default(IScriptData);
		ScriptModule scriptModule = default(ScriptModule);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		WorkflowInitWorkspaceRequest workflowInitWorkspaceRequest = default(WorkflowInitWorkspaceRequest);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 10:
				list.Add(processContext3);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 8;
				}
				continue;
			case 16:
				processContext3.TableParts.AddRange((IEnumerable<TablePartMetadata>)processContext.EntityTableParts);
				num2 = 10;
				continue;
			default:
				metadataServiceContext = MetadataServiceContext.Extend(list.Concat(processContext2));
				num2 = 18;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 9;
				}
				continue;
			case 4:
				obj = null;
				break;
			case 2:
				return result;
			case 14:
				return null;
			case 15:
				scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ProcessScriptModuleType.UID);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 21;
				}
				continue;
			case 20:
				workflowProcess = workflowProcessManager.Load(SUvUvu5BGRRng4hgoEk(workflowInitWorkspaceRequest));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 13;
				}
				continue;
			case 9:
				if (processContext2 != null)
				{
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 14;
			case 8:
				workflowProcess = (IWorkflowProcess)qdjdSC5cgackMCNQsGM(workflowProcess);
				num2 = 11;
				continue;
			case 5:
				if (request == null)
				{
					num2 = 4;
					continue;
				}
				obj = xSHZVb55OibARjAhKBM(request);
				break;
			case 18:
				try
				{
					IList<IScriptSource> list2 = GenerateSources(processContext2, scriptModule, list);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 3:
							return result;
						default:
							result = new ScriptData(list2, assemblies);
							num3 = 3;
							break;
						case 2:
							list2.AddRange(GenerateWebReferencesSources(scriptModule));
							num3 = 5;
							break;
						case 1:
							projectHelper = new WorkspaceProjectHelper(scriptModule);
							num3 = 4;
							break;
						case 4:
							list2.Add(GenerateProjectFile(projectHelper, list2, assemblies));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
							{
								num3 = 0;
							}
							break;
						case 5:
							assemblies = GetAssemblies(scriptModule);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (metadataServiceContext == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
						{
							num4 = 0;
						}
						goto IL_0314;
					}
					goto IL_0349;
					IL_0349:
					xj6Z2S5X55yyFF6uB0S(metadataServiceContext);
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num4 = 1;
					}
					goto IL_0314;
					IL_0314:
					switch (num4)
					{
					default:
						goto end_IL_02ef;
					case 0:
						goto end_IL_02ef;
					case 2:
						break;
					case 1:
						goto end_IL_02ef;
					}
					goto IL_0349;
					end_IL_02ef:;
				}
			case 6:
				processContext3.Properties.AddRange((IEnumerable<PropertyMetadata>)processContext.EntityProperties);
				num2 = 16;
				continue;
			case 12:
				if (!Rx2rO55g7mOOqWGt4DG(workflowInitWorkspaceRequest.ProcessUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 20;
			case 7:
				processContext3 = ClassSerializationHelper.CloneObjectByXml(processContext);
				num2 = 6;
				continue;
			case 11:
			case 13:
				if (qdjdSC5cgackMCNQsGM(workflowProcess) != null)
				{
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 17;
					}
					continue;
				}
				goto default;
			case 22:
				if ((workflowInitWorkspaceRequest = request as WorkflowInitWorkspaceRequest) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 12;
			case 3:
			case 17:
				processContext = (ProcessContext)Tgdw8g5Pl3rkajJsj5t(qdjdSC5cgackMCNQsGM(workflowProcess));
				num2 = 7;
				continue;
			case 21:
				list = new List<EntityMetadata>();
				num2 = 22;
				continue;
			}
			processContext2 = obj as ProcessContext;
			num2 = 9;
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0139, IL_017e
		int num = 10;
		ScriptModule scriptModule = default(ScriptModule);
		ProcessContext processContext = default(ProcessContext);
		WorkspaceProjectHelper workspaceProjectHelper = default(WorkspaceProjectHelper);
		ProcessContext processContext2 = default(ProcessContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
				{
					CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
					iDQPsN5uheo8BXgdQPX(codeEditorInitData, scriptModule.ModuleName);
					codeEditorInitData.ClassName = GetClassName(processContext);
					TIgWFh5np8XSXaWwq9J(codeEditorInitData, X4pw6p5DA9ENLS2t8Kf(request));
					rM5rFk5Lj7IHNtXXS6I(codeEditorInitData, BfHqIH5H6Kx7Qxx1yx6(scriptModule));
					S0uNOG59hUHLHwgyJSr(codeEditorInitData, oMVd9I5fhxGL90dNo3w(workspaceProjectHelper));
					return codeEditorInitData;
				}
				case 10:
					if (request == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj = xSHZVb55OibARjAhKBM(request);
					break;
				case 2:
					if (processContext != null)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 5:
					goto end_IL_0012;
				default:
					processContext2 = ClassSerializationHelper.CloneObjectByXml(processContext);
					num2 = 4;
					continue;
				case 4:
					processContext2.Properties.AddRange((IEnumerable<PropertyMetadata>)processContext.EntityProperties);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					ETAS1n5droNd07Plx38(request, processContext2);
					num2 = 6;
					continue;
				case 9:
					obj = null;
					break;
				case 3:
					return null;
				case 7:
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ProcessScriptModuleType.UID);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 1;
					}
					continue;
				}
				processContext = obj as ProcessContext;
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			processContext2.TableParts.AddRange((IEnumerable<TablePartMetadata>)processContext.EntityTableParts);
			num = 8;
		}
	}

	private IList<IScriptSource> GenerateSources(ProcessContext metadata, ScriptModule scriptModule, List<EntityMetadata> additionalMetadata)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		metadata = metadata.CastAsRealType();
		CS_0024_003C_003E8__locals0.metadataType = metadata.GetType();
		IMetadataTypeInfo metadataTypeInfo = this.metadataTypeInfo.FirstOrDefault((IMetadataTypeInfo m) => _003C_003Ec__DisplayClass8_0.aJ0vGdZjI1rfVsblZmeS(m.MetadataType, CS_0024_003C_003E8__locals0.metadataType));
		if (metadataTypeInfo == null)
		{
			throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39171314), CS_0024_003C_003E8__locals0.metadataType));
		}
		ICodeGenerator codeGenerator = (ICodeGenerator)Activator.CreateInstance(metadataTypeInfo.GeneratorType);
		codeGenerator.Metadata = metadata;
		codeGenerator.GenerationParams = new ProcessContextGenerationParams
		{
			ParentContext = (MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid) as EntityMetadata),
			IsFullContext = false,
			ParentContextList = additionalMetadata,
			FileName = metadata.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2C222),
			Namespace = metadata.Namespace,
			Mode = GenerationMode.CodeEditor
		};
		ICodeGenerator codeGenerator2 = new ProcessContextScriptGenerator(MetadataServiceContext.Service);
		codeGenerator2.Metadata = metadata;
		codeGenerator2.GenerationParams.Mode = GenerationMode.CodeEditor;
		string @string = Encoding.UTF8.GetString(codeGenerator2.GenerateMainFile().Data);
		List<IScriptSource> list = new List<IScriptSource>();
		list.Add(new ScriptSource(GetClassName(metadata), scriptModule.SourceCode, ScriptSourceType.Edit));
		list.Add(new ScriptSource(string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7F2717), metadata.Name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438A4743)), @string, ScriptSourceType.Additional));
		List<IScriptSource> list2 = list;
		GeneratedFileInfo[] array = codeGenerator.Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				string text = generatedFileInfo.Extension;
				if (text.EndsWith(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002082021)))
				{
					text = text.Substring(0, text.Length - SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431982290).Length);
				}
				list2.Add(new ScriptSource(metadata.Name + text, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list2;
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<AbstractCodeEditorExtension>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17833099), (string s) => ((string)_003C_003Ec__DisplayClass9_0.CAGsXcZj1rrVl0EuBXni(_003C_003Ec__DisplayClass9_0.CAGsXcZj1rrVl0EuBXni(_003C_003Ec__DisplayClass9_0.CAGsXcZj1rrVl0EuBXni(s, _003C_003Ec__DisplayClass9_0.P1wwVxZjxobAjsq9adYV(-22348816 ^ -22530622), _003C_003Ec__DisplayClass9_0.QoOAUrZjSYgWFSdFfELR(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass9_0.P1wwVxZjxobAjsq9adYV(-1516552726 ^ -1516637256), _003C_003Ec__DisplayClass9_0.yYMD7bZjhkcq2EtVuBOq(CS_0024_003C_003E8__locals0.projectHelper)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057615053), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references))).Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C6D41), AbstractCodeEditorExtension.GenerateSourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	private static string GetClassName(object context)
	{
		return string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49403F7F), (string)q1JOxF5WnG1vO9yUEHT(context), (string)fgmk885jguZoPJMD56I(-106528299 ^ -106510177));
	}

	internal static CodeType oqv1nZ5tVaTRvJndOYx(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static object NlWo9p5bhtfi56tDyoR(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool rqg9N95yogU3RNaPc1w()
	{
		return vFuwLU50ynRnRqmvPu0 == null;
	}

	internal static ServerWorkflowCodeEditorExtension squqps5mVQljJObLv5F()
	{
		return vFuwLU50ynRnRqmvPu0;
	}

	internal static object xSHZVb55OibARjAhKBM(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool Rx2rO55g7mOOqWGt4DG(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid SUvUvu5BGRRng4hgoEk(object P_0)
	{
		return ((WorkflowInitWorkspaceRequest)P_0).ProcessUid;
	}

	internal static object qdjdSC5cgackMCNQsGM(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object Tgdw8g5Pl3rkajJsj5t(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static void xj6Z2S5X55yyFF6uB0S(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void ETAS1n5droNd07Plx38(object P_0, object P_1)
	{
		((InitWorkspaceRequest)P_0).Metadata = (NamedMetadata)P_1;
	}

	internal static void iDQPsN5uheo8BXgdQPX(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static object X4pw6p5DA9ENLS2t8Kf(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).MethodName;
	}

	internal static void TIgWFh5np8XSXaWwq9J(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).MethodName = (string)P_1;
	}

	internal static object BfHqIH5H6Kx7Qxx1yx6(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static void rM5rFk5Lj7IHNtXXS6I(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object oMVd9I5fhxGL90dNo3w(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static void S0uNOG59hUHLHwgyJSr(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ProjectName = (string)P_1;
	}

	internal static object q1JOxF5WnG1vO9yUEHT(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object fgmk885jguZoPJMD56I(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
