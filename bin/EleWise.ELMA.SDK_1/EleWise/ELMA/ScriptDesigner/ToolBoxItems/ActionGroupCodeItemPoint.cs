// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ActionGroupCodeItemPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  [Serializable]
  public class ActionGroupCodeItemPoint : ActionGroupBaseCodeItemPoint
  {
    private static ActionGroupCodeItemPoint DQjJTyu0lHVjaqDJdLc;

    public ActionGroupCodeItemPoint()
    {
      ActionGroupCodeItemPoint.dlkQMnuMCmfPqJv8Wui();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ActionGroupCodeItemPoint(string name)
    {
      ActionGroupCodeItemPoint.dlkQMnuMCmfPqJv8Wui();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.ActionGroups = new List<ActionGroupBaseCodeItemPoint>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Name = name;
            num = 2;
            continue;
          default:
            this.Actions = new List<ActionOverridesCodeItemPoint>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public List<ActionOverridesCodeItemPoint> Actions { get; set; }

    public List<ActionGroupBaseCodeItemPoint> ActionGroups { get; set; }

    internal static void dlkQMnuMCmfPqJv8Wui() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MVq14QumPGHb5qqQcOO() => ActionGroupCodeItemPoint.DQjJTyu0lHVjaqDJdLc == null;

    internal static ActionGroupCodeItemPoint C0YneAuywFyh45K8UnJ() => ActionGroupCodeItemPoint.DQjJTyu0lHVjaqDJdLc;
  }
}
