// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService.ExtendedReplaceUidAtPropertyMapServiceExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService
{
  /// <summary>
  /// Обёртка над сервисом-расширением для замены UID-ов в сервисе маппинга свойств
  /// для работы с первоначальными данными по маппингу при повторном вызове метода PropertyMapService.<see cref="M:EleWise.ELMA.Model.Mappings.PropertyMapService.Map(System.Object,System.Object,EleWise.ELMA.Model.Mappings.PropertyMap)" />
  /// </summary>
  internal sealed class ExtendedReplaceUidAtPropertyMapServiceExtension : 
    IReplaceUidAtPropertyMapServiceExtension
  {
    private IReplaceUidAtPropertyMapServiceExtension source;
    private static ExtendedReplaceUidAtPropertyMapServiceExtension YDIZBihhn9m1NN0VBKMo;

    /// <summary>Ctor</summary>
    /// <param name="service">Исходный сервис-расширение для замены UID-ов в сервисе маппинга</param>
    public ExtendedReplaceUidAtPropertyMapServiceExtension(
      IReplaceUidAtPropertyMapServiceExtension service)
    {
      ExtendedReplaceUidAtPropertyMapServiceExtension.fsmht0hhe0vOCYd9iWMD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.source = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public void Init(object objLeft, object objRight)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (this.source is ExtendedReplaceUidAtPropertyMapServiceExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            }
            ExtendedReplaceUidAtPropertyMapServiceExtension.mJdCekhhP01O5UvKWr0D((object) this.source, objLeft, objRight);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_5:
      return;
label_7:;
    }

    /// <inheritdoc />
    public bool GetUidReplace(Guid uid, out Guid? newUid) => this.source.GetUidReplace(uid, out newUid);

    /// <inheritdoc />
    public void EndWork()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(this.source is ExtendedReplaceUidAtPropertyMapServiceExtension))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_7;
          case 3:
            goto label_3;
          default:
            ExtendedReplaceUidAtPropertyMapServiceExtension.WqSApnhh1s0h4Vf1yRKF((object) this.source);
            num = 3;
            continue;
        }
      }
label_7:
      return;
label_3:
      return;
label_2:;
    }

    internal static void fsmht0hhe0vOCYd9iWMD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FtZieFhhOGlaXJpuu7f1() => ExtendedReplaceUidAtPropertyMapServiceExtension.YDIZBihhn9m1NN0VBKMo == null;

    internal static ExtendedReplaceUidAtPropertyMapServiceExtension b1R4M9hh25lvKlHAhF63() => ExtendedReplaceUidAtPropertyMapServiceExtension.YDIZBihhn9m1NN0VBKMo;

    internal static void mJdCekhhP01O5UvKWr0D([In] object obj0, [In] object obj1, [In] object obj2) => ((IReplaceUidAtPropertyMapServiceExtension) obj0).Init(obj1, obj2);

    internal static void WqSApnhh1s0h4Vf1yRKF([In] object obj0) => ((IReplaceUidAtPropertyMapServiceExtension) obj0).EndWork();
  }
}
