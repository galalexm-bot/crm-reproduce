using System;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.OmniSharp;

[Component(Order = -50)]
internal sealed class ServerCustomActivityCodeEditorExtension : AbstractCodeEditorExtension
{
	internal static ServerCustomActivityCodeEditorExtension DhjvMDwmLIni6ywNbc1;

	protected override CodeType CodeType => CodeType.Server;

	public override bool Check(InitWorkspaceRequest request)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (request != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				if (Yy9ZMiwGAOI6A75U2Kq(request) == xsm9IxwnZGIUryUbE0k(this))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return Eg2VYRwyYdysK65vlUd(request) is CustomActivityParameters;
			}
			break;
		}
		return false;
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0287, IL_02e8, IL_0328, IL_0337, IL_0343, IL_03ab, IL_03e4
		int num = 3;
		List<IScriptSource> list = default(List<IScriptSource>);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		ScriptModule scriptModule = default(ScriptModule);
		IScriptData result = default(IScriptData);
		string text = default(string);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
		int num5 = default(int);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		List<IMetadata> metadataList = default(List<IMetadata>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 10:
					list = new List<IScriptSource>();
					num2 = 5;
					continue;
				case 5:
					list.Add(new ScriptSource((string)kZBOdAwON9GUKoV2FMb(customActivityParameters), (string)cbougBw6TBwkTmF20Kj(scriptModule), ScriptSourceType.Edit));
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					return result;
				case 3:
					if (request != null)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 4:
					try
					{
						CustomActivityParamsGenerator customActivityParamsGenerator = new CustomActivityParamsGenerator();
						LFOgbjwBDdALixXfhS9(MXbfj9w0pAWULZY2qEs(customActivityParamsGenerator), GenerationMode.CodeEditor);
						((ICodeGenerator)customActivityParamsGenerator).Metadata = customActivityParameters;
						GeneratedFileInfo[] array = (GeneratedFileInfo[])vTX9XswWHiaBY6Io91G(customActivityParamsGenerator);
						int num3 = 10;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 3:
								return result;
							case 8:
								text = (string)rlbCFWwlNZpca7kip6k(text, 0, BS967pwi8STQqVht3E1(text) - cUvOA5wuEkMAf65IMRg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66914DC5 ^ 0x669171B5)));
								num4 = 6;
								continue;
							case 13:
								result = new ScriptData(list, assemblies);
								num4 = 3;
								continue;
							case 5:
								if (JcGi1GwHGAo15aRvoKP(generatedFileInfo) == GeneratedFileType.CS)
								{
									num4 = 12;
									continue;
								}
								break;
							case 12:
								text = generatedFileInfo.Extension;
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
								{
									num4 = 14;
								}
								continue;
							case 14:
								if (text.EndsWith((string)SrhgmEwe7wM6ohmh0DC(-1643416224 ^ -1643427568)))
								{
									num4 = 8;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
									{
										num4 = 6;
									}
									continue;
								}
								goto case 6;
							case 4:
							case 9:
								if (num5 >= array.Length)
								{
									num4 = 7;
									continue;
								}
								goto case 11;
							case 11:
								generatedFileInfo = array[num5];
								num4 = 5;
								continue;
							case 1:
								list.Add(GenerateProjectFile(projectHelper, list, assemblies));
								num4 = 13;
								continue;
							default:
								projectHelper = new WorkspaceProjectHelper(scriptModule);
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
								{
									num4 = 1;
								}
								continue;
							case 6:
								list.Add(new ScriptSource((string)DPsnMmwLh4Ar2o10UW6(uYGrUTwf6ihabcLaCZh(customActivityParameters), text), (string)eb9DgNwJBFnaaKZ3Nd4(Encoding.UTF8, generatedFileInfo.Data), ScriptSourceType.Additional));
								num4 = 2;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
								{
									num4 = 1;
								}
								continue;
							case 10:
								num5 = 0;
								num4 = 9;
								continue;
							case 7:
								assemblies = GetAssemblies(scriptModule);
								num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								break;
							}
							num5++;
							num4 = 4;
						}
					}
					finally
					{
						int num6;
						if (metadataServiceContext == null)
						{
							num6 = 2;
							goto IL_02ec;
						}
						goto IL_0302;
						IL_02ec:
						switch (num6)
						{
						default:
							goto end_IL_02d7;
						case 1:
							break;
						case 2:
							goto end_IL_02d7;
						case 0:
							goto end_IL_02d7;
						}
						goto IL_0302;
						IL_0302:
						a35rsgwr8TflLsh4vsr(metadataServiceContext);
						num6 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 != 0)
						{
							num6 = 0;
						}
						goto IL_02ec;
						end_IL_02d7:;
					}
				case 1:
					metadataServiceContext = new MetadataServiceContext(new ExtendedMetadataService((IMetadataService)k1Oi8GwRQLrerocUIZZ(this), metadataList));
					num2 = 4;
					continue;
				case 6:
					if (customActivityParameters == null)
					{
						num2 = 7;
						continue;
					}
					goto end_IL_0012;
				case 9:
					list.AddRange(GenerateWebReferencesSources(scriptModule));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					obj = null;
					break;
				case 7:
					return null;
				default:
					metadataList = new List<IMetadata> { customActivityParameters };
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					obj = request.Metadata;
					break;
				}
				customActivityParameters = obj as CustomActivityParameters;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, CustomActivityScriptModuleType.UID);
			num = 10;
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_009e, IL_0123, IL_0132
		int num = 2;
		CustomActivityParameters customActivityParameters2 = default(CustomActivityParameters);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		WorkspaceProjectHelper workspaceProjectHelper = default(WorkspaceProjectHelper);
		ScriptModule scriptModule = default(ScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 10:
					customActivityParameters2.Properties.AddRange((IEnumerable<PropertyMetadata>)customActivityParameters.EntityProperties);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					if (customActivityParameters != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 9:
					XudqDrw5uCay872hNjF(request, customActivityParameters2);
					num2 = 5;
					continue;
				case 1:
					obj = null;
					break;
				case 5:
					workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
					num2 = 3;
					continue;
				case 7:
					goto end_IL_0012;
				case 3:
				{
					CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
					yeCOxDwgxGSrOqpl1x9(codeEditorInitData, kZBOdAwON9GUKoV2FMb(customActivityParameters));
					Ab2cATw1TI14XiHOgiB(codeEditorInitData, GetClassName(customActivityParameters));
					codeEditorInitData.MethodName = (string)iaNSPrwIJHnHapBq7R0(request);
					QqYB80wZ6Bw4lFkiLyC(codeEditorInitData, cbougBw6TBwkTmF20Kj(scriptModule));
					codeEditorInitData.ProjectName = (string)KfYj9bwzUbuw8H7ZT2j(workspaceProjectHelper);
					return codeEditorInitData;
				}
				case 6:
					customActivityParameters2 = ClassSerializationHelper.CloneObjectByXml(customActivityParameters);
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					return null;
				case 4:
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, CustomActivityScriptModuleType.UID);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					if (request == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = m9TaeLw7gOseemc3eBy(request);
					break;
				}
				customActivityParameters = obj as CustomActivityParameters;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			customActivityParameters2.TableParts.AddRange((IEnumerable<TablePartMetadata>)customActivityParameters.EntityTableParts);
			num = 9;
		}
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<AbstractCodeEditorExtension>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882646278 ^ -882647424), (string s) => (string)_003C_003Ec__DisplayClass5_0.TRNHmhG5DoTC8jkZoJX(((string)_003C_003Ec__DisplayClass5_0.TRNHmhG5DoTC8jkZoJX(_003C_003Ec__DisplayClass5_0.TRNHmhG5DoTC8jkZoJX(s, _003C_003Ec__DisplayClass5_0.wNvGVpGrqyI2DDONO3n(0x19163E7B ^ 0x19169C37), _003C_003Ec__DisplayClass5_0.G9UvHVG76HR89Kw7VyH(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass5_0.wNvGVpGrqyI2DDONO3n(-882678999 ^ -882654907), _003C_003Ec__DisplayClass5_0.K02wjiGgkfTmjgsojCi(CS_0024_003C_003E8__locals0.projectHelper))).Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C9503E1 ^ 0x2C95A16F), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references)), _003C_003Ec__DisplayClass5_0.wNvGVpGrqyI2DDONO3n(0x713816B4 ^ 0x7138B41E), AbstractCodeEditorExtension.GenerateSourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	private static string GetScripsFileName(object metadata)
	{
		return (string)USp5jWtEGGVOKPePGyL(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x467974A9 ^ 0x46796895), new string[2]
		{
			((NamedMetadata)metadata).Name,
			(string)SrhgmEwe7wM6ohmh0DC(-193507406 ^ -193498344)
		});
	}

	private static string GetClassName(object metadata)
	{
		return (string)DPsnMmwLh4Ar2o10UW6(uYGrUTwf6ihabcLaCZh(metadata), SrhgmEwe7wM6ohmh0DC(-1952076060 ^ -1952083378));
	}

	public ServerCustomActivityCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static CodeType Yy9ZMiwGAOI6A75U2Kq(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).CodeType;
	}

	internal static CodeType xsm9IxwnZGIUryUbE0k(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static object Eg2VYRwyYdysK65vlUd(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool qZUqXGwAiR90mEEabNK()
	{
		return DhjvMDwmLIni6ywNbc1 == null;
	}

	internal static ServerCustomActivityCodeEditorExtension k7apBwwpAuW82ajKAm6()
	{
		return DhjvMDwmLIni6ywNbc1;
	}

	internal static object kZBOdAwON9GUKoV2FMb(object P_0)
	{
		return GetScripsFileName(P_0);
	}

	internal static object cbougBw6TBwkTmF20Kj(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static object k1Oi8GwRQLrerocUIZZ(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).MetadataRuntimeService;
	}

	internal static object MXbfj9w0pAWULZY2qEs(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerationParams;
	}

	internal static void LFOgbjwBDdALixXfhS9(object P_0, GenerationMode P_1)
	{
		((GenerationParams)P_0).Mode = P_1;
	}

	internal static object vTX9XswWHiaBY6Io91G(object P_0)
	{
		return ((ICodeGenerator)P_0).Generate();
	}

	internal static GeneratedFileType JcGi1GwHGAo15aRvoKP(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Type;
	}

	internal static object SrhgmEwe7wM6ohmh0DC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int BS967pwi8STQqVht3E1(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int cUvOA5wuEkMAf65IMRg(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object rlbCFWwlNZpca7kip6k(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object uYGrUTwf6ihabcLaCZh(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object DPsnMmwLh4Ar2o10UW6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object eb9DgNwJBFnaaKZ3Nd4(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void a35rsgwr8TflLsh4vsr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object m9TaeLw7gOseemc3eBy(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static void XudqDrw5uCay872hNjF(object P_0, object P_1)
	{
		((InitWorkspaceRequest)P_0).Metadata = (NamedMetadata)P_1;
	}

	internal static void yeCOxDwgxGSrOqpl1x9(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static void Ab2cATw1TI14XiHOgiB(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ClassName = (string)P_1;
	}

	internal static object iaNSPrwIJHnHapBq7R0(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).MethodName;
	}

	internal static void QqYB80wZ6Bw4lFkiLyC(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object KfYj9bwzUbuw8H7ZT2j(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static object USp5jWtEGGVOKPePGyL(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}
}
