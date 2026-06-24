// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentViewModelGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор класса ViewModel для компонента</summary>
  internal class ComponentViewModelGenerator : ClassGenerator
  {
    /// <summary>Метаданные компонента</summary>
    private ComponentMetadata componentMetadata;
    /// <summary>Константа для переменной</summary>
    protected const string ViewVariable = "view";
    /// <summary>Константа для переменной</summary>
    protected const string MetadataVariable = "metadata";
    /// <summary>Константа для переменной</summary>
    protected const string PropertyContainerVariable = "propertyContainer";
    /// <summary>Константа для свойства</summary>
    protected const string Form = "Form";
    internal static ComponentViewModelGenerator sA0jLJBItcI1ed1a3do3;

    /// <summary>Сгенерировать класс ViewModel</summary>
    /// <returns>Класс ViewModel</returns>
    internal ISyntaxNode Generate() => ((string) ComponentViewModelGenerator.x78qMSBI6k2jBfZMISbf((object) this.componentMetadata)).NamespaceDeclaration((ISyntaxNode) ComponentViewModelGenerator.O0inwDBIAhAxDy1NKXIq(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(-477139494 ^ -477207676)), (ISyntaxNode) ComponentViewModelGenerator.O0inwDBIAhAxDy1NKXIq(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(1654249598 >> 2 ^ 413624019)), this.componentMetadata.Name.ClassDeclaration(modifiers: DeclarationModifiers.Partial, members: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088354068).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, members: this.GetMembers()).XmlComments(((string) ComponentViewModelGenerator.gQoggyBI7LCr29ZpSCu4(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(333888594 ^ 1075625116 ^ 1408964348))).SummaryComment())
    }));

    /// <inheritdoc />
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentViewModelGenerator.X9C6b4BIx2pa1V7TurVL((object) metadata, ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(1051276242 - 990076387 ^ 61185233));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
            continue;
          default:
            ComponentViewModelGenerator.OG9MR7BI0omu0PgKsrxq(metadata is ComponentMetadata, ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(--1867379187 ^ 1867317203));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[2]
    {
      ComponentViewModelGenerator.GetCtor(),
      ComponentViewModelGenerator.GetContextProperty()
    };

    /// <summary>Получить свойство контекста</summary>
    /// <returns>Свойство контекста</returns>
    protected static ISyntaxNode GetContextProperty() => ((string) ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(712480695 ^ 712496051)).PropertyDeclaration((ISyntaxNode) ComponentViewModelGenerator.cpj3H5BImblfoMWJ46FZ(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(-420743386 ^ -420760798)), Accessibility.Internal, setterAccessibility: Accessibility.Private).XmlComments(SR.T((string) ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(1218962250 ^ 1218947578)).SummaryComment());

    private static ISyntaxNode GetCtor() => SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      ((string) ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(-1852837372 ^ -1852852718)).ParameterDeclaration((ISyntaxNode) ComponentViewModelGenerator.cpj3H5BImblfoMWJ46FZ(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(-477139494 ^ -477156898)))
    }, Accessibility.Private, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      (ISyntaxNode) ComponentViewModelGenerator.lER3nXBIMl97yT8fD97f((object) ((string) ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(~1767720452 ^ -1767703041)).ParseExpression(), ComponentViewModelGenerator.P6QkdNBIyScsomCluoxN(ComponentViewModelGenerator.Tm2KDmBIHId9nUFxCgvu(92412609 - 1050237057 ^ -957839786)))
    });

    public ComponentViewModelGenerator()
    {
      ComponentViewModelGenerator.d55CZ5BIJbD9KIeYt1Zt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object x78qMSBI6k2jBfZMISbf([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object Tm2KDmBIHId9nUFxCgvu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object O0inwDBIAhAxDy1NKXIq([In] object obj0) => (object) ((string) obj0).NamespaceImportDeclaration();

    internal static object gQoggyBI7LCr29ZpSCu4([In] object obj0) => (object) SR.T((string) obj0);

    internal static bool DTNhroBIwmji4Uouqqa5() => ComponentViewModelGenerator.sA0jLJBItcI1ed1a3do3 == null;

    internal static ComponentViewModelGenerator nQu9eaBI4X9t6cn9iob6() => ComponentViewModelGenerator.sA0jLJBItcI1ed1a3do3;

    internal static void X9C6b4BIx2pa1V7TurVL([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void OG9MR7BI0omu0PgKsrxq(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object cpj3H5BImblfoMWJ46FZ([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object P6QkdNBIyScsomCluoxN([In] object obj0) => (object) ((string) obj0).ParseExpression();

    internal static object lER3nXBIMl97yT8fD97f([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).AssignmentStatement((ISyntaxNode) obj1);

    internal static void d55CZ5BIJbD9KIeYt1Zt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
