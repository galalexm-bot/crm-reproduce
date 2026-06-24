using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp;

[Component]
internal abstract class AbstractComponentCodeEditorExtension : AbstractCodeEditorExtension
{
	private static AbstractComponentCodeEditorExtension fxFwrdW9mrlc6D0Iygbo;

	public IComponentMetadataSourcesService ComponentMetadataSourcesService
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentMetadataSourcesService_003Ek__BackingField;
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
					_003CComponentMetadataSourcesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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

	protected abstract Guid ModuleTypeUid { get; }

	public override bool Check(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_008d, IL_009c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return b4GjOjW9dCdhx5wePBlb(request) is ComponentMetadata;
			case 1:
				return false;
			case 2:
				if (request == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (sYmRroW9JZyGcXgKNtPS(request) == MZBw4BW993tYde04dirr(this))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public override int GetMethodPosition(string sourceCode, string className, string methodName)
	{
		//Discarded unreachable code: IL_0055, IL_00bb, IL_00ca, IL_0101, IL_0110
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		int num = 10;
		ClassDeclarationSyntax val = default(ClassDeclarationSyntax);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					if (val != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 1:
					return 0;
				case 7:
				{
					MethodDeclarationSyntax obj3 = ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<MethodDeclarationSyntax>().FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetMethodPosition_003Eb__2);
					if (obj3 == null)
					{
						num2 = 4;
						continue;
					}
					return KN6rrlW9jM01LX3PBPpM(yv0wLmW95OttrPhpUIPs(obj3));
				}
				case 12:
					if (!zxUU15W9laIgcUrhunqg(sourceCode))
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 3:
					_003C_003Ec__DisplayClass5_.methodName = methodName;
					num2 = 5;
					continue;
				case 5:
					if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass5_.methodName))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 12;
				case 10:
					break;
				case 9:
					_003C_003Ec__DisplayClass5_.className = className;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return 0;
				case 6:
				{
					ClassDeclarationSyntax obj2 = CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions)dxyaloW9g2sKjIukjjEt(GVaA2DW9rgcbwqRE2G5J(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false)
						.OfType<ClassDeclarationSyntax>()
						.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetMethodPosition_003Eb__0);
					if (obj2 == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					obj = ((IEnumerable)(object)((TypeDeclarationSyntax)obj2).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
					{
						//IL_0025: Unknown result type (might be due to invalid IL or missing references)
						//IL_002a: Unknown result type (might be due to invalid IL or missing references)
						int num3 = 1;
						int num4 = num3;
						SyntaxToken val2 = default(SyntaxToken);
						while (true)
						{
							switch (num4)
							{
							case 1:
								val2 = _003C_003Ec.qVE5m7QU4B7GsqNL6f6V(q);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return _003C_003Ec.QXkkmVQU6hBUu85e82a2(((object)(SyntaxToken)(ref val2)).ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289775736));
							}
						}
					});
					goto IL_0235;
				}
				case 8:
					obj = null;
					goto IL_0235;
				case 4:
					{
						return 0;
					}
					IL_0235:
					val = (ClassDeclarationSyntax)obj;
					num2 = 2;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			num = 9;
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		//Discarded unreachable code: IL_0091
		int num = 5;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		ScriptModule scriptModule = default(ScriptModule);
		WorkspaceProjectHelper workspaceProjectHelper = default(WorkspaceProjectHelper);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
			{
				CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
				BnShrqW9LJF2qaQRF0fW(codeEditorInitData, GetFileName(componentMetadata));
				codeEditorInitData.ClassName = componentMetadata.Name;
				codeEditorInitData.MethodName = (string)siPFLRW9UDeK7D5RvOqv(request);
				xvGJCiW9ckWPtI2s9Vuk(codeEditorInitData, aiHJMtW9svOkoAcS7NYj(scriptModule));
				VbjFBNWdFJhWe1bmg3bf(codeEditorInitData, CaVYFoW9zkSeXMv9Rk82(workspaceProjectHelper));
				return codeEditorInitData;
			}
			case 5:
				if (request == null)
				{
					num2 = 4;
					continue;
				}
				obj = request.Metadata;
				break;
			case 4:
				obj = null;
				break;
			case 3:
				workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
				num2 = 2;
				continue;
			case 1:
				return null;
			default:
				if (componentMetadata != null)
				{
					scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, yJpL1QW9YkkdJ0HVlyec(this));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
				}
				continue;
			}
			componentMetadata = obj as ComponentMetadata;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
			{
				num2 = 0;
			}
		}
	}

	protected IEnumerable<IMetadata> GetExtendMetadata(ComponentMetadata metadata)
	{
		return base.SearchMetadataService.GetPublishedDataClasses().Concat(metadata.GetMetadataToRegister());
	}

	private string GetFileName(ComponentMetadata metadata)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		CodeType codeType = default(CodeType);
		while (true)
		{
			switch (num2)
			{
			default:
				switch (codeType)
				{
				case CodeType.Client:
					goto IL_0074;
				case CodeType.Server:
					return ComponentMetadataSourcesService.ServerControllerName(metadata);
				case CodeType.Test:
					return (string)BPslRHWdBbMiCQvjcxrK(ComponentMetadataSourcesService, metadata);
				case CodeType.View:
					return (string)kFFLCUWdWh5qTDcDmdLs(ComponentMetadataSourcesService, metadata);
				case CodeType.GlobalFunction:
					goto IL_00a8;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				goto IL_0074;
			case 2:
				goto IL_00a8;
			case 1:
				{
					codeType = MZBw4BW993tYde04dirr(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0074:
				return ComponentMetadataSourcesService.ClientControllerName(metadata);
				IL_00a8:
				return string.Empty;
			}
		}
	}

	protected AbstractComponentCodeEditorExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uLCnOJWdoQHtPLSccvn5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VHBCa3W9yALRYRVDTi12()
	{
		return fxFwrdW9mrlc6D0Iygbo == null;
	}

	internal static AbstractComponentCodeEditorExtension uk96CtW9MenHVw7xnv3Y()
	{
		return fxFwrdW9mrlc6D0Iygbo;
	}

	internal static CodeType sYmRroW9JZyGcXgKNtPS(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).CodeType;
	}

	internal static CodeType MZBw4BW993tYde04dirr(object P_0)
	{
		return ((AbstractCodeEditorExtension)P_0).CodeType;
	}

	internal static object b4GjOjW9dCdhx5wePBlb(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).Metadata;
	}

	internal static bool zxUU15W9laIgcUrhunqg(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object GVaA2DW9rgcbwqRE2G5J()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object dxyaloW9g2sKjIukjjEt(object P_0, LanguageVersion P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpParseOptions)P_0).WithLanguageVersion(P_1);
	}

	internal static object yv0wLmW95OttrPhpUIPs(object P_0)
	{
		return ((BaseMethodDeclarationSyntax)P_0).get_Body();
	}

	internal static int KN6rrlW9jM01LX3PBPpM(object P_0)
	{
		return ((SyntaxNode)P_0).get_SpanStart();
	}

	internal static Guid yJpL1QW9YkkdJ0HVlyec(object P_0)
	{
		return ((AbstractComponentCodeEditorExtension)P_0).ModuleTypeUid;
	}

	internal static void BnShrqW9LJF2qaQRF0fW(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).FileName = (string)P_1;
	}

	internal static object siPFLRW9UDeK7D5RvOqv(object P_0)
	{
		return ((InitWorkspaceRequest)P_0).MethodName;
	}

	internal static object aiHJMtW9svOkoAcS7NYj(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static void xvGJCiW9ckWPtI2s9Vuk(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).SourceCode = (string)P_1;
	}

	internal static object CaVYFoW9zkSeXMv9Rk82(object P_0)
	{
		return ((WorkspaceProjectHelper)P_0).CsprojFileName;
	}

	internal static void VbjFBNWdFJhWe1bmg3bf(object P_0, object P_1)
	{
		((CodeEditorInitData)P_0).ProjectName = (string)P_1;
	}

	internal static object BPslRHWdBbMiCQvjcxrK(object P_0, object P_1)
	{
		return ((IComponentMetadataSourcesService)P_0).TestControllerName((ComponentMetadata)P_1);
	}

	internal static object kFFLCUWdWh5qTDcDmdLs(object P_0, object P_1)
	{
		return ((IComponentMetadataSourcesService)P_0).ViewControllerName((ComponentMetadata)P_1);
	}

	internal static void uLCnOJWdoQHtPLSccvn5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
