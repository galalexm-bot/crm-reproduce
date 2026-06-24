// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CounterInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Данные счётчика</summary>
  internal sealed class CounterInfo
  {
    internal static CounterInfo FErSslGzbgNpxlvhVrMh;

    /// <summary>Тип счётчика</summary>
    public PerformanceCounterType CounterType
    {
      get => this.\u003CCounterType\u003Ek__BackingField;
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
              this.\u003CCounterType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Имя счётчика</summary>
    public string CounterName
    {
      get => this.\u003CCounterName\u003Ek__BackingField;
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
              this.\u003CCounterName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

    /// <summary>Описание счётчика</summary>
    public string CounterHelp
    {
      get => this.\u003CCounterHelp\u003Ek__BackingField;
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
              this.\u003CCounterHelp\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
    /// Конвертировать из <see cref="T:System.Diagnostics.CounterCreationData" />
    /// </summary>
    /// <param name="counter">Данные счётчика</param>
    public static CounterInfo From(CounterCreationData counter)
    {
      CounterInfo counterInfo = new CounterInfo();
      CounterInfo.Hlgd7rGzfCfRSx73Ewou((object) counterInfo, CounterInfo.L7yQxCGzEsMC9HX6tkki((object) counter));
      CounterInfo.Cr4w0nGzCDvov5Bpj14t((object) counterInfo, CounterInfo.uIINf0GzQbEScYnl7V3V((object) counter));
      CounterInfo.xhouRdGz8xtRYjLPyhHs((object) counterInfo, CounterInfo.zMJvsfGzvCObjEHMOimi((object) counter));
      return counterInfo;
    }

    public CounterInfo()
    {
      CounterInfo.gRSKZMGzZFEUkWAHLcOh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool un66wgGzhTxWuggRXIdY() => CounterInfo.FErSslGzbgNpxlvhVrMh == null;

    internal static CounterInfo JVZDniGzGyqWTXG7rPGa() => CounterInfo.FErSslGzbgNpxlvhVrMh;

    internal static object L7yQxCGzEsMC9HX6tkki([In] object obj0) => (object) ((CounterCreationData) obj0).CounterHelp;

    internal static void Hlgd7rGzfCfRSx73Ewou([In] object obj0, [In] object obj1) => ((CounterInfo) obj0).CounterHelp = (string) obj1;

    internal static object uIINf0GzQbEScYnl7V3V([In] object obj0) => (object) ((CounterCreationData) obj0).CounterName;

    internal static void Cr4w0nGzCDvov5Bpj14t([In] object obj0, [In] object obj1) => ((CounterInfo) obj0).CounterName = (string) obj1;

    internal static PerformanceCounterType zMJvsfGzvCObjEHMOimi([In] object obj0) => ((CounterCreationData) obj0).CounterType;

    internal static void xhouRdGz8xtRYjLPyhHs([In] object obj0, PerformanceCounterType value) => ((CounterInfo) obj0).CounterType = value;

    internal static void gRSKZMGzZFEUkWAHLcOh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
