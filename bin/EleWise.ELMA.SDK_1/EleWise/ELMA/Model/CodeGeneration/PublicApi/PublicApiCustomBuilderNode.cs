// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiCustomBuilderNode
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
  public class PublicApiCustomBuilderNode : IPublicApiNode
  {
    internal static PublicApiCustomBuilderNode R07IaPh6cFTpiX7Vemu1;

    public PublicApiCustomBuilderNode(string parentPath, Type builderType)
    {
      PublicApiCustomBuilderNode.ThvQFphHBiO0utf3vmO9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.BuilderType = builderType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
            continue;
          default:
            this.ParentPath = parentPath;
            num = 2;
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

    internal Type BuilderType
    {
      get => this.\u003CBuilderType\u003Ek__BackingField;
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
              this.\u003CBuilderType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    internal ISyntaxNode CreateBuilderExpression(
      IEnumerable<(string Name, Type Type)> parameters,
      IEnumerable<Type> availableBuilders,
      Func<Type, ISyntaxNode> builderIdentifier)
    {
      return this.BuilderType.CreateTypeSyntax().ObjectCreationExpression(parameters.Select<(string, Type), ISyntaxNode>((Func<(string, Type), ISyntaxNode>) (p => p.Name.IdentifierName())));
    }

    string IPublicApiNode.Path => throw new NotImplementedException();

    IEnumerable<ISyntaxNode> IPublicApiNode.Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      throw new NotImplementedException();
    }

    internal static void ThvQFphHBiO0utf3vmO9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GKkCuAh6zrCeE5tPSprq() => PublicApiCustomBuilderNode.R07IaPh6cFTpiX7Vemu1 == null;

    internal static PublicApiCustomBuilderNode BAYwqbhHFSbtNCxEToQH() => PublicApiCustomBuilderNode.R07IaPh6cFTpiX7Vemu1;
  }
}
