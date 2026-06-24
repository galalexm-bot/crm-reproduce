using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EntityViewModelGenerator : ClassGenerator
{
	private static EntityViewModelGenerator vWrMnhhOY1rMuuEmggfn;

	protected virtual string BaseName => (string)d0l1nOh2ESeDPY8Dw8DC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4F0F35), FD7G9Jh2GrXM5MbyGAGi(metadata));

	private string ClassName => (string)d0l1nOh2ESeDPY8Dw8DC(FD7G9Jh2GrXM5MbyGAGi(metadata), AtBQ04hOseSRiCW9pT4A(-606654180 ^ -606763736));

	public virtual ISyntaxNode Generate()
	{
		return ((string)AtBQ04hOseSRiCW9pT4A(0x35C0467B ^ 0x35C0854F)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode)yXKn0PhOc98lMLN7wS0D(this), null, GetMembers());
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return y5gr7rhOzsy8FBanMSxm(typeof(FormViewBuilder<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)OQsmn8h2FvgVQbkuAscQ(BaseName));
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[3]
		{
			GetFirstCtor(),
			GetSecondCtor(),
			GetContextProperty()
		};
	}

	private ISyntaxNode GetFirstCtor()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode[] parameters = default(ISyntaxNode[]);
		ISyntaxNode[] thisConstructorArguments = default(ISyntaxNode[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				parameters = new ISyntaxNode[3]
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8313024).ParameterDeclaration((ISyntaxNode)OQsmn8h2FvgVQbkuAscQ(ClassName)),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137958531).ParameterDeclaration((ISyntaxNode)jCek2jh2BF59oEvTTQcd(typeof(RootViewItem))),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822904538).ParameterDeclaration((ISyntaxNode)jCek2jh2BF59oEvTTQcd(y5gr7rhOzsy8FBanMSxm(typeof(ClassMetadata).TypeHandle)))
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return SyntaxGeneratorExtensions.ThisConstructorDeclaration(parameters, Accessibility.Internal, DeclarationModifiers.None, thisConstructorArguments);
			}
			thisConstructorArguments = new ISyntaxNode[4]
			{
				(ISyntaxNode)Q7JQx3h2WNsyEDv1xZMu(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675488343)),
				(ISyntaxNode)Q7JQx3h2WNsyEDv1xZMu(AtBQ04hOseSRiCW9pT4A(-2107978722 ^ -2108021092)),
				(ISyntaxNode)Q7JQx3h2WNsyEDv1xZMu(AtBQ04hOseSRiCW9pT4A(0x2ACE37D ^ 0x2ACAA43)),
				(ISyntaxNode)a7aJCrh2ot4qBOFPArGI()
			};
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
			{
				num2 = 2;
			}
		}
	}

	private ISyntaxNode GetSecondCtor()
	{
		int num = 3;
		int num2 = num;
		ISyntaxNode[] statements = default(ISyntaxNode[]);
		ISyntaxNode[] baseConstructorArguments = default(ISyntaxNode[]);
		ISyntaxNode[] parameters = default(ISyntaxNode[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				statements = new ISyntaxNode[1] { (ISyntaxNode)IxLqGFh2bDwKrJAF6Kmn(Q7JQx3h2WNsyEDv1xZMu(AtBQ04hOseSRiCW9pT4A(-521266112 ^ -521250748)), Q7JQx3h2WNsyEDv1xZMu(AtBQ04hOseSRiCW9pT4A(-97972138 ^ -97954752))) };
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				baseConstructorArguments = new ISyntaxNode[3]
				{
					((string)AtBQ04hOseSRiCW9pT4A(-1633514411 ^ -1633524009)).ParseExpression(),
					(ISyntaxNode)Q7JQx3h2WNsyEDv1xZMu(AtBQ04hOseSRiCW9pT4A(-541731959 ^ -541746505)),
					((string)AtBQ04hOseSRiCW9pT4A(0x5F3078B6 ^ 0x5F317406)).ParseExpression()
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				parameters = new ISyntaxNode[4]
				{
					((string)AtBQ04hOseSRiCW9pT4A(0x31326106 ^ 0x31322510)).ParameterDeclaration(ClassName.CreateTypeSyntax()),
					((string)AtBQ04hOseSRiCW9pT4A(-345420348 ^ -345397434)).ParameterDeclaration(y5gr7rhOzsy8FBanMSxm(typeof(RootViewItem).TypeHandle)),
					((string)AtBQ04hOseSRiCW9pT4A(-606654180 ^ -606635998)).ParameterDeclaration(y5gr7rhOzsy8FBanMSxm(typeof(ClassMetadata).TypeHandle)),
					((string)AtBQ04hOseSRiCW9pT4A(-1767720453 ^ -1767656117)).ParameterDeclaration(y5gr7rhOzsy8FBanMSxm(typeof(PropertyViewInfoContainer).TypeHandle))
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return SyntaxGeneratorExtensions.ConstructorDeclaration(parameters, Accessibility.Internal, DeclarationModifiers.None, baseConstructorArguments, statements);
			}
		}
	}

	private ISyntaxNode GetContextProperty()
	{
		return ((string)AtBQ04hOseSRiCW9pT4A(0x3A5D5EF ^ 0x3A591EB)).AutoPropertyDeclaration((ISyntaxNode)OQsmn8h2FvgVQbkuAscQ(ClassName), Accessibility.Internal, DeclarationModifiers.None, Accessibility.NotApplicable, Accessibility.Private).XmlComments(((string)JUD9Gqh2hPlCfqVSp5tT(AtBQ04hOseSRiCW9pT4A(0x7E6E5A0B ^ 0x7E6D0881))).SummaryComment());
	}

	public EntityViewModelGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dsI56kh2fdsAJ1U2Qfve();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object AtBQ04hOseSRiCW9pT4A(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yXKn0PhOc98lMLN7wS0D(object P_0)
	{
		return ((ClassGenerator)P_0).GetBaseClass();
	}

	internal static bool TP7iePhOLyA4LHGgM2a4()
	{
		return vWrMnhhOY1rMuuEmggfn == null;
	}

	internal static EntityViewModelGenerator JJN3vLhOUymQDk9fx12i()
	{
		return vWrMnhhOY1rMuuEmggfn;
	}

	internal static Type y5gr7rhOzsy8FBanMSxm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OQsmn8h2FvgVQbkuAscQ(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object jCek2jh2BF59oEvTTQcd(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object Q7JQx3h2WNsyEDv1xZMu(object P_0)
	{
		return ((string)P_0).ParseExpression();
	}

	internal static object a7aJCrh2ot4qBOFPArGI()
	{
		return SyntaxGeneratorExtensions.Null;
	}

	internal static object IxLqGFh2bDwKrJAF6Kmn(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).AssignmentStatement((ISyntaxNode)P_1);
	}

	internal static object JUD9Gqh2hPlCfqVSp5tT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object FD7G9Jh2GrXM5MbyGAGi(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object d0l1nOh2ESeDPY8Dw8DC(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void dsI56kh2fdsAJ1U2Qfve()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
