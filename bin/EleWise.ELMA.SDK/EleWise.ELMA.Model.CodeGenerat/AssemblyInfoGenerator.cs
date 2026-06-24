using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class AssemblyInfoGenerator : CodeGenerator
{
	protected AssemblyInfoMetadata metadata;

	private static AssemblyInfoGenerator BDCqpihDFE45qwXosX32;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Ammy9yhDhUQ9TtvDhNLG(metadata is AssemblyInfoMetadata, tcApnuhDbKXJYSnJhxjx(0x1C9495B4 ^ 0x1C97FA08));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				this.metadata = (AssemblyInfoMetadata)metadata;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				lSnWnlhDohhk2fboPP7P(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217505273));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_009b, IL_00ce, IL_0111, IL_0120
		int num = 2;
		int num2 = num;
		GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return generatedFileInfo;
			case 2:
				PG4NXQhDGA8aiq8MmItc(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABEDD6));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					generatedFileInfo = GenerateMainFileHelper(AssemblyAttributes().Concat(MemberDeclarations()), withPragmaWarningDisable: true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => generatedFileInfo, 
						_ => generatedFileInfo, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T((string)tcApnuhDbKXJYSnJhxjx(-35995181 ^ -36066643), khZWrGhDEfimW8mclHqH(metadata)), innerException);
					}
				}
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateAdditionalFilesInternal_003Ed__2))]
	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateAdditionalFilesInternal_003Ed__2(-2);
	}

	[IteratorStateMachine(typeof(_003CAssemblyAttributes_003Ed__4))]
	protected virtual IEnumerable<ISyntaxNode> AssemblyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CAssemblyAttributes_003Ed__4(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected ISyntaxNode AssemblyAttribute<T>(params object[] ctorParameters)
	{
		ISyntaxNode syntaxNode = TypeOf<T>.Raw.CreateAttribute(ctorParameters);
		syntaxNode.Unpack<AttributeSyntax>().AssemblySpecifier = true;
		return syntaxNode;
	}

	[IteratorStateMachine(typeof(_003CMemberDeclarations_003Ed__6))]
	protected virtual IEnumerable<ISyntaxNode> MemberDeclarations()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CMemberDeclarations_003Ed__6(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode GenerateStubClass()
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				SR.RunWithFutureTranslate((Func<ISyntaxNode>)_003C_003Ec__DisplayClass7_._003CGenerateStubClass_003Eb__0, escapeQuote: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass7_.type = ((string)tcApnuhDbKXJYSnJhxjx(-1146510045 ^ -1146432221)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.None, null, null, UidStaticMembers());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (!LXow3JhDfdRS2PkPVe0w(metadata.Summary))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 4:
				_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
				num2 = 2;
				break;
			case 5:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return _003C_003Ec__DisplayClass7_.type;
			default:
				WriteBasicAttributes(_003C_003Ec__DisplayClass7_.type);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__8))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__8(-2);
	}

	protected ISyntaxNode ResourceClassProperty(string propertyName, string propertyValue)
	{
		return propertyName.PropertyDeclaration((ISyntaxNode)hbEfOYhDQDIkn2lvEsyS(TypeOf<string>.Raw), Accessibility.Public, DeclarationModifiers.Static, new ISyntaxNode[1] { (ISyntaxNode)hAPi6fhDC71cZdLpHVL5(GetLocalizableExpression(propertyValue)) });
	}

	public AssemblyInfoGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qiGSm4hDvu3yF1mxEcZp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void lSnWnlhDohhk2fboPP7P(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object tcApnuhDbKXJYSnJhxjx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Ammy9yhDhUQ9TtvDhNLG(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool dGX1TohDBu6Cxf65p4ve()
	{
		return BDCqpihDFE45qwXosX32 == null;
	}

	internal static AssemblyInfoGenerator AdhnHThDWq8Ymuwv9Txu()
	{
		return BDCqpihDFE45qwXosX32;
	}

	internal static void PG4NXQhDGA8aiq8MmItc(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object khZWrGhDEfimW8mclHqH(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool LXow3JhDfdRS2PkPVe0w(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hbEfOYhDQDIkn2lvEsyS(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object hAPi6fhDC71cZdLpHVL5(object P_0)
	{
		return ((ISyntaxNode)P_0).ReturnStatement();
	}

	internal static void qiGSm4hDvu3yF1mxEcZp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
