using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal class ComponentViewModelGenerator : ClassGenerator
{
	private ComponentMetadata componentMetadata;

	protected const string ViewVariable = "view";

	protected const string MetadataVariable = "metadata";

	protected const string PropertyContainerVariable = "propertyContainer";

	protected const string Form = "Form";

	internal static ComponentViewModelGenerator sA0jLJBItcI1ed1a3do3;

	internal ISyntaxNode Generate()
	{
		return ((string)x78qMSBI6k2jBfZMISbf(componentMetadata)).NamespaceDeclaration((ISyntaxNode)O0inwDBIAhAxDy1NKXIq(Tm2KDmBIHId9nUFxCgvu(-477139494 ^ -477207676)), (ISyntaxNode)O0inwDBIAhAxDy1NKXIq(Tm2KDmBIHId9nUFxCgvu(0x18A6761F ^ 0x18A766D3)), componentMetadata.Name.ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088354068).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, null, null, GetMembers()).XmlComments(((string)gQoggyBI7LCr29ZpSCu4(Tm2KDmBIHId9nUFxCgvu(0x53FA00CE ^ 0x53FB16FC))).SummaryComment()) }));
	}

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				X9C6b4BIx2pa1V7TurVL(metadata, Tm2KDmBIHId9nUFxCgvu(0x3A5D5EF ^ 0x3A59CD1));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				OG9MR7BI0omu0PgKsrxq(metadata is ComponentMetadata, Tm2KDmBIHId9nUFxCgvu(--1867379187 ^ 0x6F4CFFD3));
				num2 = 3;
				break;
			case 2:
				return;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[2]
		{
			GetCtor(),
			GetContextProperty()
		};
	}

	protected static ISyntaxNode GetContextProperty()
	{
		return ((string)Tm2KDmBIHId9nUFxCgvu(0x2A7797B7 ^ 0x2A77D3B3)).PropertyDeclaration((ISyntaxNode)cpj3H5BImblfoMWJ46FZ(Tm2KDmBIHId9nUFxCgvu(-420743386 ^ -420760798)), Accessibility.Internal, DeclarationModifiers.None, null, null, Accessibility.NotApplicable, Accessibility.Private).XmlComments(SR.T((string)Tm2KDmBIHId9nUFxCgvu(0x48A7E34A ^ 0x48A7A9FA)).SummaryComment());
	}

	private static ISyntaxNode GetCtor()
	{
		return SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[1] { ((string)Tm2KDmBIHId9nUFxCgvu(-1852837372 ^ -1852852718)).ParameterDeclaration((ISyntaxNode)cpj3H5BImblfoMWJ46FZ(Tm2KDmBIHId9nUFxCgvu(-477139494 ^ -477156898))) }, Accessibility.Private, DeclarationModifiers.None, null, new ISyntaxNode[1] { (ISyntaxNode)lER3nXBIMl97yT8fD97f(((string)Tm2KDmBIHId9nUFxCgvu(-1767720453 ^ -1767703041)).ParseExpression(), P6QkdNBIyScsomCluoxN(Tm2KDmBIHId9nUFxCgvu(-957824448 ^ -957839786))) });
	}

	public ComponentViewModelGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		d55CZ5BIJbD9KIeYt1Zt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object x78qMSBI6k2jBfZMISbf(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object Tm2KDmBIHId9nUFxCgvu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object O0inwDBIAhAxDy1NKXIq(object P_0)
	{
		return ((string)P_0).NamespaceImportDeclaration();
	}

	internal static object gQoggyBI7LCr29ZpSCu4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool DTNhroBIwmji4Uouqqa5()
	{
		return sA0jLJBItcI1ed1a3do3 == null;
	}

	internal static ComponentViewModelGenerator nQu9eaBI4X9t6cn9iob6()
	{
		return sA0jLJBItcI1ed1a3do3;
	}

	internal static void X9C6b4BIx2pa1V7TurVL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void OG9MR7BI0omu0PgKsrxq(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object cpj3H5BImblfoMWJ46FZ(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object P6QkdNBIyScsomCluoxN(object P_0)
	{
		return ((string)P_0).ParseExpression();
	}

	internal static object lER3nXBIMl97yT8fD97f(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).AssignmentStatement((ISyntaxNode)P_1);
	}

	internal static void d55CZ5BIJbD9KIeYt1Zt()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
