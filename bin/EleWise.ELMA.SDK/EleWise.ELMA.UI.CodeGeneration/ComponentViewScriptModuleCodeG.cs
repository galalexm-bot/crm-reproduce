using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class ComponentViewScriptModuleCodeGenerator : ScriptModuleCodeGenerator
{
	private ComponentMetadata componentMetadata;

	internal static ComponentViewScriptModuleCodeGenerator bttae2Bup6MEbQcWoHwj;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				fkcJybBuw22BgAHdhIqb(metadata, F2LyP9ButCkJBmX8Jdrm(-35995181 ^ -36009747));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				qe0OElBu45WbIVj0KPvu(metadata is ComponentMetadata, F2LyP9ButCkJBmX8Jdrm(0x6A81B9B4 ^ 0x6A80B794));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[14]
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124512FA).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900246).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867759382).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29322315).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F54FB).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70072319).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541795141).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420808618).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787389747).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70106680).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345481766).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195675831).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35925685).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675444365).NamespaceImportDeclaration()
		};
	}

	protected override string GetNamespace()
	{
		return (string)M8RlsLBu6uspZMCbFJ0X(componentMetadata);
	}

	protected override string GetClassName()
	{
		return (string)PdCLnlBuHHhWZIgmyfHj(componentMetadata);
	}

	protected override void WriteComments(ISyntaxNode type)
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
				type.XmlComments(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521204416), QZpSLCBuAmDDeUKkypRd(componentMetadata)).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740408172).ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, new ISyntaxNode[1] { OverrideMethodRender() }) };
	}

	private ISyntaxNode OverrideMethodRender()
	{
		return ((string)F2LyP9ButCkJBmX8Jdrm(-2099751081 ^ -2099689981)).MethodDeclaration(null, null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281903652).CreateTypeSyntax(), Accessibility.Public, DeclarationModifiers.Override, new ISyntaxNode[1] { (ISyntaxNode)yguXmuBu7cw20xoHgUJt(((object)null).CreateSyntaxNode()) });
	}

	public ComponentViewScriptModuleCodeGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object F2LyP9ButCkJBmX8Jdrm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void fkcJybBuw22BgAHdhIqb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void qe0OElBu45WbIVj0KPvu(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool BpZZpZBuaIhFKSy8NmfJ()
	{
		return bttae2Bup6MEbQcWoHwj == null;
	}

	internal static ComponentViewScriptModuleCodeGenerator k0WMZHBuDPk8ZeWwEIAh()
	{
		return bttae2Bup6MEbQcWoHwj;
	}

	internal static object M8RlsLBu6uspZMCbFJ0X(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object PdCLnlBuHHhWZIgmyfHj(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object QZpSLCBuAmDDeUKkypRd(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object yguXmuBu7cw20xoHgUJt(object P_0)
	{
		return ((ISyntaxNode)P_0).ReturnStatement();
	}
}
