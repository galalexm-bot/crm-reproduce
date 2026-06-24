// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityViewModelDescriptorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Расширение ViewModelDescriptor для сущностей</summary>
  [Component]
  internal sealed class EntityViewModelDescriptorExtension : IViewModelDescriptorExtension
  {
    private readonly MetadataItemHeaderManager metadataItemHeaderManager;
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private static EntityViewModelDescriptorExtension nlKQtbfh3SYZFJQ0r3D5;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных сущностей</param>
    /// <param name="metadataRuntimeService">Сервис для работы с метаданными в режиме Runtime</param>
    public EntityViewModelDescriptorExtension(
      MetadataItemHeaderManager metadataItemHeaderManager,
      IMetadataRuntimeService metadataRuntimeService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.metadataItemHeaderManager = metadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          default:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public bool Check(string typeRef) => EntityViewModelDescriptorExtension.q6OIo6fhtGCjvpASCDKQ((object) typeRef, EntityViewModelDescriptorExtension.Um5qvTfhDDoJ7LAwhAE0(~541731958 ^ -542051953));

    /// <inheritdoc />
    public IMetadata GetMetadata(string typeRef)
    {
      int num = 1;
      string str;
      IMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Check(typeRef))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_5;
          case 3:
            metadataItemHeader = this.metadataItemHeaderManager.Load(EntityViewModelDescriptorExtension.atOy8Tfh4AJLU5L2pY7o((object) str));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_6;
          default:
            str = typeRef.Substring(EntityViewModelDescriptorExtension.qtEViofhwJNeGiBYPGVQ(EntityViewModelDescriptorExtension.Um5qvTfhDDoJ7LAwhAE0(381945751 ^ 1158627804 ^ 1406035021)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 3;
            continue;
        }
      }
label_5:
      return this.metadataRuntimeService.GetMetadata(EntityViewModelDescriptorExtension.ieLa6Bfh6oou0pYjUU4L((object) metadataItemHeader), false);
label_6:
      return (IMetadata) null;
    }

    internal static bool pB0F7UfhpnYftTsZKd7L() => EntityViewModelDescriptorExtension.nlKQtbfh3SYZFJQ0r3D5 == null;

    internal static EntityViewModelDescriptorExtension GLfs3ufharvrts6jN5Gf() => EntityViewModelDescriptorExtension.nlKQtbfh3SYZFJQ0r3D5;

    internal static object Um5qvTfhDDoJ7LAwhAE0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool q6OIo6fhtGCjvpASCDKQ([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static int qtEViofhwJNeGiBYPGVQ([In] object obj0) => ((string) obj0).Length;

    internal static long atOy8Tfh4AJLU5L2pY7o([In] object obj0) => long.Parse((string) obj0);

    internal static Guid ieLa6Bfh6oou0pYjUU4L([In] object obj0) => ((IMetadataItemHeader) obj0).Uid;
  }
}
