// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService.ReplaceUidAtPropertyMapServiceContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService
{
  /// <summary>
  /// Контекст для работы с сервисом расширением для замены UID-ов в сервисе маппинга<see cref="T:EleWise.ELMA.Model.Mappings.PropertyMapService" />
  /// </summary>
  internal sealed class ReplaceUidAtPropertyMapServiceContext : IDisposable
  {
    [ThreadStatic]
    private static IReplaceUidAtPropertyMapServiceExtension currentService;
    private readonly IReplaceUidAtPropertyMapServiceExtension previousService;
    private static IReplaceUidAtPropertyMapServiceExtension stub;
    internal static ReplaceUidAtPropertyMapServiceContext O98htChhaS3y6jBAqxyi;

    /// <summary>Ctor</summary>
    /// <param name="service">Исходный сервис-расширение для замены UID-ов в сервисе маппинга</param>
    public ReplaceUidAtPropertyMapServiceContext(IReplaceUidAtPropertyMapServiceExtension service)
    {
      ReplaceUidAtPropertyMapServiceContext.R33LLshhw0T6ZgbKoKvg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.previousService = ReplaceUidAtPropertyMapServiceContext.currentService;
            num = 2;
            continue;
          case 2:
            ReplaceUidAtPropertyMapServiceContext.currentService = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Уничтожить контекст (вернуться к предыдущему)</summary>
    public void Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ReplaceUidAtPropertyMapServiceContext.currentService = this.previousService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            ReplaceUidAtPropertyMapServiceContext.UpiLSChh4qH0YxIygRFB((object) ReplaceUidAtPropertyMapServiceContext.currentService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Текущий сервис</summary>
    [NotNull]
    public static IReplaceUidAtPropertyMapServiceExtension Service => ReplaceUidAtPropertyMapServiceContext.ServiceOrNull ?? throw new ServiceNotFoundException((string) ReplaceUidAtPropertyMapServiceContext.UWkInJhh6UiHAEqjo9Iy(-281842504 ^ -282048256));

    /// <summary>
    /// Расширить текущий контекст для замены UID-ов в сервисе маппинга
    /// </summary>
    /// <param name="objLeft">Объект маппинга ИЗ</param>
    /// <param name="objRight">Объект маппинга В</param>
    /// <returns>Новый контекст</returns>
    /// <example>
    /// Пример использования
    /// <code>
    /// using (ReplaceUidAtPropertyMapServiceContext.Extend(objLeft, objRight))
    /// {
    ///     ...
    /// }
    /// </code>
    /// </example>
    public static ReplaceUidAtPropertyMapServiceContext Extend(object objLeft, object objRight)
    {
      ExtendedReplaceUidAtPropertyMapServiceExtension service = new ExtendedReplaceUidAtPropertyMapServiceExtension((IReplaceUidAtPropertyMapServiceExtension) ReplaceUidAtPropertyMapServiceContext.qGqB9uhhHj5rman6jgXC());
      ReplaceUidAtPropertyMapServiceContext.YGKymfhhAndOPGIrCpsb((object) service, objLeft, objRight);
      return new ReplaceUidAtPropertyMapServiceContext((IReplaceUidAtPropertyMapServiceExtension) service);
    }

    /// <summary>Текущий сервис. Или null - если не найден ни один</summary>
    [CanBeNull]
    private static IReplaceUidAtPropertyMapServiceExtension ServiceOrNull
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ReplaceUidAtPropertyMapServiceContext.currentService != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              }
              if (!ReplaceUidAtPropertyMapServiceContext.a0hZurhh7FSWJYO2VlSf())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_4:
        return (IReplaceUidAtPropertyMapServiceExtension) null;
label_5:
        return (IReplaceUidAtPropertyMapServiceExtension) ReplaceUidAtPropertyMapServiceContext.gUNnFmhhxa7fLvUUFJpx();
label_6:
        return ReplaceUidAtPropertyMapServiceContext.currentService;
      }
    }

    /// <summary>
    /// Сервис-расширение для замены UID-ов в сервисе маппинга <see cref="T:EleWise.ELMA.Model.Mappings.PropertyMapService" />
    /// </summary>
    private static IReplaceUidAtPropertyMapServiceExtension ReplaceUidServiceOrNull
    {
      get
      {
        int num = 1;
        IReplaceUidAtPropertyMapServiceExtension service;
        while (true)
        {
          switch (num)
          {
            case 1:
              service = Locator.GetService<IReplaceUidAtPropertyMapServiceExtension>();
              if (service == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return service;
label_5:
        return ReplaceUidAtPropertyMapServiceContext.Stub;
      }
    }

    /// <summary>Заглушка</summary>
    private static IReplaceUidAtPropertyMapServiceExtension Stub
    {
      get
      {
        int num = 1;
        IReplaceUidAtPropertyMapServiceExtension stub;
        while (true)
        {
          switch (num)
          {
            case 1:
              stub = ReplaceUidAtPropertyMapServiceContext.stub;
              if (stub == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return stub;
label_5:
        return ReplaceUidAtPropertyMapServiceContext.stub = (IReplaceUidAtPropertyMapServiceExtension) new ReplaceUidAtPropertyMapServiceStub();
      }
    }

    internal static void R33LLshhw0T6ZgbKoKvg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ROQwjMhhDe7AELOEyHh7() => ReplaceUidAtPropertyMapServiceContext.O98htChhaS3y6jBAqxyi == null;

    internal static ReplaceUidAtPropertyMapServiceContext w5VVfvhht3I0U940cgiQ() => ReplaceUidAtPropertyMapServiceContext.O98htChhaS3y6jBAqxyi;

    internal static void UpiLSChh4qH0YxIygRFB([In] object obj0) => ((IReplaceUidAtPropertyMapServiceExtension) obj0).EndWork();

    internal static object UWkInJhh6UiHAEqjo9Iy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qGqB9uhhHj5rman6jgXC() => (object) ReplaceUidAtPropertyMapServiceContext.Service;

    internal static void YGKymfhhAndOPGIrCpsb([In] object obj0, [In] object obj1, [In] object obj2) => ((ExtendedReplaceUidAtPropertyMapServiceExtension) obj0).Init(obj1, obj2);

    internal static bool a0hZurhh7FSWJYO2VlSf() => Locator.Initialized;

    internal static object gUNnFmhhxa7fLvUUFJpx() => (object) ReplaceUidAtPropertyMapServiceContext.ReplaceUidServiceOrNull;
  }
}
