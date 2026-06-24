// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiCreateFilterHelperMethodNode
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
  public class PublicApiCreateFilterHelperMethodNode : IPublicApiNode
  {
    private readonly EntityMetadata entityMetadata;
    private readonly string displayName;
    private readonly bool skipExample;
    internal static PublicApiCreateFilterHelperMethodNode Fu84cih6lgI3QYNyTTP7;

    public PublicApiCreateFilterHelperMethodNode(
      string parentPath,
      [NotNull] EntityMetadata entityMetadata,
      bool skipExample = false)
    {
      PublicApiCreateFilterHelperMethodNode.GyTfYvh65kWBJGjPN806();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.displayName = SR.T((string) PublicApiCreateFilterHelperMethodNode.TmwbPBh6jSHqb14H1poy((object) entityMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 4;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.ParentPath = parentPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          case 4:
            if (PublicApiCreateFilterHelperMethodNode.USsyQUh6YD09XINdHmAf((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
            {
              num = 5;
              continue;
            }
            goto case 6;
          case 5:
            entityMetadata = (EntityMetadata) ((PublicApiCodeGenerator) PublicApiCreateFilterHelperMethodNode.aakVD0h6LMUpg7pKboZu()).GetMetadata(entityMetadata.BaseClassUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 6;
            continue;
          case 6:
            this.entityMetadata = entityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            this.skipExample = skipExample;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    public string Path => (string) PublicApiCreateFilterHelperMethodNode.U8ErN8h6sKbJ1k40CVhh((object) this.ParentPath, PublicApiCreateFilterHelperMethodNode.MMAxQwh6UQykndgnqSA0(-1939377524 ^ -1939602396));

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiCreateFilterHelperMethodNode.\u003CGenerate\u003Ed__10(-2)
      {
        \u003C\u003E4__this = this
      };
    }

    internal static void GyTfYvh65kWBJGjPN806() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object TmwbPBh6jSHqb14H1poy([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static EntityMetadataType USsyQUh6YD09XINdHmAf([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static object aakVD0h6LMUpg7pKboZu() => (object) PublicApiCodeGenerator.Current;

    internal static bool DNpSJhh6r2TnXsJJ9U4F() => PublicApiCreateFilterHelperMethodNode.Fu84cih6lgI3QYNyTTP7 == null;

    internal static PublicApiCreateFilterHelperMethodNode Ve9o4Zh6g0Fvi1DshIL6() => PublicApiCreateFilterHelperMethodNode.Fu84cih6lgI3QYNyTTP7;

    internal static object MMAxQwh6UQykndgnqSA0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object U8ErN8h6sKbJ1k40CVhh([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
