// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.FindViewInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о поиске представления</summary>
  [DiagnosticEvents(StartEvent = typeof (FindViewStartEvent), EndEvent = typeof (FindViewEndEvent))]
  [Serializable]
  public class FindViewInfo : AbstractCallInfo, IEmptyCallInfo
  {
    private static FindViewInfo q7PNKeEFOeDmqFkVZoPY;

    /// <summary>Ctor</summary>
    public FindViewInfo()
    {
      FindViewInfo.PQfGwsEFPw5BRtBHm5pA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="controllerContext">Контекст контроллера</param>
    /// <param name="viewName">Название представления</param>
    /// <param name="masterName">Основное название</param>
    /// <param name="searchedLocations">Пути поиска</param>
    /// <param name="isFound">Представление найдено</param>
    /// <param name="useCache">Используется кеш</param>
    /// <param name="isPartial">Частичное</param>
    public FindViewInfo(
      ControllerContext controllerContext,
      string viewName,
      string masterName,
      IEnumerable<string> searchedLocations,
      bool isFound,
      bool useCache,
      bool isPartial)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ControllerContext = controllerContext;
      this.ViewContext = controllerContext.ParentActionViewContext;
      this.ViewName = viewName;
      this.MasterName = masterName;
      this.SearchedLocations = searchedLocations;
      this.IsFound = isFound;
      this.UseCache = useCache;
      this.IsPartial = isPartial;
    }

    /// <summary>Результат поиска представления</summary>
    public ViewEngineResult ViewEngineResult
    {
      get => this.\u003CViewEngineResult\u003Ek__BackingField;
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
              this.\u003CViewEngineResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Контекст контроллера</summary>
    public ControllerContext ControllerContext
    {
      get => this.\u003CControllerContext\u003Ek__BackingField;
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
              this.\u003CControllerContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
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

    /// <summary>Контекст представления</summary>
    public ViewContext ViewContext
    {
      get => this.\u003CViewContext\u003Ek__BackingField;
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
              this.\u003CViewContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    /// <summary>Название представления</summary>
    public string ViewName
    {
      get => this.\u003CViewName\u003Ek__BackingField;
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
              this.\u003CViewName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Основное название</summary>
    public string MasterName
    {
      get => this.\u003CMasterName\u003Ek__BackingField;
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
              this.\u003CMasterName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Пути поиска</summary>
    public IEnumerable<string> SearchedLocations { get; set; }

    /// <summary>Представление найдено</summary>
    public bool IsFound
    {
      get => this.\u003CIsFound\u003Ek__BackingField;
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
              this.\u003CIsFound\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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

    /// <summary>Используется кеш</summary>
    public bool UseCache
    {
      get => this.\u003CUseCache\u003Ek__BackingField;
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
              this.\u003CUseCache\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    /// <summary>Частичное</summary>
    public bool IsPartial
    {
      get => this.\u003CIsPartial\u003Ek__BackingField;
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
              this.\u003CIsPartial\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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
    public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121747764);

    /// <inheritdoc />
    public override string Description
    {
      get
      {
        int num = 1;
        string viewName;
        while (true)
        {
          switch (num)
          {
            case 1:
              viewName = this.ViewName;
              if (viewName == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return viewName;
label_5:
        return (string) FindViewInfo.lTfgnOEF1xVmtdUU7KNJ(-1822890472 ^ -1822637742);
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
              FindViewInfo.yXfRP2EFpXZwjwkQvQdy((object) info, FindViewInfo.lTfgnOEF1xVmtdUU7KNJ(1304605005 ^ 1304860391), this.IsFound);
              num2 = 4;
              continue;
            case 2:
              if (this.SearchedLocations.Any<string>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 8 : 8;
                continue;
              }
              goto case 9;
            case 3:
              FindViewInfo.yXfRP2EFpXZwjwkQvQdy((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306199412), this.IsPartial);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 4 : 7;
              continue;
            case 4:
              goto label_12;
            case 5:
              info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418693094), (object) this.MasterName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            case 6:
              if (FindViewInfo.BlOoagEFNdHG287ASFoN((object) this.MasterName))
                goto default;
              else
                goto label_14;
            case 7:
              goto label_5;
            case 9:
              FindViewInfo.L7a54cEF3WOxgRIKLPfL((object) info, FindViewInfo.lTfgnOEF1xVmtdUU7KNJ(277947046 - -1479185048 ^ 1757385402), (object) this.SearchedLocations);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            default:
              if (this.SearchedLocations == null)
                goto case 1;
              else
                goto label_8;
          }
        }
label_8:
        num1 = 2;
        continue;
label_12:
        FindViewInfo.yXfRP2EFpXZwjwkQvQdy((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372499349), this.UseCache);
        num1 = 3;
        continue;
label_14:
        num1 = 5;
      }
label_5:;
    }

    internal static void PQfGwsEFPw5BRtBHm5pA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RIh2pPEF2a82dB88Zpcw() => FindViewInfo.q7PNKeEFOeDmqFkVZoPY == null;

    internal static FindViewInfo cMEG1yEFe72hAnALEGji() => FindViewInfo.q7PNKeEFOeDmqFkVZoPY;

    internal static object lTfgnOEF1xVmtdUU7KNJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool BlOoagEFNdHG287ASFoN([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static void L7a54cEF3WOxgRIKLPfL([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void yXfRP2EFpXZwjwkQvQdy([In] object obj0, [In] object obj1, [In] bool obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
