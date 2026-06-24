// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CacheReadInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о чтении из кэша</summary>
  [Serializable]
  public class CacheReadInfo : CacheQueryInfo
  {
    private static CacheReadInfo OcZkW5EBSRSNFBKpYaW8;

    /// <summary>Ctor</summary>
    public CacheReadInfo()
    {
      CacheReadInfo.oQm334EBqYDNdZPLbs0C();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Operation = (string) CacheReadInfo.znKF79EBK4ur7WIcaq4v(1304605005 ^ 1304861171);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Найдено ли значение</summary>
    public bool Success
    {
      get => this.\u003CSuccess\u003Ek__BackingField;
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
              this.\u003CSuccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.GetObjectData(info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CacheReadInfo.VIdG9cEBXKt45juZXWNn((object) info, CacheReadInfo.znKF79EBK4ur7WIcaq4v(647913418 ^ 647657216), this.Success);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void oQm334EBqYDNdZPLbs0C() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object znKF79EBK4ur7WIcaq4v(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Wdt7vLEBialO89j0wCIf() => CacheReadInfo.OcZkW5EBSRSNFBKpYaW8 == null;

    internal static CacheReadInfo vwZvNGEBRlKSa2DLEfpw() => CacheReadInfo.OcZkW5EBSRSNFBKpYaW8;

    internal static void VIdG9cEBXKt45juZXWNn([In] object obj0, [In] object obj1, [In] bool obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
