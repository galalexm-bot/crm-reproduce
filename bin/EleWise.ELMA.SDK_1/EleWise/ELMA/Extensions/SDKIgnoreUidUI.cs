// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.SDKIgnoreUidUI
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Реализация расширения, позволяющего не назначать уникальные индексы для таблиц сущностей модуля EleWise.ELMA.SDK
  /// </summary>
  [Component]
  public class SDKIgnoreUidUI : IIgnoreUidUI
  {
    private static SDKIgnoreUidUI OrHKXZG4UxtDFj1MOLwx;

    public virtual bool NeedIgnoreUid(EntityMetadata md)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SDKIgnoreUidUI.M01WZvG4zYSmpi7meD6w((object) md) == SDKIgnoreUidUI.GZApuQG6BR1rkg63YQVP(SDKIgnoreUidUI.h71wAHG6F4MbiHj97gGI(-680446928 - -370807692 ^ -309377106)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return true;
label_5:
      return false;
    }

    public SDKIgnoreUidUI()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid M01WZvG4zYSmpi7meD6w([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object h71wAHG6F4MbiHj97gGI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid GZApuQG6BR1rkg63YQVP([In] object obj0) => Guid.Parse((string) obj0);

    internal static bool wXxZorG4sCkF7X1r7CUs() => SDKIgnoreUidUI.OrHKXZG4UxtDFj1MOLwx == null;

    internal static SDKIgnoreUidUI m8qnShG4ck18RNoHEmBW() => SDKIgnoreUidUI.OrHKXZG4UxtDFj1MOLwx;
  }
}
