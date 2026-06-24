// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.SyntaxNodeContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.CodeGeneration
{
  internal class SyntaxNodeContainer : ISyntaxNode
  {
    private static SyntaxNodeContainer hOQSXLhegx8dg672xnNq;

    public SyntaxNodeContainer(SyntaxNode syntaxNode)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.SyntaxNode = syntaxNode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public SyntaxNode SyntaxNode
    {
      get => this.\u003CSyntaxNode\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSyntaxNode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override string ToString() => this.SyntaxNode.ToString();

    internal static bool K8WC6Whe54Y4U2Gj48xS() => SyntaxNodeContainer.hOQSXLhegx8dg672xnNq == null;

    internal static SyntaxNodeContainer HKfJqRhejVk71vLaPbqh() => SyntaxNodeContainer.hOQSXLhegx8dg672xnNq;
  }
}
