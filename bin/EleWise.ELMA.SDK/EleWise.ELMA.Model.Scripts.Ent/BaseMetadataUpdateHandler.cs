using System;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
public abstract class BaseMetadataUpdateHandler : IMetadataUpdateHandler
{
	private static BaseMetadataUpdateHandler njav2yb2v26hKdyoTQUh;

	public abstract bool Check(IMetadata metadata);

	public abstract void UpdateMetadata(IMetadataUpdateResult updateResult);

	public abstract void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid);

	public abstract void UpdateScriptModules(IMetadataUpdateResult updateResult);

	protected virtual string UpdateServerSourceCode(string sourceCode, string className)
	{
		//Discarded unreachable code: IL_00fa, IL_0296, IL_02a5
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		int num = 12;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		SyntaxToken val = default(SyntaxToken);
		SyntaxTokenList val3 = default(SyntaxTokenList);
		ClassDeclarationSyntax val2 = default(ClassDeclarationSyntax);
		SyntaxNode val4 = default(SyntaxNode);
		SyntaxTriviaList val6 = default(SyntaxTriviaList);
		SyntaxTrivia val7 = default(SyntaxTrivia);
		ClassDeclarationSyntax val5 = default(ClassDeclarationSyntax);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				SyntaxTriviaList leadingTrivia;
				switch (num2)
				{
				case 12:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 11;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass4_.className = className;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					goto end_IL_0012;
				case 1:
					leadingTrivia = ((SyntaxToken)(ref val)).get_LeadingTrivia();
					break;
				case 10:
					if (((SyntaxTokenList)(ref val3)).Any())
					{
						val3 = euhQf7b2S900FcGK9EGR(val2);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 13;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 13:
					val = ((SyntaxTokenList)(ref val3)).First();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 5;
					}
					continue;
				case 14:
					val2 = val4.DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().FirstOrDefault(_003C_003Ec__DisplayClass4_._003CUpdateServerSourceCode_003Eb__0);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 9;
					}
					continue;
				case 4:
				{
					ClassDeclarationSyntax obj = val2;
					val = CiaAjJb2qSQDe7Wwtr8I((SyntaxKind)8406);
					val = ((SyntaxToken)(ref val)).WithLeadingTrivia(val6);
					object obj2 = N5877fb2XMwueLmtFCs4(obj.WithModifiers(z9MeDQb2K1DUe5l8PCX0(((SyntaxToken)(ref val)).WithTrailingTrivia((SyntaxTrivia[])(object)new SyntaxTrivia[1] { val7 }))), null);
					val = l3m3HGb2T7AfAFU8Aq8U(val2);
					val5 = ((ClassDeclarationSyntax)obj2).WithIdentifier(((SyntaxToken)(ref val)).WithTrailingTrivia((SyntaxTrivia[])(object)new SyntaxTrivia[1] { sAbASNb2RK10y4Zmj1ka((SyntaxKind)8540, Environment.NewLine) }));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 3:
					val4 = (SyntaxNode)O80128b2VSKMwEEw5nsD(CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions)I7i2Odb2Ia9v5lVfMbJn(BGbPdCb2uO3D3GvDck67(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)), default(CancellationToken));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 14;
					}
					continue;
				default:
					val = OC5PBRb2iMc7BGcRIrxt(val2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return (string)N38G3qb2kt6wT11jjihP(SyntaxNodeExtensions.ReplaceNode<SyntaxNode>(val4, (SyntaxNode)(object)val2, (SyntaxNode)(object)val5));
				case 9:
					if (val2 != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				case 2:
					return sourceCode;
				case 7:
					val3 = euhQf7b2S900FcGK9EGR(val2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					leadingTrivia = ((SyntaxToken)(ref val)).get_LeadingTrivia();
					break;
				}
				val6 = leadingTrivia;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			val7 = sAbASNb2RK10y4Zmj1ka((SyntaxKind)8540, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB0F69));
			num = 4;
		}
	}

	protected virtual ViewItemTransformationChange CreateViewItemTransformationChange(Guid formUid)
	{
		ViewItemTransformationChange obj = new ViewItemTransformationChange
		{
			Uid = formUid
		};
		CM8R0yb2O9qpucu2MFDN(obj, dIk1GKb2nMfV0LIn9gBi(0xE1229CF ^ 0xE10F6B1));
		SHiD0hb22Uy4Xd5A8NgH(obj, RuntimeVersion.Version2);
		pD40Stb2Pqr6lRKUU6oA(obj, dnXNbLb2eCC3vDvu4y3B(typeof(FormViewItem).TypeHandle).AssemblyQualifiedName);
		return obj;
	}

	protected BaseMetadataUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BcqEldb21IHZ1xKF2RDU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BGbPdCb2uO3D3GvDck67()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object I7i2Odb2Ia9v5lVfMbJn(object P_0, LanguageVersion P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpParseOptions)P_0).WithLanguageVersion(P_1);
	}

	internal static object O80128b2VSKMwEEw5nsD(object P_0, CancellationToken P_1)
	{
		return ((SyntaxTree)P_0).GetRoot(P_1);
	}

	internal static SyntaxTokenList euhQf7b2S900FcGK9EGR(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((MemberDeclarationSyntax)P_0).get_Modifiers();
	}

	internal static SyntaxToken OC5PBRb2iMc7BGcRIrxt(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TypeDeclarationSyntax)P_0).get_Keyword();
	}

	internal static SyntaxTrivia sAbASNb2RK10y4Zmj1ka(SyntaxKind P_0, object P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.SyntaxTrivia(P_0, (string)P_1);
	}

	internal static SyntaxToken CiaAjJb2qSQDe7Wwtr8I(SyntaxKind P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.Token(P_0);
	}

	internal static SyntaxTokenList z9MeDQb2K1DUe5l8PCX0(SyntaxToken P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxTokenList.Create(P_0);
	}

	internal static object N5877fb2XMwueLmtFCs4(object P_0, object P_1)
	{
		return ((ClassDeclarationSyntax)P_0).WithBaseList((BaseListSyntax)P_1);
	}

	internal static SyntaxToken l3m3HGb2T7AfAFU8Aq8U(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BaseTypeDeclarationSyntax)P_0).get_Identifier();
	}

	internal static object N38G3qb2kt6wT11jjihP(object P_0)
	{
		return ((SyntaxNode)P_0).ToFullString();
	}

	internal static bool CPkBdjb282y0IZD0meB7()
	{
		return njav2yb2v26hKdyoTQUh == null;
	}

	internal static BaseMetadataUpdateHandler QGeGxRb2ZgjwyWOKsFqP()
	{
		return njav2yb2v26hKdyoTQUh;
	}

	internal static object dIk1GKb2nMfV0LIn9gBi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void CM8R0yb2O9qpucu2MFDN(object P_0, object P_1)
	{
		((ViewItemTransformationChange)P_0).PropertyName = (string)P_1;
	}

	internal static void SHiD0hb22Uy4Xd5A8NgH(object P_0, object P_1)
	{
		((ViewItemTransformationChange)P_0).Value = P_1;
	}

	internal static Type dnXNbLb2eCC3vDvu4y3B(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void pD40Stb2Pqr6lRKUU6oA(object P_0, object P_1)
	{
		((ViewItemTransformationChange)P_0).TypeName = (string)P_1;
	}

	internal static void BcqEldb21IHZ1xKF2RDU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
