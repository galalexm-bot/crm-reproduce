// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataPublicMetadataFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  [Component]
  internal class MetadataPublicMetadataFilter : IPublicMetadataFilter
  {
    private static MetadataPublicMetadataFilter Sy620EbwS4XLcoDa4ZDw;

    /// <summary>Функция фильтрации метаданных</summary>
    public Func<IMetadata, bool> Filter => new Func<IMetadata, bool>(MetadataPublicMetadataFilter.FilterMetadata);

    private static bool FilterMetadata(object md)
    {
      int num = 4;
      EntityMetadata entityMetadata;
      Type typeByUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (typeByUid != (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 3:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 4:
            entityMetadata = md as EntityMetadata;
            num = 3;
            continue;
          default:
            typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
            continue;
        }
      }
label_7:
      // ISSUE: type reference
      return !MetadataPublicMetadataFilter.nM2H6gbwqhNx3EWpaG12(__typeref (IMetadata)).IsAssignableFrom(typeByUid);
label_8:
      return true;
    }

    public MetadataPublicMetadataFilter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type nM2H6gbwqhNx3EWpaG12([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool pjBdgVbwiIKYQUc8AGwu() => MetadataPublicMetadataFilter.Sy620EbwS4XLcoDa4ZDw == null;

    internal static MetadataPublicMetadataFilter RLDS51bwRpdynHo1PAhK() => MetadataPublicMetadataFilter.Sy620EbwS4XLcoDa4ZDw;
  }
}
