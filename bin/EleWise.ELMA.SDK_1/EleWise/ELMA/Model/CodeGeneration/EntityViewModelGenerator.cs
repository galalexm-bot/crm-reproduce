// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityViewModelGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор класса модели представления объекта</summary>
  public class EntityViewModelGenerator : ClassGenerator
  {
    private static EntityViewModelGenerator vWrMnhhOY1rMuuEmggfn;

    /// <summary>Сгенерировать класс ViewModel</summary>
    /// <returns>Класс ViewModel</returns>
    public virtual ISyntaxNode Generate() => ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(901793403 ^ 901809487)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode) EntityViewModelGenerator.yXKn0PhOc98lMLN7wS0D((object) this), members: this.GetMembers());

    /// <inheritdoc />
    protected override ISyntaxNode GetBaseClass() => EntityViewModelGenerator.y5gr7rhOzsy8FBanMSxm(__typeref (FormViewBuilder<>)).CreateTypeSyntax((ISyntaxNode) EntityViewModelGenerator.OQsmn8h2FvgVQbkuAscQ((object) this.BaseName));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[3]
    {
      this.GetFirstCtor(),
      this.GetSecondCtor(),
      this.GetContextProperty()
    };

    private ISyntaxNode GetFirstCtor()
    {
      int num = 1;
      ISyntaxNode[] thisConstructorArguments;
      ISyntaxNode[] parameters;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            parameters = new ISyntaxNode[3]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137441316).ParameterDeclaration((ISyntaxNode) EntityViewModelGenerator.OQsmn8h2FvgVQbkuAscQ((object) this.ClassName)),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137958531).ParameterDeclaration((ISyntaxNode) EntityViewModelGenerator.jCek2jh2BF59oEvTTQcd(typeof (RootViewItem))),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822904538).ParameterDeclaration((ISyntaxNode) EntityViewModelGenerator.jCek2jh2BF59oEvTTQcd(EntityViewModelGenerator.y5gr7rhOzsy8FBanMSxm(__typeref (ClassMetadata))))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            thisConstructorArguments = new ISyntaxNode[4]
            {
              (ISyntaxNode) EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675488343)),
              (ISyntaxNode) EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-2107978722 ^ -2108021092)),
              (ISyntaxNode) EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(44884861 ^ 44870211)),
              (ISyntaxNode) EntityViewModelGenerator.a7aJCrh2ot4qBOFPArGI()
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return SyntaxGeneratorExtensions.ThisConstructorDeclaration((IEnumerable<ISyntaxNode>) parameters, Accessibility.Internal, thisConstructorArguments: (IEnumerable<ISyntaxNode>) thisConstructorArguments);
    }

    private ISyntaxNode GetSecondCtor()
    {
      int num = 3;
      ISyntaxNode[] statements;
      ISyntaxNode[] baseConstructorArguments;
      ISyntaxNode[] parameters;
      while (true)
      {
        switch (num)
        {
          case 1:
            statements = new ISyntaxNode[1]
            {
              (ISyntaxNode) EntityViewModelGenerator.IxLqGFh2bDwKrJAF6Kmn(EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(864270449 << 6 ^ -521250748)), EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-97972138 ^ -97954752)))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 2:
            baseConstructorArguments = new ISyntaxNode[3]
            {
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-342626196 - 1290888215 ^ -1633524009)).ParseExpression(),
              (ISyntaxNode) EntityViewModelGenerator.Q7JQx3h2WNsyEDv1xZMu(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(~541731958 ^ -541746505)),
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(1597012150 ^ 1597076486)).ParseExpression()
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            parameters = new ISyntaxNode[4]
            {
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(825385222 ^ 825369872)).ParameterDeclaration(this.ClassName.CreateTypeSyntax()),
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-345420348 ^ -345397434)).ParameterDeclaration(EntityViewModelGenerator.y5gr7rhOzsy8FBanMSxm(__typeref (RootViewItem))),
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-606654180 ^ -606635998)).ParameterDeclaration(EntityViewModelGenerator.y5gr7rhOzsy8FBanMSxm(__typeref (ClassMetadata))),
              ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(~1767720452 ^ -1767656117)).ParameterDeclaration(EntityViewModelGenerator.y5gr7rhOzsy8FBanMSxm(__typeref (PropertyViewInfoContainer)))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) parameters, Accessibility.Internal, baseConstructorArguments: (IEnumerable<ISyntaxNode>) baseConstructorArguments, statements: (IEnumerable<ISyntaxNode>) statements);
    }

    private ISyntaxNode GetContextProperty() => ((string) EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(1051276242 - 990076387 ^ 61182443)).AutoPropertyDeclaration((ISyntaxNode) EntityViewModelGenerator.OQsmn8h2FvgVQbkuAscQ((object) this.ClassName), Accessibility.Internal, setterAccessibility: Accessibility.Private).XmlComments(((string) EntityViewModelGenerator.JUD9Gqh2hPlCfqVSp5tT(EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-1839087379 - 334718690 ^ 2121074817))).SummaryComment());

    /// <summary>Имя базового типа</summary>
    protected virtual string BaseName => (string) EntityViewModelGenerator.d0l1nOh2ESeDPY8Dw8DC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867452213), EntityViewModelGenerator.FD7G9Jh2GrXM5MbyGAGi((object) this.metadata));

    private string ClassName => (string) EntityViewModelGenerator.d0l1nOh2ESeDPY8Dw8DC(EntityViewModelGenerator.FD7G9Jh2GrXM5MbyGAGi((object) this.metadata), EntityViewModelGenerator.AtBQ04hOseSRiCW9pT4A(-606654180 ^ -606763736));

    public EntityViewModelGenerator()
    {
      EntityViewModelGenerator.dsI56kh2fdsAJ1U2Qfve();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object AtBQ04hOseSRiCW9pT4A(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yXKn0PhOc98lMLN7wS0D([In] object obj0) => (object) ((ClassGenerator) obj0).GetBaseClass();

    internal static bool TP7iePhOLyA4LHGgM2a4() => EntityViewModelGenerator.vWrMnhhOY1rMuuEmggfn == null;

    internal static EntityViewModelGenerator JJN3vLhOUymQDk9fx12i() => EntityViewModelGenerator.vWrMnhhOY1rMuuEmggfn;

    internal static Type y5gr7rhOzsy8FBanMSxm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object OQsmn8h2FvgVQbkuAscQ([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object jCek2jh2BF59oEvTTQcd(Type type) => (object) type.CreateTypeSyntax();

    internal static object Q7JQx3h2WNsyEDv1xZMu([In] object obj0) => (object) ((string) obj0).ParseExpression();

    internal static object a7aJCrh2ot4qBOFPArGI() => (object) SyntaxGeneratorExtensions.Null;

    internal static object IxLqGFh2bDwKrJAF6Kmn([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).AssignmentStatement((ISyntaxNode) obj1);

    internal static object JUD9Gqh2hPlCfqVSp5tT([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object FD7G9Jh2GrXM5MbyGAGi([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object d0l1nOh2ESeDPY8Dw8DC([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void dsI56kh2fdsAJ1U2Qfve() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
