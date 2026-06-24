using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class PortletViewModelGenerator : ComponentViewModelGenerator
{
	internal static PortletViewModelGenerator sLZLKhBuYXB8JXP35yne;

	private static ISyntaxNode FormProperty => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E2035).PropertyDeclaration(SG1rAbBuzfTIYohoOclb(typeof(FormViewBuilder<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)oBOctYBucN0RMiQHFRYU(GJYb65BusNmTTaQugFj8(-521266112 ^ -521250748))), Accessibility.Internal, DeclarationModifiers.None, null, null, Accessibility.NotApplicable, Accessibility.Private).XmlComments(SR.T((string)GJYb65BusNmTTaQugFj8(0x76DD48E ^ 0x76CD858)).SummaryComment());

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[4]
		{
			GetCtor(),
			ComponentViewModelGenerator.GetContextProperty(),
			GetSettingsProperty(),
			FormProperty
		};
	}

	private static ISyntaxNode GetCtor()
	{
		return SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[5]
		{
			((string)GJYb65BusNmTTaQugFj8(0x63ABA4E8 ^ 0x63ABE0FE)).ParameterDeclaration((ISyntaxNode)oBOctYBucN0RMiQHFRYU(GJYb65BusNmTTaQugFj8(-477139494 ^ -477156898))),
			((string)GJYb65BusNmTTaQugFj8(--1418440330 ^ 0x548B4404)).ParameterDeclaration((ISyntaxNode)oBOctYBucN0RMiQHFRYU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E0832))),
			((string)GJYb65BusNmTTaQugFj8(0x463A0F3C ^ 0x463AE5BE)).ParameterDeclaration(SG1rAbBuzfTIYohoOclb(typeof(RootViewItem).TypeHandle)),
			((string)GJYb65BusNmTTaQugFj8(-87337865 ^ -87351991)).ParameterDeclaration(SG1rAbBuzfTIYohoOclb(typeof(ClassMetadata).TypeHandle)),
			((string)GJYb65BusNmTTaQugFj8(-398663332 ^ -398594580)).ParameterDeclaration(typeof(PropertyViewInfoContainer))
		}, Accessibility.Private, DeclarationModifiers.None, null, new ISyntaxNode[3]
		{
			((ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(-1710575414 ^ -1710558002))).AssignmentStatement((ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(-35995181 ^ -36010555))),
			((ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(0x463A0F3C ^ 0x463A2FAA))).AssignmentStatement((ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(0x20261A4F ^ 0x2026F0C1))),
			(ISyntaxNode)Cw62c8BIBk9AE33qCHre(mjGWcbBIFcF7T9rHL8LQ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12962B)), SG1rAbBuzfTIYohoOclb(typeof(FormViewBuilder<>).TypeHandle).CreateTypeSyntax((ISyntaxNode)oBOctYBucN0RMiQHFRYU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867811256))).ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583783818).ParseExpression(), (ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(-2099751081 ^ -2099765655)), (ISyntaxNode)mjGWcbBIFcF7T9rHL8LQ(GJYb65BusNmTTaQugFj8(0x7459E02 ^ 0x74492B2))))
		});
	}

	private static ISyntaxNode GetSettingsProperty()
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576157902).PropertyDeclaration((ISyntaxNode)oBOctYBucN0RMiQHFRYU(GJYb65BusNmTTaQugFj8(-1411196499 ^ -1411239289)), Accessibility.Internal, DeclarationModifiers.None, null, null, Accessibility.NotApplicable, Accessibility.Private).XmlComments(SR.T((string)GJYb65BusNmTTaQugFj8(0x3630F361 ^ 0x3631E2E1)).SummaryComment());
	}

	public PortletViewModelGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dTftg7BIWkSyP8FpgMOV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object GJYb65BusNmTTaQugFj8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oBOctYBucN0RMiQHFRYU(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static Type SG1rAbBuzfTIYohoOclb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mjGWcbBIFcF7T9rHL8LQ(object P_0)
	{
		return ((string)P_0).ParseExpression();
	}

	internal static object Cw62c8BIBk9AE33qCHre(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).AssignmentStatement((ISyntaxNode)P_1);
	}

	internal static bool aXIx3LBuLPR569o9iFoL()
	{
		return sLZLKhBuYXB8JXP35yne == null;
	}

	internal static PortletViewModelGenerator v96mAOBuUGbQAyNVLmJf()
	{
		return sLZLKhBuYXB8JXP35yne;
	}

	internal static void dTftg7BIWkSyP8FpgMOV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
