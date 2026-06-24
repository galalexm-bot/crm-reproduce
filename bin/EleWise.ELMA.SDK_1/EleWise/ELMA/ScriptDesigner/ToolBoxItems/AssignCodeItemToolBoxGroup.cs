// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.AssignCodeItemToolBoxGroup
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
  /// <summary>Группа общих элементов представления</summary>
  [Component(Order = 20)]
  public class AssignCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    internal static AssignCodeItemToolBoxGroup cWINJXI8TvBUakfD97J;

    public Guid GroupUid => AssignCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) AssignCodeItemToolBoxGroup.K2rF92IItEGW6o6X5Wd((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740352316));

    public AssignCodeItemToolBoxGroup()
    {
      AssignCodeItemToolBoxGroup.hhEJpYIVRKkEWgJf3lL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AssignCodeItemToolBoxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AssignCodeItemToolBoxGroup.UID = new Guid((string) AssignCodeItemToolBoxGroup.sivZBLIS9BsqB2piuaP(1669371371 ^ 1669390039));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            AssignCodeItemToolBoxGroup.hhEJpYIVRKkEWgJf3lL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object K2rF92IItEGW6o6X5Wd([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool xPZwXWIZ0e2Zg2Av2K0() => AssignCodeItemToolBoxGroup.cWINJXI8TvBUakfD97J == null;

    internal static AssignCodeItemToolBoxGroup DKmljCIuIlBuhRWC0K2() => AssignCodeItemToolBoxGroup.cWINJXI8TvBUakfD97J;

    internal static void hhEJpYIVRKkEWgJf3lL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object sivZBLIS9BsqB2piuaP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
