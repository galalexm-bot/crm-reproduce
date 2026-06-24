// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiMembersNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiMembersNode : IPublicApiNode
  {
    private readonly IEnumerable<ISyntaxNode> syntaxNodes;
    internal static PublicApiMembersNode zd1lTRhH9Ft40UZH2ZpV;

    public PublicApiMembersNode(string parentPath, params ISyntaxNode[] syntaxNodes)
    {
      PublicApiMembersNode.Q6vWcshHrTybiGs0cf81();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, ((IEnumerable<ISyntaxNode>) syntaxNodes).AsEnumerable<ISyntaxNode>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicApiMembersNode(string parentPath, IEnumerable<ISyntaxNode> syntaxNodes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ParentPath = parentPath;
      this.syntaxNodes = syntaxNodes;
    }

    public string ParentPath
    {
      get => this.\u003CParentPath\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CParentPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    string IPublicApiNode.Path => throw new NotImplementedException();

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return this.syntaxNodes;
    }

    internal static void Q6vWcshHrTybiGs0cf81() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QSvnePhHdRPwWIQ5uqle() => PublicApiMembersNode.zd1lTRhH9Ft40UZH2ZpV == null;

    internal static PublicApiMembersNode J4cZYuhHlAEhYblBMsRr() => PublicApiMembersNode.zd1lTRhH9Ft40UZH2ZpV;
  }
}
