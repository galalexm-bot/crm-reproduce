// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.DiagnosticsSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Настройки диагностики</summary>
  public class DiagnosticsSettings : GlobalSettingsBase
  {
    private List<EventProcessorsInfo> eventProcessorsInfos;
    internal static DiagnosticsSettings dNBaBSEWfi9KpMdCB0JM;

    /// <summary>Ctor</summary>
    public DiagnosticsSettings()
    {
      DiagnosticsSettings.AMdVisEWvbPPHlKMnXLh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.ClearStatisticsPeriod = ClearStatisticsPeriod.Never;
            num2 = 5;
            break;
          case 2:
            goto label_3;
          case 3:
            this.Enabled = false;
            num2 = 6;
            break;
          case 4:
            this.ClearOldReports = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
            continue;
          case 5:
            this.CountersEnabled = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 7;
            continue;
          case 6:
            this.ExportReports = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 7:
            this.eventProcessorsInfos = new List<EventProcessorsInfo>();
            num2 = 4;
            break;
          default:
            this.ExportReportPeriod = 1440;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
            continue;
        }
        num1 = num2;
      }
label_3:;
    }

    /// <summary>Включена ли диагностика</summary>
    [BoolSettings(DisplayType = BoolDisplayType.Switch)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "Enabled")]
    public bool Enabled
    {
      get => this.\u003CEnabled\u003Ek__BackingField;
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
              this.\u003CEnabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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

    /// <summary>Формировать отчеты автоматически</summary>
    [BoolSettings(DisplayType = BoolDisplayType.Switch)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "ExportReports")]
    public bool ExportReports
    {
      get => this.\u003CExportReports\u003Ek__BackingField;
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
              this.\u003CExportReports\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    /// <summary>
    /// Чистить старые отчеты автоматически, старше заданного значения (в часах, 0 - не чистить)
    /// </summary>
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "ClearOldReports")]
    public int ClearOldReports
    {
      get => this.\u003CClearOldReports\u003Ek__BackingField;
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
              this.\u003CClearOldReports\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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

    /// <summary>
    /// Период автоматического формирования отчетов (в минутах)
    /// </summary>
    [Int32Settings(MinValue = 0, MaxValue = 1440)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "ExportReportPeriod")]
    public int ExportReportPeriod
    {
      get => this.\u003CExportReportPeriod\u003Ek__BackingField;
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
              this.\u003CExportReportPeriod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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

    /// <summary>
    /// Начальное время для автоматического формирования отчетов
    /// </summary>
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "ExportReportStartTime")]
    [DateTimeSettings(ShowDate = false, ShowTime = true)]
    public DateTime ExportReportStartTime
    {
      get => this.\u003CExportReportStartTime\u003Ek__BackingField;
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
              this.\u003CExportReportStartTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Период обнуления статистики</summary>
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "ClearStatisticsPeriod")]
    public ClearStatisticsPeriod ClearStatisticsPeriod
    {
      get => this.\u003CClearStatisticsPeriod\u003Ek__BackingField;
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
              this.\u003CClearStatisticsPeriod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    /// <summary>Включен ли журнал</summary>
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "LogsEnabled")]
    [BoolSettings(DisplayType = BoolDisplayType.Switch)]
    public bool LogsEnabled
    {
      get => this.\u003CLogsEnabled\u003Ek__BackingField;
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
              this.\u003CLogsEnabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>Настройки обработчиков событий диагностики</summary>
    [HiddenInput(DisplayValue = false)]
    public IList<EventProcessorsInfo> EventProcessorsInfos => (IList<EventProcessorsInfo>) this.eventProcessorsInfos;

    /// <summary>
    /// Сериализованное представление настроек обработчиков событий диагностики, предназначенное для сохранения в БД
    /// </summary>
    public string SerializedEventProcessorsInfos
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.eventProcessorsInfos == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_8;
          }
        }
label_4:
        string separator = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210712801);
        List<EventProcessorsInfo> eventProcessorsInfos = this.eventProcessorsInfos;
        Func<EventProcessorsInfo, string> func = DiagnosticsSettings.\u003C\u003Ec.\u003C\u003E9__32_0;
        Func<EventProcessorsInfo, string> selector;
        if (func == null)
          DiagnosticsSettings.\u003C\u003Ec.\u003C\u003E9__32_0 = selector = (Func<EventProcessorsInfo, string>) (i => ClassSerializationHelper.SerializeObjectByXml((object) i));
        else
          goto label_5;
label_7:
        IEnumerable<string> values = eventProcessorsInfos.Select<EventProcessorsInfo, string>(selector);
        return string.Join(separator, values);
label_5:
        selector = func;
        goto label_7;
label_8:
        return string.Empty;
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_8;
            case 1:
              this.eventProcessorsInfos = new List<EventProcessorsInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 4;
              continue;
            case 2:
              object source = DiagnosticsSettings.VNaFDmEWu6fYpb7q5Gpf((object) value, (object) new string[1]
              {
                (string) DiagnosticsSettings.yVIEpTEWZO6DLihAiE58(-1426456882 ^ 2009939514 ^ -583756760)
              }, StringSplitOptions.RemoveEmptyEntries);
              Func<string, EventProcessorsInfo> func = DiagnosticsSettings.\u003C\u003Ec.\u003C\u003E9__33_0;
              Func<string, EventProcessorsInfo> selector;
              if (func == null)
                DiagnosticsSettings.\u003C\u003Ec.\u003C\u003E9__33_0 = selector = (Func<string, EventProcessorsInfo>) (i => ClassSerializationHelper.DeserializeObjectByXml<EventProcessorsInfo>(i));
              else
                goto label_11;
label_10:
              this.eventProcessorsInfos = ((IEnumerable<string>) source).Select<string, EventProcessorsInfo>(selector).ToList<EventProcessorsInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
label_11:
              selector = func;
              goto label_10;
            case 3:
              if (!DiagnosticsSettings.qpxgxSEW8aGHshoxNsWk((object) value))
              {
                num = 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_8:
        return;
label_6:
        return;
label_5:;
      }
    }

    /// <summary>Инициализация настроек EventProcessorsInfos</summary>
    public void InitEventProcessorsInfos()
    {
      int num1 = 2;
      DiagnosticsSettings diagnosticsSettings;
      List<IDiagnosticsEventProcessor> storages;
      while (true)
      {
        switch (num1)
        {
          case 1:
            diagnosticsSettings = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
            continue;
          case 3:
            storages.ForEach((Action<IDiagnosticsEventProcessor>) (s =>
            {
              int num2 = 2;
              IDiagnosticsEventProcessor s1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_6;
                  case 1:
                    s1 = s;
                    num2 = 5;
                    continue;
                  case 2:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                    continue;
                  case 3:
                    goto label_2;
                  case 4:
                    List<EventProcessorsInfo> eventProcessorsInfos = diagnosticsSettings.eventProcessorsInfos;
                    EventProcessorsInfo eventProcessorsInfo = new EventProcessorsInfo();
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_0.hRssJ18VrXMdkR2XTIeL((object) eventProcessorsInfo, DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_0.dR15re8Vlsli6qmSc8jj((object) s1));
                    // ISSUE: reference to a compiler-generated method
                    DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_0.t8hkeP8VgGd0LejbJDCD((object) eventProcessorsInfo, false);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_0.KVJUmr8VjTh9k15Y6aEN((object) eventProcessorsInfo, DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_0.rQ5A9k8V547qUwBTXYfk((object) s1));
                    eventProcessorsInfos.Add(eventProcessorsInfo);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!diagnosticsSettings.eventProcessorsInfos.All<EventProcessorsInfo>((Func<EventProcessorsInfo, bool>) (i => DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_1.wpspxg8Vzxf7wT2jWlhi(DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_1.sh0GCM8VscwfoIHpirdN((object) i), DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_1.cO5qnA8Vc9d6o4VZgB6B((object) s1)))))
                    {
                      num2 = 3;
                      continue;
                    }
                    goto case 4;
                  default:
                    goto label_9;
                }
              }
label_6:
              return;
label_2:
              return;
label_9:;
            }));
            num1 = 4;
            continue;
          case 4:
            this.eventProcessorsInfos.RemoveAll((Predicate<EventProcessorsInfo>) (i =>
            {
              int num3 = 2;
              EventProcessorsInfo i1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    i1 = i;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return storages.All<IDiagnosticsEventProcessor>((Func<IDiagnosticsEventProcessor, bool>) (s => DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_2.eFlhD08SGmnfq34VhuSo(DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_2.SGmdsY8SbmHNJnpJWN3P((object) s), DiagnosticsSettings.\u003C\u003Ec__DisplayClass34_2.n78N1D8ShXXAby7paKKl((object) i1))));
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 5;
            continue;
          case 5:
            goto label_2;
          default:
            storages = ((ComponentManager) DiagnosticsSettings.xDPgiCEWIu0LlWOj6Ggh()).GetExtensionPoints<IDiagnosticsEventProcessor>().ToList<IDiagnosticsEventProcessor>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Уровень детализации журнала</summary>
    [Obsolete("Свойство устарело и больше не используется", true)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "LogLevel")]
    public EleWise.ELMA.Logging.LogLevel LogLevel
    {
      get => this.\u003CLogLevel\u003Ek__BackingField;
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
              this.\u003CLogLevel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>Использовать счетчики производительности</summary>
    [BoolSettings(DisplayType = BoolDisplayType.Switch)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "CountersEnabled")]
    public bool CountersEnabled
    {
      get => this.\u003CCountersEnabled\u003Ek__BackingField;
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
              this.\u003CCountersEnabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Включен ли Glimpse</summary>
    [BoolSettings(DisplayType = BoolDisplayType.Switch)]
    [DisplayName(typeof (DiagnosticsSettings.__Resources_DiagnosticsSettings), "GlimpseDiagnostic")]
    public bool GlimpseDiagnostic
    {
      get => this.\u003CGlimpseDiagnostic\u003Ek__BackingField;
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
              this.\u003CGlimpseDiagnostic\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    internal static void AMdVisEWvbPPHlKMnXLh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tLvtOTEWQhPbehO6ukRx() => DiagnosticsSettings.dNBaBSEWfi9KpMdCB0JM == null;

    internal static DiagnosticsSettings o0LaUVEWCNBEETJ3k8Y0() => DiagnosticsSettings.dNBaBSEWfi9KpMdCB0JM;

    internal static bool qpxgxSEW8aGHshoxNsWk([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object yVIEpTEWZO6DLihAiE58(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VNaFDmEWu6fYpb7q5Gpf([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object xDPgiCEWIu0LlWOj6Ggh() => (object) ComponentManager.Current;

    internal class __Resources_DiagnosticsSettings
    {
      private static DiagnosticsSettings.__Resources_DiagnosticsSettings EMgdjd8VwZvGYCv4rNvo;

      public static string Enabled => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-1146510045 ^ -1146324831));

      public static string ExportReports => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-342626196 - 1290888215 ^ -1633201695));

      public static string ClearOldReports => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-1317790512 ^ -1317945048));

      public static string ExportReportPeriod => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-16752921 ^ -16416693));

      public static string ExportReportStartTime => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(--1333735954 ^ 1333456116));

      public static string ClearStatisticsPeriod => EleWise.ELMA.SR.T((string) DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-1998538950 ^ -1998231098));

      public static string LogsEnabled => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(1304605005 ^ 1304915579));

      public static string LogLevel => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-1334993905 ^ -1335344301));

      public static string CountersEnabled => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283230541));

      public static string GlimpseDiagnostic => (string) DiagnosticsSettings.__Resources_DiagnosticsSettings.TpGnRM8VAwbL8vf7FPUW(DiagnosticsSettings.__Resources_DiagnosticsSettings.U1o6DW8VHVIdNaBhWEc0(-1146510045 ^ -1146324279));

      public __Resources_DiagnosticsSettings()
      {
        DiagnosticsSettings.__Resources_DiagnosticsSettings.a9j3Fy8V7ByApXxoghMG();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object U1o6DW8VHVIdNaBhWEc0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object TpGnRM8VAwbL8vf7FPUW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool FUZhpu8V4vigrw4ZVMro() => DiagnosticsSettings.__Resources_DiagnosticsSettings.EMgdjd8VwZvGYCv4rNvo == null;

      internal static DiagnosticsSettings.__Resources_DiagnosticsSettings fMRLAA8V6aSO6iGcNrhf() => DiagnosticsSettings.__Resources_DiagnosticsSettings.EMgdjd8VwZvGYCv4rNvo;

      internal static void a9j3Fy8V7ByApXxoghMG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
