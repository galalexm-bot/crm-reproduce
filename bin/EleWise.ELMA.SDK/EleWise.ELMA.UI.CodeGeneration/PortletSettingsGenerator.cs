using System;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.CodeGeneration;

public class PortletSettingsGenerator : FormContextGenerator
{
	private static PortletSettingsGenerator WlI2KtBVxbhJd0O9hDqq;

	protected override ISyntaxNode GetBaseClass()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			default:
				return nnBxAwBVM7UP51gpsgao(typeof(PortletSettings<>).TypeHandle).CreateTypeSyntax(syntaxNode);
			case 1:
				syntaxNode = (ISyntaxNode)fCDo6uBVyrJXRYGMETiF((ITypeGenerationInfo)GetIdTypeDescriptor(), metadata, null, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PortletSettingsGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AcT1P3BVJ0LAH8JyTJBh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object fCDo6uBVyrJXRYGMETiF(object P_0, object P_1, object P_2, bool forFilter)
	{
		return ((ITypeGenerationInfo)P_0).GetPropertyTypeReference((ClassMetadata)P_1, (PropertyMetadata)P_2, forFilter);
	}

	internal static Type nnBxAwBVM7UP51gpsgao(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool T5SwtSBV0yUCdeqlUdIe()
	{
		return WlI2KtBVxbhJd0O9hDqq == null;
	}

	internal static PortletSettingsGenerator zWgH2jBVmiOiyhVLX2gL()
	{
		return WlI2KtBVxbhJd0O9hDqq;
	}

	internal static void AcT1P3BVJ0LAH8JyTJBh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
