using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class PageViewModelGenerator : ComponentViewModelGenerator
{
	private static PageViewModelGenerator GNfSUSBuXVenJ2D6KvKd;

	private static ISyntaxNode FormProperty => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0F99F).PropertyDeclaration(oVJ4IrBu2jpnXBs9HqEs(typeof(FormViewBuilder<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)ahjIGpBuOe2jfGdkHAJB(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2ACA779))), Accessibility.Internal, DeclarationModifiers.None, null, null, Accessibility.NotApplicable, Accessibility.Private).XmlComments(((string)zl3TApBu1LbyELs9bOmi(uAJRt5Bun5sH58gGpVJP(0x5F3078B6 ^ 0x5F317460))).SummaryComment());

	private static ISyntaxNode RedirectToPageMethod => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE132533).MethodDeclaration(new ISyntaxNode[1] { ((string)uAJRt5Bun5sH58gGpVJP(0x3B36AB09 ^ 0x3B360151)).ParameterDeclaration((ISyntaxNode)oqphv8BuN6Bf3rW719up(typeof(string))) }, null, null, Accessibility.Internal, DeclarationModifiers.None, new ISyntaxNode[1] { (ISyntaxNode)cGToMiBuPJQ658GTPlNR(((string)uAJRt5Bun5sH58gGpVJP(0x637E299B ^ 0x637EE14F)).ParseExpression(), typeof(RedirectToPageResult).CreateTypeSyntax().ObjectCreationExpression((ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979208087)))) }).XmlComments(SR.T((string)uAJRt5Bun5sH58gGpVJP(0x3A6135BE ^ 0x3A6038A2)).SummaryComment(), ((string)zl3TApBu1LbyELs9bOmi(uAJRt5Bun5sH58gGpVJP(-672123589 ^ -672057157))).ParamComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4264985B)));

	private static ISyntaxNode RedirectToUrlMethod => ((string)uAJRt5Bun5sH58gGpVJP(0x4785BC0D ^ 0x4784B1BD)).MethodDeclaration(new ISyntaxNode[1] { ((string)uAJRt5Bun5sH58gGpVJP(-3333094 ^ -3305900)).ParameterDeclaration(oVJ4IrBu2jpnXBs9HqEs(typeof(string).TypeHandle).CreateTypeSyntax()) }, null, null, Accessibility.Internal, DeclarationModifiers.None, new ISyntaxNode[1] { ((ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A51D3B))).AssignmentStatement(((ISyntaxNode)oqphv8BuN6Bf3rW719up(oVJ4IrBu2jpnXBs9HqEs(typeof(RedirectToUrlResult).TypeHandle))).ObjectCreationExpression((ISyntaxNode)pRFEFiBueYBwDewIsQSG(uAJRt5Bun5sH58gGpVJP(-951514650 ^ -951475288)))) }).XmlComments(((string)zl3TApBu1LbyELs9bOmi(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870823431))).SummaryComment(), ((string)zl3TApBu1LbyELs9bOmi(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099685051))).ParamComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D4530)));

	private static ISyntaxNode FormResultField => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858901643).FieldDeclaration(typeof(FormResult).CreateTypeSyntax(), Accessibility.Private);

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[6]
		{
			FormResultField,
			GetCtor(),
			ComponentViewModelGenerator.GetContextProperty(),
			FormProperty,
			RedirectToPageMethod,
			RedirectToUrlMethod
		};
	}

	private static ISyntaxNode GetCtor()
	{
		return SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[4]
		{
			((string)uAJRt5Bun5sH58gGpVJP(0x8317432 ^ 0x8313024)).ParameterDeclaration((ISyntaxNode)ahjIGpBuOe2jfGdkHAJB(uAJRt5Bun5sH58gGpVJP(0xD3DEF7E ^ 0xD3DAB7A))),
			((string)uAJRt5Bun5sH58gGpVJP(0x20261A4F ^ 0x2026F0CD)).ParameterDeclaration(oVJ4IrBu2jpnXBs9HqEs(typeof(RootViewItem).TypeHandle)),
			((string)uAJRt5Bun5sH58gGpVJP(-1146510045 ^ -1146491875)).ParameterDeclaration(oVJ4IrBu2jpnXBs9HqEs(typeof(ClassMetadata).TypeHandle)),
			((string)uAJRt5Bun5sH58gGpVJP(-867826612 ^ -867759876)).ParameterDeclaration(oVJ4IrBu2jpnXBs9HqEs(typeof(PropertyViewInfoContainer).TypeHandle))
		}, Accessibility.Private, DeclarationModifiers.None, null, new ISyntaxNode[2]
		{
			((ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488896561))).AssignmentStatement((ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583760670))),
			(ISyntaxNode)cGToMiBuPJQ658GTPlNR(((string)uAJRt5Bun5sH58gGpVJP(0x4DC2B14D ^ 0x4DC20EA9)).ParseExpression(), typeof(FormViewBuilder<>).CreateTypeSyntax((ISyntaxNode)ahjIGpBuOe2jfGdkHAJB(uAJRt5Bun5sH58gGpVJP(0x12441CA4 ^ 0x124458A0))).ObjectCreationExpression((ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36033711)), (ISyntaxNode)pRFEFiBueYBwDewIsQSG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561060774)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E3EA2).ParseExpression()))
		});
	}

	public PageViewModelGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		F7ZYwNBu3n2xphQPoUEO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object uAJRt5Bun5sH58gGpVJP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ahjIGpBuOe2jfGdkHAJB(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static Type oVJ4IrBu2jpnXBs9HqEs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pRFEFiBueYBwDewIsQSG(object P_0)
	{
		return ((string)P_0).ParseExpression();
	}

	internal static object cGToMiBuPJQ658GTPlNR(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).AssignmentStatement((ISyntaxNode)P_1);
	}

	internal static bool yYW6BkBuToBQDcOhJQ2h()
	{
		return GNfSUSBuXVenJ2D6KvKd == null;
	}

	internal static PageViewModelGenerator gJfbVlBukMs6BQ7dTCkZ()
	{
		return GNfSUSBuXVenJ2D6KvKd;
	}

	internal static object zl3TApBu1LbyELs9bOmi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object oqphv8BuN6Bf3rW719up(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static void F7ZYwNBu3n2xphQPoUEO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
