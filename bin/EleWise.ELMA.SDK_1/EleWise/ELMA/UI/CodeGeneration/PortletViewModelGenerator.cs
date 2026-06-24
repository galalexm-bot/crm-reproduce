// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletViewModelGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор класса ViewModel для портлета</summary>
  internal sealed class PortletViewModelGenerator : ComponentViewModelGenerator
  {
    internal static PortletViewModelGenerator sLZLKhBuYXB8JXP35yne;

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[4]
    {
      PortletViewModelGenerator.GetCtor(),
      ComponentViewModelGenerator.GetContextProperty(),
      PortletViewModelGenerator.GetSettingsProperty(),
      PortletViewModelGenerator.FormProperty
    };

    private static ISyntaxNode GetCtor() => SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[5]
    {
      ((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(1819636893 << 3 ^ 1672208638)).ParameterDeclaration((ISyntaxNode) PortletViewModelGenerator.oBOctYBucN0RMiQHFRYU(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-477139494 ^ -477156898))),
      ((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(--1418440330 ^ 1418413060)).ParameterDeclaration((ISyntaxNode) PortletViewModelGenerator.oBOctYBucN0RMiQHFRYU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082342962))),
      ((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(1178210108 ^ 1178265022)).ParameterDeclaration(PortletViewModelGenerator.SG1rAbBuzfTIYohoOclb(__typeref (RootViewItem))),
      ((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-87337865 ^ -87351991)).ParameterDeclaration(PortletViewModelGenerator.SG1rAbBuzfTIYohoOclb(__typeref (ClassMetadata))),
      ((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-398663332 ^ -398594580)).ParameterDeclaration(typeof (PropertyViewInfoContainer))
    }, Accessibility.Private, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[3]
    {
      ((ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-1710575414 ^ -1710558002))).AssignmentStatement((ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-35995181 ^ -36010555))),
      ((ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(1178210108 ^ 1178218410))).AssignmentStatement((ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-1445902765 ^ -1980277732 ^ 539422913))),
      (ISyntaxNode) PortletViewModelGenerator.Cw62c8BIBk9AE33qCHre(PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236099115)), (object) PortletViewModelGenerator.SG1rAbBuzfTIYohoOclb(__typeref (FormViewBuilder<>)).CreateTypeSyntax((ISyntaxNode) PortletViewModelGenerator.oBOctYBucN0RMiQHFRYU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867811256))).ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583783818).ParseExpression(), (ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(-2099751081 ^ -2099765655)), (ISyntaxNode) PortletViewModelGenerator.mjGWcbBIFcF7T9rHL8LQ(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(~-122002947 ^ 121934514))))
    });

    private static ISyntaxNode GetSettingsProperty() => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576157902).PropertyDeclaration((ISyntaxNode) PortletViewModelGenerator.oBOctYBucN0RMiQHFRYU(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(1051802738 - -1831968059 ^ -1411239289)), Accessibility.Internal, setterAccessibility: Accessibility.Private).XmlComments(EleWise.ELMA.SR.T((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(572119659 - -337058038 ^ 909239009)).SummaryComment());

    private static ISyntaxNode FormProperty => z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813572149).PropertyDeclaration(PortletViewModelGenerator.SG1rAbBuzfTIYohoOclb(__typeref (FormViewBuilder<>)).CreateTypeSyntax((ISyntaxNode) PortletViewModelGenerator.oBOctYBucN0RMiQHFRYU(PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(864270449 << 6 ^ -521250748))), Accessibility.Internal, setterAccessibility: Accessibility.Private).XmlComments(EleWise.ELMA.SR.T((string) PortletViewModelGenerator.GJYb65BusNmTTaQugFj8(1994213607 >> 4 ^ 124573784)).SummaryComment());

    public PortletViewModelGenerator()
    {
      PortletViewModelGenerator.dTftg7BIWkSyP8FpgMOV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object GJYb65BusNmTTaQugFj8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oBOctYBucN0RMiQHFRYU([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static Type SG1rAbBuzfTIYohoOclb([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object mjGWcbBIFcF7T9rHL8LQ([In] object obj0) => (object) ((string) obj0).ParseExpression();

    internal static object Cw62c8BIBk9AE33qCHre([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).AssignmentStatement((ISyntaxNode) obj1);

    internal static bool aXIx3LBuLPR569o9iFoL() => PortletViewModelGenerator.sLZLKhBuYXB8JXP35yne == null;

    internal static PortletViewModelGenerator v96mAOBuUGbQAyNVLmJf() => PortletViewModelGenerator.sLZLKhBuYXB8JXP35yne;

    internal static void dTftg7BIWkSyP8FpgMOV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
