using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public abstract class ScriptModuleCodeGenerator : ClassGenerator
{
	internal static ScriptModuleCodeGenerator S0v7sfhO3g1au7mY8ZCd;

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_004f, IL_00fb, IL_010a, IL_0136, IL_0165, IL_0174
		GeneratedFileInfo result = default(GeneratedFileInfo);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				ISyntaxNode[] declarations = GenerateMainFile().ToArray();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				string text = default(string);
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 1:
						text = (string)CSMsYShOD0qTqK8QUdkn(this);
						num = 5;
						break;
					case 3:
					case 4:
						result = GenerateMainFileHelper(declarations);
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num = 2;
						}
						break;
					default:
						declarations = GetNamespaces().Concat(text.NamespaceDeclaration(declarations)).ToArray();
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num = 1;
						}
						break;
					case 5:
						if (C5oQTThOtqOR7YPJZUZD(text))
						{
							num = 3;
							break;
						}
						goto default;
					}
				}
			}
			catch (Exception innerException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw new CodeGenerationException(SR.T((string)V2cOPAhOwipsMbX57je6(-1334993905 ^ -1334915607)), innerException);
				}
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		ISyntaxNode syntaxNode = GetClassName().ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, GetMembers());
		WriteComments(syntaxNode);
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected abstract string GetClassName();

	protected ScriptModuleCodeGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		R1Ki7AhO4J3IHTf7eDCF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object CSMsYShOD0qTqK8QUdkn(object P_0)
	{
		return ((ClassGenerator)P_0).GetNamespace();
	}

	internal static bool C5oQTThOtqOR7YPJZUZD(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object V2cOPAhOwipsMbX57je6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nF276jhOplhMt8oEDfXi()
	{
		return S0v7sfhO3g1au7mY8ZCd == null;
	}

	internal static ScriptModuleCodeGenerator IfwbshhOawApFnJINHGt()
	{
		return S0v7sfhO3g1au7mY8ZCd;
	}

	internal static void R1Ki7AhO4J3IHTf7eDCF()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
