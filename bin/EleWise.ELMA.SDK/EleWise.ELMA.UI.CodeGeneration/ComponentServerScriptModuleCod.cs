using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class ComponentServerScriptModuleCodeGenerator : ScriptModuleCodeGenerator
{
	private ComponentMetadata componentMetadata;

	internal static ComponentServerScriptModuleCodeGenerator LgrM29BIRbyCu3cjhNCh;

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
			case 0:
				return;
			case 3:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				h4BXkoBITLkAMlFkZde2(metadata is ComponentMetadata, KlNQwYBIXVjSvkcdZdJG(0x31326106 ^ 0x31336F26));
				num2 = 3;
				break;
			case 2:
				Contract.ArgumentNotNull(metadata, (string)KlNQwYBIXVjSvkcdZdJG(-1146510045 ^ -1146491875));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[9]
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900262).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146574003).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70106890).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488812089).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195675341).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4784ACC1).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146570903).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951581170).NamespaceImportDeclaration(),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3CFD02).NamespaceImportDeclaration()
		};
	}

	protected override string GetNamespace()
	{
		return (string)ha0IR0BIkYEfxYA5t8Wv(componentMetadata);
	}

	protected override string GetClassName()
	{
		return (string)BdFrm6BInNcQ7RuPPDmn(componentMetadata);
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
				type.XmlComments(SR.T((string)KlNQwYBIXVjSvkcdZdJG(0x463A0F3C ^ 0x463B1E94), o4HksdBIOM25ooMHc0dw(componentMetadata)).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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
		return new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFFE988).ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial) };
	}

	public ComponentServerScriptModuleCodeGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Kdge4MBI2B8Ly70kROu2();
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

	internal static object KlNQwYBIXVjSvkcdZdJG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void h4BXkoBITLkAMlFkZde2(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool WJKd8HBIqHdum4QdRt9N()
	{
		return LgrM29BIRbyCu3cjhNCh == null;
	}

	internal static ComponentServerScriptModuleCodeGenerator BtDC8BBIKsMVep7ixAP2()
	{
		return LgrM29BIRbyCu3cjhNCh;
	}

	internal static object ha0IR0BIkYEfxYA5t8Wv(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object BdFrm6BInNcQ7RuPPDmn(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object o4HksdBIOM25ooMHc0dw(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void Kdge4MBI2B8Ly70kROu2()
	{
		SingletonReader.PushGlobal();
	}
}
