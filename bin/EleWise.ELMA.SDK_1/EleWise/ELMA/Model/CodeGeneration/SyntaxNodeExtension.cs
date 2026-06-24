// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.SyntaxNodeExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  public static class SyntaxNodeExtension
  {
    private static SyntaxNodeExtension gHMwkWheYIPAkU7aXIOt;

    public static ISyntaxNode If(
      this ISyntaxNode syntaxNode,
      bool condition,
      Func<ISyntaxNode, ISyntaxNode> builder)
    {
      if (condition)
        syntaxNode = builder(syntaxNode);
      return syntaxNode;
    }

    public static ISyntaxNode Pack(this SyntaxNode syntaxNode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (syntaxNode == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (ISyntaxNode) null;
label_5:
      return (ISyntaxNode) new SyntaxNodeContainer(syntaxNode);
    }

    public static ISyntaxNode Pack(this ISyntaxNode syntaxNodeContainer, SyntaxNode syntaxNode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SyntaxNodeExtension.VML29shes86heR6MXIkM((object) (SyntaxNodeContainer) syntaxNodeContainer, (object) syntaxNode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return syntaxNodeContainer;
    }

    public static IEnumerable<ISyntaxNode> Pack(this IEnumerable<SyntaxNode> syntaxNodes) => syntaxNodes == null ? (IEnumerable<ISyntaxNode>) null : syntaxNodes.Select<SyntaxNode, ISyntaxNode>(new Func<SyntaxNode, ISyntaxNode>(SyntaxNodeExtension.Pack));

    public static SyntaxNode Unpack(this ISyntaxNode syntaxNode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (syntaxNode == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (SyntaxNode) null;
label_5:
      return (SyntaxNode) SyntaxNodeExtension.Ers7qAhecgaT9UPp4k3O((object) (SyntaxNodeContainer) syntaxNode);
    }

    public static T Unpack<T>(this ISyntaxNode syntaxNode) where T : SyntaxNode => syntaxNode == null ? default (T) : (T) syntaxNode.Unpack();

    public static IEnumerable<SyntaxNode> Unpack(this IEnumerable<ISyntaxNode> syntaxNodes) => syntaxNodes == null ? (IEnumerable<SyntaxNode>) null : syntaxNodes.Select<ISyntaxNode, SyntaxNode>(new Func<ISyntaxNode, SyntaxNode>(SyntaxNodeExtension.Unpack));

    public static IEnumerable<T> Unpack<T>(this IEnumerable<ISyntaxNode> syntaxNodes) where T : SyntaxNode => syntaxNodes == null ? (IEnumerable<T>) null : syntaxNodes.Unpack().Cast<T>();

    public static IEnumerable<StatementSyntax> UnpackStatements(
      this IEnumerable<ISyntaxNode> syntaxNodes)
    {
      return syntaxNodes == null ? (IEnumerable<StatementSyntax>) null : syntaxNodes.Where<ISyntaxNode>((Func<ISyntaxNode, bool>) (n => n != null)).Select<ISyntaxNode, SyntaxNode>(new Func<ISyntaxNode, SyntaxNode>(SyntaxNodeExtension.Unpack)).Select<SyntaxNode, StatementSyntax>((Func<SyntaxNode, StatementSyntax>) (n =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(n is StatementSyntax statementSyntax2))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return statementSyntax2;
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (StatementSyntax) SyntaxNodeExtension.\u003C\u003Ec.sHNJwNvutAoMNmuDnDtX(SyntaxNodeExtension.\u003C\u003Ec.xONuqQvuDiYvSF4sqNwZ(), (object) (ExpressionSyntax) n);
      }));
    }

    internal static bool SjdhGTheL0bNo4rKEnpn() => SyntaxNodeExtension.gHMwkWheYIPAkU7aXIOt == null;

    internal static SyntaxNodeExtension EB6ACuheUxgJTsVVXGgY() => SyntaxNodeExtension.gHMwkWheYIPAkU7aXIOt;

    internal static void VML29shes86heR6MXIkM([In] object obj0, [In] object obj1) => ((SyntaxNodeContainer) obj0).SyntaxNode = (SyntaxNode) obj1;

    internal static object Ers7qAhecgaT9UPp4k3O([In] object obj0) => (object) ((SyntaxNodeContainer) obj0).SyntaxNode;
  }
}
