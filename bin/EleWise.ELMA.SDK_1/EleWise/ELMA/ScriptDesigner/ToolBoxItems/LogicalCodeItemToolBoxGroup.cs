// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.LogicalCodeItemToolBoxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Группа логических элементов</summary>
  [Component(Order = 21)]
  public class LogicalCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    private static LogicalCodeItemToolBoxGroup OaXCBKIU7KXO6MsXCmN;

    public Guid GroupUid => LogicalCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) LogicalCodeItemToolBoxGroup.mfjgrkVFEsiqt4IwGPR(LogicalCodeItemToolBoxGroup.WDuSZ0IzeKarBmFmXoQ(-1088304168 ^ -1088323548));

    public LogicalCodeItemToolBoxGroup()
    {
      LogicalCodeItemToolBoxGroup.I0rD8FVBGw8sy23gxRX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static LogicalCodeItemToolBoxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LogicalCodeItemToolBoxGroup.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470459722));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            LogicalCodeItemToolBoxGroup.I0rD8FVBGw8sy23gxRX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object WDuSZ0IzeKarBmFmXoQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object mfjgrkVFEsiqt4IwGPR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool HSwWvLIsmBX9vXJaOxx() => LogicalCodeItemToolBoxGroup.OaXCBKIU7KXO6MsXCmN == null;

    internal static LogicalCodeItemToolBoxGroup Q5YBD4IcE2GPMNpSjPQ() => LogicalCodeItemToolBoxGroup.OaXCBKIU7KXO6MsXCmN;

    internal static void I0rD8FVBGw8sy23gxRX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
