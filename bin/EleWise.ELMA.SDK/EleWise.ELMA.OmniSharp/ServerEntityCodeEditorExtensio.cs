using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

[Component]
internal sealed class ServerEntityCodeEditorExtension : AbstractCodeEditorExtension
{
	private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfo;

	private readonly IMetadataSourceCodeCache metadataSourceCodeCache;

	private readonly IMetadataEditorService metadataEditorService;

	private IList<string> additionalElmaReferences;

	private static ServerEntityCodeEditorExtension OhoTEDWd2aC2TgnWmKB3;

	protected override CodeType CodeType => CodeType.Server;

	protected override IEnumerable<string> AdditionalElmaReferences => additionalElmaReferences;

	public ServerEntityCodeEditorExtension(IMetadataSourceCodeCache metadataSourceCodeCache, IMetadataEditorService metadataEditorService, IEnumerable<IMetadataTypeInfo> metadataTypeInfo)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		additionalElmaReferences = new List<string>();
		this.metadataSourceCodeCache = metadataSourceCodeCache;
		this.metadataEditorService = metadataEditorService;
		this.metadataTypeInfo = metadataTypeInfo;
	}

	public override bool Check(InitWorkspaceRequest request)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (request != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0057;
			case 2:
				return CGPsKHWd3btCrYE9hH2Q(request) is EntityMetadata;
			default:
				{
					if (nyEx7OWd1PYwh1OJiliV(request) == zgroKYWdNmcGyXuqd4by(this))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_0057;
				}
				IL_0057:
				return false;
			}
		}
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0068, IL_0088, IL_0097, IL_00f7, IL_0123, IL_0228, IL_0260, IL_026f
		int num = 6;
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		EntityMetadata entityMetadata = default(EntityMetadata);
		ScriptModule scriptModule = default(ScriptModule);
		WorkspaceProjectHelper projectHelper = default(WorkspaceProjectHelper);
		IList<IScriptReference> assemblies = default(IList<IScriptReference>);
		IScriptData result = default(IScriptData);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					metadataServiceContext = new MetadataServiceContext(new ExtendedMetadataService(metadataEditorService, entityMetadata.ToEnumerable()));
					num2 = 3;
					continue;
				case 7:
					if (entityMetadata != null)
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 2:
					return null;
				case 8:
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, EntityScriptModuleType.UID);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					if (request != null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 4:
					obj = null;
					break;
				case 3:
					try
					{
						IList<IScriptSource> list = GenerateSources(entityMetadata, scriptModule);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								list.AddRange(GenerateWebReferencesSources(scriptModule));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 1;
								}
								break;
							case 4:
								list.Add(GenerateProjectFile(projectHelper, list, assemblies));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 2;
								}
								break;
							case 1:
								AddAdditionalElmaReferences(entityMetadata);
								num3 = 3;
								break;
							case 2:
								result = new ScriptData(list, assemblies);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num3 = 6;
								}
								break;
							case 5:
								projectHelper = new WorkspaceProjectHelper(scriptModule);
								num3 = 4;
								break;
							case 3:
								assemblies = GetAssemblies(scriptModule);
								num3 = 5;
								break;
							case 6:
								return result;
							}
						}
					}
					finally
					{
						if (metadataServiceContext != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									HrpN47WdpQrrC89WdljE(metadataServiceContext);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				default:
					return result;
				case 5:
					obj = request.Metadata;
					break;
				}
				entityMetadata = obj as EntityMetadata;
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0065
		int num = 5;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		ScriptModule scriptModule = default(ScriptModule);
		WorkspaceProjectHelper workspaceProjectHelper = default(WorkspaceProjectHelper);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				return null;
			case 4:
				obj = null;
				break;
			case 5:
				if (request == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				obj = request.Metadata;
				break;
			case 1:
			{
				CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
				CwINdxWdD1BSaKbmM0VU(codeEditorInitData, c9xKV6WdaMUrpbHxX6qf(entityMetadata));
				CBD3CPWdt84ZwHiCvRyZ(codeEditorInitData, GetClassName(entityMetadata));
				JWZDy3Wd4V7k2AptaY3E(codeEditorInitData, oUDfwsWdwjPYG54l7xoE(request));
				qRfmgPWdHsdsNhiMSnBo(codeEditorInitData, kAjOS1Wd68r4eKEdyhKN(scriptModule));
				hCHBCRWd7994Zh0dvACN(codeEditorInitData, IVEKb6WdAby8ia3gZdsU(workspaceProjectHelper));
				return codeEditorInitData;
			}
			case 2:
				workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (entityMetadata != null)
				{
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, EntityScriptModuleType.UID);
					num2 = 2;
					continue;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 3;
				}
				continue;
			}
			entityMetadata = obj as EntityMetadata;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num2 = 0;
			}
		}
	}

	protected override List<IScriptReference> GetDynamicAssemblies()
	{
		return new List<IScriptReference>();
	}

	private IList<IScriptSource> GenerateSources(ClassMetadata metadata, ScriptModule scriptModule)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		metadata = metadata.CastAsRealType();
		CS_0024_003C_003E8__locals0.metadataType = metadata.GetType();
		IMetadataTypeInfo metadataTypeInfo = this.metadataTypeInfo.FirstOrDefault((IMetadataTypeInfo m) => _003C_003Ec__DisplayClass13_0.rWjkdXQUULpqOGpIKcsI(m) == CS_0024_003C_003E8__locals0.metadataType);
		if (metadataTypeInfo == null)
		{
			throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475908853), CS_0024_003C_003E8__locals0.metadataType));
		}
		ICodeGenerator codeGenerator = (ICodeGenerator)Activator.CreateInstance(metadataTypeInfo.GeneratorType);
		codeGenerator.Metadata = metadata;
		codeGenerator.GenerationParams.FileName = metadata.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61ECC6E8);
		codeGenerator.GenerationParams.Namespace = metadata.Namespace;
		ICodeGenerator codeGenerator2 = new EntityScriptGenerator(base.MetadataRuntimeService);
		codeGenerator2.Metadata = metadata;
		string @string = Encoding.UTF8.GetString(codeGenerator2.GenerateMainFile().Data);
		List<IScriptSource> list = new List<IScriptSource>();
		list.Add(new ScriptSource(GetScripsFileName(metadata), scriptModule.SourceCode, ScriptSourceType.Edit));
		list.Add(new ScriptSource(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E450E), metadata.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F3008EE)), @string, ScriptSourceType.Additional));
		List<IScriptSource> list2 = list;
		GeneratedFileInfo[] array = codeGenerator.Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				string text = generatedFileInfo.Extension;
				if (text.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477203308)))
				{
					text = text.Substring(0, text.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269F4684).Length);
				}
				list2.Add(new ScriptSource(metadata.Name + text, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list2;
	}

	private void AddAdditionalElmaReferences(ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_0144, IL_0153, IL_0180
		int num = 1;
		int num2 = num;
		Type typeByUidOrNull = default(Type);
		EntityMetadata entityMetadata = default(EntityMetadata);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return;
			case 9:
				if (W1ehleWdyjl89MImFItK(typeByUidOrNull.Assembly) == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 1:
				entityMetadata = (EntityMetadata)T3pvNQWdxI2oG7JgcktK((EntityMetadata)metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 7:
				return;
			case 12:
				return;
			case 10:
				if (FDsUdkWdJj7kK9YT5hfA(text))
				{
					return;
				}
				num2 = 6;
				break;
			case 8:
				typeByUidOrNull = base.MetadataRuntimeService.GetTypeByUidOrNull(P4FP8MWd0hnJX9RktwOl(entityMetadata), loadImplementation: false);
				num2 = 4;
				break;
			case 4:
				if (!gatdU7WdmwBtwSD8p0aW(typeByUidOrNull, null))
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 2;
			default:
				if (entityMetadata == null)
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 8;
				}
				break;
			case 5:
				text = (string)B1a9oxWdMm6Fk5Cyn0F4(W1ehleWdyjl89MImFItK(typeByUidOrNull.Assembly));
				num2 = 10;
				break;
			case 6:
				additionalElmaReferences.Add(text);
				num2 = 3;
				break;
			case 2:
				if (!(typeByUidOrNull.Assembly != null))
				{
					num2 = 12;
					break;
				}
				goto case 9;
			}
		}
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.projectHelper = projectHelper;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.references = references;
		CS_0024_003C_003E8__locals0.sources = sources;
		string content = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313053F6), (string s) => (string)_003C_003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw(((string)_003C_003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw(_003C_003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw(s, _003C_003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(0x10E41EDB ^ 0x10E19365), _003C_003Ec__DisplayClass15_0.W4lH3PQsBIbPmU99Sgn1(CS_0024_003C_003E8__locals0.projectHelper)), _003C_003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(-541731959 ^ -542089641), _003C_003Ec__DisplayClass15_0.v6WrulQsocqBdCUdnul6(CS_0024_003C_003E8__locals0.projectHelper))).Replace((string)_003C_003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(0x4785BC0D ^ 0x4780320D), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateReferencesSection(CS_0024_003C_003E8__locals0.references)), _003C_003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(-195614443 ^ -195909879), CS_0024_003C_003E8__locals0._003C_003E4__this.GenerateEntitySourcesSection(CS_0024_003C_003E8__locals0.sources)));
		return CS_0024_003C_003E8__locals0.projectHelper.CreateCsprojSource(content);
	}

	private string GenerateEntitySourcesSection(IEnumerable<IScriptSource> sources)
	{
		List<IScriptSource> sources2 = sources.ToList();
		string text = AbstractCodeEditorExtension.GenerateSourcesSection(sources2);
		string text2 = GenerateCacheSourceSection(sources2);
		return string.Join(Environment.NewLine, text, text2);
	}

	private string GenerateCacheSourceSection(List<IScriptSource> sources)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		metadataSourceCodeCache.UpdateDiskCache();
		CS_0024_003C_003E8__locals0.cacheFolder = metadataSourceCodeCache.GetFolderPath(CodeType);
		string[] files = Directory.GetFiles(CS_0024_003C_003E8__locals0.cacheFolder);
		if (files.Length == 0)
		{
			return string.Empty;
		}
		List<string> list = sources.Select((IScriptSource source) => (string)_003C_003Ec__DisplayClass17_0.PI9A57QsQ8n9sYKRFGNf(CS_0024_003C_003E8__locals0.cacheFolder, _003C_003Ec__DisplayClass17_0.d4ta32QsffZaJ7mPp3am(_003C_003Ec__DisplayClass17_0.W8jpu6QsEhS5moyaueCR(source), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281905674)))).ToList();
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = files;
		foreach (string text in array)
		{
			if (!list.Contains(text))
			{
				stringBuilder.Append(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5B1961), text));
				stringBuilder.AppendLine();
			}
		}
		return stringBuilder.ToString();
	}

	private static string GetScripsFileName(object metadata)
	{
		return (string)I86JtvWdl7506t0fZt7e(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E40CF), new string[2]
		{
			(string)mSskAfWd9y5Hh6Lfm1pD(metadata),
			(string)goaPksWddmIvYegXdqM2(-672123589 ^ -672045531)
		});
	}

	private static string GetClassName(object metadata)
	{
		return (string)D9SWygWdrZVf1ysW34oZ(((NamedMetadata)metadata).Name, goaPksWddmIvYegXdqM2(-210725949 ^ -210648867));
	}

	internal static CodeType nyEx7OWd1PYwh1OJiliV(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).CodeType;
	}

	internal static CodeType zgroKYWdNmcGyXuqd4by(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static object CGPsKHWd3btCrYE9hH2Q(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool lNmCdVWdeJ9UQ0CtxdVC()
	{
		return OhoTEDWd2aC2TgnWmKB3 == null;
	}

	internal static ServerEntityCodeEditorExtension Gti5mlWdP94RCOyWbPbH()
	{
		return OhoTEDWd2aC2TgnWmKB3;
	}

	internal static void HrpN47WdpQrrC89WdljE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object c9xKV6WdaMUrpbHxX6qf(object P_0)
	{
		return GetScripsFileName(P_0);
	}

	internal static void CwINdxWdD1BSaKbmM0VU(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static void CBD3CPWdt84ZwHiCvRyZ(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ClassName = (string)P_1;
	}

	internal static object oUDfwsWdwjPYG54l7xoE(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).MethodName;
	}

	internal static void JWZDy3Wd4V7k2AptaY3E(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).MethodName = (string)P_1;
	}

	internal static object kAjOS1Wd68r4eKEdyhKN(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static void qRfmgPWdHsdsNhiMSnBo(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object IVEKb6WdAby8ia3gZdsU(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static void hCHBCRWd7994Zh0dvACN(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ProjectName = (string)P_1;
	}

	internal static object T3pvNQWdxI2oG7JgcktK(object P_0)
	{
		return ((EntityMetadata)P_0).GetBaseMetadata();
	}

	internal static Guid P4FP8MWd0hnJX9RktwOl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool gatdU7WdmwBtwSD8p0aW(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object W1ehleWdyjl89MImFItK(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object B1a9oxWdMm6Fk5Cyn0F4(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static bool FDsUdkWdJj7kK9YT5hfA(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object mSskAfWd9y5Hh6Lfm1pD(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object goaPksWddmIvYegXdqM2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object I86JtvWdl7506t0fZt7e(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object D9SWygWdrZVf1ysW34oZ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
