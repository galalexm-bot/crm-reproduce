using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class ModuleInfoGenerator : CodeGenerator
{
	protected ModuleInfoMetadata metadata;

	private static ModuleInfoGenerator c27J1Ph3cgNaryHFkSoQ;

	[IteratorStateMachine(typeof(_003CGenerateAdditionalFilesInternal_003Ed__0))]
	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateAdditionalFilesInternal_003Ed__0(-2);
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_008a, IL_00bd, IL_0100, IL_010f
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
				OLScL5hpWY68CnT9g9Rf(metadata, h7ruXLhpB8NV6er1JT0e(-951514650 ^ -951500584));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					generatedFileInfo = GenerateMainFileHelper(AssemblyAttributes());
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345364806), metadata.Name), innerException);
					}
				}
			}
		}
	}

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				A45QqOhpbVBTCTgZjFgm(metadata is ModuleInfoMetadata, h7ruXLhpB8NV6er1JT0e(0x26FFCB59 ^ 0x26FCA0E5));
				num2 = 3;
				break;
			case 2:
				i34qNBhpougsbgfnG74Q(metadata, h7ruXLhpB8NV6er1JT0e(0x5F3078B6 ^ 0x5F303188));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				this.metadata = (ModuleInfoMetadata)metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
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

	public ModuleInfoGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OdbjoAhphTcFDJXN8Ovb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object h7ruXLhpB8NV6er1JT0e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void OLScL5hpWY68CnT9g9Rf(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool g2Gcr7h3zbL2kud42snd()
	{
		return c27J1Ph3cgNaryHFkSoQ == null;
	}

	internal static ModuleInfoGenerator jddxQJhpFBVQbyyARxpL()
	{
		return c27J1Ph3cgNaryHFkSoQ;
	}

	internal static void i34qNBhpougsbgfnG74Q(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void A45QqOhpbVBTCTgZjFgm(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static void OdbjoAhphTcFDJXN8Ovb()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
