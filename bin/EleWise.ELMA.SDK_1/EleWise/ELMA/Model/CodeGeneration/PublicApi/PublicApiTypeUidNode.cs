// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiTypeUidNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiTypeUidNode : IPublicApiNode
  {
    private readonly EntityMetadata entityMetadata;
    internal static PublicApiTypeUidNode myQRpgh7CjkQA9m0G15n;

    public PublicApiTypeUidNode(string parentPath, [NotNull] EntityMetadata entityMetadata)
    {
      PublicApiTypeUidNode.vWXdsWh7ZWG4ZKeHqwx7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.entityMetadata = entityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            this.ParentPath = parentPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    public string Path => (string) PublicApiTypeUidNode.gRVFEQh7IvOaOf3Itar5((object) this.ParentPath, PublicApiTypeUidNode.r09bD7h7u04chKngGoy9(~210725948 ^ -210563071));

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiTypeUidNode.\u003CGenerate\u003Ed__8(-2)
      {
        \u003C\u003E4__this = this
      };
    }

    internal static void vWXdsWh7ZWG4ZKeHqwx7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lr7o7vh7vCC9r9iNgpHB() => PublicApiTypeUidNode.myQRpgh7CjkQA9m0G15n == null;

    internal static PublicApiTypeUidNode nRoT1uh78vvGZq8iQYqC() => PublicApiTypeUidNode.myQRpgh7CjkQA9m0G15n;

    internal static object r09bD7h7u04chKngGoy9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object gRVFEQh7IvOaOf3Itar5([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
