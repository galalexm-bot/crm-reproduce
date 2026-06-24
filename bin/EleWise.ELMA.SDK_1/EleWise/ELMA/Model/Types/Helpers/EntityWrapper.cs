// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.EntityWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("EntityValue")]
  public class EntityWrapper : IXsiType
  {
    internal static EntityWrapper y4UPuSbQILRyuOVNYdEP;

    [XmlElement("Id")]
    public object Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    [XmlElement("TypeUid")]
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    public EntityWrapper()
    {
      EntityWrapper.GGFkA7bQi1Jj26WVOStK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EntityWrapper(IEntity entity)
    {
      EntityWrapper.GGFkA7bQi1Jj26WVOStK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            metadata = MetadataLoader.LoadMetadata(entity.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 1;
            continue;
          case 2:
            this.TypeUid = EntityWrapper.TrNY2IbQqLUKeqZaKfMT((object) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 3:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
              continue;
            }
            goto label_8;
          case 4:
            this.Id = EntityWrapper.SW5qHPbQRmOiTm8eXdGX((object) entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_8:;
    }

    internal static bool bhnC5BbQV04roHdTNq23() => EntityWrapper.y4UPuSbQILRyuOVNYdEP == null;

    internal static EntityWrapper pljdHYbQSbdMr70nqCKt() => EntityWrapper.y4UPuSbQILRyuOVNYdEP;

    internal static void GGFkA7bQi1Jj26WVOStK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object SW5qHPbQRmOiTm8eXdGX([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static Guid TrNY2IbQqLUKeqZaKfMT([In] object obj0) => ((IMetadata) obj0).Uid;
  }
}
