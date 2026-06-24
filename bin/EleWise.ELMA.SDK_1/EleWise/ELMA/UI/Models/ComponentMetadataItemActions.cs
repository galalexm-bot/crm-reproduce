// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ComponentMetadataItemActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Действия для объекта "Элемент метаданных компонента"</summary>
  public class ComponentMetadataItemActions : DefaultEntityActions
  {
    /// <summary>Отметить версию как не рабочую</summary>
    /// <remarks>
    /// Отмечает версию, которая не участвует в механизме версионности
    /// </remarks>
    [Uid("ab615fac-fc87-4672-b68e-173bf0b24c60")]
    [DisplayName("SR.M('Отметить версию как не рабочую')")]
    [Description("SR.M('Отмечает версию, которая не участвует в механизме версионности')")]
    public const string MarkAsNotWorking = "ab615fac-fc87-4672-b68e-173bf0b24c60";
    private static Guid _markAsNotWorkingGuid;
    internal static ComponentMetadataItemActions BCa3HYBWU6N0d2IZjCIj;

    /// <summary>ctor</summary>
    protected ComponentMetadataItemActions()
    {
      ComponentMetadataItemActions.luc20oBWzKOh2rbGeb8U();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Отметить версию как не рабочую</summary>
    /// <remarks>
    /// Отмечает версию, которая не участвует в механизме версионности
    /// </remarks>
    public static Guid MarkAsNotWorkingGuid => ComponentMetadataItemActions._markAsNotWorkingGuid;

    static ComponentMetadataItemActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentMetadataItemActions._markAsNotWorkingGuid = new Guid((string) ComponentMetadataItemActions.WHNhDyBoFV3DW7pjhdpF(-1290212282 ^ -644262414 ^ 1786862684));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void luc20oBWzKOh2rbGeb8U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ot4vNgBWsIYicJl8g0lk() => ComponentMetadataItemActions.BCa3HYBWU6N0d2IZjCIj == null;

    internal static ComponentMetadataItemActions pSY4DsBWc1LMtbRoRppU() => ComponentMetadataItemActions.BCa3HYBWU6N0d2IZjCIj;

    internal static object WHNhDyBoFV3DW7pjhdpF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
