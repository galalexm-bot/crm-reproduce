// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiRootNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiRootNode : IPublicApiNode
  {
    public const string Namespace = "EleWise.ELMA.API";
    public const string Path = "PublicAPI";
    internal static PublicApiRootNode ErRYQnh7hDYPdXbghNGG;

    internal PublicApiRootNode()
    {
      PublicApiRootNode.k6uq2Xh7f8ShpfAG2RKs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public string ParentPath => (string) PublicApiRootNode.WEXL66h7QXhRjm6FR5a3(--1867379187 ^ 1867310037);

    string IPublicApiNode.Path => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553374);

    public ISyntaxNode Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539428969).NamespaceDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153905605).ClassDeclaration(Accessibility.Public, DeclarationModifiers.Sealed, members: SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Private).Concat<ISyntaxNode>(tree[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124694430)].SelectMany<IPublicApiNode, ISyntaxNode>((Func<IPublicApiNode, IEnumerable<ISyntaxNode>>) (n => n.Generate(tree))))).AddAttributes(TypeOf<ShowDefaultMethodsAttribute>.Raw.CreateAttribute((object) false)).XmlComments(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671893937)).SummaryComment()));
    }

    IEnumerable<ISyntaxNode> IPublicApiNode.Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      throw new NotImplementedException();
    }

    internal static void k6uq2Xh7f8ShpfAG2RKs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ELadLOh7Gxsxr09dIjmu() => PublicApiRootNode.ErRYQnh7hDYPdXbghNGG == null;

    internal static PublicApiRootNode ydpeRsh7ER9mrHALQORw() => PublicApiRootNode.ErRYQnh7hDYPdXbghNGG;

    internal static object WEXL66h7QXhRjm6FR5a3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
