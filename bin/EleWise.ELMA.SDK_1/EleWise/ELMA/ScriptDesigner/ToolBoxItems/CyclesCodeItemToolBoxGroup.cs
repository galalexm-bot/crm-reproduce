// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.CyclesCodeItemToolBoxGroup
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
  /// <summary>Группа элементов для работы с циклами</summary>
  [Component(Order = 28)]
  public class CyclesCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    internal static CyclesCodeItemToolBoxGroup lwsiCnIKDkxqsGk4AjW;

    public Guid GroupUid => CyclesCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) CyclesCodeItemToolBoxGroup.LNhXqHIks9W5xe0vFLw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70056536));

    public CyclesCodeItemToolBoxGroup()
    {
      CyclesCodeItemToolBoxGroup.h5tGYAInYvqTcRs9xl1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CyclesCodeItemToolBoxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CyclesCodeItemToolBoxGroup.UID = new Guid((string) CyclesCodeItemToolBoxGroup.offt2PIOETFYY393CCU(2008901894 << 3 ^ -1108671578));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 2:
            CyclesCodeItemToolBoxGroup.h5tGYAInYvqTcRs9xl1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object LNhXqHIks9W5xe0vFLw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool jHo855IXpR5LD0G5rnM() => CyclesCodeItemToolBoxGroup.lwsiCnIKDkxqsGk4AjW == null;

    internal static CyclesCodeItemToolBoxGroup MOt2AJITscD21ybulmP() => CyclesCodeItemToolBoxGroup.lwsiCnIKDkxqsGk4AjW;

    internal static void h5tGYAInYvqTcRs9xl1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object offt2PIOETFYY393CCU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
