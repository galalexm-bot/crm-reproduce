// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ActionOverridesCodeItemPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Элемент содержащий все перегрузки метода</summary>
  [Serializable]
  public class ActionOverridesCodeItemPoint : ActionGroupBaseCodeItemPoint
  {
    internal static ActionOverridesCodeItemPoint VGuQ2euJdIwdJLG6LDg;

    public ActionOverridesCodeItemPoint()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ActionOverridesCodeItemPoint(IGrouping<string, MethodInfo> grouping, string callPath)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = grouping.Key;
      this.Actions = new List<ActionCodeItemPoint>();
      this.InitializeActions((IEnumerable<MethodInfo>) grouping, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122019208), (object) callPath.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123618220), "")));
      this.Description = grouping.First<MethodInfo>().GetFullComments();
      this.CallPath = callPath;
    }

    /// <summary>Индекс выбранного метода</summary>
    public int SelectedActionIndex
    {
      get => this.\u003CSelectedActionIndex\u003Ek__BackingField;
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
              this.\u003CSelectedActionIndex\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    /// <summary>Список перегрузок</summary>
    public List<ActionCodeItemPoint> Actions { get; set; }

    /// <summary>Инициализировать действия</summary>
    /// <param name="grouping"></param>
    /// <param name="callPath"></param>
    private void InitializeActions(IEnumerable<MethodInfo> grouping, string callPath)
    {
      if (!(grouping is IList<MethodInfo> methodInfoList1))
        methodInfoList1 = (IList<MethodInfo>) grouping.ToList<MethodInfo>();
      IList<MethodInfo> methodInfoList2 = methodInfoList1;
      foreach (MethodInfo info in (IEnumerable<MethodInfo>) methodInfoList2)
      {
        int order = methodInfoList2.IndexOf(info);
        this.Actions.Add(new ActionCodeItemPoint(info, callPath, order));
      }
    }

    internal static bool jn5Hm3u9PJ2vSnZMA9n() => ActionOverridesCodeItemPoint.VGuQ2euJdIwdJLG6LDg == null;

    internal static ActionOverridesCodeItemPoint bLTaqaudaWmgDLwj7TP() => ActionOverridesCodeItemPoint.VGuQ2euJdIwdJLG6LDg;
  }
}
