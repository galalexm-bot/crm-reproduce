// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.RootMetadataComparer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// <see cref="!:IEqualityComparer&lt;&gt;" /> для <see cref="T:EleWise.ELMA.Model.Metadata.IRootMetadata" />, сравнивающий по уникальному идентификатору метаданных
  /// </summary>
  public class RootMetadataComparer : IEqualityComparer<IRootMetadata>
  {
    internal static RootMetadataComparer IlfDG8b3vEkLUv46K0nm;

    /// <summary>Экземпляр</summary>
    public static IEqualityComparer<IRootMetadata> Instance { get; }

    private RootMetadataComparer()
    {
      RootMetadataComparer.mhL8JWb3u6q6PMf4K1AB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    bool IEqualityComparer<IRootMetadata>.Equals(IRootMetadata x, IRootMetadata y) => RootMetadataComparer.QsP8RYb3VY2Q2qCVPdgT(RootMetadataComparer.FxyeCIb3IDorp9KXsANd((object) x), y.Uid);

    int IEqualityComparer<IRootMetadata>.GetHashCode(IRootMetadata obj)
    {
      int num = 1;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            guid = RootMetadataComparer.FxyeCIb3IDorp9KXsANd((object) obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return guid.GetHashCode();
    }

    static RootMetadataComparer()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RootMetadataComparer.Instance = (IEqualityComparer<IRootMetadata>) new RootMetadataComparer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            RootMetadataComparer.mhL8JWb3u6q6PMf4K1AB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void mhL8JWb3u6q6PMf4K1AB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DkGndfb38UyA9KW0dSTN() => RootMetadataComparer.IlfDG8b3vEkLUv46K0nm == null;

    internal static RootMetadataComparer EmlokGb3ZNFNHCbg7bOk() => RootMetadataComparer.IlfDG8b3vEkLUv46K0nm;

    internal static Guid FxyeCIb3IDorp9KXsANd([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool QsP8RYb3VY2Q2qCVPdgT([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
