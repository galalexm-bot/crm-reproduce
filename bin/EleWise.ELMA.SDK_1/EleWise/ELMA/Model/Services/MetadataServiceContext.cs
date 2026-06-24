// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.MetadataServiceContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Контекст для работы с сервисами метаданных (в режиме Run-time и Design-time)
  /// </summary>
  public class MetadataServiceContext : IDisposable
  {
    private static AsyncLocal<IMetadataService> currentService;
    private IMetadataService _previousService;
    private static IMetadataEditorService _metadataEditorService;
    private static IMetadataRuntimeService _metadataRuntimeService;
    private static MetadataServiceContext TdA0FhbZNUH66ZDpembH;

    /// <summary>Создать контекст с указанной реализацией сервиса</summary>
    /// <param name="service"></param>
    public MetadataServiceContext(IMetadataService service)
    {
      MetadataServiceContext.VnemkDbZaZQWSAwC1vTx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            MetadataServiceContext.currentService.Value = service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
          default:
            this._previousService = MetadataServiceContext.currentService.Value;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уничтожить контекст (вернуться к предыдущему)</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataServiceContext.currentService.Value = this._previousService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Очистка инъекции, для тестирования</summary>
    internal static void ClearInjections()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataServiceContext._metadataEditorService = (IMetadataEditorService) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MetadataServiceContext._metadataRuntimeService = (IMetadataRuntimeService) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать контекст с указанным типом реализации сервиса</summary>
    /// <typeparam name="TService">Тип реализации сервиса</typeparam>
    /// <returns>Контекст</returns>
    public static MetadataServiceContext New<TService>() where TService : IMetadataService => new MetadataServiceContext((IMetadataService) Locator.GetServiceNotNull<TService>());

    /// <summary>Текущий сервис</summary>
    [NotNull]
    public static IMetadataService Service => MetadataServiceContext.ServiceOrNull ?? throw new ServiceNotFoundException((string) MetadataServiceContext.Jayw0UbZDNbAKYN3feOW(-1426456882 ^ 2009939514 ^ -583633400));

    [NotNull]
    public static IMetadataEditorService MetadataEditorService => (IMetadataEditorService) (MetadataServiceContext.U4DrDSbZtcohv1RJnrWj() ?? throw new ServiceNotFoundException((string) MetadataServiceContext.Jayw0UbZDNbAKYN3feOW(1304605005 ^ 1304430189)));

    [NotNull]
    public static IMetadataRuntimeService MetadataRuntimeService => (IMetadataRuntimeService) (MetadataServiceContext.zC4FdCbZwXQcRtAAj13r() ?? throw new ServiceNotFoundException((string) MetadataServiceContext.Jayw0UbZDNbAKYN3feOW(-1146510045 ^ -1146416525)));

    /// <summary>Текущий сервис. Или null - если не найден ни один</summary>
    [CanBeNull]
    public static IMetadataService ServiceOrNull
    {
      get
      {
        int num1 = 7;
        IMetadataService serviceOrNull1;
        IMetadataService serviceOrNull2;
        IMetadataService serviceOrNull3;
        IMetadataService serviceOrNull4;
        while (true)
        {
          int num2 = num1;
          IMetadataService metadataService;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_20;
              case 2:
                metadataService = (IMetadataService) MetadataServiceContext.zC4FdCbZwXQcRtAAj13r();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                continue;
              case 3:
                metadataService = (IMetadataService) MetadataServiceContext.U4DrDSbZtcohv1RJnrWj();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 5;
                continue;
              case 4:
                metadataService = (IMetadataService) MetadataServiceContext._metadataEditorService;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 10 : 6;
                continue;
              case 5:
                serviceOrNull2 = metadataService;
                if (serviceOrNull2 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                  continue;
                }
                goto label_18;
              case 6:
                goto label_9;
              case 7:
                if (MetadataServiceContext.currentService.Value != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 6 : 2;
                  continue;
                }
                if (MetadataServiceContext.gPgrpfbZ4NFRc4xWWcJO())
                {
                  metadataService = (IMetadataService) MetadataServiceContext._metadataRuntimeService;
                  num2 = 8;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 8;
                continue;
              case 8:
                serviceOrNull3 = metadataService;
                if (serviceOrNull3 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 4;
                  continue;
                }
                goto label_21;
              case 9:
                goto label_5;
              case 10:
                serviceOrNull4 = metadataService;
                if (serviceOrNull4 == null)
                {
                  num2 = 2;
                  continue;
                }
                goto label_24;
              default:
                goto label_23;
            }
          }
label_20:
          serviceOrNull1 = metadataService;
          if (serviceOrNull1 == null)
            num1 = 3;
          else
            goto label_25;
        }
label_5:
        return (IMetadataService) null;
label_21:
        return serviceOrNull3;
label_9:
        return MetadataServiceContext.currentService.Value;
label_18:
        return serviceOrNull2;
label_24:
        return serviceOrNull4;
label_25:
        return serviceOrNull1;
label_23:
        return Locator.GetService<IMetadataService>();
      }
    }

    [CanBeNull]
    public static IMetadataEditorService MetadataEditorServiceOrNull
    {
      get
      {
        int num = 1;
        IMetadataEditorService metadataEditorService;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadataEditorService = MetadataServiceContext._metadataEditorService;
              if (metadataEditorService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return metadataEditorService;
label_5:
        return MetadataServiceContext._metadataEditorService = Locator.GetService<IMetadataEditorService>();
      }
    }

    [CanBeNull]
    public static IMetadataRuntimeService MetadataRuntimeServiceOrNull
    {
      get
      {
        int num = 1;
        IMetadataRuntimeService metadataRuntimeService;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadataRuntimeService = MetadataServiceContext._metadataRuntimeService;
              if (metadataRuntimeService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return metadataRuntimeService;
label_5:
        return MetadataServiceContext._metadataRuntimeService = Locator.GetService<IMetadataRuntimeService>();
      }
    }

    /// <summary>Расширить текущий контекст метаданных</summary>
    /// <param name="metadataList">Дополнительные метаданные</param>
    /// <returns>Новый контекст</returns>
    /// <example>
    /// Пример использования
    /// <code>
    /// using (MetadataServiceContext.Extend(metadataList))
    /// {
    ///     ...
    /// }
    /// </code>
    /// </example>
    public static MetadataServiceContext Extend(IEnumerable<IMetadata> metadataList) => new MetadataServiceContext((IMetadataService) new ExtendedMetadataService(MetadataServiceContext.Service, metadataList));

    static MetadataServiceContext()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataServiceContext.currentService = new AsyncLocal<IMetadataService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void VnemkDbZaZQWSAwC1vTx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool k9CI0JbZ3Nr3YgSVFr5m() => MetadataServiceContext.TdA0FhbZNUH66ZDpembH == null;

    internal static MetadataServiceContext tTVPwCbZpP0tFmGFbLQM() => MetadataServiceContext.TdA0FhbZNUH66ZDpembH;

    internal static object Jayw0UbZDNbAKYN3feOW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object U4DrDSbZtcohv1RJnrWj() => (object) MetadataServiceContext.MetadataEditorServiceOrNull;

    internal static object zC4FdCbZwXQcRtAAj13r() => (object) MetadataServiceContext.MetadataRuntimeServiceOrNull;

    internal static bool gPgrpfbZ4NFRc4xWWcJO() => Locator.Initialized;
  }
}
