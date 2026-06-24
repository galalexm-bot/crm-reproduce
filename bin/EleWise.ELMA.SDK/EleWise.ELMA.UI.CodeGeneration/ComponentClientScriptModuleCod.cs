using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class ComponentClientScriptModuleCodeGenerator : ScriptModuleCodeGenerator
{
	private ComponentMetadata componentMetadata;

	internal static ComponentClientScriptModuleCodeGenerator X2LMrpBIoLdfPTiyCHx5;

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UjRCOdBIE8SuOEVW50vE(metadata, GdiMggBIG9xiUsitIDVg(0x26FFCB59 ^ 0x26FF8267));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				MPWSohBIfmjoTQUtlppY(metadata is ComponentMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A7DC10));
				num2 = 3;
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[12]
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A6ED14).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951580792).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475794849).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411131525).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398594480).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1FEC2A).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561012204).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583676132).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876124495).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289776074).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA583AD9).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889521524).NamespaceImportDeclaration()
		};
	}

	protected override string GetNamespace()
	{
		return (string)WaOyTVBIQ0cLaSk9Fjur(componentMetadata);
	}

	protected override string GetClassName()
	{
		return (string)PN1sCIBICUhZ8lYBhJvy(componentMetadata);
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
				type.XmlComments(SR.T((string)GdiMggBIG9xiUsitIDVg(0x26FFCB59 ^ 0x26FEDAF1), componentMetadata.DisplayName).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886577555).ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial) };
	}

	public ComponentClientScriptModuleCodeGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object GdiMggBIG9xiUsitIDVg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void UjRCOdBIE8SuOEVW50vE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void MPWSohBIfmjoTQUtlppY(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool ekClYABIbmunfaFTKbIq()
	{
		return X2LMrpBIoLdfPTiyCHx5 == null;
	}

	internal static ComponentClientScriptModuleCodeGenerator kjhQeXBIhP9ITOrBRcs5()
	{
		return X2LMrpBIoLdfPTiyCHx5;
	}

	internal static object WaOyTVBIQ0cLaSk9Fjur(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object PN1sCIBICUhZ8lYBhJvy(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}
}
