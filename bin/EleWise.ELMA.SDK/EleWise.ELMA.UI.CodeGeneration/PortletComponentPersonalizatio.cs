using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class PortletComponentPersonalizationGenerator : PortletPersonalizationGenerator
{
	private static PortletComponentPersonalizationGenerator TEsu7eBu9Y4JfvQLgeGA;

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		ISyntaxNode syntaxNode = ignoreNamespaces.WithIgnoreNamespaces(() => ((string)a9fBeyBu53AfsgD7YbOv(-2107978722 ^ -2108020940)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.None, (ISyntaxNode)QwPyrOBujDa95aMUXIrM(this), GetBaseInterfaces(), GetMembers()));
		WriteComments(syntaxNode);
		WriteTypeAttributes(syntaxNode);
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_0032, IL_0041
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (HtZZqQBurDHU0YxH1iJK(generationParams) != 0)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				break;
			}
			base.WriteTypeAttributes(type);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num2 = 0;
			}
		}
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		//Discarded unreachable code: IL_007f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 1:
				if (HtZZqQBurDHU0YxH1iJK(generationParams) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public PortletComponentPersonalizationGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Aveel4BugjjyDLcjfIIJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static GenerationMode HtZZqQBurDHU0YxH1iJK(object P_0)
	{
		return ((GenerationParams)P_0).Mode;
	}

	internal static bool DAWDVkBudj8FYy0huddY()
	{
		return TEsu7eBu9Y4JfvQLgeGA == null;
	}

	internal static PortletComponentPersonalizationGenerator cwX86VBultJHJRHEXJGh()
	{
		return TEsu7eBu9Y4JfvQLgeGA;
	}

	internal static void Aveel4BugjjyDLcjfIIJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object a9fBeyBu53AfsgD7YbOv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QwPyrOBujDa95aMUXIrM(object P_0)
	{
		return ((ClassGenerator)P_0).GetBaseClass();
	}
}
