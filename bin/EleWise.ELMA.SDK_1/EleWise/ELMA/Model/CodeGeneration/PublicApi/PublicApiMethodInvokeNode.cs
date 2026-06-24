// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiMethodInvokeNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiMethodInvokeNode : IPublicApiNode
  {
    private readonly ISyntaxNode targetObjectExpression;
    private readonly TypeArgument[] typeArguments;
    internal static PublicApiMethodInvokeNode uEqoDQhHgL4GySZtVhbg;

    public PublicApiMethodInvokeNode(
      string parentPath,
      MethodInfo methodInfo,
      ISyntaxNode targetObjectExpression,
      params TypeArgument[] typeArguments)
    {
      PublicApiMethodInvokeNode.ApBLNthHYyVDZhdxPwOt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.targetObjectExpression = targetObjectExpression;
            num = 2;
            continue;
          case 2:
            this.typeArguments = typeArguments;
            num = 4;
            continue;
          case 3:
            this.MethodInfo = methodInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
            continue;
          case 4:
            goto label_3;
          default:
            this.ParentPath = parentPath;
            num = 3;
            continue;
        }
      }
label_3:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    public MethodInfo MethodInfo
    {
      get => this.\u003CMethodInfo\u003Ek__BackingField;
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
              this.\u003CMethodInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiMethodInvokeNode.\u003CGenerate\u003Ed__13(-2)
      {
        \u003C\u003E4__this = this
      };
    }

    internal static void ApBLNthHYyVDZhdxPwOt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EB11vuhH5cSYesg1CJsY() => PublicApiMethodInvokeNode.uEqoDQhHgL4GySZtVhbg == null;

    internal static PublicApiMethodInvokeNode SL0qUEhHj1yIR5rovuml() => PublicApiMethodInvokeNode.uEqoDQhHgL4GySZtVhbg;
  }
}
