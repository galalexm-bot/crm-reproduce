// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PageViewModelGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор класса ViewModel для страницы</summary>
  internal sealed class PageViewModelGenerator : ComponentViewModelGenerator
  {
    private static PageViewModelGenerator GNfSUSBuXVenJ2D6KvKd;

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[6]
    {
      PageViewModelGenerator.FormResultField,
      PageViewModelGenerator.GetCtor(),
      ComponentViewModelGenerator.GetContextProperty(),
      PageViewModelGenerator.FormProperty,
      PageViewModelGenerator.RedirectToPageMethod,
      PageViewModelGenerator.RedirectToUrlMethod
    };

    private static ISyntaxNode GetCtor() => SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[4]
    {
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-1204263869 ^ -1341583247 ^ 137441316)).ParameterDeclaration((ISyntaxNode) PageViewModelGenerator.ahjIGpBuOe2jfGdkHAJB(PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(222162814 ^ 222145402))),
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-1445902765 ^ -1980277732 ^ 539422925)).ParameterDeclaration(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (RootViewItem))),
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-1146510045 ^ -1146491875)).ParameterDeclaration(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (ClassMetadata))),
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-867826612 ^ -867759876)).ParameterDeclaration(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (PropertyViewInfoContainer)))
    }, Accessibility.Private, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[2]
    {
      ((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488896561))).AssignmentStatement((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583760670))),
      (ISyntaxNode) PageViewModelGenerator.cGToMiBuPJQ658GTPlNR((object) ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(1304605005 ^ 1304563369)).ParseExpression(), (object) typeof (FormViewBuilder<>).CreateTypeSyntax((ISyntaxNode) PageViewModelGenerator.ahjIGpBuOe2jfGdkHAJB(PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(~-306453669 ^ 306469024))).ObjectCreationExpression((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36033711)), (ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561060774)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333673634).ParseExpression()))
    });

    private static ISyntaxNode FormProperty => z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901839263).PropertyDeclaration(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (FormViewBuilder<>)).CreateTypeSyntax((ISyntaxNode) PageViewModelGenerator.ahjIGpBuOe2jfGdkHAJB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44869497))), Accessibility.Internal, setterAccessibility: Accessibility.Private).XmlComments(((string) PageViewModelGenerator.zl3TApBu1LbyELs9bOmi(PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(1597012150 ^ 1597076576))).SummaryComment());

    private static ISyntaxNode RedirectToPageMethod => z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236135731).MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(993438473 ^ 993395025)).ParameterDeclaration((ISyntaxNode) PageViewModelGenerator.oqphv8BuN6Bf3rW719up(typeof (string)))
    }, accessibility: Accessibility.Internal, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      (ISyntaxNode) PageViewModelGenerator.cGToMiBuPJQ658GTPlNR((object) ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(1669212571 ^ 1669259599)).ParseExpression(), (object) typeof (RedirectToPageResult).CreateTypeSyntax().ObjectCreationExpression((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979208087))))
    }).XmlComments(EleWise.ELMA.SR.T((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(979449278 ^ 979384482)).SummaryComment(), ((string) PageViewModelGenerator.zl3TApBu1LbyELs9bOmi(PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(694673736 ^ -23604109 ^ -672057157))).ParamComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113888859)));

    private static ISyntaxNode RedirectToUrlMethod => ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(1199946765 ^ 1199878589)).MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      ((string) PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-53329496 >> 4 ^ -3305900)).ParameterDeclaration(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (string)).CreateTypeSyntax())
    }, accessibility: Accessibility.Internal, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      ((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61152571))).AssignmentStatement(((ISyntaxNode) PageViewModelGenerator.oqphv8BuN6Bf3rW719up(PageViewModelGenerator.oVJ4IrBu2jpnXBs9HqEs(__typeref (RedirectToUrlResult)))).ObjectCreationExpression((ISyntaxNode) PageViewModelGenerator.pRFEFiBueYBwDewIsQSG(PageViewModelGenerator.uAJRt5Bun5sH58gGpVJP(-951514650 ^ -951475288))))
    }).XmlComments(((string) PageViewModelGenerator.zl3TApBu1LbyELs9bOmi((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870823431))).SummaryComment(), ((string) PageViewModelGenerator.zl3TApBu1LbyELs9bOmi((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099685051))).ParamComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222119216)));

    private static ISyntaxNode FormResultField => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858901643).FieldDeclaration(typeof (FormResult).CreateTypeSyntax(), Accessibility.Private);

    public PageViewModelGenerator()
    {
      PageViewModelGenerator.F7ZYwNBu3n2xphQPoUEO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object uAJRt5Bun5sH58gGpVJP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ahjIGpBuOe2jfGdkHAJB([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static Type oVJ4IrBu2jpnXBs9HqEs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object pRFEFiBueYBwDewIsQSG([In] object obj0) => (object) ((string) obj0).ParseExpression();

    internal static object cGToMiBuPJQ658GTPlNR([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).AssignmentStatement((ISyntaxNode) obj1);

    internal static bool yYW6BkBuToBQDcOhJQ2h() => PageViewModelGenerator.GNfSUSBuXVenJ2D6KvKd == null;

    internal static PageViewModelGenerator gJfbVlBukMs6BQ7dTCkZ() => PageViewModelGenerator.GNfSUSBuXVenJ2D6KvKd;

    internal static object zl3TApBu1LbyELs9bOmi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object oqphv8BuN6Bf3rW719up(Type type) => (object) type.CreateTypeSyntax();

    internal static void F7ZYwNBu3n2xphQPoUEO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
