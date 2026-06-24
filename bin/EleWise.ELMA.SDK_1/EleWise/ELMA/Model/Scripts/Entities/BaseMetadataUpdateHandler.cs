// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.BaseMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Обновление метаданных на новый рантайм</summary>
  [Component]
  public abstract class BaseMetadataUpdateHandler : IMetadataUpdateHandler
  {
    private static BaseMetadataUpdateHandler njav2yb2v26hKdyoTQUh;

    /// <inheritdoc />
    public abstract bool Check(IMetadata metadata);

    /// <inheritdoc />
    public abstract void UpdateMetadata(IMetadataUpdateResult updateResult);

    /// <inheritdoc />
    public abstract void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid);

    /// <inheritdoc />
    public abstract void UpdateScriptModules(IMetadataUpdateResult updateResult);

    /// <summary>Преобразование серверного исходного кода</summary>
    /// <param name="sourceCode">Исходный код</param>
    /// <param name="className">Имя класса</param>
    protected virtual string UpdateServerSourceCode(string sourceCode, string className)
    {
      int num1 = 12;
      ClassDeclarationSyntax oldNode;
      SyntaxNode root;
      ClassDeclarationSyntax newNode;
      while (true)
      {
        int num2 = num1;
        SyntaxTrivia syntaxTrivia;
        while (true)
        {
          SyntaxTokenList syntaxTokenList;
          SyntaxToken syntaxToken1;
          SyntaxTriviaList trivia;
          SyntaxTriviaList leadingTrivia;
          string className1;
          switch (num2)
          {
            case 1:
              leadingTrivia = syntaxToken1.LeadingTrivia;
              break;
            case 2:
              goto label_18;
            case 3:
              root = (SyntaxNode) BaseMetadataUpdateHandler.O80128b2VSKMwEEw5nsD((object) CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions) BaseMetadataUpdateHandler.I7i2Odb2Ia9v5lVfMbJn(BaseMetadataUpdateHandler.BGbPdCb2uO3D3GvDck67(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()), new CancellationToken());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 14;
              continue;
            case 4:
              ClassDeclarationSyntax declarationSyntax = oldNode;
              syntaxToken1 = BaseMetadataUpdateHandler.CiaAjJb2qSQDe7Wwtr8I(SyntaxKind.PartialKeyword);
              syntaxToken1 = syntaxToken1.WithLeadingTrivia(trivia);
              SyntaxTokenList modifiers = BaseMetadataUpdateHandler.z9MeDQb2K1DUe5l8PCX0(syntaxToken1.WithTrailingTrivia(syntaxTrivia));
              object obj = BaseMetadataUpdateHandler.N5877fb2XMwueLmtFCs4((object) declarationSyntax.WithModifiers(modifiers), (object) null);
              syntaxToken1 = BaseMetadataUpdateHandler.l3m3HGb2T7AfAFU8Aq8U((object) oldNode);
              SyntaxToken identifier = syntaxToken1.WithTrailingTrivia(BaseMetadataUpdateHandler.sAbASNb2RK10y4Zmj1ka(SyntaxKind.WhitespaceTrivia, (object) Environment.NewLine));
              newNode = ((ClassDeclarationSyntax) obj).WithIdentifier(identifier);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 8;
              continue;
            case 5:
              leadingTrivia = syntaxToken1.LeadingTrivia;
              break;
            case 6:
              goto label_6;
            case 7:
              syntaxTokenList = BaseMetadataUpdateHandler.euhQf7b2S900FcGK9EGR((object) oldNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 10;
              continue;
            case 8:
              goto label_15;
            case 9:
              if (oldNode != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 7 : 6;
                continue;
              }
              goto label_18;
            case 10:
              if (syntaxTokenList.Any())
              {
                syntaxTokenList = BaseMetadataUpdateHandler.euhQf7b2S900FcGK9EGR((object) oldNode);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 8 : 13;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            case 11:
              className1 = className;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
              continue;
            case 12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 2 : 11;
              continue;
            case 13:
              syntaxToken1 = syntaxTokenList.First();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 5;
              continue;
            case 14:
              oldNode = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num3 = 1;
                SyntaxToken syntaxToken2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken2 = BaseMetadataUpdateHandler.\u003C\u003Ec__DisplayClass4_0.s9J9nQCpRgCRVyUtXUH4((object) q);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return BaseMetadataUpdateHandler.\u003C\u003Ec__DisplayClass4_0.lVe3y2CpqRjf98mG2qER((object) syntaxToken2.ToString(), (object) className1);
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 8 : 9;
              continue;
            default:
              syntaxToken1 = BaseMetadataUpdateHandler.OC5PBRb2iMc7BGcRIrxt((object) oldNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
          }
          trivia = leadingTrivia;
          num2 = 6;
        }
label_6:
        syntaxTrivia = BaseMetadataUpdateHandler.sAbASNb2RK10y4Zmj1ka(SyntaxKind.WhitespaceTrivia, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405816681));
        num1 = 4;
      }
label_15:
      return (string) BaseMetadataUpdateHandler.N38G3qb2kt6wT11jjihP((object) root.ReplaceNode<SyntaxNode>((SyntaxNode) oldNode, (SyntaxNode) newNode));
label_18:
      return sourceCode;
    }

    /// <summary>Создать трансформацию ViewItem</summary>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    protected virtual ViewItemTransformationChange CreateViewItemTransformationChange(Guid formUid)
    {
      ViewItemTransformationChange transformationChange = new ViewItemTransformationChange();
      transformationChange.Uid = formUid;
      BaseMetadataUpdateHandler.CM8R0yb2O9qpucu2MFDN((object) transformationChange, BaseMetadataUpdateHandler.dIk1GKb2nMfV0LIn9gBi(236071375 ^ 235992753));
      BaseMetadataUpdateHandler.SHiD0hb22Uy4Xd5A8NgH((object) transformationChange, (object) RuntimeVersion.Version2);
      // ISSUE: type reference
      BaseMetadataUpdateHandler.pD40Stb2Pqr6lRKUU6oA((object) transformationChange, (object) BaseMetadataUpdateHandler.dnXNbLb2eCC3vDvu4y3B(__typeref (FormViewItem)).AssemblyQualifiedName);
      return transformationChange;
    }

    protected BaseMetadataUpdateHandler()
    {
      BaseMetadataUpdateHandler.BcqEldb21IHZ1xKF2RDU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object BGbPdCb2uO3D3GvDck67() => (object) CSharpParseOptions.Default;

    internal static object I7i2Odb2Ia9v5lVfMbJn([In] object obj0, [In] LanguageVersion obj1) => (object) ((CSharpParseOptions) obj0).WithLanguageVersion(obj1);

    internal static object O80128b2VSKMwEEw5nsD([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetRoot(obj1);

    internal static SyntaxTokenList euhQf7b2S900FcGK9EGR([In] object obj0) => ((MemberDeclarationSyntax) obj0).Modifiers;

    internal static SyntaxToken OC5PBRb2iMc7BGcRIrxt([In] object obj0) => ((TypeDeclarationSyntax) obj0).Keyword;

    internal static SyntaxTrivia sAbASNb2RK10y4Zmj1ka([In] SyntaxKind obj0, [In] object obj1) => SyntaxFactory.SyntaxTrivia(obj0, (string) obj1);

    internal static SyntaxToken CiaAjJb2qSQDe7Wwtr8I([In] SyntaxKind obj0) => SyntaxFactory.Token(obj0);

    internal static SyntaxTokenList z9MeDQb2K1DUe5l8PCX0([In] SyntaxToken obj0) => SyntaxTokenList.Create(obj0);

    internal static object N5877fb2XMwueLmtFCs4([In] object obj0, [In] object obj1) => (object) ((ClassDeclarationSyntax) obj0).WithBaseList((BaseListSyntax) obj1);

    internal static SyntaxToken l3m3HGb2T7AfAFU8Aq8U([In] object obj0) => ((BaseTypeDeclarationSyntax) obj0).Identifier;

    internal static object N38G3qb2kt6wT11jjihP([In] object obj0) => (object) ((SyntaxNode) obj0).ToFullString();

    internal static bool CPkBdjb282y0IZD0meB7() => BaseMetadataUpdateHandler.njav2yb2v26hKdyoTQUh == null;

    internal static BaseMetadataUpdateHandler QGeGxRb2ZgjwyWOKsFqP() => BaseMetadataUpdateHandler.njav2yb2v26hKdyoTQUh;

    internal static object dIk1GKb2nMfV0LIn9gBi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void CM8R0yb2O9qpucu2MFDN([In] object obj0, [In] object obj1) => ((ViewItemTransformationChange) obj0).PropertyName = (string) obj1;

    internal static void SHiD0hb22Uy4Xd5A8NgH([In] object obj0, [In] object obj1) => ((ViewItemTransformationChange) obj0).Value = obj1;

    internal static Type dnXNbLb2eCC3vDvu4y3B([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void pD40Stb2Pqr6lRKUU6oA([In] object obj0, [In] object obj1) => ((ViewItemTransformationChange) obj0).TypeName = (string) obj1;

    internal static void BcqEldb21IHZ1xKF2RDU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
