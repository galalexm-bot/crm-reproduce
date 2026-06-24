// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CacheQueryInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация об обращении к кэшу</summary>
  [Serializable]
  public abstract class CacheQueryInfo : AbstractCallInfo, IEmptyCallInfo
  {
    private static CacheQueryInfo J0tNu5EBfyT0wZonbHe0;

    /// <summary>Операция</summary>
    public string Operation
    {
      get => this.\u003COperation\u003Ek__BackingField;
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
              this.\u003COperation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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

    /// <summary>Регион</summary>
    public string Region
    {
      get => this.\u003CRegion\u003Ek__BackingField;
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
              this.\u003CRegion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    /// <summary>Ключ</summary>
    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
    public override string CallType => (string) CacheQueryInfo.YrThY6EB8RwxAEDR2Yec(CacheQueryInfo.aEyB2REBvcHNGhmnhBhI(-1858887263 ^ -1858631389), string.IsNullOrEmpty(this.Operation) ? (object) "" : CacheQueryInfo.YrThY6EB8RwxAEDR2Yec(CacheQueryInfo.aEyB2REBvcHNGhmnhBhI(-398663332 ^ -398656616), (object) this.Operation));

    /// <inheritdoc />
    public override string Description
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (!string.IsNullOrEmpty(this.Region))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        object obj = (object) "";
        goto label_6;
label_5:
        obj = CacheQueryInfo.GGyoXDEBZ1MBoghNW7hq((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113900257), (object) this.Region, CacheQueryInfo.aEyB2REBvcHNGhmnhBhI(~-306453669 ^ 306197556));
label_6:
        string key = this.Key;
        return (string) obj + key;
      }
    }

    /// <inheritdoc />
    public bool IsEmpty
    {
      get => this.\u003CIsEmpty\u003Ek__BackingField;
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
              this.\u003CIsEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (CacheQueryInfo.o95LdnEBubVXP1WT6DGG((object) this.Region))
              {
                num2 = 2;
                continue;
              }
              break;
            case 2:
            case 3:
              if (!CacheQueryInfo.o95LdnEBubVXP1WT6DGG((object) this.Key))
                goto case 5;
              else
                goto label_7;
            case 4:
              goto label_13;
            case 5:
              info.AddValue((string) CacheQueryInfo.aEyB2REBvcHNGhmnhBhI(--1333735954 ^ 1333761112), (object) this.Key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 2;
              continue;
            case 6:
              goto label_5;
            case 7:
              CacheQueryInfo.SNZhVdEBI4GjI09dvUru((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360079493), (object) this.Operation);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
              continue;
            case 8:
              if (!CacheQueryInfo.o95LdnEBubVXP1WT6DGG((object) this.Operation))
              {
                num2 = 7;
                continue;
              }
              goto case 1;
          }
          CacheQueryInfo.SNZhVdEBI4GjI09dvUru((object) info, CacheQueryInfo.aEyB2REBvcHNGhmnhBhI(1178210108 ^ 1178478482), (object) this.Region);
          num2 = 3;
        }
label_7:
        num1 = 6;
      }
label_13:
      return;
label_5:;
    }

    protected CacheQueryInfo()
    {
      CacheQueryInfo.v6AAjREBVpxoNqorS4Uj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YXJG7BEBQjEOp9NfPpva() => CacheQueryInfo.J0tNu5EBfyT0wZonbHe0 == null;

    internal static CacheQueryInfo zedXecEBCRALXwfCE6LN() => CacheQueryInfo.J0tNu5EBfyT0wZonbHe0;

    internal static object aEyB2REBvcHNGhmnhBhI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YrThY6EB8RwxAEDR2Yec([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object GGyoXDEBZ1MBoghNW7hq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool o95LdnEBubVXP1WT6DGG([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static void SNZhVdEBI4GjI09dvUru([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void v6AAjREBVpxoNqorS4Uj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
