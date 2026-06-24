using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class ComponentTestScriptModuleCodeGenerator : ScriptModuleCodeGenerator
{
	private ComponentMetadata componentMetadata;

	internal static ComponentTestScriptModuleCodeGenerator c7EpN9BIeyD5eeKIT77Z;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				VQqwbqBI3c7DbIwoIiyg(metadata, aYIonjBINBqjJo9n568i(0x26FFCB59 ^ 0x26FF8267));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				MOr6AZBIp1JnnV8blank(metadata is ComponentMetadata, aYIonjBINBqjJo9n568i(-787452571 ^ -787389627));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
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
		return new ISyntaxNode[13]
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105133636).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31336F68).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269F516C).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675440791).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426159563).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767655735).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889526992).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138891248).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106587174).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921132641).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088365760).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542660271).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103EFBC3).NamespaceImportDeclaration()
		};
	}

	protected override string GetNamespace()
	{
		return componentMetadata.Namespace;
	}

	protected override string GetClassName()
	{
		return (string)psqJm7BIa13AQoNoKA51(componentMetadata);
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
			case 0:
				return;
			case 1:
				type.XmlComments(SR.T((string)aYIonjBINBqjJo9n568i(-672123589 ^ -672061483)).SummaryComment(), ((string)aYIonjBINBqjJo9n568i(0x12A5FAC7 ^ 0x12A4E83B)).ExampleComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112642428).ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial) };
	}

	public ComponentTestScriptModuleCodeGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pXLcjfBIDShPEbQObDmO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object aYIonjBINBqjJo9n568i(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void VQqwbqBI3c7DbIwoIiyg(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void MOr6AZBIp1JnnV8blank(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool ghRQBeBIPWXYI6loWpZ4()
	{
		return c7EpN9BIeyD5eeKIT77Z == null;
	}

	internal static ComponentTestScriptModuleCodeGenerator cOFTxwBI1IcSxlx9w80y()
	{
		return c7EpN9BIeyD5eeKIT77Z;
	}

	internal static object psqJm7BIa13AQoNoKA51(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void pXLcjfBIDShPEbQObDmO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
