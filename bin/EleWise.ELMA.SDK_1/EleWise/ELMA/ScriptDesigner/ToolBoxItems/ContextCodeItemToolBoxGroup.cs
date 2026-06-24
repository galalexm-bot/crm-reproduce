// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ContextCodeItemToolBoxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Группа контекстных переменных процесса</summary>
  [Component(Order = 20)]
  public class ContextCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    internal static ContextCodeItemToolBoxGroup cUZ8ZpIEiMbdSEI5DiC;

    public Guid GroupUid => ContextCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => EleWise.ELMA.SR.T((string) ContextCodeItemToolBoxGroup.h0JBCKICjttY4rvXonF(-1886646897 ^ -1886632129));

    public ContextCodeItemToolBoxGroup()
    {
      ContextCodeItemToolBoxGroup.JE4UJ4Ivs3xEWAOolgT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ContextCodeItemToolBoxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextCodeItemToolBoxGroup.UID = new Guid((string) ContextCodeItemToolBoxGroup.h0JBCKICjttY4rvXonF(~-306453669 ^ 306468448));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object h0JBCKICjttY4rvXonF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Q4ktvrIftKfRV0eZYod() => ContextCodeItemToolBoxGroup.cUZ8ZpIEiMbdSEI5DiC == null;

    internal static ContextCodeItemToolBoxGroup iAJPf1IQlaQkR3CWkdB() => ContextCodeItemToolBoxGroup.cUZ8ZpIEiMbdSEI5DiC;

    internal static void JE4UJ4Ivs3xEWAOolgT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
